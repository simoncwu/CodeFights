﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.CSharp.UnitTest;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class MafiaChallengeTests
    {
        private int[][] ParseJaggedArray(string s)
        {
            return Util.ParseJaggedArray(s, int.Parse);
        }

        [TestMethod]
        public void MafiaTest()
        {
            var m = new MafiaChallenge();
            var suspects = ParseJaggedArray("[[10,11,12,13,14,15,16,17,18,19],[10,11,12,13,14,15,16,17,18,19],[10,11,12,13,14,15,16,17,18,19],[10,11,12,13,14,15,16,17,18,19],[10,11,12,13,14,15,16,17,18,19],[10,11,12,13,14,15,16,17,18,19],[10,11,12,13,14,15,16,17,18,19],[10,11,12,13,14,15,16,17,18,19],[10,11,12,13,14,15,16,17,18,19],[10,11,12,13,14,15,16,17,18,19],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9],[0,1,2,3,4,5,6,7,8,9]]");
            Assert.AreEqual("[0,1,2,3,4,5,6,7,8,9]", Util.ArrayToString(m.Mafia(suspects)));

            suspects = ParseJaggedArray("[[90,94,96,92,97,91,93,47,2,66],[92,90,96,94,93,95,97,71,76,30],[96,90,98,94,93,91,92,57,40,64],[95,98,90,96,94,93,97,10,54,33],[97,90,98,99,95,94,96,2,50,52],[98,93,94,91,96,90,97,37,81,56],[92,90,94,98,97,99,91,22,14,24],[91,90,95,92,96,98,94,33,53,34],[99,91,98,97,93,96,94,2,47,35],[96,95,99,94,98,92,93,54,5,82],[95,91,94,92,98,90,97,29,64,54],[95,94,99,96,91,98,92,63,27,54],[98,99,90,91,92,96,97,44,75,3],[91,90,93,95,92,94,97,74,61,88],[92,91,98,95,90,99,93,31,89,86],[98,99,92,97,91,93,95,75,29,72],[94,92,95,91,98,93,97,2,72,27],[91,92,93,94,98,95,99,84,49,71],[97,98,91,94,92,90,95,67,75,89],[96,94,99,91,97,93,92,80,3,61],[95,93,97,99,94,91,90,73,23,80],[99,90,98,95,91,92,93,22,4,6],[97,90,93,99,98,92,96,36,47,35],[96,97,94,93,98,90,99,0,34,41],[91,98,94,93,99,90,96,71,62,9],[98,96,91,90,99,92,97,65,63,70],[98,97,92,95,90,99,96,34,59,71],[92,99,94,90,93,96,97,21,13,28],[91,94,96,93,99,97,92,79,53,14],[92,93,97,91,95,99,96,46,85,53],[99,97,90,93,91,96,94,89,53,29],[93,92,95,90,94,91,97,66,64,70],[94,99,98,97,91,96,93,80,2,67],[91,92,93,90,96,95,97,29,18,66],[93,92,98,99,97,94,95,76,14,16],[91,97,98,96,99,92,94,22,8,37],[90,96,91,99,93,98,95,80,50,29],[95,93,90,91,98,99,96,72,64,1],[93,99,96,92,91,94,95,67,43,58],[99,91,90,92,96,94,97,40,21,60],[95,98,94,97,99,92,91,67,22,39],[96,98,97,99,95,93,90,14,54,13],[98,92,97,94,93,90,91,0,54,48],[96,99,95,92,90,94,91,49,27,62],[94,99,92,90,93,97,95,78,79,55],[91,92,96,94,93,98,97,62,2,42],[96,90,91,97,94,98,93,40,48,54],[94,93,92,99,90,91,95,49,62,48],[90,92,94,97,96,93,98,43,24,21],[94,91,93,99,96,98,90,40,0,42],[91,93,90,96,95,99,94,85,58,19],[91,92,96,93,90,98,94,58,60,78],[92,95,93,99,98,96,97,74,66,69],[94,91,92,90,93,98,96,73,89,43],[94,91,92,97,96,99,90,48,71,38],[99,94,93,97,92,95,98,35,89,80],[93,96,92,99,90,91,94,60,10,61],[96,91,99,95,98,94,92,34,87,56],[96,94,90,97,95,99,91,54,84,18],[92,97,94,93,91,99,95,37,18,89],[91,98,90,99,92,93,94,86,80,51],[93,90,95,97,91,96,94,50,0,43],[95,94,90,93,91,92,98,75,37,74],[96,90,95,99,97,91,93,48,5,74],[92,93,96,94,91,95,90,34,71,40],[97,94,99,92,96,93,95,2,49,66],[97,93,98,95,94,96,92,37,45,79],[96,98,99,93,91,94,92,54,78,48],[98,92,90,97,91,95,94,64,22,69],[97,94,90,92,96,95,93,55,68,89],[92,95,90,96,94,97,99,22,52,31],[98,97,93,95,90,94,92,69,50,13],[98,92,93,90,95,97,96,47,31,34],[97,95,91,92,99,93,90,76,22,5],[90,98,96,97,92,95,93,2,42,60],[92,97,96,99,91,98,94,62,40,84],[90,95,98,92,97,93,96,55,18,42],[90,95,92,93,99,97,98,35,81,48],[97,98,92,91,94,99,93,41,75,64],[97,94,95,93,91,98,99,51,30,22],[92,95,93,96,94,97,90,72,52,17],[92,94,93,95,98,97,91,68,6,24],[96,93,91,99,95,92,98,81,57,46],[95,90,92,93,94,91,98,31,66,55],[93,92,97,91,90,95,98,66,83,43],[98,96,97,90,91,93,95,34,22,7],[90,99,98,91,94,95,96,63,13,46],[92,98,99,90,91,94,93,42,20,10],[94,92,99,98,96,93,91,79,70,66],[95,98,93,94,96,92,99,36,82,27],[23,78,43,7,0,2,50,4,62,13],[26,32,16,15,41,89,66,80,9,53],[30,38,33,59,37,78,52,45,7,74],[68,47,57,63,62,33,39,40,43,86],[60,88,17,7,41,69,74,14,75,36],[85,62,61,69,76,3,16,84,20,25],[2,17,55,39,64,24,18,42,25,83],[8,23,64,63,81,47,52,73,15,2],[36,81,85,79,53,9,47,32,25,38],[79,22,20,71,24,40,54,56,30,27]]");
            Assert.AreEqual("[90,91,92,93,94,95,96,97,98,99]", Util.ArrayToString(m.Mafia(suspects)));

            suspects = ParseJaggedArray("[[49,82,74,71,69,68,39,11,13,7],[24,39,49,82,74,69,9,5,10,13],[24,9,39,71,3,82,49,4,1,5],[1,8,6,0,4,7,11,10,13,2],[49,74,68,69,3,82,71,0,2,1],[69,9,82,68,39,71,49,13,6,7],[3,24,49,82,69,71,9,5,12,10],[3,39,71,49,74,24,9,2,5,10],[9,24,3,82,74,71,49,13,5,10],[0,11,4,10,1,2,7,8,5,6],[39,9,71,3,24,49,69,8,6,4],[69,74,24,9,82,71,39,8,1,2],[9,82,71,69,68,49,74,2,5,10],[24,71,68,69,49,9,82,8,11,0],[82,49,39,3,24,74,9,1,7,10],[9,69,24,74,3,68,82,12,0,8],[3,71,49,68,39,24,74,11,1,4],[71,24,68,74,3,82,9,5,11,12],[24,9,68,82,49,74,39,2,5,0],[68,9,39,71,24,69,3,8,4,10],[74,24,68,3,69,39,71,11,12,7],[82,9,68,3,71,49,69,2,7,6],[9,82,68,24,74,49,71,1,5,2],[69,68,24,74,9,39,3,13,8,0],[4,8,2,7,0,12,1,5,6,10],[82,9,71,49,74,69,3,7,11,4],[68,82,71,74,69,39,24,2,12,4],[69,24,74,49,39,82,3,0,8,12],[68,49,71,3,74,82,39,7,13,8],[71,68,3,82,39,69,24,6,10,5],[9,49,82,3,68,74,71,8,6,1],[3,39,74,9,82,71,69,11,5,1],[3,68,24,69,39,49,82,4,1,7],[49,24,71,3,69,74,39,12,13,2],[39,69,74,24,71,68,3,6,8,2],[71,74,39,9,3,69,49,6,13,10],[82,3,49,24,71,69,68,1,10,11],[49,24,68,69,9,74,82,2,5,7],[68,39,3,9,82,49,74,7,4,10],[0,13,4,7,8,2,12,6,11,1],[3,39,82,24,69,9,49,6,5,8],[71,24,3,68,74,49,9,11,7,5],[82,68,3,39,69,74,49,11,4,6],[71,69,39,82,49,24,68,0,12,1],[82,74,49,3,24,68,9,10,8,6],[74,9,71,69,39,82,68,13,4,0],[68,69,71,9,24,3,39,13,5,12],[69,68,49,9,71,39,82,13,2,6],[69,24,9,39,3,49,71,6,5,8],[10,7,6,8,0,12,5,4,2,1],[74,39,9,24,71,68,69,4,11,5],[74,82,49,39,3,68,9,11,0,4],[3,9,49,82,68,74,71,0,8,5],[74,9,24,49,68,69,82,4,13,11],[68,71,9,82,39,3,24,0,12,10],[39,24,68,69,71,74,9,1,10,13],[71,49,3,74,68,69,9,8,2,11],[39,74,68,69,49,71,24,8,7,6],[3,71,69,39,49,9,24,6,5,1],[49,39,69,68,71,24,82,13,5,11],[71,24,74,68,3,39,9,1,13,7],[3,69,82,71,74,68,39,4,1,2],[74,49,82,3,9,71,24,12,8,13],[24,69,68,39,49,74,9,1,2,0],[24,39,68,3,9,69,49,13,12,5],[49,69,68,74,9,24,3,10,2,13],[49,82,9,74,68,3,69,8,1,0],[74,3,24,71,69,68,49,6,8,12],[10,4,8,11,7,13,0,1,2,12],[7,2,10,1,8,12,0,13,6,4],[71,74,69,3,9,39,49,11,5,7],[11,13,1,0,5,10,12,6,8,4],[71,24,3,39,74,69,49,1,5,0],[69,68,39,82,9,74,71,0,13,6],[6,7,4,11,13,2,8,10,5,1],[24,9,69,74,71,39,3,4,0,7],[82,39,69,3,74,49,71,12,13,6],[39,49,9,69,71,68,3,6,0,7],[71,24,82,49,39,68,74,10,13,0],[69,68,9,3,74,24,82,11,10,5],[71,74,82,68,49,24,69,5,0,10],[9,74,49,68,71,69,39,6,0,4],[7,4,11,5,0,1,8,12,6,13],[39,9,24,69,74,68,71,4,10,2],[9,82,69,3,24,68,74,12,4,8],[69,68,3,74,49,82,71,5,12,8],[71,24,68,3,74,69,49,5,0,6],[24,71,74,82,9,69,39,8,10,11],[9,71,3,82,74,68,39,7,10,11],[68,39,24,69,71,3,9,5,8,12],[49,68,9,24,74,3,69,7,6,12],[68,74,82,39,71,3,49,4,7,8],[69,68,82,74,49,3,9,12,5,8],[68,49,82,24,71,39,9,13,2,7],[71,9,82,74,3,39,24,6,1,12],[9,71,69,82,68,74,49,12,0,6],[3,69,9,39,49,24,74,2,6,13],[71,9,24,82,68,3,74,7,6,10],[71,49,39,74,3,69,82,2,12,11],[69,74,3,71,49,24,39,2,8,6]]");
            Assert.AreEqual("[3,9,24,39,49,68,69,71,74,82]", Util.ArrayToString(m.Mafia(suspects)));

            suspects = ParseJaggedArray("[[1,54,71,9,4,3,8,29,32,47],[9,32,0,2,71,8,4,54,47,3],[3,13,11,1,12,10,6,4,5,0],[71,9,4,0,47,29,2,32,1,54],[29,3,1,71,54,0,2,9,8,32],[32,29,9,0,54,71,8,3,2,4],[0,9,47,71,29,4,3,54,32,8],[54,0,2,3,32,47,9,29,1,71],[0,12,7,5,1,13,3,10,11,4],[1,11,7,0,13,6,12,3,4,5],[1,8,29,3,32,71,47,54,9,4],[32,47,4,2,71,0,29,54,3,9],[29,4,0,32,1,54,9,47,8,71],[32,54,9,1,4,29,2,71,0,47],[47,9,32,54,29,2,4,8,1,3],[29,47,3,71,54,4,1,2,8,32],[9,29,32,8,54,1,47,4,0,2],[4,54,32,47,1,71,8,2,0,9],[2,4,9,32,3,71,29,0,54,8],[2,54,3,29,9,0,32,71,8,4],[0,3,47,4,71,2,54,8,9,32],[0,4,71,29,47,9,2,1,54,32],[2,54,1,8,0,71,3,47,32,9],[71,29,0,2,47,4,8,1,54,9],[32,0,2,4,71,9,3,8,47,29],[29,1,0,2,71,4,54,9,32,47],[32,9,1,0,2,29,71,8,47,4],[8,0,71,32,3,54,47,29,9,4],[71,54,0,2,29,32,1,9,3,47],[10,6,7,3,13,12,0,5,1,11],[2,71,4,29,54,1,9,8,0,32],[47,2,32,29,71,54,0,9,3,4],[13,0,7,1,11,5,3,6,12,4],[9,0,47,71,29,2,4,32,8,3],[47,29,4,32,71,9,8,2,0,1],[8,9,71,4,29,0,2,47,54,1],[2,8,29,47,4,54,1,0,9,32],[32,3,29,47,9,0,71,54,1,2],[54,4,8,29,1,71,2,3,47,32],[9,32,54,2,47,3,1,0,8,71],[8,3,71,0,4,29,2,54,47,32],[54,2,32,3,9,0,71,47,1,8],[71,0,2,1,29,9,4,54,8,47],[9,29,2,71,4,3,32,47,1,54],[4,71,54,32,3,47,9,8,0,2],[54,71,3,2,4,9,0,47,32,29],[2,71,1,8,0,4,29,32,9,47],[7,13,11,6,3,12,0,4,1,5],[32,3,0,29,8,9,2,1,47,54],[47,71,29,9,32,4,1,54,3,8],[4,0,2,32,47,1,9,8,29,54],[4,2,54,71,32,1,29,0,47,8],[71,54,8,0,47,4,2,29,9,1],[71,3,54,29,1,32,8,47,4,2],[11,12,3,6,5,13,0,7,4,10],[54,0,1,47,4,32,8,9,2,29],[71,4,47,1,2,0,29,9,32,54],[9,54,2,29,32,8,1,71,0,4],[2,3,29,9,71,47,0,32,54,4],[32,54,8,47,4,1,2,9,71,0],[47,8,29,4,2,9,71,0,32,1],[2,3,9,8,4,32,47,29,0,71],[0,2,54,47,8,4,71,9,1,29],[1,3,54,4,29,9,32,47,71,2],[0,8,32,9,71,3,54,2,29,1],[8,32,47,2,4,1,0,54,29,9],[47,4,32,2,54,3,1,29,8,71],[4,29,8,0,54,9,2,3,71,47],[32,4,54,1,29,2,9,0,47,71],[4,54,9,29,3,71,47,8,1,2],[9,1,0,8,71,54,3,47,29,32],[4,11,1,0,6,12,7,10,13,3],[4,71,8,1,32,2,29,54,9,0],[8,0,4,32,3,9,29,71,2,54],[71,8,3,9,32,0,54,1,2,29],[12,7,10,3,11,4,0,6,5,1],[9,47,32,0,54,8,2,29,3,4],[9,4,71,2,47,1,29,8,0,54],[8,32,9,1,71,2,29,4,54,0],[1,71,29,47,0,32,9,3,2,54],[29,3,2,47,9,4,71,32,1,54],[71,32,0,2,3,8,29,47,4,54],[8,32,4,9,2,71,29,0,47,3],[3,54,32,47,0,8,2,71,29,4],[0,2,9,1,32,29,8,54,3,47],[29,32,2,9,8,0,1,54,47,3],[1,9,29,0,4,8,2,32,71,54],[9,29,1,54,2,8,3,0,47,71],[54,29,3,0,1,8,47,9,32,71],[71,32,1,4,9,29,3,2,54,47],[8,71,9,0,47,2,29,1,32,3],[2,8,1,71,29,9,32,54,4,3],[7,5,0,6,11,4,1,13,3,10],[71,8,2,3,4,29,0,54,9,32],[29,3,32,1,47,9,2,54,4,8],[32,2,71,8,29,1,0,9,3,54],[1,71,29,54,2,32,4,8,3,47],[2,47,1,9,0,71,29,8,4,32],[8,71,9,47,32,0,29,2,3,4],[2,32,9,71,54,47,3,0,29,1]]");
            Assert.AreEqual("[2,8,9,29,32,47,54,71,75,92]", Util.ArrayToString(m.Mafia(suspects)));

            suspects = ParseJaggedArray("[[11,33,14,90,1,61,15,17,3,29],[3,17,61,11,29,97,33,90,14,15],[15,14,3,17,11,97,61,33,29,90],[97,18,55,71,66,61,57,1,6,78],[3,33,15,1,14,11,17,90,29,97],[11,3,90,17,33,61,14,1,15,29],[97,90,29,14,17,3,33,15,1,61],[33,90,11,3,14,17,29,15,97,61],[33,1,11,17,3,29,90,14,61,15],[14,15,33,1,11,90,61,17,3,29],[15,90,11,29,17,14,97,3,1,33],[17,1,61,14,3,33,90,97,29,15],[61,17,14,3,29,15,90,33,97,1],[1,29,14,3,17,15,97,11,33,90],[66,18,25,30,55,78,11,71,57,1],[61,78,11,55,1,97,99,18,71,83],[29,17,61,14,33,1,97,15,3,90],[6,55,18,11,99,57,71,1,30,97],[33,17,90,15,3,14,11,29,97,61],[17,15,11,97,90,14,61,29,33,3],[61,15,97,14,17,33,90,3,1,29],[17,61,33,3,1,15,14,97,90,29],[17,14,3,15,90,29,97,33,11,1],[18,61,25,1,97,99,11,66,83,71],[15,97,14,17,3,61,90,29,1,33],[97,1,29,15,3,17,11,33,90,14],[15,33,1,11,29,17,3,61,90,14],[3,15,17,29,61,11,14,33,90,1],[90,97,1,29,3,11,33,15,17,14],[66,6,11,25,57,1,71,97,61,83],[3,33,17,15,11,90,61,14,29,97],[29,11,17,15,97,3,61,90,14,33],[61,17,1,14,11,29,15,90,33,3],[25,30,18,57,1,78,83,61,55,71],[11,15,97,61,14,90,29,17,33,3],[17,61,29,33,15,1,14,11,3,90],[17,61,90,97,33,11,29,14,3,15],[33,29,61,3,90,14,17,97,11,15],[15,61,90,29,33,3,11,1,14,17],[90,29,1,33,17,3,97,61,14,15],[29,14,15,97,61,3,33,11,90,17],[97,33,1,15,29,14,90,3,17,61],[29,90,3,97,15,61,11,33,14,17],[97,29,1,15,3,14,33,17,61,90],[15,29,1,3,17,33,90,14,11,97],[17,29,33,14,15,97,3,90,11,61],[61,15,90,97,3,14,1,17,29,33],[97,15,33,90,61,1,17,3,29,14],[14,15,90,3,61,29,11,33,17,97],[90,1,17,97,61,29,14,15,33,3],[3,1,90,14,17,29,15,97,33,11],[11,1,33,61,3,14,15,17,90,29],[14,3,15,29,61,17,1,33,90,97],[90,97,3,17,61,15,14,11,33,29],[1,61,33,90,15,97,29,17,14,3],[90,3,97,29,33,15,14,1,17,11],[61,11,90,14,97,15,33,3,29,17],[14,90,33,17,97,29,3,11,15,1],[17,11,3,61,97,33,29,90,14,15],[3,17,14,97,1,33,90,61,29,15],[90,17,33,1,14,3,15,97,61,29],[97,14,15,3,11,1,33,29,90,17],[1,3,90,17,14,11,15,33,29,97],[17,11,90,97,14,33,29,3,15,1],[55,99,18,83,30,57,71,1,6,66],[14,97,1,11,29,3,33,17,15,90],[97,3,33,17,15,90,29,61,14,11],[17,90,29,3,97,15,14,1,61,33],[14,17,3,97,29,33,90,61,15,1],[55,30,61,83,99,57,18,1,78,71],[3,11,29,15,17,1,90,14,33,61],[29,15,14,17,1,90,3,33,61,97],[29,33,15,90,1,17,3,61,14,97],[15,90,33,3,14,1,97,61,17,29],[15,14,90,11,17,97,1,3,29,33],[33,61,1,90,17,11,29,14,3,15],[3,29,11,17,61,15,14,33,90,1],[14,90,17,97,15,3,29,11,33,61],[14,15,3,29,97,33,11,1,90,17],[3,11,33,15,61,17,14,90,1,29],[29,97,14,11,15,90,61,33,17,3],[29,1,3,90,15,33,14,17,97,61],[14,1,97,3,90,15,33,11,17,29],[14,61,29,17,97,15,90,11,3,33],[17,29,33,15,90,14,1,11,3,61],[97,15,1,61,3,90,14,17,29,33],[17,61,3,14,15,90,11,97,33,29],[17,14,3,11,29,61,97,33,90,15],[3,97,14,33,29,15,17,1,11,90],[11,17,29,90,1,61,14,33,3,15],[25,1,61,6,66,78,55,30,57,99],[90,33,15,14,29,17,3,61,97,11],[3,29,1,61,17,97,90,33,14,15],[33,14,29,61,90,11,1,3,15,17],[3,17,61,15,1,33,14,90,11,29],[1,17,15,97,90,3,33,61,29,14],[61,14,3,33,15,29,11,17,97,90],[14,3,11,17,15,33,29,1,61,90],[14,15,3,33,17,11,90,97,1,29],[14,3,11,61,1,17,15,29,33,90]]");
            Assert.AreEqual("[3,14,15,17,23,29,33,64,69,90]", Util.ArrayToString(m.Mafia(suspects)));

            suspects = ParseJaggedArray("[[65,36,11,51,34,39,13,66,45,26],[26,34,65,45,43,11,69,39,36,20],[66,46,36,65,43,13,51,11,20,45],[20,46,69,36,26,34,66,43,11,13],[43,66,26,46,65,39,36,20,13,69],[45,11,46,20,43,34,13,26,65,66],[26,43,45,39,36,69,46,65,51,11],[69,34,13,20,36,66,43,45,46,65],[46,36,34,66,65,43,51,11,13,45],[26,65,43,39,13,34,66,20,11,45],[66,36,43,65,45,34,46,13,39,11],[13,65,20,45,69,66,34,36,51,26],[20,34,26,36,11,69,65,43,45,66],[51,34,46,66,20,45,43,11,65,69],[43,13,20,36,69,51,65,26,45,34],[26,34,51,20,11,39,69,36,43,65],[39,65,34,46,43,11,69,66,26,45],[66,51,46,13,69,39,11,26,36,20],[65,34,46,36,51,39,13,11,20,66],[11,36,69,46,43,39,20,66,34,65],[86,42,94,65,69,41,11,75,55,57],[34,51,65,43,13,66,36,69,46,26],[36,20,46,43,26,13,66,34,65,69],[66,13,39,36,65,34,43,51,11,45],[65,34,26,36,20,51,69,39,66,11],[66,69,26,65,45,51,13,43,39,20],[40,88,65,11,59,86,69,42,79,75],[69,46,26,20,11,66,45,13,39,36],[66,26,46,11,65,36,34,69,20,43],[45,66,65,34,39,26,51,69,11,46],[26,46,20,45,36,39,13,69,43,65],[11,46,65,43,20,36,66,39,13,34],[11,45,69,46,20,39,43,13,26,66],[43,39,11,45,13,65,51,26,20,66],[13,57,41,59,65,11,79,42,40,88],[39,20,66,34,46,36,13,51,11,65],[75,65,88,79,59,13,69,40,57,41],[34,43,65,39,11,69,20,51,26,66],[45,20,36,39,65,46,13,11,66,51],[57,65,40,42,11,13,79,41,94,59],[34,20,13,69,66,36,26,51,46,65],[20,45,46,43,66,65,39,11,51,69],[39,20,46,36,11,51,66,34,65,69],[42,57,55,79,86,11,88,59,65,69],[65,36,34,11,43,26,69,51,20,46],[57,79,86,94,42,55,75,88,40,69],[41,65,40,11,75,69,88,79,57,94],[51,11,20,39,26,69,36,13,43,46],[36,65,51,34,69,66,45,13,46,26],[69,26,43,46,20,34,51,11,65,66],[39,26,43,13,34,66,11,69,36,20],[75,13,57,79,94,59,65,42,55,41],[20,34,66,39,45,11,36,13,46,65],[51,20,46,43,36,34,65,26,69,11],[39,66,65,20,34,11,45,46,43,13],[69,20,34,26,13,36,43,39,46,11],[45,39,13,51,20,34,36,46,69,65],[51,36,65,45,69,66,34,39,43,13],[69,66,34,36,11,20,65,46,43,51],[36,65,39,11,13,66,43,20,26,46],[26,11,51,36,46,45,65,66,20,13],[65,39,11,34,13,46,26,51,66,36],[20,39,43,13,69,46,45,36,11,26],[43,45,66,46,11,13,36,69,51,34],[11,46,13,26,34,69,45,20,66,36],[69,46,43,51,66,36,34,39,13,11],[69,79,59,57,86,42,94,55,11,75],[39,20,36,13,34,51,43,11,26,65],[20,45,13,46,65,26,43,39,34,11],[66,39,43,36,65,26,13,51,11,45],[69,51,11,46,43,65,20,39,45,34],[65,39,46,20,36,69,34,43,11,45],[69,45,34,43,13,36,66,46,11,39],[65,69,66,36,20,43,45,26,11,46],[39,11,46,36,51,45,43,69,65,26],[69,39,46,20,11,51,45,13,66,34],[11,20,51,46,69,65,66,43,34,39],[43,11,36,39,13,66,26,46,20,65],[45,43,11,26,69,39,66,46,13,34],[36,65,51,13,43,11,39,34,26,45],[51,36,69,46,11,34,43,26,20,13],[34,20,39,65,11,36,13,51,45,66],[45,11,36,26,46,65,39,34,51,13],[34,11,43,65,69,51,36,26,45,20],[11,26,66,36,65,39,46,20,13,43],[66,39,69,45,65,51,34,43,46,11],[20,65,46,66,69,13,26,45,43,39],[34,46,69,11,65,26,20,51,43,36],[26,43,39,69,51,46,13,11,20,66],[43,45,39,13,51,20,11,34,26,65],[65,13,66,26,11,36,34,39,20,46],[46,11,39,13,45,51,20,34,43,65],[11,43,46,66,20,69,65,39,34,45],[11,34,26,65,66,43,20,36,13,46],[39,66,43,11,20,36,65,26,51,69],[39,13,45,34,69,66,26,51,43,65],[65,26,13,36,20,66,45,69,34,43],[34,65,26,46,69,66,20,45,11,43],[36,46,51,13,43,20,39,65,11,66],[26,43,13,65,11,39,66,51,46,34]]");
            Assert.AreEqual("[20,26,34,36,39,43,45,46,51,66]", Util.ArrayToString(m.Mafia(suspects)));

            suspects = ParseJaggedArray("[[56,57,2,65,71,77,24,29,4,84],[65,18,56,67,24,29,0,57,2,13],[13,4,28,81,0,39,73,77,18,84],[19,65,88,67,13,71,56,29,2,57],[56,77,84,29,24,14,57,18,2,65],[4,67,57,14,77,24,29,56,65,0],[65,18,39,77,56,14,29,24,71,2],[65,67,56,29,13,14,81,2,57,4],[29,57,71,73,18,65,2,56,24,84],[13,24,56,88,57,4,67,14,29,2],[2,71,19,28,67,56,14,29,77,65],[24,29,0,65,18,71,57,19,67,2],[71,2,88,57,14,65,24,19,28,67],[19,71,29,28,2,65,67,14,39,57],[39,28,81,4,88,84,13,19,77,18],[29,57,18,71,56,4,24,67,65,0],[56,67,29,39,65,18,57,14,71,13],[71,14,65,88,81,39,56,2,24,29],[2,29,71,84,24,65,14,73,57,4],[2,28,56,84,24,81,57,67,65,14],[24,29,14,56,2,4,57,73,71,77],[14,67,56,4,18,73,2,71,24,57],[2,65,19,0,18,24,56,29,67,71],[19,65,56,2,81,29,57,13,14,67],[28,13,84,88,18,39,4,77,73,0],[0,73,67,65,29,57,14,71,39,24],[2,71,67,18,0,24,73,29,14,56],[81,29,88,71,28,2,14,56,57,65],[57,2,14,39,65,24,84,67,29,18],[4,84,88,13,81,0,18,28,77,19],[13,81,67,24,4,71,56,65,14,57],[19,4,67,71,24,29,18,65,14,2],[84,14,28,88,29,24,65,2,71,56],[2,0,57,71,24,56,18,29,65,73],[71,67,0,56,57,24,18,29,73,65],[24,56,71,14,67,4,39,77,57,29],[29,77,39,2,57,0,71,65,67,14],[88,77,0,39,13,19,4,18,81,73],[57,39,28,2,56,65,29,18,24,67],[67,0,71,13,2,14,24,56,19,65],[56,24,29,84,71,4,2,77,67,65],[57,56,77,71,14,18,29,88,65,24],[24,65,29,56,81,14,71,77,13,2],[18,88,57,56,67,29,2,24,13,14],[57,71,19,88,81,56,29,24,65,67],[14,56,57,29,67,4,88,28,65,71],[84,56,29,14,2,24,77,65,13,57],[71,57,24,88,2,67,13,56,73,65],[18,67,73,29,24,56,14,65,28,71],[81,56,29,65,18,57,71,24,14,88],[2,67,14,84,65,71,13,57,19,29],[67,56,84,24,13,2,28,65,71,29],[67,0,57,56,29,18,71,14,81,2],[56,57,2,4,29,0,71,84,24,14],[0,56,71,57,29,18,81,2,67,14],[71,29,14,57,24,88,56,65,4,39],[19,18,84,88,4,81,39,0,73,28],[39,4,81,19,88,28,18,84,73,77],[29,0,65,57,14,67,18,2,24,77],[14,67,2,57,24,84,81,56,65,28],[77,2,57,88,71,14,56,67,28,65],[57,2,71,13,67,65,73,24,19,56],[14,67,57,2,18,84,29,71,65,73],[67,19,4,29,71,24,65,2,57,88],[73,67,71,14,0,2,13,57,56,65],[0,18,77,81,73,88,19,4,28,39],[13,67,4,24,56,14,2,29,28,57],[73,81,18,28,4,39,84,77,19,88],[28,24,88,29,56,2,65,57,71,18],[88,14,67,81,39,65,57,2,71,24],[19,29,57,13,67,2,71,65,24,88],[39,28,18,19,84,81,77,0,4,73],[65,0,14,2,67,18,71,73,57,56],[2,57,18,67,14,65,71,29,0,84],[77,65,88,24,56,14,2,67,71,19],[67,2,77,39,14,56,29,57,24,84],[71,2,73,65,67,57,56,39,18,24],[57,29,19,2,56,67,81,65,13,24],[67,57,29,2,13,24,28,56,71,18],[2,81,65,56,13,14,19,67,24,29],[19,57,56,0,2,24,67,29,77,14],[88,2,71,67,29,14,19,65,77,56],[14,2,67,0,29,77,18,71,65,24],[56,24,29,84,4,65,0,2,57,14],[56,2,14,77,29,57,81,4,24,71],[24,29,19,57,2,88,56,81,67,71],[56,67,28,2,29,57,71,0,77,24],[77,14,4,67,84,65,29,56,57,2],[65,67,73,2,39,57,71,18,29,24],[56,67,18,14,29,28,65,77,2,57],[14,24,56,65,2,39,84,71,0,57],[24,65,14,13,19,29,67,71,2,88],[67,4,2,14,39,57,56,24,71,0],[0,81,29,2,67,65,56,24,18,14],[56,84,4,2,29,57,24,67,65,0],[84,14,65,29,77,67,88,2,57,56],[29,24,14,2,39,56,13,67,57,88],[14,29,73,84,71,57,24,67,56,88],[65,2,81,14,73,29,18,71,56,67],[57,0,24,14,56,71,2,29,84,18]]");
            Assert.AreEqual("[2,14,24,29,37,56,57,65,67,71]", Util.ArrayToString(m.Mafia(suspects)));

            suspects = ParseJaggedArray("[[39,86,89,77,84,74,91,16,47,32],[74,16,49,24,91,47,79,23,89,78],[86,24,74,47,39,77,16,84,49,89],[89,74,24,16,7,35,79,23,84,39],[39,23,74,86,79,47,91,89,32,84],[91,16,74,79,89,84,47,66,49,23],[39,16,47,23,77,24,89,84,49,78],[39,23,47,84,89,35,16,86,91,66],[49,81,24,23,91,89,47,84,16,35],[24,47,77,32,89,23,91,39,16,49],[57,87,84,16,89,24,91,66,74,39],[39,81,89,47,91,23,74,7,66,16],[35,89,16,24,84,91,7,78,39,23],[57,89,24,84,79,39,32,74,23,47],[35,84,23,39,24,16,78,81,47,89],[24,74,16,39,84,35,89,7,23,87],[81,35,79,86,77,57,69,46,32,66],[16,39,35,47,84,32,57,24,23,89],[39,86,79,89,91,16,74,77,23,24],[32,16,74,23,81,39,24,79,89,84],[47,24,86,91,79,89,84,16,57,74],[81,91,32,16,24,23,47,84,7,74],[39,78,16,89,79,24,47,74,23,87],[87,26,69,94,66,7,86,79,46,77],[35,12,69,57,78,49,94,7,86,66],[79,84,47,16,23,24,91,39,66,7],[7,89,16,84,24,86,35,91,47,23],[81,39,91,77,74,84,78,47,89,16],[77,84,23,47,74,35,91,89,39,86],[84,16,35,47,23,77,24,78,74,39],[7,39,79,91,24,16,23,74,35,47],[87,89,16,86,47,84,74,39,35,91],[23,39,78,91,7,16,35,84,47,74],[91,32,81,39,84,78,89,74,16,23],[84,79,24,86,74,66,39,16,47,89],[74,89,39,91,79,66,47,77,16,23],[89,24,47,7,84,74,66,78,16,39],[16,91,23,74,89,47,78,84,79,35],[66,81,74,91,23,24,39,89,16,32],[49,57,77,66,46,86,26,78,79,87],[12,49,94,77,87,66,26,78,81,57],[23,74,81,84,79,24,89,16,91,57],[84,81,74,35,91,47,23,89,77,39],[86,35,74,39,16,84,91,66,89,24],[24,74,35,89,16,23,79,86,91,84],[24,23,84,74,89,47,78,91,7,77],[32,84,23,39,91,74,16,47,86,35],[94,32,86,57,49,66,77,46,12,87],[24,89,16,35,47,32,74,7,84,23],[57,23,89,47,78,91,77,84,74,16],[57,91,35,16,23,84,47,7,74,39],[24,7,49,91,89,32,23,47,16,84],[57,86,39,16,23,84,24,91,47,77],[47,39,49,7,86,91,74,16,24,89],[81,78,57,74,47,39,89,16,91,24],[49,78,16,74,39,87,84,47,89,91],[86,23,91,74,47,16,57,84,77,89],[16,23,24,87,84,39,91,74,86,35],[74,32,91,47,84,24,77,16,78,23],[23,47,39,89,16,77,84,91,79,49],[84,16,74,47,79,23,39,66,89,86],[89,74,57,84,79,16,24,91,23,66],[23,24,57,7,89,84,66,47,74,39],[86,84,57,16,74,89,39,49,91,23],[79,84,47,91,32,89,16,74,23,57],[89,74,47,32,23,87,77,16,39,24],[24,81,84,91,87,89,16,23,39,57],[16,84,81,89,74,23,66,49,39,91],[86,23,66,16,47,84,89,79,39,91],[77,91,89,79,16,24,84,47,86,23],[16,23,39,24,57,32,47,91,89,7],[39,89,86,91,87,32,16,47,74,24],[23,39,84,79,7,47,35,16,24,74],[16,86,23,39,89,49,74,47,66,91],[57,81,32,94,77,78,26,46,49,66],[91,84,24,16,86,49,35,47,23,39],[39,91,24,47,74,16,79,66,78,84],[89,23,74,91,16,84,81,35,39,79],[16,84,23,47,35,74,86,91,57,24],[16,32,84,47,39,91,81,24,89,77],[39,24,91,7,86,89,23,84,16,66],[24,47,78,23,79,49,89,74,84,91],[7,39,23,91,79,16,84,47,24,49],[66,91,24,84,16,74,86,77,39,23],[57,7,49,69,66,79,81,94,77,86],[89,84,47,87,7,91,39,32,74,16],[74,91,24,49,79,7,89,84,16,39],[79,74,32,91,16,84,89,47,23,78],[89,23,74,49,78,66,16,47,39,84],[86,69,57,35,46,78,79,49,77,94],[16,86,47,84,89,39,23,7,49,74],[79,46,86,77,87,57,78,32,26,81],[91,84,74,24,89,79,49,23,39,57],[87,16,23,32,74,24,89,57,84,91],[74,23,39,79,47,84,89,16,7,77],[89,32,91,74,23,24,84,78,47,87],[39,91,16,47,49,89,78,77,23,84],[87,91,77,23,24,39,74,47,16,57],[84,7,77,16,24,89,23,78,47,91],[89,79,57,23,16,39,91,47,49,74]]");
            Assert.AreEqual("[16,23,24,39,40,47,74,84,89,91]", Util.ArrayToString(m.Mafia(suspects)));

            suspects = ParseJaggedArray("[[78,52,65,68,72,19,21,40,95,51],[40,8,97,78,21,52,51,28,65,95],[65,40,52,51,78,46,26,95,92,69],[32,21,50,52,51,95,78,65,68,40],[51,78,52,97,95,92,38,68,65,40],[78,52,48,40,21,92,94,4,65,95],[95,65,3,40,94,52,30,92,21,51],[65,74,21,51,95,52,46,78,94,92],[78,95,21,46,72,65,28,92,52,51],[21,78,92,52,51,50,95,56,41,40],[40,19,78,21,92,51,8,52,97,65],[40,92,69,52,28,51,95,32,65,21],[51,38,40,30,92,21,78,65,95,19],[95,28,47,78,40,92,51,52,94,21],[40,92,19,51,95,21,41,68,65,78],[24,16,60,25,99,18,75,13,44,14],[92,95,78,4,21,3,40,52,51,8],[92,40,72,21,52,48,65,38,95,78],[40,64,92,78,52,65,48,29,51,21],[52,47,95,38,92,21,78,65,28,51],[3,40,97,21,92,78,32,51,52,65],[30,72,74,32,46,50,47,76,68,19],[50,40,64,95,78,52,65,92,51,74],[78,65,52,47,38,51,40,48,95,21],[51,52,65,92,3,40,78,64,85,21],[21,95,52,69,78,47,26,92,40,51],[65,92,52,95,51,40,47,78,97,69],[51,52,85,47,92,78,65,48,95,40],[78,48,51,72,46,40,92,95,52,21],[51,52,32,92,40,21,65,50,46,95],[72,78,21,32,28,40,51,65,95,52],[95,40,78,51,3,72,92,21,52,68],[40,65,78,76,52,51,95,21,56,38],[40,65,21,4,48,29,51,92,78,52],[40,85,21,52,29,95,65,64,51,92],[51,64,78,65,40,52,94,21,95,38],[92,76,65,40,78,52,95,19,51,74],[65,52,78,50,40,21,95,51,28,94],[95,40,92,21,32,52,3,46,65,51],[52,95,65,40,41,8,78,47,21,92],[75,83,20,60,12,86,25,55,87,45],[95,78,40,51,52,65,56,3,50,21],[78,64,95,21,47,46,65,52,40,51],[29,72,32,47,30,68,74,46,50,19],[78,72,94,95,65,40,52,30,21,51],[94,78,46,95,21,92,65,51,64,40],[26,21,40,92,64,65,78,51,95,30],[97,40,41,95,78,52,92,21,74,51],[30,78,51,65,92,21,4,95,69,40],[48,40,21,74,92,51,78,65,52,56],[74,65,95,78,21,19,52,51,92,64],[73,9,48,35,10,87,36,84,96,17],[38,85,8,41,26,3,97,4,94,56],[92,78,65,46,51,21,97,95,26,40],[52,46,4,92,78,95,19,21,51,40],[65,95,47,21,78,69,40,46,51,92],[92,95,69,29,21,51,41,40,52,78],[95,76,52,65,19,78,29,21,40,51],[51,92,3,30,94,21,65,52,95,40],[51,94,92,32,40,65,52,95,74,21],[40,32,65,28,78,21,74,51,52,95],[47,21,72,52,95,4,65,40,51,92],[46,78,76,65,8,40,52,21,95,51],[52,95,92,78,21,47,40,65,48,68],[78,48,85,95,52,76,92,51,21,40],[85,26,97,38,56,94,8,41,3,4],[21,40,28,92,19,94,78,65,52,51],[85,65,51,28,95,40,92,52,21,32],[95,51,92,65,72,50,40,21,52,56],[8,92,74,52,3,51,65,21,40,78],[51,52,40,92,21,68,46,78,95,97],[65,78,30,21,51,52,46,28,95,92],[92,85,95,30,78,48,40,51,65,21],[52,64,95,78,4,51,92,21,65,19],[51,92,32,50,95,65,78,3,21,40],[56,92,95,21,40,52,68,65,51,46],[65,21,72,52,40,92,97,26,51,95],[94,8,51,65,92,21,78,52,40,30],[46,47,32,50,30,76,19,72,74,68],[68,78,52,92,64,65,51,40,21,48],[30,21,40,68,52,95,92,65,78,3],[51,40,8,95,65,69,48,52,21,78],[52,78,56,65,48,21,32,51,95,92],[92,21,40,52,56,51,69,8,65,78],[21,52,65,40,46,41,78,95,92,68],[51,78,92,56,74,21,95,3,65,40],[52,95,92,40,78,65,19,51,85,97],[92,51,40,29,19,28,21,78,52,95],[8,92,52,21,78,51,29,95,40,28],[52,92,95,21,46,28,40,78,65,4],[26,40,65,52,41,51,78,92,21,28],[72,76,78,95,40,65,52,97,21,92],[94,4,41,8,97,26,56,85,64,3],[92,40,74,28,95,78,65,51,21,29],[21,52,40,29,65,51,92,19,78,85],[3,41,8,85,38,4,26,94,97,64],[92,47,51,78,95,52,74,28,65,40],[40,47,78,51,19,65,52,21,95,41],[21,56,95,32,76,52,78,51,40,92],[19,65,92,51,97,85,21,40,52,95]]");
            Assert.AreEqual("[15,21,40,43,51,52,65,78,92,95]", Util.ArrayToString(m.Mafia(suspects)));

            suspects = ParseJaggedArray("[[90,3,18,47,66,81,39,93,62,79],[47,39,93,58,62,56,80,29,3,79],[6,39,3,29,18,79,47,62,56,54],[78,82,60,22,85,48,1,33,6,67],[79,66,62,90,3,18,81,39,47,93],[79,18,3,48,62,80,47,93,39,15],[93,83,71,3,47,16,62,29,39,79],[18,62,93,16,3,39,47,97,71,79],[39,47,93,55,54,3,15,62,29,79],[82,60,91,47,29,39,93,18,79,62],[42,82,78,48,33,66,22,57,85,60],[18,79,97,29,62,48,47,3,93,64],[39,42,29,93,48,80,47,3,18,79],[47,93,79,66,29,62,83,78,18,3],[39,35,93,29,18,6,3,47,79,57],[3,48,39,47,62,67,79,93,33,18],[29,18,3,39,54,99,47,93,71,79],[29,39,47,79,18,93,57,15,3,14],[22,4,55,99,54,58,82,56,85,15],[0,71,93,3,79,18,62,63,39,47],[93,62,39,47,18,3,90,29,74,56],[66,39,47,56,29,93,64,62,18,3],[39,47,18,79,0,62,29,54,78,3],[62,3,18,79,39,47,55,93,33,97],[29,79,58,33,39,18,93,47,42,62],[74,67,57,62,39,29,79,18,93,47],[3,29,79,16,81,39,91,93,47,18],[79,29,39,3,90,47,22,62,18,64],[29,35,93,79,39,3,64,47,85,62],[99,85,80,54,55,4,81,97,56,82],[58,93,79,47,39,78,3,62,18,33],[3,29,83,93,6,47,78,39,62,79],[18,90,47,29,3,83,39,93,82,79],[79,29,3,90,82,93,62,58,39,47],[39,54,3,18,57,62,78,29,47,93],[79,3,81,29,18,47,93,57,58,39],[29,62,3,39,79,80,47,93,40,78],[35,62,47,48,39,3,79,29,82,18],[3,39,6,18,47,93,29,60,79,0],[99,63,58,4,55,82,54,85,22,56],[18,47,0,56,93,39,29,62,58,3],[97,62,0,18,83,47,39,29,79,93],[79,93,39,63,47,0,3,62,90,29],[55,74,83,91,14,80,64,90,0,58],[29,47,48,3,1,64,93,62,18,79],[47,18,93,40,62,79,33,97,39,29],[15,62,29,93,79,47,85,18,3,71],[80,0,64,16,74,58,14,83,55,35],[79,29,47,99,3,39,4,35,93,62],[39,56,67,93,62,79,29,18,3,66],[62,47,3,71,82,39,93,79,29,78],[29,60,79,39,3,18,58,74,62,47],[29,47,62,3,42,80,39,79,18,74],[4,47,39,71,79,18,3,93,62,22],[58,18,3,66,47,39,79,62,64,93],[93,3,39,62,18,29,33,15,80,79],[62,22,29,39,79,3,83,1,47,18],[79,56,93,29,64,18,47,3,99,62],[82,18,93,3,62,29,42,39,79,6],[83,6,39,47,29,93,79,71,18,62],[90,62,29,0,47,93,18,79,3,64],[29,18,93,33,54,60,79,62,39,47],[15,54,97,85,56,58,22,63,81,14],[79,58,39,29,54,47,93,3,71,62],[18,79,3,62,58,39,93,85,33,47],[47,60,29,93,3,62,18,56,79,22],[80,47,39,29,16,58,18,93,79,62],[18,79,3,60,62,78,39,4,93,29],[93,6,80,18,39,29,40,62,79,47],[62,47,81,39,82,3,18,63,29,79],[93,29,67,62,14,3,66,47,39,79],[29,99,62,90,85,18,3,47,79,93],[93,29,67,62,79,47,3,81,39,64],[58,47,62,29,93,33,79,3,18,55],[55,93,18,99,79,62,3,83,29,47],[79,29,15,90,47,93,62,39,35,3],[18,1,93,47,29,91,62,39,48,3],[4,29,79,54,93,42,62,39,18,3],[79,62,39,22,93,29,3,48,47,14],[54,55,81,82,63,22,99,56,97,15],[3,18,39,82,79,62,47,93,6,56],[60,39,79,3,47,74,29,62,18,40],[1,62,99,39,6,3,79,18,29,47],[93,3,67,6,79,18,1,39,62,47],[62,4,29,56,39,18,3,93,80,79],[62,60,29,93,3,71,18,47,54,39],[79,62,39,66,18,64,93,3,0,29],[47,62,60,29,18,3,93,39,90,81],[93,18,79,39,3,29,62,67,22,90],[90,93,40,3,54,79,18,39,29,47],[39,83,18,35,79,62,40,3,93,47],[79,93,39,18,47,64,58,29,3,33],[39,47,93,3,55,62,79,57,18,33],[56,63,82,14,15,4,22,58,85,99],[62,39,18,3,58,85,93,47,60,29],[35,63,18,90,93,29,39,47,62,3],[71,47,93,16,39,29,62,57,18,79],[18,29,79,66,62,54,47,3,93,40],[3,18,93,58,15,39,99,79,62,47],[39,66,18,62,47,35,93,29,58,79]]");
            Assert.AreEqual("[3,10,18,29,39,43,47,62,79,93]", Util.ArrayToString(m.Mafia(suspects)));

            suspects = ParseJaggedArray("[[14,80,58,64,60,72,12,74,92,52],[80,72,60,58,2,14,52,61,74,88],[60,88,52,74,22,58,92,29,72,7],[86,92,52,80,74,60,88,22,72,12],[92,40,60,52,10,88,72,74,58,47],[74,52,32,80,60,36,92,2,58,72],[14,60,80,2,17,72,88,52,92,74],[88,36,80,74,58,92,22,60,52,2],[80,74,92,72,36,58,81,60,52,7],[43,80,92,38,88,52,74,58,60,36],[86,6,80,74,72,88,81,92,52,60],[60,80,10,72,32,92,52,18,88,74],[72,80,92,29,88,60,58,52,40,14],[40,60,74,58,52,32,72,80,37,88],[80,64,92,74,44,72,7,58,88,60],[58,60,92,80,72,88,74,76,10,18],[88,74,58,17,26,92,60,72,44,80],[80,52,14,72,30,60,88,61,92,74],[88,72,60,92,58,52,25,2,80,84],[74,88,2,60,27,7,52,80,58,92],[52,88,60,43,92,86,80,32,58,72],[30,40,72,80,74,96,88,92,60,58],[74,10,80,52,60,58,72,92,76,2],[88,72,92,80,76,32,52,74,40,60],[52,55,86,6,92,74,60,72,80,58],[2,80,52,69,92,74,58,72,38,88],[17,80,40,72,60,29,52,92,88,58],[36,80,29,47,58,60,72,92,52,88],[58,52,31,47,80,88,84,74,72,92],[7,80,92,40,52,58,60,84,74,72],[72,88,92,60,58,76,52,80,7,14],[2,74,58,72,92,64,52,69,60,80],[84,80,69,58,92,60,88,74,87,52],[74,27,17,88,52,80,60,92,61,58],[10,88,92,72,55,60,52,80,36,74],[60,52,74,61,80,88,96,14,92,72],[60,31,52,58,92,81,74,88,80,69],[72,52,74,40,80,92,60,88,7,96],[74,29,27,52,88,58,87,72,92,60],[88,38,5,92,52,72,69,60,80,58],[37,92,12,58,52,29,80,88,74,60],[60,88,74,52,72,84,14,26,92,80],[88,72,30,74,58,27,80,52,60,14],[2,52,88,80,55,74,58,92,61,72],[62,52,87,80,72,58,88,60,92,96],[88,64,72,80,74,52,58,38,31,60],[88,52,74,40,80,72,26,58,60,62],[88,72,64,44,17,52,80,74,60,58],[81,52,88,32,58,14,92,74,72,60],[92,52,58,60,5,72,18,88,6,80],[52,55,80,6,92,76,74,88,72,60],[80,92,74,52,96,58,2,60,32,88],[40,32,5,12,86,26,38,10,96,36],[27,92,74,52,58,60,72,88,22,38],[72,52,88,92,58,80,31,27,30,60],[30,92,52,72,29,58,60,80,88,27],[30,17,31,26,84,14,6,44,69,32],[88,58,72,25,30,74,62,60,80,52],[76,26,96,12,87,86,36,38,5,29],[17,61,80,74,58,60,88,92,5,72],[87,5,10,43,76,12,29,38,36,40],[74,92,52,60,58,88,72,5,29,96],[88,87,92,52,43,60,72,58,12,74],[88,38,7,58,27,92,80,72,74,52],[74,76,58,52,72,55,37,92,80,60],[88,52,58,60,76,80,61,92,72,10],[80,74,92,64,52,43,88,60,12,58],[58,74,72,86,60,38,2,88,52,80],[80,72,52,32,76,74,7,88,58,92],[12,52,92,86,72,88,80,14,58,60],[29,55,96,61,64,81,27,37,22,5],[32,60,10,80,92,5,88,52,74,72],[10,38,26,43,32,12,87,5,96,40],[52,74,62,60,58,10,5,92,88,72],[69,31,40,30,32,44,14,25,2,86],[58,61,25,74,88,92,72,52,80,6],[52,44,58,60,72,74,40,80,17,88],[88,69,96,58,47,72,52,80,74,92],[58,87,40,52,88,80,72,74,60,81],[72,80,58,52,62,60,38,44,92,88],[36,38,5,76,96,14,32,12,86,29],[58,43,62,86,92,52,60,88,80,72],[40,74,88,80,43,58,26,60,92,72],[58,88,36,12,74,60,72,80,69,92],[47,31,80,92,60,58,88,14,74,72],[58,92,80,88,69,31,62,74,72,60],[60,10,92,72,52,80,38,74,88,2],[96,69,58,74,72,40,80,52,60,92],[32,5,38,76,12,40,96,14,26,87],[72,2,52,64,84,60,88,92,74,80],[52,88,5,80,32,58,74,40,72,92],[58,60,80,29,74,52,92,22,43,72],[55,18,76,81,7,22,27,37,61,64],[92,60,58,80,47,22,5,88,74,72],[32,88,72,74,80,84,43,58,92,60],[76,88,25,92,72,52,58,7,80,60],[88,64,58,80,60,92,38,74,18,72],[74,29,87,58,55,80,72,52,92,60],[88,80,55,84,7,74,92,72,58,52],[69,96,58,72,80,92,74,52,88,25]]");
            Assert.AreEqual("[52,56,58,60,70,72,74,80,88,92]", Util.ArrayToString(m.Mafia(suspects)));
        }
    }
}