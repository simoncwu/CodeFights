﻿using CodeFights.CSharp.Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFights.CSharp.UnitTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class Challenges
    {
        public Challenges()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Cardinal()
        {
            var c = new Cardinal();
            Assert.AreEqual("one thousand two hundred and fifty five", c.cardinal("1255"));
            Assert.AreEqual("fifteen", c.cardinal("15"));
            Assert.AreEqual("zero", c.cardinal("0"));
            Assert.AreEqual("one billion one", c.cardinal("1000000001"));
            Assert.AreEqual("one hundred and twenty three trillion four hundred and fifty six billion seven hundred and eighty nine million twelve thousand three hundred and forty five", c.cardinal("123456789012345"));
            Assert.AreEqual("four hundred and fifty eight million", c.cardinal("458000000"));
            Assert.AreEqual("nine hundred and ninety nine trillion nine hundred and ninety nine billion nine hundred and ninety nine million nine hundred and ninety nine thousand nine hundred and ninety nine", c.cardinal("999999999999999"));
            Assert.AreEqual("ten billion", c.cardinal("10000000000"));
        }

        [TestMethod]
        public void WireTest()
        {
            var w = new Wire();
            int[] l = { 1, 2, 3 }, r = { 4, 6, 5 };
            Assert.AreEqual(true, w.wire(l, r));

            l = new[] { 1, 2, 3 };
            r = new[] { 4, 5, 6 };
            Assert.AreEqual(false, w.wire(l, r));

            l = new[] { 1, 3, 2, 4 };
            r = new[] { 4, 5, 5, 6 };
            Assert.AreEqual(true, w.wire(l, r));

            l = new[] { 8723, 288, 23805, 12859, 6868, 32662, 1842, 778, 25547, 8942, 3035, 19264 };
            r = new[] { 9741, 30106, 27446, 20037, 28253, 32757, 22190, 27529, 27644, 9040, 12316, 22648 };
            Assert.AreEqual(true, w.wire(l, r));

            l = new[] { 27621, 5907, 21184, 16290, 8719, 11400, 7349, 15722, 3351, 3053, 8346, 1695, 12189, 20502, 15891, 10681, 21083, 2136, 12581, 3239, 18479, 25903, 15826, 24834, 20476, 3591, 8978, 2702, 1023, 13998 };
            r = new[] { 29515, 14875, 28074, 22974, 26790, 18413, 14243, 23838, 8329, 14893, 10687, 6139, 15787, 25141, 24637, 17063, 23639, 4580, 24828, 31490, 24176, 27005, 29993, 26943, 30041, 23072, 24399, 8707, 11891, 32468 };
            Assert.AreEqual(false, w.wire(l, r));

            l = new[] { 20149, 8672, 27168, 930, 11714, 15955, 13338, 24061, 16653, 485, 16464, 26133, 15023, 21276, 16070, 19555, 1466, 10945, 2343, 1563, 142, 4231, 17480, 502, 20514, 10684, 26072, 5794, 12844, 4858, 20990, 23504, 5488, 10252, 24870, 18683, 15447, 5242, 679, 24898, 2222, 1105, 12488, 14990, 15415, 8250, 8938, 19195, 13475, 3318 };
            r = new[] { 24168, 12833, 28130, 1954, 20481, 18217, 20307, 27219, 20337, 13240, 31723, 32097, 30270, 31506, 25631, 25633, 15255, 31447, 16641, 21302, 13201, 18086, 19975, 26928, 30260, 32702, 32176, 8686, 23577, 22512, 28781, 26793, 11520, 19904, 31754, 21547, 28981, 24618, 20736, 30721, 28406, 1697, 20279, 19438, 26701, 26312, 16657, 26850, 20311, 29656 };
            Assert.AreEqual(false, w.wire(l, r));

            l = new[] { 27536, 20526, 18182, 10539, 8722, 20576, 16713, 13749, 24290, 943, 28603, 12324, 10282, 10806, 15846, 15121, 7435, 13403, 6305, 3671, 4167, 4514, 10344, 4193, 24828, 31103, 8803, 2486, 6446, 17950, 10597, 3936, 5456, 1364, 4515, 24696, 4075, 3227, 18170, 5433, 13592, 4299, 1903, 20012, 20432, 437, 2516, 21416, 1848, 3005, 16544, 16647, 11001, 24401, 22270, 19764, 8732, 11874, 2497, 4546, 14581, 25358, 26673, 26862, 24243, 19714, 14063, 14611, 10377, 2093, 14458, 2508, 11560, 19659, 21462, 12452, 3914, 22488, 3919, 14471, 391, 2280, 5175, 11989, 1366, 16030, 3338, 692, 1770, 6925, 11091, 6766, 20183, 20416, 12, 19459, 7007, 10165, 17585, 3244 };
            r = new[] { 29429, 22105, 19635, 12888, 27263, 26112, 30268, 29276, 29059, 1227, 29556, 18074, 29368, 27109, 21238, 18370, 17557, 26784, 30106, 28577, 5520, 25290, 29863, 23117, 30633, 32759, 21439, 11845, 19290, 20583, 14334, 20093, 24403, 16498, 6149, 31139, 7730, 23290, 24978, 16274, 28761, 8507, 30973, 20236, 20955, 32134, 27791, 28649, 20366, 22411, 30339, 22426, 25434, 29740, 22443, 23713, 20392, 18563, 3388, 31684, 30382, 27048, 28664, 30589, 30118, 25599, 26843, 16923, 22837, 13196, 32071, 12878, 21047, 24540, 21960, 24013, 23155, 26194, 28849, 19481, 606, 32487, 17269, 19606, 5937, 27666, 6723, 24740, 9555, 30041, 27711, 12704, 21135, 20801, 6667, 28537, 9125, 10869, 21841, 20043 };
            Assert.AreEqual(false, w.wire(l, r));

            l = new[] { 200, 100, 2000, 1700, 7100, 9800, 6100, 9200, 900, 1600, 1, 9500, 4800, 4700, 5600, 2300, 4600, 1100, 1500, 9700, 6800, 6700, 2700, 3500, 2100, 3700, 8700, 2900, 3800, 8000, 5100, 1000, 7500, 5500, 700, 5000, 7400, 7700, 6300, 3200, 9600, 8900, 9900, 3000, 5800, 5200, 7000, 9400, 1400, 8300, 8200, 2800, 4500, 5400, 7600, 1200, 7900, 6500, 6200, 2600, 7300, 9000, 800, 6400, 4400, 1900, 5300, 7800, 6600, 500, 8800, 2500, 5900, 3100, 4300, 9300, 6000, 3400, 5700, 3900, 8500, 1800, 4000, 1300, 9100, 6900, 400, 3300, 8100, 300, 8400, 4200, 7200, 2400, 2200, 8600, 4100, 600, 4900, 3600 };
            r = new[] { 301, 201, 2101, 1801, 7201, 9901, 6201, 9301, 1001, 1701, 101, 9601, 4901, 4801, 5701, 2401, 4701, 1201, 1601, 9801, 6901, 6801, 2801, 3601, 2201, 3801, 8801, 3001, 3901, 8101, 5201, 1101, 7601, 5601, 801, 5101, 7501, 7801, 6401, 3301, 9701, 9001, 10001, 3101, 5901, 5301, 7101, 9501, 1501, 8401, 8301, 2901, 4601, 5501, 7701, 1301, 8001, 6601, 6301, 2701, 7401, 9101, 901, 6501, 4501, 2001, 5401, 7901, 6701, 601, 8901, 2601, 6001, 3201, 4401, 9401, 6101, 3501, 5801, 4001, 8601, 1901, 4101, 1401, 9201, 7001, 501, 3401, 8201, 401, 8501, 4301, 7301, 2501, 2301, 8701, 4201, 701, 5001, 3701 };
            Assert.AreEqual(true, w.wire(l, r));

            l = new[] { 38, 8, 62, 32, 91, 39, 84, 22, 2, 35, 13, 71, 41, 72, 42, 80, 9, 14, 18, 63, 96, 73, 43, 60, 29, 50, 97, 82, 31, 37, 95, 58, 11, 83, 76, 24, 81, 7, 4, 86, 64, 46, 56, 74, 55, 16, 19, 57, 85, 99, 21, 93, 89, 51, 67, 27, 15, 70, 88, 78, 69, 44, 20, 1, 65, 26, 45, 36, 61, 6, 23, 5, 10, 17, 12, 100, 53, 54, 25, 77, 79, 75, 94, 47, 34, 98, 49, 3, 52, 92, 59, 66, 87, 90, 28, 40, 68, 30, 33, 48 };
            r = new[] { 163, 193, 139, 169, 110, 162, 117, 179, 199, 166, 188, 130, 160, 129, 159, 121, 192, 187, 183, 138, 105, 128, 158, 141, 172, 151, 104, 119, 170, 164, 106, 143, 190, 118, 125, 177, 120, 194, 197, 115, 137, 155, 145, 127, 146, 185, 182, 144, 116, 102, 180, 108, 112, 150, 134, 174, 186, 131, 113, 123, 132, 157, 181, 200, 136, 175, 156, 165, 140, 195, 178, 196, 191, 184, 189, 101, 148, 147, 176, 124, 122, 126, 107, 154, 167, 103, 152, 198, 149, 109, 142, 135, 114, 111, 173, 161, 133, 171, 168, 153 };
            Assert.AreEqual(true, w.wire(l, r));

            l = new[] { 31, 2, 137, 819, 713, 473, 7, 647, 670, 443, 479, 12, 975, 14, 834, 167, 17, 703, 494, 714, 584, 390, 222, 361, 25, 940, 288, 652, 250, 214, 297, 468, 339, 477, 803, 469, 768, 936, 368, 966, 197, 771, 43, 260, 866, 108, 826, 777, 49, 183, 660, 203, 804, 782, 428, 56, 684, 270, 678, 589, 107, 171, 916, 64, 475, 926, 120, 487, 27, 200, 71, 405, 894, 735, 547, 337, 271, 888, 379, 829, 722, 950, 349, 84, 85, 19, 321, 88, 509, 524, 234, 205, 93, 212, 764, 86, 404, 9, 474, 431, 596, 41, 832, 208, 913, 24, 976, 46, 733, 774, 699, 719, 655, 696, 272, 122, 625, 118, 585, 744, 121, 526, 970, 76, 125, 195, 191, 323, 129, 308, 217, 132, 240, 650, 357, 546, 202, 20, 932, 140, 248, 960, 704, 319, 523, 522, 724, 23, 237, 462, 563, 152, 823, 885, 412, 984, 157, 158, 489, 160, 409, 69, 746, 151, 604, 614, 812, 168, 10, 87, 201, 172, 335, 634, 938, 101, 562, 178, 262, 500, 573, 213, 763, 427, 698, 186, 661, 188, 239, 991, 220, 232, 580, 992, 392, 128, 370, 190, 629, 627, 408, 177, 52, 673, 30, 285, 147, 483, 437, 97, 439, 331, 193, 134, 21, 22, 609, 11, 553, 794, 538, 779, 155, 633, 873, 867, 575, 33, 461, 230, 231, 951, 114, 793, 868, 236, 149, 77, 362, 377, 307, 505, 767, 680, 663, 246, 247, 755, 249, 442, 119, 135, 429, 89, 918, 35, 257, 464, 15, 864, 261, 219, 645, 264, 502, 295, 954, 514, 808, 58, 892, 252, 273, 274, 359, 770, 643, 422, 870, 593, 281, 898, 283, 887, 949, 785, 710, 371, 995, 486, 478, 360, 557, 705, 565, 707, 915, 472, 99, 863, 506, 278, 507, 39, 104, 659, 299, 626, 446, 310, 687, 434, 199, 914, 780, 209, 317, 133, 962, 218, 943, 400, 322, 721, 332, 662, 50, 572, 329, 649, 38, 386, 333, 334, 225, 320, 161, 117, 369, 905, 112, 654, 533, 838, 981, 667, 586, 395, 480, 731, 455, 725, 843, 265, 668, 356, 607, 640, 636, 561, 146, 59, 727, 548, 48, 592, 963, 642, 682, 280, 576, 32, 302, 664, 952, 376, 618, 98, 96, 380, 692, 822, 860, 958, 862, 908, 426, 388, 373, 189, 391, 948, 569, 381, 66, 418, 397, 882, 3, 720, 624, 853, 276, 836, 906, 875, 407, 691, 813, 865, 979, 623, 413, 732, 835, 385, 581, 179, 91, 919, 897, 74, 423, 424, 718, 341, 245, 100, 759, 430, 748, 174, 985, 889, 617, 947, 641, 438, 559, 223, 441, 956, 503, 444, 445, 880, 144, 741, 449, 463, 879, 876, 999, 372, 481, 726, 182, 458, 993, 460, 253, 844, 712, 425, 883, 279, 467, 269, 982, 539, 206, 364, 814, 95, 796, 840, 34, 988, 983, 448, 51, 166, 207, 874, 665, 529, 499, 37, 90, 490, 965, 366, 416, 436, 498, 198, 216, 495, 40, 518, 309, 587, 92, 749, 303, 143, 601, 384, 187, 492, 44, 512, 513, 612, 68, 340, 164, 378, 519, 535, 221, 899, 83, 608, 977, 215, 501, 211, 457, 484, 646, 532, 304, 801, 606, 298, 113, 415, 470, 551, 154, 542, 543, 850, 869, 136, 630, 556, 549, 314, 602, 552, 798, 354, 964, 893, 957, 170, 895, 36, 702, 138, 204, 700, 787, 765, 567, 65, 393, 729, 758, 414, 181, 605, 342, 148, 577, 855, 716, 939, 510, 482, 153, 325, 398, 590, 599, 757, 60, 82, 570, 454, 639, 116, 595, 8, 421, 583, 312, 67, 872, 110, 328, 690, 525, 611, 235, 316, 858, 821, 287, 706, 291, 497, 63, 131, 73, 62, 619, 399, 676, 520, 917, 401, 432, 961, 450, 459, 330, 387, 631, 632, 635, 294, 986, 163, 6, 638, 508, 358, 419, 877, 417, 644, 347, 594, 827, 740, 476, 227, 846, 173, 653, 903, 176, 775, 657, 751, 909, 471, 105, 610, 683, 185, 530, 666, 402, 258, 292, 527, 5, 344, 924, 674, 352, 902, 61, 115, 679, 878, 336, 753, 72, 973, 81, 452, 786, 737, 689, 859, 795, 226, 256, 694, 783, 745, 622, 301, 242, 904, 228, 550, 978, 761, 637, 554, 296, 290, 651, 284, 516, 180, 681, 353, 959, 70, 871, 466, 852, 693, 396, 685, 159, 289, 856, 931, 656, 728, 669, 293, 350, 778, 109, 734, 313, 139, 54, 912, 224, 79, 781, 811, 671, 363, 28, 766, 375, 127, 440, 971, 857, 536, 75, 754, 921, 756, 937, 675, 750, 338, 435, 762, 251, 282, 688, 233, 980, 130, 743, 403, 311, 772, 773, 394, 613, 776, 106, 568, 210, 192, 1000, 945, 760, 784, 969, 802, 315, 406, 987, 711, 791, 792, 534, 555, 672, 677, 797, 16, 799, 907, 854, 365, 603, 53, 708, 351, 800, 849, 389, 488, 701, 521, 78, 493, 809, 847, 564, 818, 923, 920, 739, 382, 267, 102, 825, 343, 715, 828, 162, 141, 831, 103, 833, 824, 42, 374, 451, 517, 839, 4, 942, 616, 286, 558, 845, 790, 327, 841, 55, 544, 851, 254, 769, 243, 848, 318, 820, 150, 305, 738, 861, 974, 697, 588, 410, 45, 545, 571, 752, 944, 717, 57, 816, 456, 810, 742, 540, 244, 326, 196, 881, 582, 600, 259, 268, 886, 515, 355, 345, 890, 891, 238, 996, 537, 806, 896, 597, 658, 807, 837, 18, 255, 277, 411, 817, 723, 504, 566, 815, 910, 496, 383, 175, 628, 574, 695, 306, 169, 598, 830, 453, 922, 900, 709, 925, 788, 927, 531, 929, 930, 29, 620, 933, 934, 935, 324, 47, 511, 591, 346, 941, 928, 26, 126, 686, 946, 229, 124, 275, 911, 348, 955, 953, 901, 80, 420, 805, 621, 184, 560, 736, 111, 367, 541, 165, 998, 967, 968, 884, 123, 615, 994, 648, 465, 13, 263, 579, 485, 747, 842, 266, 241, 730, 156, 433, 94, 789, 1, 989, 990, 491, 194, 142, 972, 578, 528, 997, 300, 447, 145 };
            r = new[] { 1970, 1999, 1864, 1182, 1288, 1528, 1994, 1354, 1331, 1558, 1522, 1989, 1026, 1987, 1167, 1834, 1984, 1298, 1507, 1287, 1417, 1611, 1779, 1640, 1976, 1061, 1713, 1349, 1751, 1787, 1704, 1533, 1662, 1524, 1198, 1532, 1233, 1065, 1633, 1035, 1804, 1230, 1958, 1741, 1135, 1893, 1175, 1224, 1952, 1818, 1341, 1798, 1197, 1219, 1573, 1945, 1317, 1731, 1323, 1412, 1894, 1830, 1085, 1937, 1526, 1075, 1881, 1514, 1974, 1801, 1930, 1596, 1107, 1266, 1454, 1664, 1730, 1113, 1622, 1172, 1279, 1051, 1652, 1917, 1916, 1982, 1680, 1913, 1492, 1477, 1767, 1796, 1908, 1789, 1237, 1915, 1597, 1992, 1527, 1570, 1405, 1960, 1169, 1793, 1088, 1977, 1025, 1955, 1268, 1227, 1302, 1282, 1346, 1305, 1729, 1879, 1376, 1883, 1416, 1257, 1880, 1475, 1031, 1925, 1876, 1806, 1810, 1678, 1872, 1693, 1784, 1869, 1761, 1351, 1644, 1455, 1799, 1981, 1069, 1861, 1753, 1041, 1297, 1682, 1478, 1479, 1277, 1978, 1764, 1539, 1438, 1849, 1178, 1116, 1589, 1017, 1844, 1843, 1512, 1841, 1592, 1932, 1255, 1850, 1397, 1387, 1189, 1833, 1991, 1914, 1800, 1829, 1666, 1367, 1063, 1900, 1439, 1823, 1739, 1501, 1428, 1788, 1238, 1574, 1303, 1815, 1340, 1813, 1762, 1010, 1781, 1769, 1421, 1009, 1609, 1873, 1631, 1811, 1372, 1374, 1593, 1824, 1949, 1328, 1971, 1716, 1854, 1518, 1564, 1904, 1562, 1670, 1808, 1867, 1980, 1979, 1392, 1990, 1448, 1207, 1463, 1222, 1846, 1368, 1128, 1134, 1426, 1968, 1540, 1771, 1770, 1050, 1887, 1208, 1133, 1765, 1852, 1924, 1639, 1624, 1694, 1496, 1234, 1321, 1338, 1755, 1754, 1246, 1752, 1559, 1882, 1866, 1572, 1912, 1083, 1966, 1744, 1537, 1986, 1137, 1740, 1782, 1356, 1737, 1499, 1706, 1047, 1487, 1193, 1943, 1109, 1749, 1728, 1727, 1642, 1231, 1358, 1579, 1131, 1408, 1720, 1103, 1718, 1114, 1052, 1216, 1291, 1630, 1006, 1515, 1523, 1641, 1444, 1296, 1436, 1294, 1086, 1529, 1902, 1138, 1495, 1723, 1494, 1962, 1897, 1342, 1702, 1375, 1555, 1691, 1314, 1567, 1802, 1087, 1221, 1792, 1684, 1868, 1039, 1783, 1058, 1601, 1679, 1280, 1669, 1339, 1951, 1429, 1672, 1352, 1963, 1615, 1668, 1667, 1776, 1681, 1840, 1884, 1632, 1096, 1889, 1347, 1468, 1163, 1020, 1334, 1415, 1606, 1521, 1270, 1546, 1276, 1158, 1736, 1333, 1645, 1394, 1361, 1365, 1440, 1855, 1942, 1274, 1453, 1953, 1409, 1038, 1359, 1319, 1721, 1425, 1969, 1699, 1337, 1049, 1625, 1383, 1903, 1905, 1621, 1309, 1179, 1141, 1043, 1139, 1093, 1575, 1613, 1628, 1812, 1610, 1053, 1432, 1620, 1935, 1583, 1604, 1119, 1998, 1281, 1377, 1148, 1725, 1165, 1095, 1126, 1594, 1310, 1188, 1136, 1022, 1378, 1588, 1269, 1166, 1616, 1420, 1822, 1910, 1082, 1104, 1927, 1578, 1577, 1283, 1660, 1756, 1901, 1242, 1571, 1253, 1827, 1016, 1112, 1384, 1054, 1360, 1563, 1442, 1778, 1560, 1045, 1498, 1557, 1556, 1121, 1857, 1260, 1552, 1538, 1122, 1125, 1002, 1629, 1520, 1275, 1819, 1543, 1008, 1541, 1748, 1157, 1289, 1576, 1118, 1722, 1534, 1732, 1019, 1462, 1795, 1637, 1187, 1906, 1205, 1161, 1967, 1013, 1018, 1553, 1950, 1835, 1794, 1127, 1336, 1472, 1502, 1964, 1911, 1511, 1036, 1635, 1585, 1565, 1503, 1803, 1785, 1506, 1961, 1483, 1692, 1414, 1909, 1252, 1698, 1858, 1400, 1617, 1814, 1509, 1957, 1489, 1488, 1389, 1933, 1661, 1837, 1623, 1482, 1466, 1780, 1102, 1918, 1393, 1024, 1786, 1500, 1790, 1544, 1517, 1355, 1469, 1697, 1200, 1395, 1703, 1888, 1586, 1531, 1450, 1847, 1459, 1458, 1151, 1132, 1865, 1371, 1445, 1452, 1687, 1399, 1449, 1203, 1647, 1037, 1108, 1044, 1831, 1106, 1965, 1299, 1863, 1797, 1301, 1214, 1236, 1434, 1936, 1608, 1272, 1243, 1587, 1820, 1396, 1659, 1853, 1424, 1146, 1285, 1062, 1491, 1519, 1848, 1676, 1603, 1411, 1402, 1244, 1941, 1919, 1431, 1547, 1362, 1885, 1406, 1993, 1580, 1418, 1689, 1934, 1129, 1891, 1673, 1311, 1476, 1390, 1766, 1685, 1143, 1180, 1714, 1295, 1710, 1504, 1938, 1870, 1928, 1939, 1382, 1602, 1325, 1481, 1084, 1600, 1569, 1040, 1551, 1542, 1671, 1614, 1370, 1369, 1366, 1707, 1015, 1838, 1995, 1363, 1493, 1643, 1582, 1124, 1584, 1357, 1654, 1407, 1174, 1261, 1525, 1774, 1155, 1828, 1348, 1098, 1825, 1226, 1344, 1250, 1092, 1530, 1896, 1391, 1318, 1816, 1471, 1335, 1599, 1743, 1709, 1474, 1996, 1657, 1077, 1327, 1649, 1099, 1940, 1886, 1322, 1123, 1665, 1248, 1929, 1028, 1920, 1549, 1215, 1264, 1312, 1142, 1206, 1775, 1745, 1307, 1218, 1256, 1379, 1700, 1759, 1097, 1773, 1451, 1023, 1240, 1364, 1447, 1705, 1711, 1350, 1717, 1485, 1821, 1320, 1648, 1042, 1931, 1130, 1535, 1149, 1308, 1605, 1316, 1842, 1712, 1145, 1070, 1345, 1273, 1332, 1708, 1651, 1223, 1892, 1267, 1688, 1862, 1947, 1089, 1777, 1922, 1220, 1190, 1330, 1638, 1973, 1235, 1626, 1874, 1561, 1030, 1144, 1465, 1926, 1247, 1080, 1245, 1064, 1326, 1251, 1663, 1566, 1239, 1750, 1719, 1313, 1768, 1021, 1871, 1258, 1598, 1690, 1229, 1228, 1607, 1388, 1225, 1895, 1433, 1791, 1809, 1001, 1056, 1241, 1217, 1032, 1199, 1686, 1595, 1014, 1290, 1210, 1209, 1467, 1446, 1329, 1324, 1204, 1985, 1202, 1094, 1147, 1636, 1398, 1948, 1293, 1650, 1201, 1152, 1612, 1513, 1300, 1480, 1923, 1508, 1192, 1154, 1437, 1183, 1078, 1081, 1262, 1619, 1734, 1899, 1176, 1658, 1286, 1173, 1839, 1860, 1170, 1898, 1168, 1177, 1959, 1627, 1550, 1484, 1162, 1997, 1059, 1385, 1715, 1443, 1156, 1211, 1674, 1160, 1946, 1457, 1150, 1747, 1232, 1758, 1153, 1683, 1181, 1851, 1696, 1263, 1140, 1027, 1304, 1413, 1591, 1956, 1456, 1430, 1249, 1057, 1284, 1944, 1185, 1545, 1191, 1259, 1461, 1757, 1675, 1805, 1120, 1419, 1401, 1742, 1733, 1115, 1486, 1646, 1656, 1111, 1110, 1763, 1005, 1464, 1195, 1105, 1404, 1343, 1194, 1164, 1983, 1746, 1724, 1590, 1184, 1278, 1497, 1435, 1186, 1091, 1505, 1618, 1826, 1373, 1427, 1306, 1695, 1832, 1403, 1171, 1548, 1079, 1101, 1292, 1076, 1213, 1074, 1470, 1072, 1071, 1972, 1381, 1068, 1067, 1066, 1677, 1954, 1490, 1410, 1655, 1060, 1073, 1975, 1875, 1315, 1055, 1772, 1877, 1726, 1090, 1653, 1046, 1048, 1100, 1921, 1581, 1196, 1380, 1817, 1441, 1265, 1890, 1634, 1460, 1836, 1003, 1034, 1033, 1117, 1878, 1386, 1007, 1353, 1536, 1988, 1738, 1422, 1516, 1254, 1159, 1735, 1760, 1271, 1845, 1568, 1907, 1212, 2000, 1012, 1011, 1510, 1807, 1859, 1029, 1423, 1473, 1004, 1701, 1554, 1856 };
            Assert.AreEqual(true, w.wire(l, r));
        }

        [TestMethod]
        public void SumDigitalRootFactorTest()
        {
            var s = new SumDigitalRootFactor();
            Assert.AreEqual(2, s.sumDigitalRootFactor(2));
            Assert.AreEqual(9, s.sumDigitalRootFactor(4));
            Assert.AreEqual(51, s.sumDigitalRootFactor(10));
            Assert.AreEqual(2717, s.sumDigitalRootFactor(278));
            Assert.AreEqual(38145, s.sumDigitalRootFactor(3239));
        }

        [TestMethod]
        public void MaxLCMTest()
        {
            var m = new MaxLCM();
            Assert.AreEqual("3+5,15", m.maxLCM(8));
            Assert.AreEqual("2,2", m.maxLCM(2));
            Assert.AreEqual("3,3", m.maxLCM(3));
            Assert.AreEqual("4,4", m.maxLCM(4));
            Assert.AreEqual("2+3,6", m.maxLCM(5));
            Assert.AreEqual("1+2+3,6", m.maxLCM(6));
            Assert.AreEqual("2+3+5,30", m.maxLCM(10));
            Assert.AreEqual("3+5+7,105", m.maxLCM(15));
            Assert.AreEqual("1+3+4+5+7,420", m.maxLCM(20));
            Assert.AreEqual("4+5+7+9,1260", m.maxLCM(25));
            Assert.AreEqual("1+1+1+5+7+9+11+13+16+17+19,232792560", m.maxLCM(100));
        }

        [TestMethod]
        public void FillTemplateTest()
        {
            var f = new FillTemplate();
            string template = "{{foo}}";
            string[][] placeholders = { new[] { "foo", "bar" } };
            Assert.AreEqual("bar", f.fillTemplate(template, placeholders));

            template = "Hello, {{foo}}";
            placeholders = new[] { new[] { "foo", "bar" } };
            Assert.AreEqual("Hello, bar", f.fillTemplate(template, placeholders));

            template = "Some {{ text with random {{stuff}} }} in it.";
            placeholders = new[] { new[] { "stuff", "things" } };
            Assert.AreEqual("Some {{ text with random things }} in it.", f.fillTemplate(template, placeholders));

            template = "{{nested {{placeholders}} oh noes!}}";
            placeholders = new[] { new[] { "nested placeholders! oh noes!", "nah is k" }, new[] { "placeholders", "placeholders!" } };
            Assert.AreEqual("nah is k", f.fillTemplate(template, placeholders));

            template = "As you might notice, the given {{template}} cannot be loaded properly.";
            placeholders = new string[][] { };
            Assert.AreEqual("As you might notice, the given {{template}} cannot be loaded properly.", f.fillTemplate(template, placeholders));
        }

        [TestMethod]
        public void BouncyBallTest()
        {
            var b = new BouncyBall(BouncyBall.PathsByPathPrefixing);
            Assert.AreEqual(b.bouncyBall(10, 1), 10);
            Assert.AreEqual(b.bouncyBall(10, 10), 1);
            Assert.AreEqual(b.bouncyBall(10, 3), 4);
            Assert.AreEqual(b.bouncyBall(10, 0), 42);
            Assert.AreEqual(b.bouncyBall(36, 2), 239);
            Assert.AreEqual(b.bouncyBall(120, 0), 1844349560);
        }

        [TestMethod]
        public void BitWorkTest()
        {
            var b = new BitWork();
            Assert.AreEqual(65772, b.bitWork("SB16"));
            Assert.AreEqual(4195432, b.bitWork("|12<<3&510>>2SB10^6CB4"));
            Assert.AreEqual(4299, b.bitWork("<<8|9>>10^11"));
            Assert.AreEqual(148, b.bitWork("255"));
            Assert.AreEqual(51, b.bitWork("1"));
        }
    }
}
