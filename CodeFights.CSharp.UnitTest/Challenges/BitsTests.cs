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
    public class BitsTests
    {
        [TestMethod()]
        public void bitsTest()
        {
            var b = new Bits();
            Assert.IsTrue(new long[] { 1, 6, 12 }.SequenceEqual(b.bits(new long[] { 1, 5, 9 })));
            Assert.IsTrue(new long[] { 1, 6, 6, 12 }.SequenceEqual(b.bits(new long[] { 1, 5, 6, 9 })));
            Assert.IsTrue(new long[] { 6, 7, 6, 2, 12 }.SequenceEqual(b.bits(new long[] { 5, 7, 6, 2, 10 })));
            Assert.IsTrue(new long[] { 30, 56, 64, 30, 28 }.SequenceEqual(b.bits(new long[] { 27, 44, 64, 30, 25 })));
            Assert.IsTrue(new long[] { 13458, 12368, 7790, 8048, 7712, 3720, 7968, 6470, 7960, 6422, 12740, 7192, 3106, 3088, 12288, 7692, 13376, 3158, 6500, 8128, 6968, 12928, 8072, 3162, 1640, 7596, 13240, 6724, 7884, 13240, 7776, 1664, 8160, 4092, 8146, 6884, 13804, 13804, 13892, 14094, 1984, 1696, 8112, 7956, 8064, 2000, 6870, 2036, 3680, 1774, 13756, 14080, 4044, 3954, 8048, 3820, 7644, 7326 }.SequenceEqual(b.bits(new long[] { 9363, 8276, 6767, 7794, 7216, 2700, 7720, 4423, 7708, 4375, 8645, 6170, 2083, 2065, 8196, 7181, 9312, 2135, 4453, 8001, 4922, 8896, 6026, 2139, 1129, 5549, 9148, 4677, 7373, 9146, 5729, 1216, 7906, 3070, 7891, 4837, 9710, 9710, 9797, 9999, 1736, 1186, 7090, 6934, 7968, 1746, 4823, 1526, 2658, 1263, 9661, 10000, 3918, 2931, 7793, 3309, 6621, 5279 })));
            Assert.IsTrue(new long[] { 7680, 6916, 3946, 7784, 932, 8176, 984, 1788, 13626, 8064, 6652, 3616, 4072, 13312, 508, 4076, 3904, 448, 1962, 7896, 3902, 6736, 3760, 7728, 4084, 7750, 7702, 7122, 6340, 3672, 3748, 12960, 7960, 12780, 3806, 12848, 3528, 7848, 3520, 3204, 3790, 7104, 8132, 934, 7256, 7942, 4070, 8132, 7704, 3584, 12846, 12922, 7982, 7994, 7620, 7928, 7514, 13556, 8084, 7356, 8036, 8124, 2042, 2012, 7308, 1572, 7336, 8152, 8036, 4036, 7760, 3910, 6664, 12412, 13784, 7402, 3668, 968, 4076, 424, 1688, 1960, 13352, 7010, 3852, 8144, 7798, 3960, 8152, 8156, 204, 8078, 511, 13416, 4016, 7664, 8152, 13340, 3388, 1000 }.SequenceEqual(b.bits(new long[] { 7424, 4869, 3435, 6761, 806, 8049, 922, 1277, 9531, 7840, 4605, 3105, 3948, 9217, 493, 4014, 3650, 324, 1451, 5849, 3391, 4692, 3250, 7218, 4053, 5703, 6679, 5075, 4294, 3161, 2725, 8866, 7705, 8686, 2783, 8760, 2506, 6828, 2512, 2182, 3279, 5060, 8006, 807, 5210, 6919, 4007, 6086, 5658, 3200, 8751, 8827, 7727, 5947, 6597, 6906, 6491, 9461, 7574, 5310, 7526, 7102, 2011, 1757, 6286, 1061, 6316, 8025, 7526, 3781, 6738, 3399, 4618, 8318, 9689, 6379, 2645, 906, 3822, 298, 1177, 1833, 9258, 4963, 3598, 7122, 5751, 2938, 7130, 7133, 142, 7823, 511, 9322, 2996, 6648, 7130, 9246, 2365, 874 })));
        }
    }
}