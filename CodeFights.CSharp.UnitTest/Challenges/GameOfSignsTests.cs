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
    public class GameOfSignsTests
    {
        [TestMethod()]
        public void gameOfSignsTest()
        {
            var g = new GameOfSigns();
            Assert.IsTrue(g.gameOfSigns(new[] { "S-R", "F-R" }, "R"));
            Assert.IsTrue(g.gameOfSigns(new[] { "S-", "F-" }, "D"));
            Assert.IsFalse(g.gameOfSigns(new[] { "-S", "F-" }, "L"));
            Assert.IsTrue(g.gameOfSigns(new[] {
                "S-------------R",
                "R------------R-",
                "-R----------R--",
                "--R--------R---",
                "---R------R----",
                "----R----R-----",
                "-----R--R------",
                "------RF-------",
                "------R-R------",
                "-----R---R-----",
                "----R-----R----",
                "---R-------R---",
                "--R---------R--",
                "-R-----------R-",
                "R-------------R" }, "R"));
            Assert.IsTrue(g.gameOfSigns(new[] {
                "S--R-----------------------------------------------------F----------",
                "---L-R--------------------------------------------------------------",
                "-----L-R------------------------------------------------------------",
                "-------L-R----------------------------------------------------------",
                "---------L-R--------------------------------------------------------",
                "-----------L-R------------------------------------------------------",
                "-------------L-R----------------------------------------------------",
                "---------------L-R--------------------------------------------------",
                "-----------------L-R------------------------------------------------",
                "-------------------L-R----------------------------------------------",
                "---------------------L-R--------------------------------------------",
                "-----------------------L-R------------------------------------------",
                "-------------------------L-R----------------------------------------",
                "---------------------------L-R--------------------------------------",
                "-----------------------------L-R------------------------------------",
                "-------------------------------L-R----------------------------------",
                "---------------------------------L-R--------------------------------",
                "-----------------------------------L-R------------------------------",
                "-------------------------------------L-R----------------------------",
                "---------------------------------------L-R--------------------------",
                "-----------------------------------------L-R------------------------",
                "-------------------------------------------L-R----------------------",
                "---------------------------------------------L-R--------------------",
                "-----------------------------------------------L-R------------------",
                "-------------------------------------------------L-R----------------",
                "---------------------------------------------------L-R--------------",
                "-----------------------------------------------------L-R------------",
                "-------------------------------------------------------L-L----------" }, "R"));
            Assert.IsTrue(g.gameOfSigns(new[] {
                "R-----R---",
                "----------",
                "----------",
                "R-----L--R",
                "L--------R",
                "----------",
                "L----FS---",
                "----------",
                "----------",
                "----------" }, "U"));
            Assert.IsTrue(g.gameOfSigns(new[] { "LS", "LF" }, "L"));
            Assert.IsTrue(g.gameOfSigns(new[] { "S", "-", "F" }, "D"));
            Assert.IsFalse(g.gameOfSigns(new[] { "--R-R", "F--RS", "-R-R-" }, "R"));
            Assert.IsFalse(g.gameOfSigns(new[] { "-LS-L----R", "--L-L-F-L-", "-----LL---", "RL---R-RRL", "-R------RL" }, "R"));
            Assert.IsFalse(g.gameOfSigns(new[] {
               "F--LRS-L--RR------------L--LLL-R------RL-LLRLR-R-----RLLRL-RLL-R--RRL-LL---LLRL-------L---RL--RR----",
               "-R--RLLL-L-R-RL-------RL----RR-LR-RL--R----R-LR--R-----LR---RR---RR-L------LL---R--L----R-LRL--RLL--",
               "RRL--L----L--R-RR-L-LRR-R-R--L--R-----R-----R-RL-----LL-RLR-L-R---L-----------LL--RR-L-LR-RL-RR-R-R-",
               "-R-L----RRL---LRR---LR---------RRL-L-LL-R--RRL--L-L-------R-LRR---RL-L---R-R-LLL--R-RR-L-RRRLRR-R-R-",
               "R-RR----R-------R-RR-R---R--------L-R-R-RLLLR--RLLLLRLRR---R--RL---L-R-R-R-RLR---R-RR--R-LR-L-R---R-",
               "---LLLL---RL-----R----L-R---R-----L--RR----RRR--L--LR-L-R-R-RR-R-------RL----RRRL--L------R--RR-L--L",
               "-R-L--R-R-LLLRR------R--R-RR-L---RRLL-LL----LR---L-R---LLR--LR--L----LLRLR----RR------LLLLR------RR-",
               "R-----L-LLRLR-L-RRR----R-L-L-----LRL--------R----L--L--R--R-RRR---LLR---RR-----RRLLL--RLR-L--RRLLRL-",
               "LRL---LR-RLRR--R-----R---RRL----RR--R-LR-LRL-R-R--LR-----LRRLLR-RRL-R---R-R--LR-------L-L-----R-LLR-",
               "LL-LL--R-R-R-----R-L--RRL-LRLL-R-RRR---LL--L-----LRRR------L-R----RR-RR----R-RLL--RR-R--RRR----R-RRR",
               "--LRRRR-----RLL-RRRL---L----LL---RRR---LL--L-LL-L---R-L--L--------LRR---RR-RLLR--LR-L-R---L--L---LR-",
               "---LRR-RL-RR-LL-----L----R--RLL--RLL--R-L-R-LL---R-R--LR---R--R--RLL--R--------RR--RR--LR--R---R-LLR",
               "R---R--R---L--R-RRRR-R-LRRLLRL--R-L-R--LL---R-R------LLR--------R---RLR-L--LRR----R---LL--R-----LRL-",
               "-RLR-LL---LL-L-RLR--L--R-R-RL--RR--R-RRL-RR-R--L--L-RR-L--R--R-R-LR-L--L--RLR-R-LR----LRL-R-L---R-LR",
               "R-L--R--L-R----R-R-L-------L-L-----RRRL-R---LLL-----R---LRR--RLR-RRR--R-L---R-----RR--LR-R----L-RL-R",
               "L---R--L-L-R-R-R-R---L-LR-R--R-R--------RL------L-LR---LRRR-RRL---L-----RR-RR--L--R------RLLR---R-R-",
               "R---LRRL-----R---RR--R-L-R-RR-RL--------LR--RR--RR-RL-RR-R--R----RLL-L-R-RLL--L----------L-R-R---L-R",
               "LR-----R------RRL-L-R-L-LRRR--R-L---R-RL-RR-R---LLLR---LRR-R-R-----R--L-L----R-L---R---LL--R-LL-----",
               "---RR-RL----L--R----------RLR-----RR--R---RRLRR-L---------RRR----LR-L----L-----LR-LRR--LRL-RLL-RRRLR",
               "----R-R---LLLLR--R---RRLR-R-LLLR-R-RRL-L-R---RRL-R-L-LLRR-RL---R--RL---LL-----LLL-LL---RR-RRRR--L---",
               "R--L--RRL-------L--R-L--L-RLR--LL-R----LR-LRR-R---RRLL----RR-----L-R-L---RRR-RLL-R--LRR-LR--LLRLRL-R",
               "--LRR---RR--LL-L-L-LLRLR--R-RR-R-R---R--RR-----R---L--L-RL-L-LLR-L--L-RR--RRRL-L------R----R-R---LRL",
               "--R-L--LRRL---L--L---RR---R---R-RLL--R--R--LL-----L--R--R-----R---L--RLRLRR-R---RRRLRR-L-LR---R-RR--",
               "R-R-RL--RLRR--R-LRRLL-L-LRRRLL---LR-R-------L-R-----L---L-RL-L-R-R-L--R--L--------L-L-R--R--L-R-----",
               "-R----RR-RR----RR---R----------L---R-LLR----------R-L-----R-L--R---L---R--RRLLLL-LR-R--RRRLRR-RR--R-",
               "LR-----RLL-R-----RL-----R---RR-L----R-L--R-L-----L--R--L---RLRRLL-RLR-R------LLLLLRRL-RL---R-LL---RL",
               "R-L-R-RRRLRR-RR-LR---RRLR-LLR--LRRRRLLL--RL--L--R-------RR---LR-L--R-R--------R-R--RLR----RLL-RRR-L-",
               "L---L-------RLRR---LLR-RL---LLL------RRL-RLL----RRR------L--LRLL---RR---R----R-R-------L-R---L-LR-RL",
               "--RR-R------LLRR----LL--L-R----R----RRL--RL-RL-LR-R-R-RR--R-R--RRLLR---R-L--R-LLL-RRR------R-L-----R",
               "R-L--RL-LLR-R---RL---R-R-L---L-RLLL----RR--RR-R--R--L-L--RLRLR-R--R-RR-RL-L---R--LLRRR-R-R---R-L-LLR",
               "---L--RL--LL---RL-L-RL------R--LR--LR-L-L-LR-LRRR--R-L-RL---R---R--RRL-R-L-L--LRL-----RLL-RRLRR-R---",
               "L---L-L--R--RL-RRL----L--RL--L---RR-R-LRR-R--R---L--LL---LRRR-L-L-RR--LL--R---L-LL------L--RRLLRR--R",
               "-R---RR----LLLRR-R-RL-RRR-R--R-----RL--LRL--RRRRR-L-R--RRR-L--LR-R-----L-R-RRL-RR--RL--LRR---RR-LLL-",
               "RL-RLRLRR-R-RL--R----LRR----R----RL--RRRRRRR-----LRRRRLR-R---L------L-L--L--LL-RL--LLL---R-LL--RR-R-",
               "-R-RR-R--LLL-----LR----L---LLL-L---L----L--R--R-----R-L---R-L---R------R-R-R--L-RRRRL---R---L-R-RR--",
               "--LLLR---R-----LRRRRRR-RLL--LR----LRR-RRRL-LRR-L-RL---RRR-LR-----LR-R-L---RR-R------R-RR--L-R----RR-",
               "-L-R-LR-R-L-RRL----L--RR------RLR--R--RL---LRL-R--LR----R-------------RRL----LLL-L---R-RR-RR--LL--LR",
               "---L--L---R---R---L--R---LRR--LR---R---RRRL-R----RLRRRR---RR--R----R-----LR-R-LRRL---LR---LL-L--L-LR",
               "-L-L--------L--LR---R-RRL-LL---LL---L--L-----R-----RLR---L-RL----RRR-R------RL--RLR-----------L--R-R",
               "LR--R-L---R--RR-LL-L------R--RR-R--RLRRL-------L--------L-R-LLL-LL-L----R-RL-R-L-R----L-R-----R-LRL-",
               "--L-LL---L-LR-LLR-RL--R-R----L-L---R-L-LRR--R-L-LL-LLLR-R-----RRR--R------LR--R--L---------LR-LLR-R-",
               "R-R--RL-RRR-LLR----RR-L--R----------L-L--R--R--L---LR--LR--LL-R---L-LRL-RLL--RR-R---LL--LLR-LRLRL---",
               "L-LRRL-R-LRR----------L-RL-RRL-RL--R-------RR-----RRRL-L--LR-----RRL-------RLL-L--R-L-L-R-RRL-R--L--",
               "RRL-RRR-R----R-R-LR--LLLRRLLR-LL---RRR-LL---RRL-R---RLR--R-L----R----R-----R--R-----R-RRL-L--RL-R-R-",
               "R-----R---R--R-------RL-LL--LL--L--RR--R--LR----LR--------L-L-R--R-L-L--R--LRR-R------R---LR--R--RR-",
               "---L---RR--R---R---LLL--R-RR-LL--RR--L--R-----RLLLL-RR----LL-L------------R-RL-----L-----L-----RLR--",
               "-------RLL---R---R--LLRLRRL-R-RR---RL-LLRRLLRRL-R---LR---R-L--LL--LL---LL--LR---L-L--RLL-R-R--LLL--R",
               "--R-------LL---L-L-RRR-L-R-R-L--R-L--R---LR-LR--R---L-RRLR-R-R----RRLR--R--L----RRRRL---------RLL-L-",
               "L-L---L-L--L--L-L-L-R--R-LL---L-L---R--R---R-LRL---L------R-----LL--LLR-L---LLR--LR------RRRLLL-----",
               "R----R---LR-L-R-RRL---L-RRR-RRLR---R--L-LR-RRRLRR--R---R--R-LR---L-R-R--RL-LL---LRRR--LLL--R------RR",
               "LL-RR-----R------R-----L--R----L-RR-LL---R--R---R---R-RLLLLL--LLRRR--L---RR-R----RR-----L-LR---RR-LL",
               "L--RL-R--R--R----LRRR---------RLRLL-----R-----RRR-L-R---RRL-R----RR------L---L-LL-LLLRRR---R--R-R-R-",
               "L--------LRR--RR-RLRLL---L--R-LRRL-----R-RLL-LRLL-R-RRR-LR-L-L-RRLR----L---R----LR--RR-----LR-R-----",
               "----LRRL--L-RR--RLL-LL-LRRRRL--R-----RRL-R--LRRR---R----L---LRLL-R-L--R-----RR--R--R--LLRLR-RLLR---L",
               "R-R-----R-R-L---L-RL--RRL-LR-R----LL---R----R-LLLRRL--L--L---L--L--L-RR--------RRR----LLL-RL-R----L-",
               "--L-RL----R----R--R----R-L-L---R--R-LLL-RR-L---R-----L-RL--LL--L-R-L---L---R-L---------R---------LR-",
               "-LLRR---L---RLRRR--R--------R--L---RRR---R---LRR-RR--R--R-L--RL--R---R-R-RLRRR-----------L----RR-L-R",
               "-RL-RRL---LR--RL-RR---LL------R--R-R-L--R--R-------L--RR-------R------RR-L-L-L--R-RL------R--RR-L-RR",
               "R-RR--R--L-----L---R----RLL-----R---LLR-LRL-R-R---R----LRRR-R-R--R---L-LL-RRRR-R----RR-L---L--------",
               "---R--R-RR-----L-----LRR---L---R---L-R-----LR---R---LRL---R-L----------L-RR-L-L---R-------R-RR-L---L",
               "RL---R-R--L-L---L----L-L-R---R-R-RRRL---L-LL----LL------R---L--R----R------RRR-L-R--R-----LRL---RR--",
               "R---L--R--RL-L-----L---LL--R--LRRL--RR---L-RL----R-------LLR---L--L-RRLRL-RL-R-RRL--RRLRRL--RRR-R---",
               "-LR-------R-L-----RRR-R---L----L--RR--LRRLR--L--L---R-LR--L---RL--LL--RLL----RRRRR-----L--LR----R-R-",
               "--LR-RR--L--LLRRRRRLR--RLR-L-RLLRR----R---R---L------L-RL-R-RLR---LLL--R-------R--LR-L-RL-------RLR-",
               "R-R-LLL-R--R-------L--RL--LR--RLRL--R--------RR-------LR-LR---RR-R--LL-RL-R---RL---RR-R-L-LR--R--LR-",
               "L------LLR--L----LR-LL-L---L-R---LLLL--R-R---R--R-R--L-LR-R-----R----L-LLLR--R---RR----R---L-R--R--R",
               "-L----LR-RRRRR-L-L---R--L-LLLLRL--L--LRR------L--L--R-RRRLR------R---R--R---R--L-R-LRRLLRR--L--R---R",
               "R----L----R----R-------L-R-L-RRL-----L--------------LLR-L---R-----LR-R---L---LL-----LL---R---R--R---",
               "R---R-RRLL---LR---R-L--L-----L--RL-LLL-R-R---L-L-R-RR--LR--R----RRRR-RR-LRR----R----LRR---RRL-RL-L--",
               "-RRLLRRL-RL-R-L----R--LL-R---LR-L--RR-L--RR--------LLL---L--R-RL---RR----RRR--R----LL--RLR-L-LRL-RL-",
               "--R-------R--LL---L--L--L-L-R-R-----L-R----R-RRRRRL-R-L--RLRR-----L-R-R--------L----LL-R--LL-LLR-R--",
               "LL--RR-L--L-RL---LLLR---R-L---LRR--R--R------R--R--LRLR-L---LLR------LLLL--L--R--LL----R---L--RR----",
               "--RR--R---L-R--L--R---LR----L-RR-----R------RRRR-----LRR--LR---RR---------R-----R---L--LL-RR---LRLR-",
               "---RR-R----LR-R---L--RRL-RL-LR--RL----R-RRL-RR--R-RL-------L---RRLLL-RLL-RR-R--R---R-R-R-R-R--------",
               "-LRLR----R-L-R-L-R---RR--L---R-RRR-R--LL-R------RRL-RLL-R--LL--R---R-R-R--LLLR--R-RR-RL--R-RR---L-R-",
               "----L-L--RR-R---LRR--L--LR-L----R-L----L-L--RL----RR--L-R--L--R--R---L---R----R--L--LR-R---LL----LRR",
               "RR-L--LRLRL----RR-L----RL---R------RLR-LLR-R-RLR-----LL-L--R-R-R-R-R-LL-R---LL----R--RLRR---L--R-R-L",
               "-----R-RLRLLRR--R--R-RR-L-L-RRR---RLRLR-RRR--------------R---RL-LLRR-R--LR--R-----L------RL---LR--R-",
               "-L---LL-L---R--L--L-RR---LL--LR-LL--R--RLL--R---R-R--R-R-R-RR-RRL-----RL-RL-RLR-R-------LL-LLLR-R-R-",
               "RLR-LL-RL-L----L----L--L-RRLRRRRLL-LLR--LR-RR-----L-R-----L----L-R-LLRRL--L--LR--R--L--RRRRRR--L-L-R",
               "L-L-R---LRRL-RRRR------R--R---RR-R-RLL-LRLLR-L-L--L--RRRLRL--R----R-----R-LR----RR---L-R--R-RR-RR-L-",
               "L-R----R-RLLR---R-LL---R--R-LRLRRL-L----R----R-R--LRRR--R----R---R----RR-L----RLL-------------L-LLRR",
               "--R-L-----R------RR--RR--LRLR--L-----R-LR----R--L-R-R---R-RR---L--R--RLR--R-RRL-L-----R-----R-----R-",
               "---RL----------LR---R----RL-RRL-LL-RL--RL-LLR---LRR--LRLLR--R-R-R-R--LR-L--R--L---L---R--LRR-RR-----",
               "-LL-RR--RRR--L---RRR--LLL-----LR--L-R--R-RLR---RR-RR-RLLRL-LRRL-LLR-L-RL-L-R---L-R-RR-RRRRLRR-RR-RRR",
               "-LL-R-R-L---RLR-RR-L-L--L--LL-RRLLR-------R-LR--LL---R-R-R--R-RR-----L-R-LL-R---R----R-LL--RLL-R----",
               "----RR--LRR---LR--RLR-------R-RRR--L---R------L--RR---R---L-LL--LL---------R-----R---LLR-RRLRRLLR-RL",
               "R---LRRR-LRRL---R-----R--L-RR--------R--R-LRR-R-RLR-R--RL--R----LLRR-----L-----R-LL--------L-LRLR---",
               "L---R-L-LLR--RLR---L----LLLR--RR-R---R--RL---LR--RRL-------R--LR-RR-LRRR-R----L------L-LRRL---RLRR--",
               "R--LLRR----R-L--RR-LR-R---RLL---L--RL-RRL-----RLRR----R---L---LLRLR--RL----R------R---LRLL---RRRL--R",
               "-L--L--L-RRL--RL--R--R----R-R-RR-LRR-L--R----L-------RL-RR---L----R--L----R--RL--L-L-RRLL---L-------",
               "R---R---LL--RR----LLR-LLL-RRLR-R-R---R-RR-------------L--L-LR--RRRL--R--L---------R------R-L--L--LRL",
               "--L--RR-L--RLRL-R--L-L--R----L-RR--LL-----RR-RLR-----L--R---LRL--R--R-R-L---L---L--L-L---L---L-L-L-R",
               "R---R-----R-RLLLL-RLL--LL-L-R---R--LL--L-R---R--RR-L---L---RR-R-L--L-L-LL-R-RL--L---L-RRL---R---LR--",
               "LRRRLRLL-RLRL----RR--RR-L----R-L-LR---R-RL---L--R---LR---R-----R---RR-RRL-LRLL---RR--RR-----RLLL-L-R",
               "R---LLLLL-L---L-LLL-R--R--R--R---R-R--RR-R---LL--R--R-L--L-RRR----R--RRRL--RRL-L-RLLL---L----LLLRR--",
               "R-RL------R-R---R-----LR-L----R--R---RR---RL-LL--L---RR-RL--R--L--R-L--LL--R-L---RLL------R-R--L---R",
               "RRL-LR----RRRR---L-LR--R-R---L--R---R--R--R--RRR---R--L--R-R-RL---R-L-RR--L-RLLRLR-RR-LL--R-L-L-R--R",
               "-LL-RR-RL-LLR--R-R---RR-RL-L-----------LL-LLR--RL-R---LR---RR----LR-L-LLRRRLR---R--R----L--R---L-RR-",
               "-R-R----RRL--RLR-R-LR-L-R-RR-L--LL--LL----R--LL-L-R-R----L------LL---R--LR-R-RR--R--RL----RRLRL-R-RR"
            }, "R"));
            Assert.IsFalse(g.gameOfSigns(new[] {
               "-RS--FL---L-R--LR--R--------R--L---RLR-L-----LLRR-----LR-R------RR-L---R---------R------RLR-R--R-R-R",
               "----R--R-RR-------L---L----R----L-L--L--L-R------LR--RRL--LL--R--R-R--L---L----R-----R-RL--L--R--R--",
               "-LL-L---RR-----L------L-----RR---R------R---R-RRLL------RR----L----L---R-----L-L--R----------L-R--R-",
               "LL--LR-----L---LR------R-RRL--LL-------L-L---R-R-------R-R---L----RR-L--L--R--R----RL------LRL--L-L-",
               "-LRR--R-L-----LRR----L-------------RL--R-L-----RR-RRLL-RR---------------LR----------R---R----L------",
               "---L--R-R---R-RR----------LL---L-R--R-L------RL--LL----L--R--R---R----RL----RRR-R----R--R-------R---",
               "-R-R-----------------LLR-RRR----L------RLRR---L--RLR---L-RR-RLL------------L--L-R-----L----L--R-LR--",
               "--RR-LL------R-RLR------R-RL-LRRLLLL------R-LR-----R-R---LR-RR-----R-R----L------R-L-L---L----RR--R-",
               "-RL--LL---R---R--L---------------R--R----R----L-------R---R---L-----R-RRL--R----R--L-L-R----R---R-L-",
               "R----LR-L--L-RR---R-R-R-R-----L--LL--R-------R------LRR---R--R---L---LR---R----R----L---L-RR----R--R",
               "LL-----RR---RL-LRR----RR-LL--R-R-L---------RRR-L--R---RRLRRR-R-----L-R---L-LL----R-R--L--RR--R-RR--L",
               "-R--R-L-----L----L---L------R-----LR------------LR--L--R--RR-RR-----L----------R--L--R--R-R--RL-LR-R",
               "--R---LLLL---R-----R--LL-----R---------R---------RR-L-R---LR-R-R-R----L---R-R--R--L----L-L-R-LRR-LRR",
               "-R-RL-L------------L-RR-R-LL-L-L----RLLLL--LL---RR----------------R---L-R---R---R--------R--L-------",
               "----R---------R--L------L-L----L-LR-R--R----L-R--LR-----L--RR-R-L-L--L----L------RR-L-RL--LR--L--L--",
               "----L---L--LRRR-LL-L---L-R--R---L------------LL---L--R---R---RL---L-RR-----R-----L--L---LLR-RR------",
               "--R-R--RLR-R-----L--------L-LRL-L-R----------------R--RLRL------RL--L-----R-LR-R--R----L-R--R-R---RL",
               "-LR-L-----RL------R-L-----R----R--------R--R---R-LRL---LR--LLL-R---L-----R-----LL--RR---L-----------",
               "--LLLL--R-R--R-------R---L---R-L-L-----R-L------R-LL-R--RL-R-R-LR-R-------R---L-----------------R--R",
               "----R--------R-L----------R---R-------RR----LRR--LLRL--R-R-R-----L----LLRLL-------L---L--RLR-L-R-L--",
               "------L---R-L-R--R------RR-R-R----LL---LRR----R--R---------R--------L---L-R----L--LR----L-R-L--LL--R",
               "R--LL----R--------LL---LLR-R---LRR-R-LR-LL------LL--R-RR----LR----L-LR-----R-----LL--L------R-----R-",
               "-----L-RL--L--L----L-R-L---R-L---RR-RR-L---R-L-R--LRLR-L-----R--L--R------------L------RL-------L---",
               "--L----------RRLL--RR-------R-----L-RL--R-LR---RLL--RL-R-R----R-L-----------R---LL-----L-R-R-L--L---",
               "---LR-------RR--R---R-----R----L-L---R-RL-L-----L--L-----R------R-LL--R-------R--RLL----RR---R----R-",
               "-------L--L---L--R---------RR------R-RRL-R--LRR----R-L----R----R-LLL---L-R--------L-------R-R----RR-",
               "RRL----L-------R--L---LR---L------R--L---LL-L---LRR----------R------R----LR---LRRR----L--R-L-L--L-RL",
               "---R-R-LL-L----R-----------LLR-----LL---LL---RR------R--R---------R--R----RL----LL--L--L--R---L-R---",
               "L---L---LLL----RRRL----R--R-----R-L-L----R-R--L-RL-------R----R---L-----RL-R-RRL---LR--R--LLRR-RR---",
               "-----L-------RL----R-RR-----R-R------R-----R---RRL-RL---R-LRR-LR------L---R--R---R-L---L-R--L-------",
               "-------RR---R-L-R-LR-------R-L-R-----RL-R---------LR--L------R---L-----R-----L--L-R----LL---R-------",
               "--R-------L------R---R--LLL----L----L-----R----L--R---L-L-L---------R-R-RR----LL--R---------RR------",
               "-L--R-------L-RL--RL-------R-----LL--L----R----LR------L----R----L---RL--L--L--L--LL-LRR------LR--RL",
               "--L-------R----L----L--------RR----R-----L-RL--LL---R--L----L-LR-R--R--L---R-------------RL---L-----",
               "---RRLRLL---LRL-L---R-R-----R----------LR---L-R--LL-R------LRR-----------R-L----R--R--R-RL-L---R----",
               "-LR---L-L----------R-RRLR--R-RR--LR--R-LR--L--L-RR-R---R--R-----L-------RRL-L-----LR-RRLL-L---------",
               "R--L--------R--R-----R-LR-R----------RRR-----R-----------LRRLL--------L-RR--L--------L---R-RR----R--",
               "RL-----LRLR-R------------L-L--L-R---------LR-RR-------L----R-R--LR--L------LLR---R-RLL----R-----L-R-",
               "-RR--R--------------R-----R----L-----LR--L----R-----R--L-R-L--------LL---------------RL----R----RL--",
               "-R--R-L--R----R-R-R--------L---R--R-------R-----L-LLL-------------R-LR--R------L--L-R-------R-L---LR",
               "-L--L-----L-RL-RL-----R--L---L-----RL-----L------R-L-L-----L-R--L-R---------------R----LL----L------",
               "------R---RR-R-----R---L----L---R---------R-L---LR---RRR----LL----RLR----R-R----RLR-LLRLRLRR---R----",
               "---L--R---L------LR-L--L-----RR---R-L---RL-R--R---R---R---L---LR-R-------L--L--R-R-----R----R---LRL-",
               "-----RR----L-L--------------R-L--L-----RR----R--R-RR----RR-R--LLR------------L--LR------------R-L---",
               "--R------------L-L-L-LL---L---RR------R-L----R------R-L-R--R-----L--RLR-L------RLR-RL-L--R--LR-LRL--",
               "---R-RL---R--RL-LR----L--L-----R-------------RR---R------R---R-R--R-----L--------L-LR--------L--R--R",
               "--------L-R---L-LRRL-R-L------LR---L--------R---LR--LL---R--L-R-------RR---L-L---------L-L-L-R---R--",
               "RL-R-LL----R-L-R-L----LR---L-RL--R-------LR--------L----R---L--LL-------LL-------R--------RR--------",
               "-RRRR-----R---------R--LR-R-RR-LR--R----LR--L-L-------R--R----L-RRRRL--L-R------L-L-L--R-R-R--------",
               "-----------R---RL----LR--RR-R--L-L-----LL--L----L----------LL-R----R-R-R-LR----L---RR---LLR--LR-R---",
               "-------L---R-----------L-RLRLR---RR-R-RR--L-L----RR---R-L-R--LRR-L--L---R-R-----L----RL--R---R--L--L",
               "LL-----------R--R-R-LR-----LL--LR-R-RRR---R-L-L--LLL-RR--RL-LL--RLR---------R-R-----R---R-------R--R",
               "--R----R--L--R--R-----R----------------R-----R--R--LL---LR-RL----------L-LR----LL-L--RR-------L-----",
               "-RL--R----RLR----RR--L-RR--L-----L-L-------RR------LLL---RL-LL-R---R----L--R------L-R----LR----RR-L-",
               "R----R--R------L-R----L------RL-R-LRLLLL----RR-L-L---------L---------R-RRL-----------L-RR--R---L-L--",
               "L--L----LL-LL----------------L---R----RR----LR---L----R-L-L-L---R--L-----L------LRL---L--------L-R-R",
               "---R-----RL--RL--R-R---R----------LR-----LL--RR------L-L-LL-R-R-R--R----L---RRL--------R-LL--R----L-",
               "---RLR--L-RLL-----R---R--R---L------RR----RR----------------R-------LR-L-R-----------R-R------L-----",
               "-RRRR--R----RLLL-R----RRL---R-L-L-R-------R----R-L---L---R--RR--LR------LR-R-----R-----LL-R-R-----R-",
               "---R-L----L--R---L-------------R-R---R--LR--R---R---LL---LR------L---R-R----L--R----LRR-L-------R---",
               "LL---RL----R---R--L----L---R-RRR-L---RR---R----R---R-----L----L---L-----L---R-L-LL-L------RL-----L--",
               "R-----R------RL--R---L------RL-----RR-RR--R------L-L------LR----------RL--RR-R--------RR----L---R--L",
               "--R-R---LLL---R-------RL--RL--RL--------R---LRR--RRR-R-LR-----L----R-L---RL-------L------R---L-LRRL-",
               "LL-R--L----LLLR-----LRR---L-L-L---L-L-L---RL--R-----L------R-LRR-RL---R----RRRL---L---L-----------L-",
               "----L-RR--R---LRL-L-L--RLL-L------L---R---L----LLLR--------R-RLLR-L----R-----R--LLLRRR-R----R-LR----",
               "-RL--R--LL-------RL--R---------L---L--LL--L---LR--L--R-----L---L---L--------R--R------R-R-----L---L-",
               "----R------RR-R--RR--------R------LLRLR------R--RRRR---L-R-RR--L----L--RR---R-------LLL--R--RLL---R-",
               "-L---L----L----RLR-------R---R-LR-------L-----L----R----L---R---L-------L----R---R--R---RR--RRL-----",
               "-----------RR-R---R---R-L---R--R-R--L-R---R-LR--LR-L-RL----R-RL-L-L---L-R--LL---LL---RRL--R-R---R--L",
               "---RL--LR----L--L-L--R-R-LL------LR--L-L---L---L---L---RLR--L--L-------LR-R-R----R----L---R-R-------",
               "L-----R--RL-L--LR--L----R-R------RL----R-R--R--R-L-------------RRL-R-----R-RR-RL-R-R--L-----R--LR-RL",
               "-R-L----R--R------RL---R-----RR-LRL----R--L-------R-L--RR-L----R-L--R-RL-R----LR--L--RL-L-L--R------",
               "---LR--L-------R---------------RL-R-----RL---R-LRL--L----L-L-LRR---L------RL--L--L--R-RR---RL-RR-L-L",
               "----L----L---RL-R--L-RL------R-----R---R-----L--R----LL---LR-R----L------RL-R----RL-------R---R-----",
               "L--L-------RL----R--R---R-------R------L---------LL-RL--R--------L-----L-R-R-L---L--LR--R-LLRR------",
               "-R------RRLR---LRRR--R-----L-R--RLRR---L--R-L------R-------R-R---R--R-------L-L--L-R---R-L-L--RR----",
               "LRR-------L-L---R-R--R--L---------RR---L---RL-LR-L-R--L---------R-----LL-----R-R-LLR----RLR-R-------",
               "-L-----R--L---R-R-----R---L-R--RRRL---L----R--R-------RRL--L-L-L-R-R-LR--L----------RR---LLR---R---R",
               "L--R-------R----L---R-------LR-L--R---R---LR--R---RLRL-RR-----L-R-R----------L-RL-----RR--L---------",
               "--L-L----R----------LR---R--------L----RLR-------LRR---RR-L--L------RLLL----R---------LRRR----R-R---",
               "-R--------------R-L---R-------RR-RR---L----R-RL--R--L-------L------------L---L-R-----L-------L-----L",
               "R----R-RRR-----R---RL--L--R-LR---R--------L--R--RR--L------L-----RL---R-----RR--R---R----L-------L--",
               "-----LL------L---L--RLR--L--R-L--RR-R-L------LL----RL-R-------LRLRRR-------LRL-------------R----R--L",
               "--LRR---LL--------L-L--L--------R------LRR---RL--------L-R-L-LRR-L----L---R-L---LL---LLR-R-LLR---RL-",
               "-L--LL------RL--LL--R------R-L---L-R---R---RR--L-L----RL--L-L---LL-----R--------RR------R--R--R-----",
               "----RRL---RL----------R----R-R-L-----------LR-R---LLRL------R---LL---L--RR--R-L----L--L--LR-----R---",
               "---RR--LR---RRRL-R-----LL-LL---LLL---L---------R-R-----R-R-R-----RLRLL---L--LL---R-RL-RRLR---RL-----",
               "-R---R-RL----R--LRRR----L--------------R-LL-L-----R--L--R-----L---L-LR------------L-R-R--------R--RR",
               "--R-R--L-R--R--L---L--------L-R--L---LR--R-RL-----RLR-------L---L---LR------R-L-R-------------L-----",
               "-----LR--L-----R--------------L--L----LL---R-R-----R---------RL--R---R----L--R-R--RL---R--L-R---R--L",
               "-L--R---R----R-----L-R-R---RLL-R-----R--R-----L---------L--L-L--R-------RL-L----L------LR--LLLLR--L-",
               "L---RL--R--R---L---R---------R------L------R-----R--L----R---L-R------L-------R--R-RL-L----L----RRL-",
               "-L-L--------R--L------R--LL-R-R--------R----------L-----------L--R-L------RRR----LL-L-----L---R-R---",
               "-R--LLR-RR-L------R-----LL-R---------L-R--L-----R--L------L-------------L---LLL---------L----RRLL---",
               "---R--L----L-----RL-L----LL------L-RRRR--L--RRLRL--L---------R-R---LR-LRL--RR-RRL--L---------R--RL--",
               "--R---LR--R-L-L---R-----------L------L---R-RRR--L---------L----L--L---------RR-RR--L------R--R-LR---",
               "L---RL------R--RL-R-L----R-LR--R--L----RR-R--RL--LL-----R-----RRR----L------L----R----------------L-",
               "--L-R------LR---R-----R--LL-------R----L-R---L-R------L-L--L--L-L-----R--RR------L--LR-----RR---R--L",
               "--L----------LL---LR-----L---L-L----R--------RR--L-------R-L---R------RR---R-L-------R-R----R--R----",
               "----R--R-----RL--R---LLL--RLL---R-L-RL--R--L----------LRLR-RR-LLL--L----L-----L----L---L-R--L-L-L-LL"
            }, "D"));
            Assert.IsFalse(g.gameOfSigns(new[] {
                "RLRL--RLL-",
                "-L--LR-RRR",
                "---LRF-RLL",
                "-R----RRR-",
                "--R-L----L",
                "---R-LR---",
                "------SL-R",
                "L--------L",
                "-R-R---R-L",
                "-LRRLR----" }, "U"));
            Assert.IsTrue(g.gameOfSigns(new[] {
                "L--L-R-RS-",
                "L-L-----RL",
                "--LR-R-L-R",
                "R-------L-",
                "--LFL-R-RR",
                "--R--L--L-",
                "-RR-R-RL-R",
                "--LL--L--R",
                "-----R-R--",
                "-R---LR-R-" }, "D"));
            Assert.IsFalse(g.gameOfSigns(new[] {
                "RL-RLLL-------------",
                "--L-RLL---R-LR--RLR-",
                "LRRR---------R-L-R--",
                "LL-R---LR-LR--RRS-LL",
                "RR-R--L---L-----RRR-",
                "--R--L--------R---R-",
                "--L-LL---L----------",
                "L--R--L-----R-L-R---",
                "L--R-------R-RLL-R--",
                "--L-------L-RLR-LLL-",
                "RLL-F----LR-RR--LL-R",
                "-R--------R--LR-----",
                "-LLLL-----RL---L--RL",
                "-R-L-----LL-RR---RLR",
                "-----R---L---RRR---L",
                "------R------R-LLR--",
                "----L---L--R----R---",
                "----------L--------L",
                "-L-R------LLR--R----",
                "L-LRR-----LR--------" }, "R"));
        }
    }
}