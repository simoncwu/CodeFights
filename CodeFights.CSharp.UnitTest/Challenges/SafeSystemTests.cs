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
    public class SafeSystemTests
    {
        [TestMethod()]
        public void safeSystemTest()
        {
            var s = new SafeSystem();
            var prev = new[] { 1, 2 };
            var length = new[] { 1, 1 };
            var limit = new[] { 2, 2 };
            Assert.AreEqual(4, s.safeSystem(prev, length, limit));

            prev = new[] { 1, 2, 2, 4, 4, 4, 3 };
            length = new[] { 1, 1, 2, 1, 1, 2, 1 };
            limit = new[] { 4, 2, 3, 7, 1, 5, 4 };
            Assert.AreEqual(16, s.safeSystem(prev, length, limit));

            prev = new[] { 1 };
            length = new[] { 1 };
            limit = new[] { 239 };
            Assert.AreEqual(239, s.safeSystem(prev, length, limit));

            prev = new[] { 9, 1, 9, 1, 8, 3, 1, 8, 5 };
            length = new[] { 10, 20, 20, 20, 20, 10, 20, 20, 20 };
            limit = new[] { 10, 3, 6, 17, 9, 5, 27, 22, 12 };
            Assert.AreEqual(105, s.safeSystem(prev, length, limit));

            prev = new[] { 1, 7, 1, 4, 1, 4, 2, 1, 1 };
            length = new[] { 300, 300, 300, 300, 200, 300, 200, 300, 100 };
            limit = new[] { 5, 3, 10, 4, 29, 3, 24, 3, 9 };
            Assert.AreEqual(71, s.safeSystem(prev, length, limit));

            prev = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            length = new[] { 8, 2, 1, 9, 8, 7, 2, 1, 6 };
            limit = new[] { 64, 62, 14, 147, 98, 156, 1, 178, 69 };
            Assert.AreEqual(789, s.safeSystem(prev, length, limit));

            prev = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            length = new[] { 6, 8, 3, 7, 4, 2, 4, 2, 7 };
            limit = new[] { 70, 20, 154, 175, 160, 140, 25, 141, 111 };
            Assert.AreEqual(230, s.safeSystem(prev, length, limit));

            prev = new[] { 1, 2, 3, 4, 5, 6, 7, 4, 9, 10, 11, 4, 13, 14, 15 };
            length = new[] { 1, 2, 3, 4, 3, 2, 3, 4, 3, 3, 3, 2, 1, 1, 4 };
            limit = new[] { 3, 3, 4, 3, 2, 5, 2, 6, 5, 6, 6, 5, 4, 6, 2 };
            Assert.AreEqual(33, s.safeSystem(prev, length, limit));

            prev = new[] { 1, 9, 31, 38, 35, 1, 54, 46, 56, 56, 18, 56, 56, 35, 19, 35, 19, 3, 56, 46, 20, 51, 45, 16, 22, 7, 33, 43, 27, 35, 58, 1, 46, 9, 56, 1, 15, 16, 60, 24, 28, 45, 17, 3, 7, 44, 46, 11, 6, 56, 34, 26, 1, 4, 1, 37, 34, 24, 35 };
            length = new[] { 1000000000, 1000000000, 500000000, 1000000000, 1000000000, 1000000000, 500000000, 500000000, 500000000, 500000000, 500000000, 1000000000, 500000000, 1000000000, 1000000000, 500000000, 500000000, 1000000000, 500000000, 1000000000, 500000000, 1000000000, 500000000, 1000000000, 1000000000, 500000000, 1000000000, 500000000, 1000000000, 500000000, 500000000, 500000000, 1000000000, 1000000000, 500000000, 1000000000, 500000000, 1000000000, 500000000, 500000000, 500000000, 1000000000, 1000000000, 1000000000, 1000000000, 500000000, 500000000, 500000000, 1000000000, 500000000, 500000000, 500000000, 500000000, 500000000, 500000000, 1000000000, 500000000, 500000000, 500000000 };
            limit = new[] { 556, 513, 181, 734, 298, 501, 230, 853, 660, 578, 564, 764, 732, 542, 465, 394, 654, 435, 827, 283, 106, 6, 790, 486, 245, 993, 72, 56, 480, 105, 931, 991, 487, 656, 910, 1000, 379, 853, 469, 898, 793, 479, 628, 689, 705, 414, 104, 612, 800, 850, 798, 799, 6, 929, 338, 785, 337, 734, 185 };
            Assert.AreEqual(10600, s.safeSystem(prev, length, limit));

            prev = new[] { 1, 27, 35, 35, 49, 21, 18, 4, 46, 10, 14, 28, 51, 54, 4, 32, 35, 4, 8, 35, 30, 59, 48, 53, 27, 54, 51, 20, 4, 37, 59, 2, 46, 2, 7, 47, 21, 42, 21, 35, 54, 52, 32, 47, 1, 40, 2, 60, 53, 4, 1, 54, 21, 5, 30, 8, 53, 1, 2 };
            length = new[] { 200000000, 300000000, 300000000, 100000000, 300000000, 200000000, 100000000, 100000000, 300000000, 100000000, 100000000, 200000000, 300000000, 200000000, 300000000, 200000000, 100000000, 100000000, 300000000, 100000000, 300000000, 100000000, 200000000, 200000000, 200000000, 300000000, 300000000, 300000000, 300000000, 100000000, 300000000, 200000000, 100000000, 100000000, 100000000, 200000000, 300000000, 200000000, 300000000, 200000000, 100000000, 300000000, 100000000, 300000000, 100000000, 100000000, 100000000, 100000000, 200000000, 300000000, 300000000, 300000000, 300000000, 200000000, 300000000, 300000000, 300000000, 100000000, 300000000 };
            limit = new[] { 865, 840, 768, 603, 108, 354, 899, 868, 821, 878, 486, 413, 896, 872, 129, 97, 801, 838, 279, 971, 756, 250, 24, 245, 883, 731, 887, 106, 204, 381, 204, 678, 33, 340, 987, 80, 662, 845, 955, 39, 654, 989, 24, 105, 822, 704, 690, 573, 800, 243, 372, 939, 338, 986, 246, 983, 445, 196, 931 };
            Assert.AreEqual(10957, s.safeSystem(prev, length, limit));

            prev = new[] { 1, 4, 1, 71, 45, 47, 57, 4, 9, 45, 37, 47, 10, 74, 1, 13, 5, 24, 5, 79, 47, 9, 17, 37, 22, 3, 71, 26, 63, 8, 57, 52, 95, 85, 6, 2, 63, 69, 63, 46, 38, 11, 2, 32, 82, 4, 4, 1, 2, 21, 25, 58, 2, 9, 47, 3, 22, 12, 47, 48, 100, 57, 97, 20, 5, 60, 9, 45, 55, 4, 32, 61, 92, 71, 52, 30, 100, 35, 48, 57, 33, 99, 60, 23, 97, 68, 45, 100, 7, 58, 25, 67, 10, 55, 55, 84, 2, 43, 43 };
            length = new[] { 800000000, 400000000, 400000000, 800000000, 900000000, 600000000, 200000000, 500000000, 500000000, 500000000, 500000000, 200000000, 900000000, 100000000, 200000000, 300000000, 400000000, 600000000, 800000000, 400000000, 300000000, 400000000, 900000000, 1000000000, 600000000, 200000000, 100000000, 300000000, 700000000, 100000000, 400000000, 1000000000, 200000000, 800000000, 100000000, 800000000, 600000000, 800000000, 500000000, 900000000, 300000000, 200000000, 800000000, 800000000, 500000000, 500000000, 900000000, 400000000, 800000000, 700000000, 900000000, 100000000, 1000000000, 500000000, 200000000, 900000000, 200000000, 800000000, 500000000, 400000000, 500000000, 600000000, 500000000, 300000000, 1000000000, 900000000, 900000000, 800000000, 500000000, 600000000, 400000000, 1000000000, 500000000, 700000000, 600000000, 300000000, 400000000, 200000000, 800000000, 400000000, 200000000, 800000000, 700000000, 400000000, 900000000, 1000000000, 500000000, 600000000, 200000000, 800000000, 600000000, 200000000, 500000000, 200000000, 1000000000, 900000000, 500000000, 500000000, 1000000000 };
            limit = new[] { 23, 950, 890, 467, 99, 124, 628, 433, 578, 906, 970, 872, 373, 457, 158, 320, 132, 661, 35, 801, 720, 364, 668, 714, 448, 908, 563, 683, 648, 82, 539, 213, 949, 924, 334, 52, 243, 680, 472, 228, 767, 211, 202, 337, 589, 827, 856, 101, 691, 564, 275, 78, 700, 671, 687, 222, 807, 599, 198, 529, 109, 18, 988, 666, 726, 326, 161, 710, 164, 737, 514, 327, 623, 480, 376, 643, 319, 777, 415, 203, 349, 1000, 632, 524, 211, 318, 792, 633, 263, 70, 879, 439, 148, 862, 314, 287, 529, 44, 706 };
            Assert.AreEqual(18918, s.safeSystem(prev, length, limit));

            prev = new[] { 65, 26, 29, 46, 68, 8, 21, 21, 46, 32, 49, 17, 17, 54, 23, 9, 23, 17, 21, 1, 93, 20, 63, 7, 1, 72, 59, 10, 46, 17, 46, 25, 68, 17, 72, 40, 46, 5, 6, 68, 8, 46, 40, 42, 1, 1, 42, 20, 72, 56, 1, 52, 40, 10, 13, 80, 74, 9, 7, 46, 53, 64, 39, 9, 76, 8, 46, 44, 49, 10, 46, 20, 56, 39, 54, 95, 80, 72, 29, 92, 92, 85, 45, 17, 46, 21, 7, 97, 9, 25, 6, 33, 54, 5, 75, 21, 56, 46, 5 };
            length = new[] { 400000000, 400000000, 500000000, 500000000, 400000000, 100000000, 400000000, 500000000, 100000000, 300000000, 300000000, 300000000, 400000000, 200000000, 400000000, 300000000, 500000000, 200000000, 300000000, 200000000, 500000000, 200000000, 100000000, 500000000, 200000000, 200000000, 200000000, 100000000, 500000000, 500000000, 400000000, 200000000, 300000000, 300000000, 500000000, 100000000, 500000000, 200000000, 400000000, 500000000, 400000000, 400000000, 100000000, 400000000, 400000000, 200000000, 200000000, 300000000, 300000000, 200000000, 300000000, 100000000, 200000000, 100000000, 200000000, 400000000, 100000000, 200000000, 500000000, 400000000, 200000000, 400000000, 100000000, 400000000, 500000000, 400000000, 300000000, 300000000, 100000000, 200000000, 500000000, 300000000, 400000000, 400000000, 300000000, 300000000, 200000000, 300000000, 100000000, 500000000, 300000000, 100000000, 400000000, 400000000, 200000000, 300000000, 500000000, 300000000, 200000000, 100000000, 100000000, 500000000, 200000000, 100000000, 300000000, 500000000, 200000000, 100000000, 500000000 };
            limit = new[] { 687, 4172, 3447, 6264, 2428, 1231, 3436, 8483, 9940, 5609, 7123, 8841, 7614, 6801, 2885, 7007, 9798, 2702, 5857, 2656, 4972, 7917, 8855, 523, 7699, 1407, 1326, 2211, 9154, 8696, 8000, 9294, 9830, 9329, 2680, 1046, 8302, 7879, 6907, 8171, 8398, 154, 4492, 4175, 6333, 9295, 9494, 9849, 6936, 8334, 6854, 3955, 4108, 8437, 3326, 6892, 6623, 9123, 5284, 311, 1096, 6013, 9649, 713, 226, 1933, 6290, 6239, 9933, 7166, 9770, 774, 7213, 5217, 4574, 4881, 4697, 5835, 9495, 1606, 2157, 5365, 4820, 6913, 7289, 4043, 2870, 7936, 112, 8493, 5442, 2469, 7274, 7137, 4978, 6471, 1986, 9727, 6660 };
            Assert.AreEqual(173360, s.safeSystem(prev, length, limit));

            prev = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            length = new[] { 2, 8, 7, 10, 9, 2, 12, 8, 10, 15, 6, 14, 1, 2, 10, 2, 1, 5, 10, 9, 3, 4, 8, 7, 9, 10, 14, 5, 11, 7, 3, 5, 15, 2, 14, 13, 8, 7, 15, 1, 11, 4, 4, 1, 14, 5, 9, 6, 10, 12, 11, 9, 9, 7, 13, 4, 15, 11, 9, 11, 1, 6, 14, 1, 13, 13, 2, 12, 6, 7, 14, 4, 1, 9, 12, 13, 12, 8, 5, 9, 1, 11, 4, 3, 15, 9, 4, 12, 13, 2, 3, 11, 7, 9, 7, 9, 3, 1, 13 };
            limit = new[] { 8328, 5305, 2000, 9720, 977, 8025, 4760, 250, 6402, 9133, 7301, 5976, 9608, 4596, 1574, 6238, 9967, 7801, 1895, 3290, 1750, 9338, 1206, 4776, 7928, 9797, 2927, 3894, 6498, 3637, 3759, 7408, 515, 8713, 8931, 3172, 5286, 5804, 7081, 719, 3881, 5629, 1660, 3373, 1689, 2711, 9467, 4443, 5507, 4153, 547, 9959, 8979, 3503, 9791, 3293, 9799, 9029, 5470, 7835, 8044, 6074, 9884, 670, 2431, 7401, 5879, 8770, 2108, 337, 5866, 9412, 401, 9566, 9028, 6866, 8427, 6028, 594, 3881, 4999, 5386, 2495, 5733, 4833, 7796, 9130, 5988, 2232, 6998, 5247, 7474, 295, 8783, 6171, 8348, 3339, 9691, 3116 };
            Assert.AreEqual(546724, s.safeSystem(prev, length, limit));

            prev = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 10, 21, 22, 23, 24, 25, 26, 27, 28, 29, 10, 31, 32, 33, 34, 35, 36, 37, 38, 39, 10, 41, 42, 43, 44, 45, 46, 47, 48, 49, 10, 51, 52, 53, 54, 55, 56, 57, 58, 59, 10, 61, 62, 63, 64, 65, 66, 67, 68, 69, 10, 71, 72, 73, 74, 75, 76, 77, 78, 79, 10, 81, 82, 83, 84, 85, 86, 87, 88, 89, 10, 91, 92, 93, 94, 95, 96, 97, 98, 99 };
            length = new[] { 5, 2, 5, 4, 5, 3, 4, 4, 4, 5, 1, 4, 2, 3, 4, 2, 5, 4, 2, 1, 4, 3, 5, 1, 1, 2, 4, 3, 5, 1, 2, 3, 2, 2, 3, 1, 4, 1, 4, 2, 2, 4, 1, 5, 4, 1, 2, 1, 2, 4, 2, 2, 1, 1, 1, 5, 2, 2, 5, 5, 2, 5, 2, 3, 4, 4, 5, 4, 3, 4, 2, 4, 4, 3, 4, 5, 3, 4, 3, 5, 2, 5, 5, 1, 1, 3, 5, 1, 2, 5, 1, 5, 5, 5, 3, 2, 5, 4, 3 };
            limit = new[] { 7665, 4483, 7303, 7805, 9179, 8122, 8320, 9677, 3017, 5566, 7586, 1385, 7400, 1292, 9068, 3420, 8052, 5809, 9594, 2069, 9547, 7321, 8633, 7872, 1321, 7106, 4806, 5467, 7132, 2633, 1390, 1665, 1888, 2619, 6093, 3041, 3123, 9892, 338, 4632, 209, 9603, 4761, 9473, 6280, 195, 1759, 4475, 8068, 417, 6465, 6242, 8643, 6092, 4076, 9155, 9457, 511, 9821, 9867, 9996, 7752, 8049, 9160, 8945, 372, 4085, 4550, 2268, 1391, 3126, 1523, 3242, 4520, 6945, 4058, 6137, 7322, 7315, 2218, 9701, 9747, 6793, 1791, 9020, 6991, 3600, 1063, 395, 7133, 7685, 2285, 734, 2552, 5478, 2032, 2690, 7950, 1550 };
            Assert.AreEqual(118242, s.safeSystem(prev, length, limit));

            prev = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            length = new[] { 18, 8, 19, 4, 9, 10, 10, 15, 18, 14, 18, 17, 2, 13, 16, 13, 7, 18, 12, 6, 20, 4, 4, 6, 8, 20, 17, 10, 2, 1, 19, 19, 9, 19, 12, 13, 5, 16, 20, 15, 3, 3, 9, 5, 1, 20, 16, 7, 18, 17, 9, 11, 5, 2, 6, 19, 13, 1, 12, 18, 5, 2, 7, 14, 13, 6, 13, 12, 6, 11, 19, 8, 2, 13, 13, 9, 4, 1, 13, 7, 15, 9, 7, 2, 2, 17, 18, 20, 16, 11, 4, 7, 9, 19, 5, 6, 2, 15, 4, 7, 20, 6, 15, 15, 9, 12, 6, 10, 16, 19, 11, 7, 12, 6, 14, 18, 5, 10, 14, 3, 16, 18, 2, 20, 2, 14, 3, 19, 4, 12, 11, 3, 16, 11, 11, 18, 17, 7, 20, 5, 18, 18, 2, 20, 10, 4, 3, 10, 20, 7, 7, 11, 17, 19, 12, 15, 4, 13, 3, 9, 7, 19, 16, 8, 16, 13, 9, 10, 6, 12, 10, 16, 8, 2, 6, 15, 14, 3, 16, 20, 13, 5, 17, 15, 10, 8, 19, 11, 19, 9, 19, 16, 15, 18, 17, 10, 17, 19, 8, 15, 13, 10, 18, 20, 19, 19, 3, 2, 18, 7, 10, 6, 19, 16, 16, 9, 1, 10, 16, 16, 2, 7, 20, 20, 8, 19, 4, 17, 3, 19, 15, 1, 16, 1, 3, 10, 20, 5, 1, 19, 12, 4, 9, 18, 13, 16, 12, 8, 1, 6, 13, 14, 11, 5, 3, 12, 18, 12, 12, 1, 10, 12, 12, 1, 8, 1, 9, 16, 17, 8, 3, 20, 14, 2, 1, 7, 1, 1, 6, 20, 13, 2, 3, 9, 13, 5, 6, 14, 13, 11, 4, 2, 2, 17, 6, 17, 9, 17, 8, 7, 12, 20, 7, 3, 18, 17, 14, 8, 2, 16, 8, 4, 3, 15, 14, 4, 8, 9, 11, 1, 9, 10, 10, 20, 3, 4, 20, 10, 19, 15, 7, 4, 3, 1, 16, 2, 14, 13, 16, 11, 11, 19, 7, 14, 6, 13, 11, 17, 4, 6, 16, 5, 2, 3, 20, 7, 17, 12, 12, 8, 7, 6, 4, 9, 7, 2, 10, 7, 12, 2, 15, 2, 2, 19, 19, 9, 14, 5, 12, 3, 17, 17, 15, 2, 8, 16, 4, 3, 4, 20, 5, 15, 7, 2, 6, 3, 5, 9, 17, 8, 6, 4, 19, 15, 13, 16, 8, 12, 18, 17, 10, 2, 11, 8, 18, 20, 7, 15, 12, 9, 17, 2, 10, 20, 16, 6, 9, 15, 3, 17, 9, 19, 14, 19, 4, 8, 18, 6, 19, 5, 4, 2, 10, 6, 6, 13, 2, 15, 11, 14, 18, 19, 6, 1, 5, 17, 18, 16, 9, 3, 6, 10, 2, 18, 2, 8, 18, 3, 8, 13, 2, 7, 11, 8, 2, 3, 17, 6, 20, 11, 20, 7, 8, 14, 16, 16, 1, 3, 6, 19, 18, 16, 7, 8, 12, 7, 12, 17, 9 };
            limit = new[] { 480488956, 610524181, 851592955, 21466891, 533416911, 246546036, 768772222, 838466234, 856117364, 78867179, 737173762, 585889592, 34998746, 560579448, 541303189, 737032610, 817869870, 192210007, 731154820, 343038294, 248341979, 24799749, 608999003, 461873135, 873546640, 204206912, 510874601, 71601995, 509926969, 842566917, 867281977, 130655111, 893406467, 341632656, 189806488, 154615553, 297532764, 190328671, 574033045, 834166356, 110101232, 730542382, 317657083, 243136094, 672524204, 217489403, 497075416, 341282365, 340097981, 322660866, 806624377, 666275660, 985081233, 899221441, 766658155, 615224617, 614707668, 116476916, 931332218, 652656050, 21551475, 36202905, 875587252, 297302274, 401539995, 9792492, 402703206, 403790199, 4483002, 402199659, 752770845, 75621295, 678146940, 578661074, 441471142, 20602501, 518882510, 817774367, 763383053, 537600792, 710797277, 593252750, 557217696, 577105091, 659797271, 781708445, 635089388, 22685989, 201894696, 575730952, 695626685, 899172377, 810860286, 839416269, 531723041, 64373182, 363916228, 21215785, 164906085, 785733743, 791970537, 362080151, 53284886, 726992075, 697990169, 176820695, 856980737, 8806317, 859325761, 767613668, 14816306, 269087284, 67637903, 483906811, 804975863, 92269500, 631418479, 152050842, 36333789, 848483809, 994068878, 61857406, 625700785, 754250370, 163105497, 805804451, 657730431, 301258170, 65656190, 929499974, 298423445, 243545576, 19022057, 623567589, 150198144, 657669032, 454751943, 78749757, 238743309, 3330518, 905265926, 620571978, 147256393, 626193809, 843421137, 548253258, 224489088, 302220853, 111422359, 637784505, 645047104, 961942879, 55158533, 54810196, 469952086, 234567403, 437182726, 415354137, 2072526, 172151032, 644561097, 214598981, 551652854, 941485026, 897082298, 666583124, 13068123, 958136902, 233684358, 838045700, 482541770, 242143488, 941922331, 930377809, 909002576, 551921455, 102042533, 266213241, 711638585, 150091311, 458770065, 644957688, 283270419, 379871645, 891706764, 34477708, 50454443, 430739286, 844569476, 221630001, 239241230, 693860215, 459559333, 503852069, 672959112, 748811357, 711272284, 44789732, 169034152, 571429541, 320039511, 860855084, 263097401, 668279083, 180805249, 103177721, 974645064, 63144206, 276270601, 191449737, 941014564, 726365610, 884939100, 727298904, 773077592, 192722076, 567609125, 702039332, 41830834, 285767105, 596808787, 778360554, 265117759, 809419574, 795837458, 203471333, 410641483, 756009304, 746942415, 164333973, 587653733, 588031684, 999003960, 700906421, 402418520, 224803928, 54552121, 840052802, 92515890, 250346799, 577517311, 877560186, 660949055, 974077607, 601374199, 364663770, 789124366, 417302621, 441892303, 389834270, 192446058, 890168366, 52796275, 491659587, 828034145, 535572023, 864938512, 940796039, 586773823, 979952853, 215471891, 726395239, 943517075, 24817317, 408313386, 911764383, 648869928, 2202757, 627189569, 473473324, 158496268, 56530320, 217292933, 730789452, 693515916, 909970212, 967036516, 110748028, 79710004, 70421726, 799677321, 725267320, 398050259, 113202331, 350234851, 988964670, 602580596, 962867833, 951983519, 48263690, 949720932, 363610323, 475821864, 63312730, 984923442, 824689223, 980637997, 973317354, 750718121, 17284019, 257678746, 630844087, 920885463, 572277810, 554525853, 304702208, 787079945, 550884642, 119661729, 519116351, 540682956, 21305889, 852539989, 114550580, 333299180, 119193866, 921925797, 676389593, 410830968, 34340859, 268515519, 227020910, 174073018, 71273810, 739502606, 876298605, 460303170, 4521386, 853713473, 365584790, 456426204, 286790626, 231173445, 792053476, 54306452, 740524821, 800693573, 152928660, 689907640, 987272866, 491920048, 69788196, 846600661, 508021796, 885634098, 185023312, 820266679, 924853114, 905473720, 107564566, 1150060, 766766783, 173462896, 956988850, 155678529, 972169810, 217958853, 497724834, 191697347, 728540366, 312824679, 715873187, 588035263, 827531026, 832958528, 436989873, 307058497, 578178105, 167306367, 829230089, 150462103, 88492450, 221579919, 168844585, 745893454, 399795944, 110437152, 416639438, 533542963, 399570410, 586163484, 909959924, 195644498, 176888516, 952012210, 644314072, 642869497, 83172306, 270118990, 554996216, 1212597, 866038195, 716801693, 430329105, 893844563, 582539075, 200704140, 119283487, 574990048, 101915038, 13227081, 739720287, 64493480, 18802723, 667602496, 517464911, 60504121, 787211374, 959619358, 289287340, 295234656, 707474012, 249181649, 415947634, 742613545, 355289097, 741964677, 916335839, 310203363, 568507860, 107526055, 528033903, 489664537, 433823321, 203478500, 62681056, 48477080, 642299509, 767178794, 392662830, 532724079, 402285893, 623740580, 438029463, 32850153, 794913829, 41465282, 521795735, 465186709, 613269172, 497240110, 356597228, 927382845, 791728846, 179747543, 252932498, 316614641, 244969616, 902183145, 179331783, 53528573, 297402967, 15366609, 970468103, 552901613, 522380480, 131750716, 166526480, 21490319, 23620776, 670052632, 736983518, 2367215, 422324524, 136549777, 477820591, 877671516, 286150569, 554547476, 735434495, 855658593, 968519612, 82195023, 98490252, 30901452, 669012290, 663113261, 974544722, 813594538, 936414808, 644210653, 60575631, 473791816, 360506203, 278761676, 288478144, 939288626, 74743528, 786870437, 221720993, 340056374, 669536732, 194544983, 632101167, 658411361, 178806612, 984390414, 338982056, 347256831 };
            Assert.AreEqual(239744759089, s.safeSystem(prev, length, limit));
        }
    }
}