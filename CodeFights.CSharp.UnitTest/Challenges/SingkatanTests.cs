﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass()]
    public class SingkatanTests
    {
        [TestMethod()]
        public void singkatanTest()
        {
            var s = new Singkatan();
            Assert.AreEqual("cesarioputera", s.singkatan("cesario", "oputera"));
            Assert.AreEqual("pakoperxxpa", s.singkatan("pakoper", "perxxpa"));
            Assert.AreEqual("abcdef", s.singkatan("abc", "def"));
            Assert.AreEqual("pakoperxxxpa", s.singkatan("pakoper", "erxxxpa"));
            Assert.AreEqual("abc", s.singkatan("abc", "abc"));
            Assert.AreEqual("abcab", s.singkatan("abc", "ab"));
            Assert.AreEqual("kcwwiclwiezxjjcfbujmdgwdpxgpobbxqozigtgxftynbflqftaconbjmzfphzafqilchsgesmdhaacasrrxbvbbvgtmehhencmgehgkgrvusjoktdfwkkulqopbjttbpewwkepfzhdzumlpycpycboariiaxtdrlgcjbevwlyzfgvdycrvlflssuwqokaaouppnvidihyofufwqqvmbgtatmhfpokfehgvanxiidrkqoqbirwrcefsclirzwezbwrtluikxmuubxkixveiryylvcdkudmvukbwcgmfsuyglckyvxezeqefdcohqqkpgfirkqpeqknifdyqapcqzlutsleneaghjyvqofuqqimubgzjbwhjmbkhtltsbjzfemenqvjhkhqqzmdtyynpkhdyfjghefbfgxtfcsfohnuvqxcodjgrjkxcidositmhoyjkbllzbsihsgpwlsjdtpfzeoukudnycypaeldmhlpisosptlrluimxdkfufzyxhgqizpbbvmqohfzromhmmphzbklcotyozhzaunsklnwstetpdyzsoyrmpxyzphtlkvzmmkdsaauevwzukynlmtvanfibmzqqwzrwnbvxsqucfnozfhrulmzxjjchhmfozidmpjmrqvezarigcjpzqrqywstccmqffsjbezlmypqvstupdsgrfrwyeiqvzbepagxtepqwtwspbufejaquwrxawsylahrqexfypkmvowodlqcaaueznwbochjtyzxwzvvojlprzwzbzdkcofpibqztgpltosxtzeufiryjqdydvrbprwjissdghvsichcsntchcoxspsgiwmrlxhkjzrjpjwvjogyqpmznwnptzwvnriqec", s.singkatan("kcwwiclwiezxjjcfbujmdgwdpxgpobbxqozigtgxftynbflqftaconbjmzfphzafqilchsgesmdhaacasrrxbvbbvgtmehhencmgehgkgrvusjoktdfwkkulqopbjttbpe", "kcwwiclwiezxjjcfbujmdgwdpxgpobbxqozigtgxftynbflqftaconbjmzfphzafqilchsgesmdhaacasrrxbvbbvgtmehhencmgehgkgrvusjoktdfwkkulqopbjttbpewwkepfzhdzumlpycpycboariiaxtdrlgcjbevwlyzfgvdycrvlflssuwqokaaouppnvidihyofufwqqvmbgtatmhfpokfehgvanxiidrkqoqbirwrcefsclirzwezbwrtluikxmuubxkixveiryylvcdkudmvukbwcgmfsuyglckyvxezeqefdcohqqkpgfirkqpeqknifdyqapcqzlutsleneaghjyvqofuqqimubgzjbwhjmbkhtltsbjzfemenqvjhkhqqzmdtyynpkhdyfjghefbfgxtfcsfohnuvqxcodjgrjkxcidositmhoyjkbllzbsihsgpwlsjdtpfzeoukudnycypaeldmhlpisosptlrluimxdkfufzyxhgqizpbbvmqohfzromhmmphzbklcotyozhzaunsklnwstetpdyzsoyrmpxyzphtlkvzmmkdsaauevwzukynlmtvanfibmzqqwzrwnbvxsqucfnozfhrulmzxjjchhmfozidmpjmrqvezarigcjpzqrqywstccmqffsjbezlmypqvstupdsgrfrwyeiqvzbepagxtepqwtwspbufejaquwrxawsylahrqexfypkmvowodlqcaaueznwbochjtyzxwzvvojlprzwzbzdkcofpibqztgpltosxtzeufiryjqdydvrbprwjissdghvsichcsntchcoxspsgiwmrlxhkjzrjpjwvjogyqpmznwnptzwvnriqec"));
            Assert.AreEqual("djcmdtjytuwweuuevkgjkqtaxqnfezkkftzhfkjptwfktbdgsawkdskzceqwtjevvtpykomlkegmjxcghnydjsfwlfuiwzxiyqhsagasgjnqgguodlvxsxwgslkwiyaylfmwxdvckeoyqiyxairqt", s.singkatan("djcmdtjytuwweuuevkgjkqtaxqnfezkkftzhfkjptwfktbdgsawkdskzceqwtjevvtpykomlkegmjxcghnydjsfwlfuiwzxiyqhsagasgjnqgguodlvxsxwgslkwiyaylfmwxdvckeoyqiyxairqt", "uwweuuevkgjkqtaxqnfezkkftzhfkjptwfktbdgsawkdskzceqwtjevvtpykomlkegmjxcghnydjsfwlfuiwzxiyqhsagasgjnqgguodlvxsxwgslkwiyaylfmwxdvckeoyqiyxairqt"));
            Assert.AreEqual("losdozrrijkluacrshsnxlaizlsqiwgqrttftoplofdnetqarjqinwztstbaxhzahffpygihktucbjyenwsgkyuvhrobqmyufxboajdxrafhpfpfcyiqwjmlsaldehrzmwxmuhrlvichqlbawevdfmwxiyuelyajsusgyrsehpirbfkelqxxxbkhmpercxtqcwuaemobzktbhrgiwegjamsniuapzuihcablhlchratgcwhsabncuqfghdsdnrkstzxhinncoopwyhxeokkpaoytpagqmbqndheovsjgmxjmbmifrqckwffzxhncebdcfrpwikeyhctysguyroemychznregvwstdxtqtajkxlowyijqolnjcqllfgqlmuiyxpvhlnoiuubjwtsxbcuejbutmmpdjpkpdkrujdjkellgkpklfyqekbndbmdktpihqiglwxhccwbgqaqxmrsdlpvnbpzvxtybhqjjnucxpudfzaembfcjubbpxyqluepbmgxreejvmaiplvflnpidimkfpywooethmiwoiqhjwqrqaueymiqmwqeyfyfxpdravkmibnrnaphfjnfafkfrxevgtgyfzrqzcuhzrpygnhrnsmxhyfcqlxlnwshstzjatuojooocrszbuphdpnukxtdiqavhycjwhtojeezepmwwsowtwiqttkcplwfdtxydtrsppxuhhomvqsntkjjrwfhlfxvraclahtcsmaktjjieumyhbelrbzveylxvlbdsdhayywbqyuzeblmynzuwloijnbcjnbgdgufdpevfhqqmokphrvfftzcgneckmtaqzrqphcnrnnpqghbvnsnqocdawibkvkmfsixovptgydbgqrrhalzereejqcexjzptmfskykhqveldlnjtqpmwptatdibcoejtmlynwlkfjsqzelswhcxcabtlghfzsvnbtnrootqjzcyomulvjxjloxbzjcnqkfyfzypppadrmaabmzhtiqsjdecsptzpwtvtzpgufqenwmpasowveforctzgapckndpwrmzrktjnnkgfbxwytufibnpaklneuxdbtjlanqrgvktsukmqvphcszqxldyc", s.singkatan("losdozrrijkluacrshsnxlaizlsqiwgqrttftoplofdnetqarjqinwztstbaxhzahffpygihktucbjyenwsgkyuvhrobqmyufxboajdxrafhpfpfcyiqwjmlsaldehrzmwxmuhrlvichqlbawevdfmwxiyuelyajsusgyrsehpirbfkelqxxxbkhmpercxtqcwuaemobzktbhrgiwegjamsniuapzuihcablhlchratgcwhsabncuqfghdsdnrkstzxhinncoopwyhxeokkpaoytpagqmbqndheovsjgmxjmbmifrqckwffzxhncebdcfrpwikeyhctysguyroemychznregvwstdxtqtajkxlowyijqolnjcqllfgqlmuiyxpvhlnoiuubjwtsxbcuejbutmmpdjpkpdkrujdjkellgkpklfyqekbndbmdktpihqiglwxhccwbgqaqxmrsdlpvnbpzvxtybhqjjnucxpudfzaembfcjubbpxyqluepbmgxreejvmaiplvflnpidimkfpywooethmiwoiqhjwq", "lbawevdfmwxiyuelyajsusgyrsehpirbfkelqxxxbkhmpercxtqcwuaemobzktbhrgiwegjamsniuapzuihcablhlchratgcwhsabncuqfghdsdnrkstzxhinncoopwyhxeokkpaoytpagqmbqndheovsjgmxjmbmifrqckwffzxhncebdcfrpwikeyhctysguyroemychznregvwstdxtqtajkxlowyijqolnjcqllfgqlmuiyxpvhlnoiuubjwtsxbcuejbutmmpdjpkpdkrujdjkellgkpklfyqekbndbmdktpihqiglwxhccwbgqaqxmrsdlpvnbpzvxtybhqjjnucxpudfzaembfcjubbpxyqluepbmgxreejvmaiplvflnpidimkfpywooethmiwoiqhjwqrqaueymiqmwqeyfyfxpdravkmibnrnaphfjnfafkfrxevgtgyfzrqzcuhzrpygnhrnsmxhyfcqlxlnwshstzjatuojooocrszbuphdpnukxtdiqavhycjwhtojeezepmwwsowtwiqttkcplwfdtxydtrsppxuhhomvqsntkjjrwfhlfxvraclahtcsmaktjjieumyhbelrbzveylxvlbdsdhayywbqyuzeblmynzuwloijnbcjnbgdgufdpevfhqqmokphrvfftzcgneckmtaqzrqphcnrnnpqghbvnsnqocdawibkvkmfsixovptgydbgqrrhalzereejqcexjzptmfskykhqveldlnjtqpmwptatdibcoejtmlynwlkfjsqzelswhcxcabtlghfzsvnbtnrootqjzcyomulvjxjloxbzjcnqkfyfzypppadrmaabmzhtiqsjdecsptzpwtvtzpgufqenwmpasowveforctzgapckndpwrmzrktjnnkgfbxwytufibnpaklneuxdbtjlanqrgvktsukmqvphcszqxldyc"));
            Assert.AreEqual("hdwkknpmnuzyfqveohaagkxnlliwzenikuvrvuynszgrdxmzjgpvcelijuijgandxvehqupimtgwblryvbydkmdmoxjdcadpidofvharmauejgvtecwqxcnwwrhjklokmgzlvyzigiiauxufshhlyxbmlryzxnzawpshzxqgvoxurinextnmkzytxluljssfqdbggpvpyyutyrmpsntrlxpikdguoqtkdqyvpapoqiakdtnndzbbjaiyfdrsklxnnygkygzlobjmanclzwiocgzcvjtbcvklkkehmraoxofhjhjqdlwmiauxliwufuenbrjmsiexgodfmkhupcxbmeocavneitufiepsyijdadcfdpuzpyiadscsielwcvhvriittckvnyhiwmstsfuvuazhpqottsbzxoaofsucknojgbgbadurdwlmezcwyrtzxoqihthdydxsgywkawdvrardviofmdcyemdsiqncxtrimqxwxxtswtdmapiqardfktfmvqvdqasruyiwnjayfdeitsvdnjlyyupwoyrusdkkedqqtbnepzaydiqmhwawseiuusiufrzmyealnrdhuxochislpndsodzbfhdmfwndjxlkgidumkivprzpmlbshmmevnaogrouyqqesmbkncgudahjgzqgiiofdpsibgjgwfyretlzwvcxnqppklnegryhjszpnyqwrbycpriapsgududdqqjgvkwdlikrkuojtnqcmyzqgsfrpqlxpgrswuzcekgjswzttbeuutnuhrhbkexyesimrovzfmpiqrmsdgpoccjvubmcmdheqfmvnvnafkivzejwsdzbnkdmxfjziqlgu", s.singkatan("hdwkknpmnuzyfqveohaagkxnlliwzenikuvrvuynszgrdxmzjgpvcelijuijgandxvehqupimtgwblryvbydkmdmoxjdcadpidofvharmauejgvtecwqxcnwwrhjklokmgzlvyzigiiauxufshhlyxbmlryzxnzawpshzxqgvoxurinextnmkzytxluljssfqdbggpvpyyutyrmpsntrlxpikdguoqtkdqyvpapoqiakdtnndzbbjaiyfdrsklxnnygkygzlobjmanclzwiocgzcvjtbcvklkkehmraoxofhjhjqdlwmiauxliwufuenbrjmsiexgodfmkhupcxbmeocavneitufiepsyijdadcfdpuzpyiadscsielwcvhvriittckvnyhiwmstsfuvuazhpqottsbzxoaofsucknojgbgbadurdwlmezcwyrtzxoqihthdydxsgywkawdvrardviofmdcyemdsiqncxtrimqxwxxtswtdmapiqardfktfmvqvdqasruyiwnjayfdeitsvdnjlyyupwoyrusdkkedqqtbnep", "agkxnlliwzenikuvrvuynszgrdxmzjgpvcelijuijgandxvehqupimtgwblryvbydkmdmoxjdcadpidofvharmauejgvtecwqxcnwwrhjklokmgzlvyzigiiauxufshhlyxbmlryzxnzawpshzxqgvoxurinextnmkzytxluljssfqdbggpvpyyutyrmpsntrlxpikdguoqtkdqyvpapoqiakdtnndzbbjaiyfdrsklxnnygkygzlobjmanclzwiocgzcvjtbcvklkkehmraoxofhjhjqdlwmiauxliwufuenbrjmsiexgodfmkhupcxbmeocavneitufiepsyijdadcfdpuzpyiadscsielwcvhvriittckvnyhiwmstsfuvuazhpqottsbzxoaofsucknojgbgbadurdwlmezcwyrtzxoqihthdydxsgywkawdvrardviofmdcyemdsiqncxtrimqxwxxtswtdmapiqardfktfmvqvdqasruyiwnjayfdeitsvdnjlyyupwoyrusdkkedqqtbnepzaydiqmhwawseiuusiufrzmyealnrdhuxochislpndsodzbfhdmfwndjxlkgidumkivprzpmlbshmmevnaogrouyqqesmbkncgudahjgzqgiiofdpsibgjgwfyretlzwvcxnqppklnegryhjszpnyqwrbycpriapsgududdqqjgvkwdlikrkuojtnqcmyzqgsfrpqlxpgrswuzcekgjswzttbeuutnuhrhbkexyesimrovzfmpiqrmsdgpoccjvubmcmdheqfmvnvnafkivzejwsdzbnkdmxfjziqlgu"));
            Assert.AreEqual("coscosabc", s.singkatan("coscos", "oscosabc"));
        }
    }
}