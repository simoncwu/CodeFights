using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "mediaUrl": 
    /// https://codefights.com/challenge/9uP4CJQQF4nMmrDsY
    /// 
    /// Parse a URL into different parameters. Each url has the following format:
    /// <c>http(s)://media.codefights.com/username/parameter/value</c>
    /// 
    /// The parse result should be an array of three lowercase elements of the following format:
    /// [username, page, value]
    /// 
    /// The URL should be parsed according to the following rules:
    /// <list type="bullet">
    /// <item><description>A valid URL contains only standard alphanumerics (no accented letters), colons, forward slashes, and hyphens; and follows all other format rules.</description></item>
    /// <item><description>'/' is an acceptable character in value.</description></item>
    /// <item><description>A URL containing either date or albums parameters with the other one in the value is invalid.</description></item>
    /// <item><description>The first portion after the domain name is a username not equal to "date" or "album".</description></item>
    /// <item><description>If the URL is invalid or contains no username, return an empty array.</description></item>
    /// <item><description>If the parameter is equal to "date" or "albums" and a part of the value is a valid date in the format yyyy-mm-dd/h:h:s, the page element of the output should be equal to "details", and the value element should be equal to the date in the format yyyy-mm-dd/hh:mm:ss.</description></item>
    /// <item><description>If the parameter is equal to "date" and the value is equal to "photo", "video" or an integer (the year number), the page element of the output should be equal to "gallery", and value should be equal to the value following the second parameter.</description></item>
    /// <item><description>If the parameter is equal to "albums" and the value is an integer (album id), the page element of the output should be equal to "album", and its value should be equal to album id.</description></item>
    /// <item><description>If username is present but other parts of url are invalid, the page element of the output should be equal to gallery, and the value should be equal to "*".</description></item>
    /// </list>
    /// </summary>
    public class MediaUrl
    {
        /// <summary>
        /// Parses a URL and returns the valid values contained within it.
        /// </summary>
        /// <param name="url">The URL to parse.</param>
        /// <returns>An array containing the valid values contained within <paramref name="url"/>.</returns>
        public string[] mediaUrl(string url)
        {
            // validate protocol/domain
            if (Regex.IsMatch(url = url.ToLower(), @"^https?://media.codefights.com/[a-zA-Z\d\/\-:]+$"))
            {
                // validate first parameter: username
                if (!Regex.IsMatch(url = url.Substring(url.IndexOf("m/") + 2), "^(date|album)/"))
                {
                    string username = url, page = "gallery", val = "*", dtFormat = "yyyy-MM-dd/HH:mm:ss";
                    int i = username.IndexOf('/');
                    if (i > 0)
                    {
                        username = username.Remove(i);
                        url = url.Substring(i + 1);

                        // validate second parameter and value
                        if (Regex.IsMatch(url, @"^(date|albums)\/.+"))
                        {
                            // validate rest of url
                            var matches = Regex.Matches(url, @"([^\/]+)\/(.+)");
                            if (matches.Count > 0)
                            {
                                string p = matches[0].Groups[1].Value, v = matches[0].Groups[2].Value;

                                // check for coexistence of both date and albums parameters
                                if (!Regex.IsMatch(v, @"^(.+\/)?" + (p == "date" ? "albums" : "date") + @"(\/.*)?$"))
                                {
                                    // parse date/albums
                                    switch (p)
                                    {
                                        case "date":
                                            if (Regex.IsMatch(v, @"^(photo|video|\d+)$"))
                                                val = v;
                                            break;
                                        case "albums":
                                            if (Regex.IsMatch(v, @"^\d+$"))
                                            {
                                                page = "album";
                                                val = v;
                                            }
                                            break;
                                        default:
                                            p = null;
                                            break;
                                    }

                                    // parse details date
                                    matches = Regex.Matches(url, @"\/\d{4}(-\d{2}){2}\/\d\d?(:\d\d?){2}$");
                                    if (matches.Count > 0)
                                    {
                                        DateTime dt;
                                        var enus = new CultureInfo("en-US");
                                        var style = DateTimeStyles.None;
                                        if (DateTime.TryParseExact(v = matches[0].Groups[0].Value.Substring(1), dtFormat, enus, style, out dt) ||
                                            DateTime.TryParseExact(v, "yyyy-MM-dd/H:m:s", enus, style, out dt))
                                        {
                                            page = "details";
                                            val = dt.ToString(dtFormat);
                                        }
                                        else
                                        {
                                            page = "gallery";
                                            val = "*";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    return new[] { username, page, val };
                }
            }
            return new string[] { };
        }
    }
}
