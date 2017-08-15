using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.InterviewPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice.Tests
{
    [TestClass()]
    public class FindLongestSubarrayBySumTests
    {
        [TestMethod()]
        public void findLongestSubarrayBySumTest()
        {
            var f = new FindLongestSubarrayBySum();
            Assert.IsTrue(new[] { 2, 4 }.SequenceEqual(f.findLongestSubarrayBySum(12, new[] { 1, 2, 3, 7, 5 })));
            Assert.IsTrue(new[] { 1, 5 }.SequenceEqual(f.findLongestSubarrayBySum(15, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })));
            Assert.IsTrue(new[] { 1, 8 }.SequenceEqual(f.findLongestSubarrayBySum(15, new[] { 1, 2, 3, 4, 5, 0, 0, 0, 6, 7, 8, 9, 10 })));
            Assert.IsTrue(new[] { 1, 3 }.SequenceEqual(f.findLongestSubarrayBySum(3, new[] { 0, 3, 0 })));
            Assert.IsTrue(new[] { 1, 1 }.SequenceEqual(f.findLongestSubarrayBySum(3, new[] { 3 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(3, new[] { 2 })));
            Assert.IsTrue(new[] { 42, 46 }.SequenceEqual(f.findLongestSubarrayBySum(468, new[] { 135, 101, 170, 125, 79, 159, 163, 65, 106, 146, 82, 28, 162, 92, 196, 143, 28, 37, 192, 5, 103, 154, 93, 183, 22, 117, 119, 96, 48, 127, 0, 172, 0, 139, 0, 0, 70, 113, 68, 100, 36, 95, 104, 12, 123, 134 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(665, new[] { 142, 112, 54, 69, 148, 45, 63, 158, 38, 60, 124, 142, 130, 179, 117, 36, 191, 43, 89, 107, 41, 143, 65, 49, 47, 6, 91, 130, 171, 151, 7, 102, 194, 149, 30, 24, 85, 155, 157, 41, 167, 177, 132, 109, 145, 40, 27, 124, 138, 139, 119, 83, 130, 142, 34, 116, 40, 59, 105, 131, 178, 107, 74, 187, 22, 146, 125, 73, 71, 30, 178, 174, 98, 113 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(1291, new[] { 162, 37, 156, 168, 56, 175, 32, 53, 151, 151, 142, 125, 167, 31, 108, 192, 8, 138, 58, 88, 154, 184, 146, 110, 10, 159, 22, 189, 23, 147, 107, 31, 14, 169, 101, 192, 163, 56, 11, 160, 25, 138, 149, 84, 196, 42, 3, 151, 92, 37, 175, 21, 197, 22, 149, 200, 69, 85, 82, 135, 54, 200, 19, 139, 101, 189, 128, 68, 129, 94, 49, 84, 8, 22, 111, 18, 14, 115, 110, 17, 136, 52, 1, 50, 120, 157, 199 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(225, new[] { 9, 45, 10, 190 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(1196, new[] { 86, 94, 144 })));
            Assert.IsTrue(new[] { 2, 2 }.SequenceEqual(f.findLongestSubarrayBySum(0, new[] { 1, 0, 2 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(1588, new[] { 115, 104, 49, 1, 59, 19, 181, 197, 199, 82, 190, 199, 10, 158, 73, 23, 139, 93, 39, 180, 191, 58, 159, 192 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(889, new[] { 157, 112, 3, 35, 73, 56, 129, 47, 163, 87, 76, 34, 70, 143, 45, 17 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(1999, new[] { 123, 52, 22, 100, 158, 77, 93, 190, 76, 113, 1, 111, 4, 70, 62, 89, 2, 190, 56, 24, 3, 186, 183, 86, 89, 27, 18, 158, 33, 133, 170, 155, 122, 190, 177, 130, 169, 93, 26, 156, 35, 150, 42, 113, 146, 61, 119, 154, 140, 24, 80, 197, 88, 130, 150, 38, 67, 150, 194, 196, 98, 17, 87, 106, 89, 83, 56, 135, 115, 102, 117, 72, 187, 64, 114, 156, 186, 54, 113, 9, 33, 146 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(1757, new[] { 122, 159, 47, 183, 82, 145, 197, 23, 130, 162, 136, 51, 174, 67 })));
            Assert.IsTrue(new[] { 2, 15 }.SequenceEqual(f.findLongestSubarrayBySum(528, new[] { 26, 144, 0, 0, 125, 24, 0, 0, 0, 0, 173, 0, 0, 0, 62, 182, 4, 33, 106, 194, 126, 32, 93, 143, 23, 87, 65, 0, 0, 0, 0, 0, 0, 0, 0, 101, 188, 161, 14, 175, 71, 171, 36, 34, 112, 161, 97, 68, 86, 151, 141, 95, 96, 25, 20, 126, 177, 95, 59, 103, 172, 67, 79, 194, 52, 85, 19, 65, 120, 153, 1, 88, 61, 127, 11, 158, 171, 116, 177, 28, 44, 159, 165, 110, 83, 87, 166, 88, 178, 75, 26, 28, 30, 129, 24, 121, 103, 163, 124, 197, 138, 62, 196, 126, 65, 61, 3, 117, 31, 127, 12, 172, 12, 148, 154, 0, 0, 0, 0, 0, 121, 191 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(189, new[] { 164, 141, 52, 63, 30, 101, 114, 159, 179, 166, 8, 78, 1, 59, 40, 104, 161, 158, 125, 78, 109, 114, 88, 2, 51 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(429, new[] { 194, 185, 6, 141, 112, 105, 36, 157, 73, 151, 24, 86, 157, 17, 27, 158, 127, 158, 138, 72, 70, 162, 97, 23, 18, 113, 118, 97, 186, 42, 24, 130, 30, 166, 160, 133, 97, 56, 54, 163, 185, 135, 55, 173, 58, 170, 133, 164, 8, 84, 112, 36, 68, 49, 76, 139, 24, 143, 155, 112, 142 })));
            Assert.IsTrue(new[] { 20, 37 }.SequenceEqual(f.findLongestSubarrayBySum(1562, new[] { 28, 68, 142, 130, 41, 14, 175, 2, 78, 16, 84, 14, 193, 25, 2, 193, 160, 71, 29, 28, 85, 76, 187, 99, 171, 88, 48, 5, 104, 22, 64, 107, 164, 11, 172, 90, 41, 165, 143, 20, 114, 192, 105, 19, 33, 151, 6, 176, 140, 104, 23, 99, 48, 185, 49, 172, 65 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(1076, new[] { 146, 113, 147, 79, 170, 63, 120, 186, 90, 145, 66, 141, 46, 109 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(1871, new[] { 2, 124, 133, 73, 153, 88, 171, 164, 102, 104, 24, 128, 1, 170, 16, 166, 29, 144, 148 })));
            Assert.IsTrue(new[] { 2, 12 }.SequenceEqual(f.findLongestSubarrayBySum(944, new[] { 38, 10, 64, 50, 82, 189, 143, 9, 61, 22, 159, 155, 89, 147, 91, 150, 44, 31, 21, 149, 68, 137, 184, 36, 27, 186, 39, 54, 30, 25, 149, 124, 160, 58, 167, 145, 156, 119, 127, 12, 26, 156, 2, 150, 97, 185, 116, 165, 143, 76, 114, 143, 197, 149, 73, 27, 7, 174, 30, 5, 106, 27, 13, 176, 94, 166, 37, 137, 142, 15, 195, 57, 53, 137, 39, 83, 156, 16, 132, 31, 42, 26, 12, 38, 187, 91, 51, 63, 35 })));
            Assert.IsTrue(new[] { 14, 19 }.SequenceEqual(f.findLongestSubarrayBySum(354, new[] { 17, 53, 9, 63, 34, 55, 104, 35, 104, 57, 149, 125, 118, 14, 110, 29, 1, 81, 119, 59, 51, 156, 162, 65, 104, 77, 44, 110, 103, 162, 90, 149, 83, 54, 75, 21, 3, 124, 32, 170, 79, 60, 9, 20, 172, 4, 146, 182, 105, 193, 86, 114, 99, 190, 123, 139, 38, 11, 62, 35, 109, 162, 160, 94, 116, 70, 138, 70, 59, 101, 172, 65, 118, 16, 156, 16, 131, 40, 13, 89, 83, 155, 86, 111, 85, 175, 181, 16, 152, 142, 116, 80, 111, 99 })));
            Assert.IsTrue(new[] { 27, 34 }.SequenceEqual(f.findLongestSubarrayBySum(789, new[] { 178, 133, 157, 90, 114, 9, 142, 191, 124, 164, 29, 185, 179, 1, 72, 86, 175, 72, 134, 68, 154, 96, 169, 26, 77, 30, 51, 199, 110, 94, 87, 81, 117, 50, 68, 129, 80, 65, 22, 6, 27, 17, 117, 127, 67, 88, 82, 165, 141, 87, 22, 63, 122, 65, 110, 16, 103, 74, 125, 142, 146, 163, 24, 132, 7, 69, 119, 3, 108, 108, 82, 13, 137, 31 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(810, new[] { 85, 157, 91, 94, 197, 153, 55, 146, 109, 49, 92, 113, 132, 115, 40 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(723, new[] { 105, 196, 53, 70, 80, 39, 24, 119, 67, 60, 99, 87, 197, 63, 34, 159, 23, 147, 193, 38, 126, 48, 59, 3, 8, 99, 31, 93, 1, 79, 200, 153, 49, 83, 141, 116, 176, 163, 168, 137, 198, 19, 98, 29, 52, 17, 31, 50, 126, 59, 30, 121, 141, 161, 148, 163, 56, 76, 193 })));
            Assert.IsTrue(new[] { -1 }.SequenceEqual(f.findLongestSubarrayBySum(1755, new[] { 199, 147, 115, 147, 189, 170, 39, 64, 76, 116, 122, 76, 16, 129, 35, 171, 106, 65, 158, 163, 162, 125, 150, 70, 131, 124, 151, 134, 126, 111, 138, 137, 138, 79, 194, 37, 115, 165, 192, 150, 136, 106, 138, 5, 138, 24, 65, 171, 9, 169, 82, 86, 153, 174, 53, 195, 77, 27, 197, 173, 50, 41 })));
        }
    }
}