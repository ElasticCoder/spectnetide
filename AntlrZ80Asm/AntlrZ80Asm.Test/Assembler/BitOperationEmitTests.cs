﻿using AntlrZ80Asm.Assembler;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace AntlrZ80Asm.Test.Assembler
{
    [TestClass]
    public class BitOperationEmitTests : AssemblerTestBed
    {
        [TestMethod]
        public void BitOpsWorkAsExpected()
        {
            CodeEmitWorks("bit 0,b", 0x40);
            CodeEmitWorks("bit 0,c", 0x41);
            CodeEmitWorks("bit 0,d", 0x42);
            CodeEmitWorks("bit 0,e", 0x43);
            CodeEmitWorks("bit 0,h", 0x44);
            CodeEmitWorks("bit 0,l", 0x45);
            CodeEmitWorks("bit 0,(hl)", 0x46);
            CodeEmitWorks("bit 0,a", 0x47);

            CodeEmitWorks("bit 1,b", 0x48);
            CodeEmitWorks("bit 1,c", 0x49);
            CodeEmitWorks("bit 1,d", 0x4A);
            CodeEmitWorks("bit 1,e", 0x4B);
            CodeEmitWorks("bit 1,h", 0x4C);
            CodeEmitWorks("bit 1,l", 0x4D);
            CodeEmitWorks("bit 1,(hl)", 0x4E);
            CodeEmitWorks("bit 1,a", 0x4F);

            CodeEmitWorks("bit 2,b", 0x50);
            CodeEmitWorks("bit 2,c", 0x51);
            CodeEmitWorks("bit 2,d", 0x52);
            CodeEmitWorks("bit 2,e", 0x53);
            CodeEmitWorks("bit 2,h", 0x54);
            CodeEmitWorks("bit 2,l", 0x55);
            CodeEmitWorks("bit 2,(hl)", 0x56);
            CodeEmitWorks("bit 2,a", 0x57);

            CodeEmitWorks("bit 3,b", 0x58);
            CodeEmitWorks("bit 3,c", 0x59);
            CodeEmitWorks("bit 3,d", 0x5A);
            CodeEmitWorks("bit 3,e", 0x5B);
            CodeEmitWorks("bit 3,h", 0x5C);
            CodeEmitWorks("bit 3,l", 0x5D);
            CodeEmitWorks("bit 3,(hl)", 0x5E);
            CodeEmitWorks("bit 3,a", 0x5F);

            CodeEmitWorks("bit 4,b", 0x60);
            CodeEmitWorks("bit 4,c", 0x61);
            CodeEmitWorks("bit 4,d", 0x62);
            CodeEmitWorks("bit 4,e", 0x63);
            CodeEmitWorks("bit 4,h", 0x64);
            CodeEmitWorks("bit 4,l", 0x65);
            CodeEmitWorks("bit 4,(hl)", 0x66);
            CodeEmitWorks("bit 4,a", 0x67);

            CodeEmitWorks("bit 5,b", 0x68);
            CodeEmitWorks("bit 5,c", 0x69);
            CodeEmitWorks("bit 5,d", 0x6A);
            CodeEmitWorks("bit 5,e", 0x6B);
            CodeEmitWorks("bit 5,h", 0x6C);
            CodeEmitWorks("bit 5,l", 0x6D);
            CodeEmitWorks("bit 5,(hl)", 0x6E);
            CodeEmitWorks("bit 5,a", 0x6F);

            CodeEmitWorks("bit 6,b", 0x70);
            CodeEmitWorks("bit 6,c", 0x71);
            CodeEmitWorks("bit 6,d", 0x72);
            CodeEmitWorks("bit 6,e", 0x73);
            CodeEmitWorks("bit 6,h", 0x74);
            CodeEmitWorks("bit 6,l", 0x75);
            CodeEmitWorks("bit 6,(hl)", 0x76);
            CodeEmitWorks("bit 6,a", 0x77);

            CodeEmitWorks("bit 7,b", 0x78);
            CodeEmitWorks("bit 7,c", 0x79);
            CodeEmitWorks("bit 7,d", 0x7A);
            CodeEmitWorks("bit 7,e", 0x7B);
            CodeEmitWorks("bit 7,h", 0x7C);
            CodeEmitWorks("bit 7,l", 0x7D);
            CodeEmitWorks("bit 7,(hl)", 0x7E);
            CodeEmitWorks("bit 7,a", 0x7F);
        }

        [TestMethod]
        public void ResOpsWorkAsExpected()
        {
            CodeEmitWorks("res 0,b", 0x80);
            CodeEmitWorks("res 0,c", 0x81);
            CodeEmitWorks("res 0,d", 0x82);
            CodeEmitWorks("res 0,e", 0x83);
            CodeEmitWorks("res 0,h", 0x84);
            CodeEmitWorks("res 0,l", 0x85);
            CodeEmitWorks("res 0,(hl)", 0x86);
            CodeEmitWorks("res 0,a", 0x87);

            CodeEmitWorks("res 1,b", 0x88);
            CodeEmitWorks("res 1,c", 0x89);
            CodeEmitWorks("res 1,d", 0x8A);
            CodeEmitWorks("res 1,e", 0x8B);
            CodeEmitWorks("res 1,h", 0x8C);
            CodeEmitWorks("res 1,l", 0x8D);
            CodeEmitWorks("res 1,(hl)", 0x8E);
            CodeEmitWorks("res 1,a", 0x8F);

            CodeEmitWorks("res 2,b", 0x90);
            CodeEmitWorks("res 2,c", 0x91);
            CodeEmitWorks("res 2,d", 0x92);
            CodeEmitWorks("res 2,e", 0x93);
            CodeEmitWorks("res 2,h", 0x94);
            CodeEmitWorks("res 2,l", 0x95);
            CodeEmitWorks("res 2,(hl)", 0x96);
            CodeEmitWorks("res 2,a", 0x97);

            CodeEmitWorks("res 3,b", 0x98);
            CodeEmitWorks("res 3,c", 0x99);
            CodeEmitWorks("res 3,d", 0x9A);
            CodeEmitWorks("res 3,e", 0x9B);
            CodeEmitWorks("res 3,h", 0x9C);
            CodeEmitWorks("res 3,l", 0x9D);
            CodeEmitWorks("res 3,(hl)", 0x9E);
            CodeEmitWorks("res 3,a", 0x9F);

            CodeEmitWorks("res 4,b", 0xA0);
            CodeEmitWorks("res 4,c", 0xA1);
            CodeEmitWorks("res 4,d", 0xA2);
            CodeEmitWorks("res 4,e", 0xA3);
            CodeEmitWorks("res 4,h", 0xA4);
            CodeEmitWorks("res 4,l", 0xA5);
            CodeEmitWorks("res 4,(hl)", 0xA6);
            CodeEmitWorks("res 4,a", 0xA7);

            CodeEmitWorks("res 5,b", 0xA8);
            CodeEmitWorks("res 5,c", 0xA9);
            CodeEmitWorks("res 5,d", 0xAA);
            CodeEmitWorks("res 5,e", 0xAB);
            CodeEmitWorks("res 5,h", 0xAC);
            CodeEmitWorks("res 5,l", 0xAD);
            CodeEmitWorks("res 5,(hl)", 0xAE);
            CodeEmitWorks("res 5,a", 0xAF);

            CodeEmitWorks("res 6,b", 0xB0);
            CodeEmitWorks("res 6,c", 0xB1);
            CodeEmitWorks("res 6,d", 0xB2);
            CodeEmitWorks("res 6,e", 0xB3);
            CodeEmitWorks("res 6,h", 0xB4);
            CodeEmitWorks("res 6,l", 0xB5);
            CodeEmitWorks("res 6,(hl)", 0xB6);
            CodeEmitWorks("res 6,a", 0xB7);

            CodeEmitWorks("res 7,b", 0xB8);
            CodeEmitWorks("res 7,c", 0xB9);
            CodeEmitWorks("res 7,d", 0xBA);
            CodeEmitWorks("res 7,e", 0xBB);
            CodeEmitWorks("res 7,h", 0xBC);
            CodeEmitWorks("res 7,l", 0xBD);
            CodeEmitWorks("res 7,(hl)", 0xBE);
            CodeEmitWorks("res 7,a", 0xBF);
        }

        [TestMethod]
        public void SetOpsWorkAsExpected()
        {
            CodeEmitWorks("set 0,b", 0xC0);
            CodeEmitWorks("set 0,c", 0xC1);
            CodeEmitWorks("set 0,d", 0xC2);
            CodeEmitWorks("set 0,e", 0xC3);
            CodeEmitWorks("set 0,h", 0xC4);
            CodeEmitWorks("set 0,l", 0xC5);
            CodeEmitWorks("set 0,(hl)", 0xC6);
            CodeEmitWorks("set 0,a", 0xC7);

            CodeEmitWorks("set 1,b", 0xC8);
            CodeEmitWorks("set 1,c", 0xC9);
            CodeEmitWorks("set 1,d", 0xCA);
            CodeEmitWorks("set 1,e", 0xCB);
            CodeEmitWorks("set 1,h", 0xCC);
            CodeEmitWorks("set 1,l", 0xCD);
            CodeEmitWorks("set 1,(hl)", 0xCE);
            CodeEmitWorks("set 1,a", 0xCF);

            CodeEmitWorks("set 2,b", 0xD0);
            CodeEmitWorks("set 2,c", 0xD1);
            CodeEmitWorks("set 2,d", 0xD2);
            CodeEmitWorks("set 2,e", 0xD3);
            CodeEmitWorks("set 2,h", 0xD4);
            CodeEmitWorks("set 2,l", 0xD5);
            CodeEmitWorks("set 2,(hl)", 0xD6);
            CodeEmitWorks("set 2,a", 0xD7);

            CodeEmitWorks("set 3,b", 0xD8);
            CodeEmitWorks("set 3,c", 0xD9);
            CodeEmitWorks("set 3,d", 0xDA);
            CodeEmitWorks("set 3,e", 0xDB);
            CodeEmitWorks("set 3,h", 0xDC);
            CodeEmitWorks("set 3,l", 0xDD);
            CodeEmitWorks("set 3,(hl)", 0xDE);
            CodeEmitWorks("set 3,a", 0xDF);

            CodeEmitWorks("set 4,b", 0xE0);
            CodeEmitWorks("set 4,c", 0xE1);
            CodeEmitWorks("set 4,d", 0xE2);
            CodeEmitWorks("set 4,e", 0xE3);
            CodeEmitWorks("set 4,h", 0xE4);
            CodeEmitWorks("set 4,l", 0xE5);
            CodeEmitWorks("set 4,(hl)", 0xE6);
            CodeEmitWorks("set 4,a", 0xE7);

            CodeEmitWorks("set 5,b", 0xE8);
            CodeEmitWorks("set 5,c", 0xE9);
            CodeEmitWorks("set 5,d", 0xEA);
            CodeEmitWorks("set 5,e", 0xEB);
            CodeEmitWorks("set 5,h", 0xEC);
            CodeEmitWorks("set 5,l", 0xED);
            CodeEmitWorks("set 5,(hl)", 0xEE);
            CodeEmitWorks("set 5,a", 0xEF);

            CodeEmitWorks("set 6,b", 0xF0);
            CodeEmitWorks("set 6,c", 0xF1);
            CodeEmitWorks("set 6,d", 0xF2);
            CodeEmitWorks("set 6,e", 0xF3);
            CodeEmitWorks("set 6,h", 0xF4);
            CodeEmitWorks("set 6,l", 0xF5);
            CodeEmitWorks("set 6,(hl)", 0xF6);
            CodeEmitWorks("set 6,a", 0xF7);

            CodeEmitWorks("set 7,b", 0xF8);
            CodeEmitWorks("set 7,c", 0xF9);
            CodeEmitWorks("set 7,d", 0xFA);
            CodeEmitWorks("set 7,e", 0xFB);
            CodeEmitWorks("set 7,h", 0xFC);
            CodeEmitWorks("set 7,l", 0xFD);
            CodeEmitWorks("set 7,(hl)", 0xFE);
            CodeEmitWorks("set 7,a", 0xFF);
        }

        [TestMethod]
        public void BitWithInvalidBitIndexRaisesError()
        {
            // --- Arrange
            var compiler = new Z80Assembler();

            // --- Act
            var output = compiler.Compile("bit 12,a");

            // --- Assert
            output.ErrorCount.ShouldBe(1);
            output.Errors[0].ShouldBeOfType<InvalidArgumentError>();
        }

        [TestMethod]
        public void ResWithInvalidBitIndexRaisesError()
        {
            // --- Arrange
            var compiler = new Z80Assembler();

            // --- Act
            var output = compiler.Compile("res -2,a");

            // --- Assert
            output.ErrorCount.ShouldBe(1);
            output.Errors[0].ShouldBeOfType<InvalidArgumentError>();
        }

        [TestMethod]
        public void SetWithInvalidBitIndexRaisesError()
        {
            // --- Arrange
            var compiler = new Z80Assembler();

            // --- Act
            var output = compiler.Compile("set 2+6,a");

            // --- Assert
            output.ErrorCount.ShouldBe(1);
            output.Errors[0].ShouldBeOfType<InvalidArgumentError>();
        }

        [TestMethod]
        public void OpsAcceptBitIndexExpression()
        {
            CodeEmitWorks("bit [3+4]*0,b", 0x40);
            CodeEmitWorks("res [3+4]*1,b", 0xB8);
            CodeEmitWorks("set [3+4]*2/3,c", 0xE1);
        }

        [TestMethod]
        public void BitWithUnresolvedBitIndexRaisesError()
        {
            // --- Arrange
            var compiler = new Z80Assembler();

            // --- Act
            var output = compiler.Compile("bit BitIndex,a");

            // --- Assert
            output.ErrorCount.ShouldBe(1);
            output.Errors[0].ShouldBeOfType<InvalidArgumentError>();
        }

        [TestMethod]
        public void ResWithUnresolvedBitIndexRaisesError()
        {
            // --- Arrange
            var compiler = new Z80Assembler();

            // --- Act
            var output = compiler.Compile("res BitIndex,a");

            // --- Assert
            output.ErrorCount.ShouldBe(1);
            output.Errors[0].ShouldBeOfType<InvalidArgumentError>();
        }

        [TestMethod]
        public void SetWithUnresolvedBitIndexRaisesError()
        {
            // --- Arrange
            var compiler = new Z80Assembler();

            // --- Act
            var output = compiler.Compile("set BitIndex,a");

            // --- Assert
            output.ErrorCount.ShouldBe(1);
            output.Errors[0].ShouldBeOfType<InvalidArgumentError>();
        }

        [TestMethod]
        public void IxIndexedBitOpsWorkAsExpected()
        {
            CodeEmitWorks("bit 0,(ix)", 0xDD, 0x40, 0x00);
            CodeEmitWorks("bit 0,(ix+6)", 0xDD, 0x40, 0x06);
            CodeEmitWorks("bit 0,(ix-#0c)", 0xDD, 0x40, 0xF4);
            CodeEmitWorks("bit 1,(ix)", 0xDD, 0x48, 0x00);
            CodeEmitWorks("bit 1,(ix+6)", 0xDD, 0x48, 0x06);
            CodeEmitWorks("bit 1,(ix-#0c)", 0xDD, 0x48, 0xF4);
            CodeEmitWorks("bit 2,(ix)", 0xDD, 0x50, 0x00);
            CodeEmitWorks("bit 2,(ix+6)", 0xDD, 0x50, 0x06);
            CodeEmitWorks("bit 2,(ix-#0c)", 0xDD, 0x50, 0xF4);
            CodeEmitWorks("bit 3,(ix)", 0xDD, 0x58, 0x00);
            CodeEmitWorks("bit 3,(ix+6)", 0xDD, 0x58, 0x06);
            CodeEmitWorks("bit 3,(ix-#0c)", 0xDD, 0x58, 0xF4);
            CodeEmitWorks("bit 4,(ix)", 0xDD, 0x60, 0x00);
            CodeEmitWorks("bit 4,(ix+6)", 0xDD, 0x60, 0x06);
            CodeEmitWorks("bit 4,(ix-#0c)", 0xDD, 0x60, 0xF4);
            CodeEmitWorks("bit 5,(ix)", 0xDD, 0x68, 0x00);
            CodeEmitWorks("bit 5,(ix+6)", 0xDD, 0x68, 0x06);
            CodeEmitWorks("bit 5,(ix-#0c)", 0xDD, 0x68, 0xF4);
            CodeEmitWorks("bit 6,(ix)", 0xDD, 0x70, 0x00);
            CodeEmitWorks("bit 6,(ix+6)", 0xDD, 0x70, 0x06);
            CodeEmitWorks("bit 6,(ix-#0c)", 0xDD, 0x70, 0xF4);
            CodeEmitWorks("bit 7,(ix)", 0xDD, 0x78, 0x00);
            CodeEmitWorks("bit 7,(ix+6)", 0xDD, 0x78, 0x06);
            CodeEmitWorks("bit 7,(ix-#0c)", 0xDD, 0x78, 0xF4);
        }

        [TestMethod]
        public void IyIndexedBitOpsWorkAsExpected()
        {
            CodeEmitWorks("bit 0,(iy)", 0xFD, 0x40, 0x00);
            CodeEmitWorks("bit 0,(iy+6)", 0xFD, 0x40, 0x06);
            CodeEmitWorks("bit 0,(iy-#0c)", 0xFD, 0x40, 0xF4);
            CodeEmitWorks("bit 1,(iy)", 0xFD, 0x48, 0x00);
            CodeEmitWorks("bit 1,(iy+6)", 0xFD, 0x48, 0x06);
            CodeEmitWorks("bit 1,(iy-#0c)", 0xFD, 0x48, 0xF4);
            CodeEmitWorks("bit 2,(iy)", 0xFD, 0x50, 0x00);
            CodeEmitWorks("bit 2,(iy+6)", 0xFD, 0x50, 0x06);
            CodeEmitWorks("bit 2,(iy-#0c)", 0xFD, 0x50, 0xF4);
            CodeEmitWorks("bit 3,(iy)", 0xFD, 0x58, 0x00);
            CodeEmitWorks("bit 3,(iy+6)", 0xFD, 0x58, 0x06);
            CodeEmitWorks("bit 3,(iy-#0c)", 0xFD, 0x58, 0xF4);
            CodeEmitWorks("bit 4,(iy)", 0xFD, 0x60, 0x00);
            CodeEmitWorks("bit 4,(iy+6)", 0xFD, 0x60, 0x06);
            CodeEmitWorks("bit 4,(iy-#0c)", 0xFD, 0x60, 0xF4);
            CodeEmitWorks("bit 5,(iy)", 0xFD, 0x68, 0x00);
            CodeEmitWorks("bit 5,(iy+6)", 0xFD, 0x68, 0x06);
            CodeEmitWorks("bit 5,(iy-#0c)", 0xFD, 0x68, 0xF4);
            CodeEmitWorks("bit 6,(iy)", 0xFD, 0x70, 0x00);
            CodeEmitWorks("bit 6,(iy+6)", 0xFD, 0x70, 0x06);
            CodeEmitWorks("bit 6,(iy-#0c)", 0xFD, 0x70, 0xF4);
            CodeEmitWorks("bit 7,(iy)", 0xFD, 0x78, 0x00);
            CodeEmitWorks("bit 7,(iy+6)", 0xFD, 0x78, 0x06);
            CodeEmitWorks("bit 7,(iy-#0c)", 0xFD, 0x78, 0xF4);
        }

        [TestMethod]
        public void IxIndexedResOpsWorkAsExpected()
        {
            CodeEmitWorks("res 0,(ix),b", 0xDD, 0x80, 0x00);
            CodeEmitWorks("res 0,(ix+6),b", 0xDD, 0x80, 0x06);
            CodeEmitWorks("res 0,(ix-#0c),b", 0xDD, 0x80, 0xF4);
            CodeEmitWorks("res 0,(ix),c", 0xDD, 0x81, 0x00);
            CodeEmitWorks("res 0,(ix+6),c", 0xDD, 0x81, 0x06);
            CodeEmitWorks("res 0,(ix-#0c),c", 0xDD, 0x81, 0xF4);
            CodeEmitWorks("res 0,(ix),d", 0xDD, 0x82, 0x00);
            CodeEmitWorks("res 0,(ix+6),d", 0xDD, 0x82, 0x06);
            CodeEmitWorks("res 0,(ix-#0c),d", 0xDD, 0x82, 0xF4);
            CodeEmitWorks("res 0,(ix),e", 0xDD, 0x83, 0x00);
            CodeEmitWorks("res 0,(ix+6),e", 0xDD, 0x83, 0x06);
            CodeEmitWorks("res 0,(ix-#0c),e", 0xDD, 0x83, 0xF4);
            CodeEmitWorks("res 0,(ix),h", 0xDD, 0x84, 0x00);
            CodeEmitWorks("res 0,(ix+6),h", 0xDD, 0x84, 0x06);
            CodeEmitWorks("res 0,(ix-#0c),h", 0xDD, 0x84, 0xF4);
            CodeEmitWorks("res 0,(ix),l", 0xDD, 0x85, 0x00);
            CodeEmitWorks("res 0,(ix+6),l", 0xDD, 0x85, 0x06);
            CodeEmitWorks("res 0,(ix-#0c),l", 0xDD, 0x85, 0xF4);
            CodeEmitWorks("res 0,(ix)", 0xDD, 0x86, 0x00);
            CodeEmitWorks("res 0,(ix+6)", 0xDD, 0x86, 0x06);
            CodeEmitWorks("res 0,(ix-#0c)", 0xDD, 0x86, 0xF4);
            CodeEmitWorks("res 0,(ix),a", 0xDD, 0x87, 0x00);
            CodeEmitWorks("res 0,(ix+6),a", 0xDD, 0x87, 0x06);
            CodeEmitWorks("res 0,(ix-#0c),a", 0xDD, 0x87, 0xF4);

            CodeEmitWorks("res 1,(ix),b", 0xDD, 0x88, 0x00);
            CodeEmitWorks("res 1,(ix+6),b", 0xDD, 0x88, 0x06);
            CodeEmitWorks("res 1,(ix-#0c),b", 0xDD, 0x88, 0xF4);
            CodeEmitWorks("res 1,(ix),c", 0xDD, 0x89, 0x00);
            CodeEmitWorks("res 1,(ix+6),c", 0xDD, 0x89, 0x06);
            CodeEmitWorks("res 1,(ix-#0c),c", 0xDD, 0x89, 0xF4);
            CodeEmitWorks("res 1,(ix),d", 0xDD, 0x8A, 0x00);
            CodeEmitWorks("res 1,(ix+6),d", 0xDD, 0x8A, 0x06);
            CodeEmitWorks("res 1,(ix-#0c),d", 0xDD, 0x8A, 0xF4);
            CodeEmitWorks("res 1,(ix),e", 0xDD, 0x8B, 0x00);
            CodeEmitWorks("res 1,(ix+6),e", 0xDD, 0x8B, 0x06);
            CodeEmitWorks("res 1,(ix-#0c),e", 0xDD, 0x8B, 0xF4);
            CodeEmitWorks("res 1,(ix),h", 0xDD, 0x8C, 0x00);
            CodeEmitWorks("res 1,(ix+6),h", 0xDD, 0x8C, 0x06);
            CodeEmitWorks("res 1,(ix-#0c),h", 0xDD, 0x8C, 0xF4);
            CodeEmitWorks("res 1,(ix),l", 0xDD, 0x8D, 0x00);
            CodeEmitWorks("res 1,(ix+6),l", 0xDD, 0x8D, 0x06);
            CodeEmitWorks("res 1,(ix-#0c),l", 0xDD, 0x8D, 0xF4);
            CodeEmitWorks("res 1,(ix)", 0xDD, 0x8E, 0x00);
            CodeEmitWorks("res 1,(ix+6)", 0xDD, 0x8E, 0x06);
            CodeEmitWorks("res 1,(ix-#0c)", 0xDD, 0x8E, 0xF4);
            CodeEmitWorks("res 1,(ix),a", 0xDD, 0x8F, 0x00);
            CodeEmitWorks("res 1,(ix+6),a", 0xDD, 0x8F, 0x06);
            CodeEmitWorks("res 1,(ix-#0c),a", 0xDD, 0x8F, 0xF4);

            CodeEmitWorks("res 2,(ix),b", 0xDD, 0x90, 0x00);
            CodeEmitWorks("res 2,(ix+6),b", 0xDD, 0x90, 0x06);
            CodeEmitWorks("res 2,(ix-#0c),b", 0xDD, 0x90, 0xF4);
            CodeEmitWorks("res 2,(ix),c", 0xDD, 0x91, 0x00);
            CodeEmitWorks("res 2,(ix+6),c", 0xDD, 0x91, 0x06);
            CodeEmitWorks("res 2,(ix-#0c),c", 0xDD, 0x91, 0xF4);
            CodeEmitWorks("res 2,(ix),d", 0xDD, 0x92, 0x00);
            CodeEmitWorks("res 2,(ix+6),d", 0xDD, 0x92, 0x06);
            CodeEmitWorks("res 2,(ix-#0c),d", 0xDD, 0x92, 0xF4);
            CodeEmitWorks("res 2,(ix),e", 0xDD, 0x93, 0x00);
            CodeEmitWorks("res 2,(ix+6),e", 0xDD, 0x93, 0x06);
            CodeEmitWorks("res 2,(ix-#0c),e", 0xDD, 0x93, 0xF4);
            CodeEmitWorks("res 2,(ix),h", 0xDD, 0x94, 0x00);
            CodeEmitWorks("res 2,(ix+6),h", 0xDD, 0x94, 0x06);
            CodeEmitWorks("res 2,(ix-#0c),h", 0xDD, 0x94, 0xF4);
            CodeEmitWorks("res 2,(ix),l", 0xDD, 0x95, 0x00);
            CodeEmitWorks("res 2,(ix+6),l", 0xDD, 0x95, 0x06);
            CodeEmitWorks("res 2,(ix-#0c),l", 0xDD, 0x95, 0xF4);
            CodeEmitWorks("res 2,(ix)", 0xDD, 0x96, 0x00);
            CodeEmitWorks("res 2,(ix+6)", 0xDD, 0x96, 0x06);
            CodeEmitWorks("res 2,(ix-#0c)", 0xDD, 0x96, 0xF4);
            CodeEmitWorks("res 2,(ix),a", 0xDD, 0x97, 0x00);
            CodeEmitWorks("res 2,(ix+6),a", 0xDD, 0x97, 0x06);
            CodeEmitWorks("res 2,(ix-#0c),a", 0xDD, 0x97, 0xF4);

            CodeEmitWorks("res 3,(ix),b", 0xDD, 0x98, 0x00);
            CodeEmitWorks("res 3,(ix+6),b", 0xDD, 0x98, 0x06);
            CodeEmitWorks("res 3,(ix-#0c),b", 0xDD, 0x98, 0xF4);
            CodeEmitWorks("res 3,(ix),c", 0xDD, 0x99, 0x00);
            CodeEmitWorks("res 3,(ix+6),c", 0xDD, 0x99, 0x06);
            CodeEmitWorks("res 3,(ix-#0c),c", 0xDD, 0x99, 0xF4);
            CodeEmitWorks("res 3,(ix),d", 0xDD, 0x9A, 0x00);
            CodeEmitWorks("res 3,(ix+6),d", 0xDD, 0x9A, 0x06);
            CodeEmitWorks("res 3,(ix-#0c),d", 0xDD, 0x9A, 0xF4);
            CodeEmitWorks("res 3,(ix),e", 0xDD, 0x9B, 0x00);
            CodeEmitWorks("res 3,(ix+6),e", 0xDD, 0x9B, 0x06);
            CodeEmitWorks("res 3,(ix-#0c),e", 0xDD, 0x9B, 0xF4);
            CodeEmitWorks("res 3,(ix),h", 0xDD, 0x9C, 0x00);
            CodeEmitWorks("res 3,(ix+6),h", 0xDD, 0x9C, 0x06);
            CodeEmitWorks("res 3,(ix-#0c),h", 0xDD, 0x9C, 0xF4);
            CodeEmitWorks("res 3,(ix),l", 0xDD, 0x9D, 0x00);
            CodeEmitWorks("res 3,(ix+6),l", 0xDD, 0x9D, 0x06);
            CodeEmitWorks("res 3,(ix-#0c),l", 0xDD, 0x9D, 0xF4);
            CodeEmitWorks("res 3,(ix)", 0xDD, 0x9E, 0x00);
            CodeEmitWorks("res 3,(ix+6)", 0xDD, 0x9E, 0x06);
            CodeEmitWorks("res 3,(ix-#0c)", 0xDD, 0x9E, 0xF4);
            CodeEmitWorks("res 3,(ix),a", 0xDD, 0x9F, 0x00);
            CodeEmitWorks("res 3,(ix+6),a", 0xDD, 0x9F, 0x06);
            CodeEmitWorks("res 3,(ix-#0c),a", 0xDD, 0x9F, 0xF4);

            CodeEmitWorks("res 4,(ix),b", 0xDD, 0xA0, 0x00);
            CodeEmitWorks("res 4,(ix+6),b", 0xDD, 0xA0, 0x06);
            CodeEmitWorks("res 4,(ix-#0c),b", 0xDD, 0xA0, 0xF4);
            CodeEmitWorks("res 4,(ix),c", 0xDD, 0xA1, 0x00);
            CodeEmitWorks("res 4,(ix+6),c", 0xDD, 0xA1, 0x06);
            CodeEmitWorks("res 4,(ix-#0c),c", 0xDD, 0xA1, 0xF4);
            CodeEmitWorks("res 4,(ix),d", 0xDD, 0xA2, 0x00);
            CodeEmitWorks("res 4,(ix+6),d", 0xDD, 0xA2, 0x06);
            CodeEmitWorks("res 4,(ix-#0c),d", 0xDD, 0xA2, 0xF4);
            CodeEmitWorks("res 4,(ix),e", 0xDD, 0xA3, 0x00);
            CodeEmitWorks("res 4,(ix+6),e", 0xDD, 0xA3, 0x06);
            CodeEmitWorks("res 4,(ix-#0c),e", 0xDD, 0xA3, 0xF4);
            CodeEmitWorks("res 4,(ix),h", 0xDD, 0xA4, 0x00);
            CodeEmitWorks("res 4,(ix+6),h", 0xDD, 0xA4, 0x06);
            CodeEmitWorks("res 4,(ix-#0c),h", 0xDD, 0xA4, 0xF4);
            CodeEmitWorks("res 4,(ix),l", 0xDD, 0xA5, 0x00);
            CodeEmitWorks("res 4,(ix+6),l", 0xDD, 0xA5, 0x06);
            CodeEmitWorks("res 4,(ix-#0c),l", 0xDD, 0xA5, 0xF4);
            CodeEmitWorks("res 4,(ix)", 0xDD, 0xA6, 0x00);
            CodeEmitWorks("res 4,(ix+6)", 0xDD, 0xA6, 0x06);
            CodeEmitWorks("res 4,(ix-#0c)", 0xDD, 0xA6, 0xF4);
            CodeEmitWorks("res 4,(ix),a", 0xDD, 0xA7, 0x00);
            CodeEmitWorks("res 4,(ix+6),a", 0xDD, 0xA7, 0x06);
            CodeEmitWorks("res 4,(ix-#0c),a", 0xDD, 0xA7, 0xF4);

            CodeEmitWorks("res 5,(ix),b", 0xDD, 0xA8, 0x00);
            CodeEmitWorks("res 5,(ix+6),b", 0xDD, 0xA8, 0x06);
            CodeEmitWorks("res 5,(ix-#0c),b", 0xDD, 0xA8, 0xF4);
            CodeEmitWorks("res 5,(ix),c", 0xDD, 0xA9, 0x00);
            CodeEmitWorks("res 5,(ix+6),c", 0xDD, 0xA9, 0x06);
            CodeEmitWorks("res 5,(ix-#0c),c", 0xDD, 0xA9, 0xF4);
            CodeEmitWorks("res 5,(ix),d", 0xDD, 0xAA, 0x00);
            CodeEmitWorks("res 5,(ix+6),d", 0xDD, 0xAA, 0x06);
            CodeEmitWorks("res 5,(ix-#0c),d", 0xDD, 0xAA, 0xF4);
            CodeEmitWorks("res 5,(ix),e", 0xDD, 0xAB, 0x00);
            CodeEmitWorks("res 5,(ix+6),e", 0xDD, 0xAB, 0x06);
            CodeEmitWorks("res 5,(ix-#0c),e", 0xDD, 0xAB, 0xF4);
            CodeEmitWorks("res 5,(ix),h", 0xDD, 0xAC, 0x00);
            CodeEmitWorks("res 5,(ix+6),h", 0xDD, 0xAC, 0x06);
            CodeEmitWorks("res 5,(ix-#0c),h", 0xDD, 0xAC, 0xF4);
            CodeEmitWorks("res 5,(ix),l", 0xDD, 0xAD, 0x00);
            CodeEmitWorks("res 5,(ix+6),l", 0xDD, 0xAD, 0x06);
            CodeEmitWorks("res 5,(ix-#0c),l", 0xDD, 0xAD, 0xF4);
            CodeEmitWorks("res 5,(ix)", 0xDD, 0xAE, 0x00);
            CodeEmitWorks("res 5,(ix+6)", 0xDD, 0xAE, 0x06);
            CodeEmitWorks("res 5,(ix-#0c)", 0xDD, 0xAE, 0xF4);
            CodeEmitWorks("res 5,(ix),a", 0xDD, 0xAF, 0x00);
            CodeEmitWorks("res 5,(ix+6),a", 0xDD, 0xAF, 0x06);
            CodeEmitWorks("res 5,(ix-#0c),a", 0xDD, 0xAF, 0xF4);

            CodeEmitWorks("res 6,(ix),b", 0xDD, 0xB0, 0x00);
            CodeEmitWorks("res 6,(ix+6),b", 0xDD, 0xB0, 0x06);
            CodeEmitWorks("res 6,(ix-#0c),b", 0xDD, 0xB0, 0xF4);
            CodeEmitWorks("res 6,(ix),c", 0xDD, 0xB1, 0x00);
            CodeEmitWorks("res 6,(ix+6),c", 0xDD, 0xB1, 0x06);
            CodeEmitWorks("res 6,(ix-#0c),c", 0xDD, 0xB1, 0xF4);
            CodeEmitWorks("res 6,(ix),d", 0xDD, 0xB2, 0x00);
            CodeEmitWorks("res 6,(ix+6),d", 0xDD, 0xB2, 0x06);
            CodeEmitWorks("res 6,(ix-#0c),d", 0xDD, 0xB2, 0xF4);
            CodeEmitWorks("res 6,(ix),e", 0xDD, 0xB3, 0x00);
            CodeEmitWorks("res 6,(ix+6),e", 0xDD, 0xB3, 0x06);
            CodeEmitWorks("res 6,(ix-#0c),e", 0xDD, 0xB3, 0xF4);
            CodeEmitWorks("res 6,(ix),h", 0xDD, 0xB4, 0x00);
            CodeEmitWorks("res 6,(ix+6),h", 0xDD, 0xB4, 0x06);
            CodeEmitWorks("res 6,(ix-#0c),h", 0xDD, 0xB4, 0xF4);
            CodeEmitWorks("res 6,(ix),l", 0xDD, 0xB5, 0x00);
            CodeEmitWorks("res 6,(ix+6),l", 0xDD, 0xB5, 0x06);
            CodeEmitWorks("res 6,(ix-#0c),l", 0xDD, 0xB5, 0xF4);
            CodeEmitWorks("res 6,(ix)", 0xDD, 0xB6, 0x00);
            CodeEmitWorks("res 6,(ix+6)", 0xDD, 0xB6, 0x06);
            CodeEmitWorks("res 6,(ix-#0c)", 0xDD, 0xB6, 0xF4);
            CodeEmitWorks("res 6,(ix),a", 0xDD, 0xB7, 0x00);
            CodeEmitWorks("res 6,(ix+6),a", 0xDD, 0xB7, 0x06);
            CodeEmitWorks("res 6,(ix-#0c),a", 0xDD, 0xB7, 0xF4);

            CodeEmitWorks("res 7,(ix),b", 0xDD, 0xB8, 0x00);
            CodeEmitWorks("res 7,(ix+6),b", 0xDD, 0xB8, 0x06);
            CodeEmitWorks("res 7,(ix-#0c),b", 0xDD, 0xB8, 0xF4);
            CodeEmitWorks("res 7,(ix),c", 0xDD, 0xB9, 0x00);
            CodeEmitWorks("res 7,(ix+6),c", 0xDD, 0xB9, 0x06);
            CodeEmitWorks("res 7,(ix-#0c),c", 0xDD, 0xB9, 0xF4);
            CodeEmitWorks("res 7,(ix),d", 0xDD, 0xBA, 0x00);
            CodeEmitWorks("res 7,(ix+6),d", 0xDD, 0xBA, 0x06);
            CodeEmitWorks("res 7,(ix-#0c),d", 0xDD, 0xBA, 0xF4);
            CodeEmitWorks("res 7,(ix),e", 0xDD, 0xBB, 0x00);
            CodeEmitWorks("res 7,(ix+6),e", 0xDD, 0xBB, 0x06);
            CodeEmitWorks("res 7,(ix-#0c),e", 0xDD, 0xBB, 0xF4);
            CodeEmitWorks("res 7,(ix),h", 0xDD, 0xBC, 0x00);
            CodeEmitWorks("res 7,(ix+6),h", 0xDD, 0xBC, 0x06);
            CodeEmitWorks("res 7,(ix-#0c),h", 0xDD, 0xBC, 0xF4);
            CodeEmitWorks("res 7,(ix),l", 0xDD, 0xBD, 0x00);
            CodeEmitWorks("res 7,(ix+6),l", 0xDD, 0xBD, 0x06);
            CodeEmitWorks("res 7,(ix-#0c),l", 0xDD, 0xBD, 0xF4);
            CodeEmitWorks("res 7,(ix)", 0xDD, 0xBE, 0x00);
            CodeEmitWorks("res 7,(ix+6)", 0xDD, 0xBE, 0x06);
            CodeEmitWorks("res 7,(ix-#0c)", 0xDD, 0xBE, 0xF4);
            CodeEmitWorks("res 7,(ix),a", 0xDD, 0xBF, 0x00);
            CodeEmitWorks("res 7,(ix+6),a", 0xDD, 0xBF, 0x06);
            CodeEmitWorks("res 7,(ix-#0c),a", 0xDD, 0xBF, 0xF4);
        }

        [TestMethod]
        public void IyIndexedResOpsWorkAsExpected()
        {
            CodeEmitWorks("res 0,(iy),b", 0xFD, 0x80, 0x00);
            CodeEmitWorks("res 0,(iy+6),b", 0xFD, 0x80, 0x06);
            CodeEmitWorks("res 0,(iy-#0c),b", 0xFD, 0x80, 0xF4);
            CodeEmitWorks("res 0,(iy),c", 0xFD, 0x81, 0x00);
            CodeEmitWorks("res 0,(iy+6),c", 0xFD, 0x81, 0x06);
            CodeEmitWorks("res 0,(iy-#0c),c", 0xFD, 0x81, 0xF4);
            CodeEmitWorks("res 0,(iy),d", 0xFD, 0x82, 0x00);
            CodeEmitWorks("res 0,(iy+6),d", 0xFD, 0x82, 0x06);
            CodeEmitWorks("res 0,(iy-#0c),d", 0xFD, 0x82, 0xF4);
            CodeEmitWorks("res 0,(iy),e", 0xFD, 0x83, 0x00);
            CodeEmitWorks("res 0,(iy+6),e", 0xFD, 0x83, 0x06);
            CodeEmitWorks("res 0,(iy-#0c),e", 0xFD, 0x83, 0xF4);
            CodeEmitWorks("res 0,(iy),h", 0xFD, 0x84, 0x00);
            CodeEmitWorks("res 0,(iy+6),h", 0xFD, 0x84, 0x06);
            CodeEmitWorks("res 0,(iy-#0c),h", 0xFD, 0x84, 0xF4);
            CodeEmitWorks("res 0,(iy),l", 0xFD, 0x85, 0x00);
            CodeEmitWorks("res 0,(iy+6),l", 0xFD, 0x85, 0x06);
            CodeEmitWorks("res 0,(iy-#0c),l", 0xFD, 0x85, 0xF4);
            CodeEmitWorks("res 0,(iy)", 0xFD, 0x86, 0x00);
            CodeEmitWorks("res 0,(iy+6)", 0xFD, 0x86, 0x06);
            CodeEmitWorks("res 0,(iy-#0c)", 0xFD, 0x86, 0xF4);
            CodeEmitWorks("res 0,(iy),a", 0xFD, 0x87, 0x00);
            CodeEmitWorks("res 0,(iy+6),a", 0xFD, 0x87, 0x06);
            CodeEmitWorks("res 0,(iy-#0c),a", 0xFD, 0x87, 0xF4);

            CodeEmitWorks("res 1,(iy),b", 0xFD, 0x88, 0x00);
            CodeEmitWorks("res 1,(iy+6),b", 0xFD, 0x88, 0x06);
            CodeEmitWorks("res 1,(iy-#0c),b", 0xFD, 0x88, 0xF4);
            CodeEmitWorks("res 1,(iy),c", 0xFD, 0x89, 0x00);
            CodeEmitWorks("res 1,(iy+6),c", 0xFD, 0x89, 0x06);
            CodeEmitWorks("res 1,(iy-#0c),c", 0xFD, 0x89, 0xF4);
            CodeEmitWorks("res 1,(iy),d", 0xFD, 0x8A, 0x00);
            CodeEmitWorks("res 1,(iy+6),d", 0xFD, 0x8A, 0x06);
            CodeEmitWorks("res 1,(iy-#0c),d", 0xFD, 0x8A, 0xF4);
            CodeEmitWorks("res 1,(iy),e", 0xFD, 0x8B, 0x00);
            CodeEmitWorks("res 1,(iy+6),e", 0xFD, 0x8B, 0x06);
            CodeEmitWorks("res 1,(iy-#0c),e", 0xFD, 0x8B, 0xF4);
            CodeEmitWorks("res 1,(iy),h", 0xFD, 0x8C, 0x00);
            CodeEmitWorks("res 1,(iy+6),h", 0xFD, 0x8C, 0x06);
            CodeEmitWorks("res 1,(iy-#0c),h", 0xFD, 0x8C, 0xF4);
            CodeEmitWorks("res 1,(iy),l", 0xFD, 0x8D, 0x00);
            CodeEmitWorks("res 1,(iy+6),l", 0xFD, 0x8D, 0x06);
            CodeEmitWorks("res 1,(iy-#0c),l", 0xFD, 0x8D, 0xF4);
            CodeEmitWorks("res 1,(iy)", 0xFD, 0x8E, 0x00);
            CodeEmitWorks("res 1,(iy+6)", 0xFD, 0x8E, 0x06);
            CodeEmitWorks("res 1,(iy-#0c)", 0xFD, 0x8E, 0xF4);
            CodeEmitWorks("res 1,(iy),a", 0xFD, 0x8F, 0x00);
            CodeEmitWorks("res 1,(iy+6),a", 0xFD, 0x8F, 0x06);
            CodeEmitWorks("res 1,(iy-#0c),a", 0xFD, 0x8F, 0xF4);

            CodeEmitWorks("res 2,(iy),b", 0xFD, 0x90, 0x00);
            CodeEmitWorks("res 2,(iy+6),b", 0xFD, 0x90, 0x06);
            CodeEmitWorks("res 2,(iy-#0c),b", 0xFD, 0x90, 0xF4);
            CodeEmitWorks("res 2,(iy),c", 0xFD, 0x91, 0x00);
            CodeEmitWorks("res 2,(iy+6),c", 0xFD, 0x91, 0x06);
            CodeEmitWorks("res 2,(iy-#0c),c", 0xFD, 0x91, 0xF4);
            CodeEmitWorks("res 2,(iy),d", 0xFD, 0x92, 0x00);
            CodeEmitWorks("res 2,(iy+6),d", 0xFD, 0x92, 0x06);
            CodeEmitWorks("res 2,(iy-#0c),d", 0xFD, 0x92, 0xF4);
            CodeEmitWorks("res 2,(iy),e", 0xFD, 0x93, 0x00);
            CodeEmitWorks("res 2,(iy+6),e", 0xFD, 0x93, 0x06);
            CodeEmitWorks("res 2,(iy-#0c),e", 0xFD, 0x93, 0xF4);
            CodeEmitWorks("res 2,(iy),h", 0xFD, 0x94, 0x00);
            CodeEmitWorks("res 2,(iy+6),h", 0xFD, 0x94, 0x06);
            CodeEmitWorks("res 2,(iy-#0c),h", 0xFD, 0x94, 0xF4);
            CodeEmitWorks("res 2,(iy),l", 0xFD, 0x95, 0x00);
            CodeEmitWorks("res 2,(iy+6),l", 0xFD, 0x95, 0x06);
            CodeEmitWorks("res 2,(iy-#0c),l", 0xFD, 0x95, 0xF4);
            CodeEmitWorks("res 2,(iy)", 0xFD, 0x96, 0x00);
            CodeEmitWorks("res 2,(iy+6)", 0xFD, 0x96, 0x06);
            CodeEmitWorks("res 2,(iy-#0c)", 0xFD, 0x96, 0xF4);
            CodeEmitWorks("res 2,(iy),a", 0xFD, 0x97, 0x00);
            CodeEmitWorks("res 2,(iy+6),a", 0xFD, 0x97, 0x06);
            CodeEmitWorks("res 2,(iy-#0c),a", 0xFD, 0x97, 0xF4);

            CodeEmitWorks("res 3,(iy),b", 0xFD, 0x98, 0x00);
            CodeEmitWorks("res 3,(iy+6),b", 0xFD, 0x98, 0x06);
            CodeEmitWorks("res 3,(iy-#0c),b", 0xFD, 0x98, 0xF4);
            CodeEmitWorks("res 3,(iy),c", 0xFD, 0x99, 0x00);
            CodeEmitWorks("res 3,(iy+6),c", 0xFD, 0x99, 0x06);
            CodeEmitWorks("res 3,(iy-#0c),c", 0xFD, 0x99, 0xF4);
            CodeEmitWorks("res 3,(iy),d", 0xFD, 0x9A, 0x00);
            CodeEmitWorks("res 3,(iy+6),d", 0xFD, 0x9A, 0x06);
            CodeEmitWorks("res 3,(iy-#0c),d", 0xFD, 0x9A, 0xF4);
            CodeEmitWorks("res 3,(iy),e", 0xFD, 0x9B, 0x00);
            CodeEmitWorks("res 3,(iy+6),e", 0xFD, 0x9B, 0x06);
            CodeEmitWorks("res 3,(iy-#0c),e", 0xFD, 0x9B, 0xF4);
            CodeEmitWorks("res 3,(iy),h", 0xFD, 0x9C, 0x00);
            CodeEmitWorks("res 3,(iy+6),h", 0xFD, 0x9C, 0x06);
            CodeEmitWorks("res 3,(iy-#0c),h", 0xFD, 0x9C, 0xF4);
            CodeEmitWorks("res 3,(iy),l", 0xFD, 0x9D, 0x00);
            CodeEmitWorks("res 3,(iy+6),l", 0xFD, 0x9D, 0x06);
            CodeEmitWorks("res 3,(iy-#0c),l", 0xFD, 0x9D, 0xF4);
            CodeEmitWorks("res 3,(iy)", 0xFD, 0x9E, 0x00);
            CodeEmitWorks("res 3,(iy+6)", 0xFD, 0x9E, 0x06);
            CodeEmitWorks("res 3,(iy-#0c)", 0xFD, 0x9E, 0xF4);
            CodeEmitWorks("res 3,(iy),a", 0xFD, 0x9F, 0x00);
            CodeEmitWorks("res 3,(iy+6),a", 0xFD, 0x9F, 0x06);
            CodeEmitWorks("res 3,(iy-#0c),a", 0xFD, 0x9F, 0xF4);

            CodeEmitWorks("res 4,(iy),b", 0xFD, 0xA0, 0x00);
            CodeEmitWorks("res 4,(iy+6),b", 0xFD, 0xA0, 0x06);
            CodeEmitWorks("res 4,(iy-#0c),b", 0xFD, 0xA0, 0xF4);
            CodeEmitWorks("res 4,(iy),c", 0xFD, 0xA1, 0x00);
            CodeEmitWorks("res 4,(iy+6),c", 0xFD, 0xA1, 0x06);
            CodeEmitWorks("res 4,(iy-#0c),c", 0xFD, 0xA1, 0xF4);
            CodeEmitWorks("res 4,(iy),d", 0xFD, 0xA2, 0x00);
            CodeEmitWorks("res 4,(iy+6),d", 0xFD, 0xA2, 0x06);
            CodeEmitWorks("res 4,(iy-#0c),d", 0xFD, 0xA2, 0xF4);
            CodeEmitWorks("res 4,(iy),e", 0xFD, 0xA3, 0x00);
            CodeEmitWorks("res 4,(iy+6),e", 0xFD, 0xA3, 0x06);
            CodeEmitWorks("res 4,(iy-#0c),e", 0xFD, 0xA3, 0xF4);
            CodeEmitWorks("res 4,(iy),h", 0xFD, 0xA4, 0x00);
            CodeEmitWorks("res 4,(iy+6),h", 0xFD, 0xA4, 0x06);
            CodeEmitWorks("res 4,(iy-#0c),h", 0xFD, 0xA4, 0xF4);
            CodeEmitWorks("res 4,(iy),l", 0xFD, 0xA5, 0x00);
            CodeEmitWorks("res 4,(iy+6),l", 0xFD, 0xA5, 0x06);
            CodeEmitWorks("res 4,(iy-#0c),l", 0xFD, 0xA5, 0xF4);
            CodeEmitWorks("res 4,(iy)", 0xFD, 0xA6, 0x00);
            CodeEmitWorks("res 4,(iy+6)", 0xFD, 0xA6, 0x06);
            CodeEmitWorks("res 4,(iy-#0c)", 0xFD, 0xA6, 0xF4);
            CodeEmitWorks("res 4,(iy),a", 0xFD, 0xA7, 0x00);
            CodeEmitWorks("res 4,(iy+6),a", 0xFD, 0xA7, 0x06);
            CodeEmitWorks("res 4,(iy-#0c),a", 0xFD, 0xA7, 0xF4);

            CodeEmitWorks("res 5,(iy),b", 0xFD, 0xA8, 0x00);
            CodeEmitWorks("res 5,(iy+6),b", 0xFD, 0xA8, 0x06);
            CodeEmitWorks("res 5,(iy-#0c),b", 0xFD, 0xA8, 0xF4);
            CodeEmitWorks("res 5,(iy),c", 0xFD, 0xA9, 0x00);
            CodeEmitWorks("res 5,(iy+6),c", 0xFD, 0xA9, 0x06);
            CodeEmitWorks("res 5,(iy-#0c),c", 0xFD, 0xA9, 0xF4);
            CodeEmitWorks("res 5,(iy),d", 0xFD, 0xAA, 0x00);
            CodeEmitWorks("res 5,(iy+6),d", 0xFD, 0xAA, 0x06);
            CodeEmitWorks("res 5,(iy-#0c),d", 0xFD, 0xAA, 0xF4);
            CodeEmitWorks("res 5,(iy),e", 0xFD, 0xAB, 0x00);
            CodeEmitWorks("res 5,(iy+6),e", 0xFD, 0xAB, 0x06);
            CodeEmitWorks("res 5,(iy-#0c),e", 0xFD, 0xAB, 0xF4);
            CodeEmitWorks("res 5,(iy),h", 0xFD, 0xAC, 0x00);
            CodeEmitWorks("res 5,(iy+6),h", 0xFD, 0xAC, 0x06);
            CodeEmitWorks("res 5,(iy-#0c),h", 0xFD, 0xAC, 0xF4);
            CodeEmitWorks("res 5,(iy),l", 0xFD, 0xAD, 0x00);
            CodeEmitWorks("res 5,(iy+6),l", 0xFD, 0xAD, 0x06);
            CodeEmitWorks("res 5,(iy-#0c),l", 0xFD, 0xAD, 0xF4);
            CodeEmitWorks("res 5,(iy)", 0xFD, 0xAE, 0x00);
            CodeEmitWorks("res 5,(iy+6)", 0xFD, 0xAE, 0x06);
            CodeEmitWorks("res 5,(iy-#0c)", 0xFD, 0xAE, 0xF4);
            CodeEmitWorks("res 5,(iy),a", 0xFD, 0xAF, 0x00);
            CodeEmitWorks("res 5,(iy+6),a", 0xFD, 0xAF, 0x06);
            CodeEmitWorks("res 5,(iy-#0c),a", 0xFD, 0xAF, 0xF4);

            CodeEmitWorks("res 6,(iy),b", 0xFD, 0xB0, 0x00);
            CodeEmitWorks("res 6,(iy+6),b", 0xFD, 0xB0, 0x06);
            CodeEmitWorks("res 6,(iy-#0c),b", 0xFD, 0xB0, 0xF4);
            CodeEmitWorks("res 6,(iy),c", 0xFD, 0xB1, 0x00);
            CodeEmitWorks("res 6,(iy+6),c", 0xFD, 0xB1, 0x06);
            CodeEmitWorks("res 6,(iy-#0c),c", 0xFD, 0xB1, 0xF4);
            CodeEmitWorks("res 6,(iy),d", 0xFD, 0xB2, 0x00);
            CodeEmitWorks("res 6,(iy+6),d", 0xFD, 0xB2, 0x06);
            CodeEmitWorks("res 6,(iy-#0c),d", 0xFD, 0xB2, 0xF4);
            CodeEmitWorks("res 6,(iy),e", 0xFD, 0xB3, 0x00);
            CodeEmitWorks("res 6,(iy+6),e", 0xFD, 0xB3, 0x06);
            CodeEmitWorks("res 6,(iy-#0c),e", 0xFD, 0xB3, 0xF4);
            CodeEmitWorks("res 6,(iy),h", 0xFD, 0xB4, 0x00);
            CodeEmitWorks("res 6,(iy+6),h", 0xFD, 0xB4, 0x06);
            CodeEmitWorks("res 6,(iy-#0c),h", 0xFD, 0xB4, 0xF4);
            CodeEmitWorks("res 6,(iy),l", 0xFD, 0xB5, 0x00);
            CodeEmitWorks("res 6,(iy+6),l", 0xFD, 0xB5, 0x06);
            CodeEmitWorks("res 6,(iy-#0c),l", 0xFD, 0xB5, 0xF4);
            CodeEmitWorks("res 6,(iy)", 0xFD, 0xB6, 0x00);
            CodeEmitWorks("res 6,(iy+6)", 0xFD, 0xB6, 0x06);
            CodeEmitWorks("res 6,(iy-#0c)", 0xFD, 0xB6, 0xF4);
            CodeEmitWorks("res 6,(iy),a", 0xFD, 0xB7, 0x00);
            CodeEmitWorks("res 6,(iy+6),a", 0xFD, 0xB7, 0x06);
            CodeEmitWorks("res 6,(iy-#0c),a", 0xFD, 0xB7, 0xF4);

            CodeEmitWorks("res 7,(iy),b", 0xFD, 0xB8, 0x00);
            CodeEmitWorks("res 7,(iy+6),b", 0xFD, 0xB8, 0x06);
            CodeEmitWorks("res 7,(iy-#0c),b", 0xFD, 0xB8, 0xF4);
            CodeEmitWorks("res 7,(iy),c", 0xFD, 0xB9, 0x00);
            CodeEmitWorks("res 7,(iy+6),c", 0xFD, 0xB9, 0x06);
            CodeEmitWorks("res 7,(iy-#0c),c", 0xFD, 0xB9, 0xF4);
            CodeEmitWorks("res 7,(iy),d", 0xFD, 0xBA, 0x00);
            CodeEmitWorks("res 7,(iy+6),d", 0xFD, 0xBA, 0x06);
            CodeEmitWorks("res 7,(iy-#0c),d", 0xFD, 0xBA, 0xF4);
            CodeEmitWorks("res 7,(iy),e", 0xFD, 0xBB, 0x00);
            CodeEmitWorks("res 7,(iy+6),e", 0xFD, 0xBB, 0x06);
            CodeEmitWorks("res 7,(iy-#0c),e", 0xFD, 0xBB, 0xF4);
            CodeEmitWorks("res 7,(iy),h", 0xFD, 0xBC, 0x00);
            CodeEmitWorks("res 7,(iy+6),h", 0xFD, 0xBC, 0x06);
            CodeEmitWorks("res 7,(iy-#0c),h", 0xFD, 0xBC, 0xF4);
            CodeEmitWorks("res 7,(iy),l", 0xFD, 0xBD, 0x00);
            CodeEmitWorks("res 7,(iy+6),l", 0xFD, 0xBD, 0x06);
            CodeEmitWorks("res 7,(iy-#0c),l", 0xFD, 0xBD, 0xF4);
            CodeEmitWorks("res 7,(iy)", 0xFD, 0xBE, 0x00);
            CodeEmitWorks("res 7,(iy+6)", 0xFD, 0xBE, 0x06);
            CodeEmitWorks("res 7,(iy-#0c)", 0xFD, 0xBE, 0xF4);
            CodeEmitWorks("res 7,(iy),a", 0xFD, 0xBF, 0x00);
            CodeEmitWorks("res 7,(iy+6),a", 0xFD, 0xBF, 0x06);
            CodeEmitWorks("res 7,(iy-#0c),a", 0xFD, 0xBF, 0xF4);
        }

        [TestMethod]
        public void IxIndexedSetOpsWorkAsExpected()
        {
            CodeEmitWorks("set 0,(ix),b", 0xDD, 0xC0, 0x00);
            CodeEmitWorks("set 0,(ix+6),b", 0xDD, 0xC0, 0x06);
            CodeEmitWorks("set 0,(ix-#0c),b", 0xDD, 0xC0, 0xF4);
            CodeEmitWorks("set 0,(ix),c", 0xDD, 0xC1, 0x00);
            CodeEmitWorks("set 0,(ix+6),c", 0xDD, 0xC1, 0x06);
            CodeEmitWorks("set 0,(ix-#0c),c", 0xDD, 0xC1, 0xF4);
            CodeEmitWorks("set 0,(ix),d", 0xDD, 0xC2, 0x00);
            CodeEmitWorks("set 0,(ix+6),d", 0xDD, 0xC2, 0x06);
            CodeEmitWorks("set 0,(ix-#0c),d", 0xDD, 0xC2, 0xF4);
            CodeEmitWorks("set 0,(ix),e", 0xDD, 0xC3, 0x00);
            CodeEmitWorks("set 0,(ix+6),e", 0xDD, 0xC3, 0x06);
            CodeEmitWorks("set 0,(ix-#0c),e", 0xDD, 0xC3, 0xF4);
            CodeEmitWorks("set 0,(ix),h", 0xDD, 0xC4, 0x00);
            CodeEmitWorks("set 0,(ix+6),h", 0xDD, 0xC4, 0x06);
            CodeEmitWorks("set 0,(ix-#0c),h", 0xDD, 0xC4, 0xF4);
            CodeEmitWorks("set 0,(ix),l", 0xDD, 0xC5, 0x00);
            CodeEmitWorks("set 0,(ix+6),l", 0xDD, 0xC5, 0x06);
            CodeEmitWorks("set 0,(ix-#0c),l", 0xDD, 0xC5, 0xF4);
            CodeEmitWorks("set 0,(ix)", 0xDD, 0xC6, 0x00);
            CodeEmitWorks("set 0,(ix+6)", 0xDD, 0xC6, 0x06);
            CodeEmitWorks("set 0,(ix-#0c)", 0xDD, 0xC6, 0xF4);
            CodeEmitWorks("set 0,(ix),a", 0xDD, 0xC7, 0x00);
            CodeEmitWorks("set 0,(ix+6),a", 0xDD, 0xC7, 0x06);
            CodeEmitWorks("set 0,(ix-#0c),a", 0xDD, 0xC7, 0xF4);

            CodeEmitWorks("set 1,(ix),b", 0xDD, 0xC8, 0x00);
            CodeEmitWorks("set 1,(ix+6),b", 0xDD, 0xC8, 0x06);
            CodeEmitWorks("set 1,(ix-#0c),b", 0xDD, 0xC8, 0xF4);
            CodeEmitWorks("set 1,(ix),c", 0xDD, 0xC9, 0x00);
            CodeEmitWorks("set 1,(ix+6),c", 0xDD, 0xC9, 0x06);
            CodeEmitWorks("set 1,(ix-#0c),c", 0xDD, 0xC9, 0xF4);
            CodeEmitWorks("set 1,(ix),d", 0xDD, 0xCA, 0x00);
            CodeEmitWorks("set 1,(ix+6),d", 0xDD, 0xCA, 0x06);
            CodeEmitWorks("set 1,(ix-#0c),d", 0xDD, 0xCA, 0xF4);
            CodeEmitWorks("set 1,(ix),e", 0xDD, 0xCB, 0x00);
            CodeEmitWorks("set 1,(ix+6),e", 0xDD, 0xCB, 0x06);
            CodeEmitWorks("set 1,(ix-#0c),e", 0xDD, 0xCB, 0xF4);
            CodeEmitWorks("set 1,(ix),h", 0xDD, 0xCC, 0x00);
            CodeEmitWorks("set 1,(ix+6),h", 0xDD, 0xCC, 0x06);
            CodeEmitWorks("set 1,(ix-#0c),h", 0xDD, 0xCC, 0xF4);
            CodeEmitWorks("set 1,(ix),l", 0xDD, 0xCD, 0x00);
            CodeEmitWorks("set 1,(ix+6),l", 0xDD, 0xCD, 0x06);
            CodeEmitWorks("set 1,(ix-#0c),l", 0xDD, 0xCD, 0xF4);
            CodeEmitWorks("set 1,(ix)", 0xDD, 0xCE, 0x00);
            CodeEmitWorks("set 1,(ix+6)", 0xDD, 0xCE, 0x06);
            CodeEmitWorks("set 1,(ix-#0c)", 0xDD, 0xCE, 0xF4);
            CodeEmitWorks("set 1,(ix),a", 0xDD, 0xCF, 0x00);
            CodeEmitWorks("set 1,(ix+6),a", 0xDD, 0xCF, 0x06);
            CodeEmitWorks("set 1,(ix-#0c),a", 0xDD, 0xCF, 0xF4);

            CodeEmitWorks("set 2,(ix),b", 0xDD, 0xD0, 0x00);
            CodeEmitWorks("set 2,(ix+6),b", 0xDD, 0xD0, 0x06);
            CodeEmitWorks("set 2,(ix-#0c),b", 0xDD, 0xD0, 0xF4);
            CodeEmitWorks("set 2,(ix),c", 0xDD, 0xD1, 0x00);
            CodeEmitWorks("set 2,(ix+6),c", 0xDD, 0xD1, 0x06);
            CodeEmitWorks("set 2,(ix-#0c),c", 0xDD, 0xD1, 0xF4);
            CodeEmitWorks("set 2,(ix),d", 0xDD, 0xD2, 0x00);
            CodeEmitWorks("set 2,(ix+6),d", 0xDD, 0xD2, 0x06);
            CodeEmitWorks("set 2,(ix-#0c),d", 0xDD, 0xD2, 0xF4);
            CodeEmitWorks("set 2,(ix),e", 0xDD, 0xD3, 0x00);
            CodeEmitWorks("set 2,(ix+6),e", 0xDD, 0xD3, 0x06);
            CodeEmitWorks("set 2,(ix-#0c),e", 0xDD, 0xD3, 0xF4);
            CodeEmitWorks("set 2,(ix),h", 0xDD, 0xD4, 0x00);
            CodeEmitWorks("set 2,(ix+6),h", 0xDD, 0xD4, 0x06);
            CodeEmitWorks("set 2,(ix-#0c),h", 0xDD, 0xD4, 0xF4);
            CodeEmitWorks("set 2,(ix),l", 0xDD, 0xD5, 0x00);
            CodeEmitWorks("set 2,(ix+6),l", 0xDD, 0xD5, 0x06);
            CodeEmitWorks("set 2,(ix-#0c),l", 0xDD, 0xD5, 0xF4);
            CodeEmitWorks("set 2,(ix)", 0xDD, 0xD6, 0x00);
            CodeEmitWorks("set 2,(ix+6)", 0xDD, 0xD6, 0x06);
            CodeEmitWorks("set 2,(ix-#0c)", 0xDD, 0xD6, 0xF4);
            CodeEmitWorks("set 2,(ix),a", 0xDD, 0xD7, 0x00);
            CodeEmitWorks("set 2,(ix+6),a", 0xDD, 0xD7, 0x06);
            CodeEmitWorks("set 2,(ix-#0c),a", 0xDD, 0xD7, 0xF4);

            CodeEmitWorks("set 3,(ix),b", 0xDD, 0xD8, 0x00);
            CodeEmitWorks("set 3,(ix+6),b", 0xDD, 0xD8, 0x06);
            CodeEmitWorks("set 3,(ix-#0c),b", 0xDD, 0xD8, 0xF4);
            CodeEmitWorks("set 3,(ix),c", 0xDD, 0xD9, 0x00);
            CodeEmitWorks("set 3,(ix+6),c", 0xDD, 0xD9, 0x06);
            CodeEmitWorks("set 3,(ix-#0c),c", 0xDD, 0xD9, 0xF4);
            CodeEmitWorks("set 3,(ix),d", 0xDD, 0xDA, 0x00);
            CodeEmitWorks("set 3,(ix+6),d", 0xDD, 0xDA, 0x06);
            CodeEmitWorks("set 3,(ix-#0c),d", 0xDD, 0xDA, 0xF4);
            CodeEmitWorks("set 3,(ix),e", 0xDD, 0xDB, 0x00);
            CodeEmitWorks("set 3,(ix+6),e", 0xDD, 0xDB, 0x06);
            CodeEmitWorks("set 3,(ix-#0c),e", 0xDD, 0xDB, 0xF4);
            CodeEmitWorks("set 3,(ix),h", 0xDD, 0xDC, 0x00);
            CodeEmitWorks("set 3,(ix+6),h", 0xDD, 0xDC, 0x06);
            CodeEmitWorks("set 3,(ix-#0c),h", 0xDD, 0xDC, 0xF4);
            CodeEmitWorks("set 3,(ix),l", 0xDD, 0xDD, 0x00);
            CodeEmitWorks("set 3,(ix+6),l", 0xDD, 0xDD, 0x06);
            CodeEmitWorks("set 3,(ix-#0c),l", 0xDD, 0xDD, 0xF4);
            CodeEmitWorks("set 3,(ix)", 0xDD, 0xDE, 0x00);
            CodeEmitWorks("set 3,(ix+6)", 0xDD, 0xDE, 0x06);
            CodeEmitWorks("set 3,(ix-#0c)", 0xDD, 0xDE, 0xF4);
            CodeEmitWorks("set 3,(ix),a", 0xDD, 0xDF, 0x00);
            CodeEmitWorks("set 3,(ix+6),a", 0xDD, 0xDF, 0x06);
            CodeEmitWorks("set 3,(ix-#0c),a", 0xDD, 0xDF, 0xF4);

            CodeEmitWorks("set 4,(ix),b", 0xDD, 0xE0, 0x00);
            CodeEmitWorks("set 4,(ix+6),b", 0xDD, 0xE0, 0x06);
            CodeEmitWorks("set 4,(ix-#0c),b", 0xDD, 0xE0, 0xF4);
            CodeEmitWorks("set 4,(ix),c", 0xDD, 0xE1, 0x00);
            CodeEmitWorks("set 4,(ix+6),c", 0xDD, 0xE1, 0x06);
            CodeEmitWorks("set 4,(ix-#0c),c", 0xDD, 0xE1, 0xF4);
            CodeEmitWorks("set 4,(ix),d", 0xDD, 0xE2, 0x00);
            CodeEmitWorks("set 4,(ix+6),d", 0xDD, 0xE2, 0x06);
            CodeEmitWorks("set 4,(ix-#0c),d", 0xDD, 0xE2, 0xF4);
            CodeEmitWorks("set 4,(ix),e", 0xDD, 0xE3, 0x00);
            CodeEmitWorks("set 4,(ix+6),e", 0xDD, 0xE3, 0x06);
            CodeEmitWorks("set 4,(ix-#0c),e", 0xDD, 0xE3, 0xF4);
            CodeEmitWorks("set 4,(ix),h", 0xDD, 0xE4, 0x00);
            CodeEmitWorks("set 4,(ix+6),h", 0xDD, 0xE4, 0x06);
            CodeEmitWorks("set 4,(ix-#0c),h", 0xDD, 0xE4, 0xF4);
            CodeEmitWorks("set 4,(ix),l", 0xDD, 0xE5, 0x00);
            CodeEmitWorks("set 4,(ix+6),l", 0xDD, 0xE5, 0x06);
            CodeEmitWorks("set 4,(ix-#0c),l", 0xDD, 0xE5, 0xF4);
            CodeEmitWorks("set 4,(ix)", 0xDD, 0xE6, 0x00);
            CodeEmitWorks("set 4,(ix+6)", 0xDD, 0xE6, 0x06);
            CodeEmitWorks("set 4,(ix-#0c)", 0xDD, 0xE6, 0xF4);
            CodeEmitWorks("set 4,(ix),a", 0xDD, 0xE7, 0x00);
            CodeEmitWorks("set 4,(ix+6),a", 0xDD, 0xE7, 0x06);
            CodeEmitWorks("set 4,(ix-#0c),a", 0xDD, 0xE7, 0xF4);

            CodeEmitWorks("set 5,(ix),b", 0xDD, 0xE8, 0x00);
            CodeEmitWorks("set 5,(ix+6),b", 0xDD, 0xE8, 0x06);
            CodeEmitWorks("set 5,(ix-#0c),b", 0xDD, 0xE8, 0xF4);
            CodeEmitWorks("set 5,(ix),c", 0xDD, 0xE9, 0x00);
            CodeEmitWorks("set 5,(ix+6),c", 0xDD, 0xE9, 0x06);
            CodeEmitWorks("set 5,(ix-#0c),c", 0xDD, 0xE9, 0xF4);
            CodeEmitWorks("set 5,(ix),d", 0xDD, 0xEA, 0x00);
            CodeEmitWorks("set 5,(ix+6),d", 0xDD, 0xEA, 0x06);
            CodeEmitWorks("set 5,(ix-#0c),d", 0xDD, 0xEA, 0xF4);
            CodeEmitWorks("set 5,(ix),e", 0xDD, 0xEB, 0x00);
            CodeEmitWorks("set 5,(ix+6),e", 0xDD, 0xEB, 0x06);
            CodeEmitWorks("set 5,(ix-#0c),e", 0xDD, 0xEB, 0xF4);
            CodeEmitWorks("set 5,(ix),h", 0xDD, 0xEC, 0x00);
            CodeEmitWorks("set 5,(ix+6),h", 0xDD, 0xEC, 0x06);
            CodeEmitWorks("set 5,(ix-#0c),h", 0xDD, 0xEC, 0xF4);
            CodeEmitWorks("set 5,(ix),l", 0xDD, 0xED, 0x00);
            CodeEmitWorks("set 5,(ix+6),l", 0xDD, 0xED, 0x06);
            CodeEmitWorks("set 5,(ix-#0c),l", 0xDD, 0xED, 0xF4);
            CodeEmitWorks("set 5,(ix)", 0xDD, 0xEE, 0x00);
            CodeEmitWorks("set 5,(ix+6)", 0xDD, 0xEE, 0x06);
            CodeEmitWorks("set 5,(ix-#0c)", 0xDD, 0xEE, 0xF4);
            CodeEmitWorks("set 5,(ix),a", 0xDD, 0xEF, 0x00);
            CodeEmitWorks("set 5,(ix+6),a", 0xDD, 0xEF, 0x06);
            CodeEmitWorks("set 5,(ix-#0c),a", 0xDD, 0xEF, 0xF4);

            CodeEmitWorks("set 6,(ix),b", 0xDD, 0xF0, 0x00);
            CodeEmitWorks("set 6,(ix+6),b", 0xDD, 0xF0, 0x06);
            CodeEmitWorks("set 6,(ix-#0c),b", 0xDD, 0xF0, 0xF4);
            CodeEmitWorks("set 6,(ix),c", 0xDD, 0xF1, 0x00);
            CodeEmitWorks("set 6,(ix+6),c", 0xDD, 0xF1, 0x06);
            CodeEmitWorks("set 6,(ix-#0c),c", 0xDD, 0xF1, 0xF4);
            CodeEmitWorks("set 6,(ix),d", 0xDD, 0xF2, 0x00);
            CodeEmitWorks("set 6,(ix+6),d", 0xDD, 0xF2, 0x06);
            CodeEmitWorks("set 6,(ix-#0c),d", 0xDD, 0xF2, 0xF4);
            CodeEmitWorks("set 6,(ix),e", 0xDD, 0xF3, 0x00);
            CodeEmitWorks("set 6,(ix+6),e", 0xDD, 0xF3, 0x06);
            CodeEmitWorks("set 6,(ix-#0c),e", 0xDD, 0xF3, 0xF4);
            CodeEmitWorks("set 6,(ix),h", 0xDD, 0xF4, 0x00);
            CodeEmitWorks("set 6,(ix+6),h", 0xDD, 0xF4, 0x06);
            CodeEmitWorks("set 6,(ix-#0c),h", 0xDD, 0xF4, 0xF4);
            CodeEmitWorks("set 6,(ix),l", 0xDD, 0xF5, 0x00);
            CodeEmitWorks("set 6,(ix+6),l", 0xDD, 0xF5, 0x06);
            CodeEmitWorks("set 6,(ix-#0c),l", 0xDD, 0xF5, 0xF4);
            CodeEmitWorks("set 6,(ix)", 0xDD, 0xF6, 0x00);
            CodeEmitWorks("set 6,(ix+6)", 0xDD, 0xF6, 0x06);
            CodeEmitWorks("set 6,(ix-#0c)", 0xDD, 0xF6, 0xF4);
            CodeEmitWorks("set 6,(ix),a", 0xDD, 0xF7, 0x00);
            CodeEmitWorks("set 6,(ix+6),a", 0xDD, 0xF7, 0x06);
            CodeEmitWorks("set 6,(ix-#0c),a", 0xDD, 0xF7, 0xF4);

            CodeEmitWorks("set 7,(ix),b", 0xDD, 0xF8, 0x00);
            CodeEmitWorks("set 7,(ix+6),b", 0xDD, 0xF8, 0x06);
            CodeEmitWorks("set 7,(ix-#0c),b", 0xDD, 0xF8, 0xF4);
            CodeEmitWorks("set 7,(ix),c", 0xDD, 0xF9, 0x00);
            CodeEmitWorks("set 7,(ix+6),c", 0xDD, 0xF9, 0x06);
            CodeEmitWorks("set 7,(ix-#0c),c", 0xDD, 0xF9, 0xF4);
            CodeEmitWorks("set 7,(ix),d", 0xDD, 0xFA, 0x00);
            CodeEmitWorks("set 7,(ix+6),d", 0xDD, 0xFA, 0x06);
            CodeEmitWorks("set 7,(ix-#0c),d", 0xDD, 0xFA, 0xF4);
            CodeEmitWorks("set 7,(ix),e", 0xDD, 0xFB, 0x00);
            CodeEmitWorks("set 7,(ix+6),e", 0xDD, 0xFB, 0x06);
            CodeEmitWorks("set 7,(ix-#0c),e", 0xDD, 0xFB, 0xF4);
            CodeEmitWorks("set 7,(ix),h", 0xDD, 0xFC, 0x00);
            CodeEmitWorks("set 7,(ix+6),h", 0xDD, 0xFC, 0x06);
            CodeEmitWorks("set 7,(ix-#0c),h", 0xDD, 0xFC, 0xF4);
            CodeEmitWorks("set 7,(ix),l", 0xDD, 0xFD, 0x00);
            CodeEmitWorks("set 7,(ix+6),l", 0xDD, 0xFD, 0x06);
            CodeEmitWorks("set 7,(ix-#0c),l", 0xDD, 0xFD, 0xF4);
            CodeEmitWorks("set 7,(ix)", 0xDD, 0xFE, 0x00);
            CodeEmitWorks("set 7,(ix+6)", 0xDD, 0xFE, 0x06);
            CodeEmitWorks("set 7,(ix-#0c)", 0xDD, 0xFE, 0xF4);
            CodeEmitWorks("set 7,(ix),a", 0xDD, 0xFF, 0x00);
            CodeEmitWorks("set 7,(ix+6),a", 0xDD, 0xFF, 0x06);
            CodeEmitWorks("set 7,(ix-#0c),a", 0xDD, 0xFF, 0xF4);
        }

        [TestMethod]
        public void IyIndexedSetOpsWorkAsExpected()
        {
            CodeEmitWorks("set 0,(iy),b", 0xFD, 0xC0, 0x00);
            CodeEmitWorks("set 0,(iy+6),b", 0xFD, 0xC0, 0x06);
            CodeEmitWorks("set 0,(iy-#0c),b", 0xFD, 0xC0, 0xF4);
            CodeEmitWorks("set 0,(iy),c", 0xFD, 0xC1, 0x00);
            CodeEmitWorks("set 0,(iy+6),c", 0xFD, 0xC1, 0x06);
            CodeEmitWorks("set 0,(iy-#0c),c", 0xFD, 0xC1, 0xF4);
            CodeEmitWorks("set 0,(iy),d", 0xFD, 0xC2, 0x00);
            CodeEmitWorks("set 0,(iy+6),d", 0xFD, 0xC2, 0x06);
            CodeEmitWorks("set 0,(iy-#0c),d", 0xFD, 0xC2, 0xF4);
            CodeEmitWorks("set 0,(iy),e", 0xFD, 0xC3, 0x00);
            CodeEmitWorks("set 0,(iy+6),e", 0xFD, 0xC3, 0x06);
            CodeEmitWorks("set 0,(iy-#0c),e", 0xFD, 0xC3, 0xF4);
            CodeEmitWorks("set 0,(iy),h", 0xFD, 0xC4, 0x00);
            CodeEmitWorks("set 0,(iy+6),h", 0xFD, 0xC4, 0x06);
            CodeEmitWorks("set 0,(iy-#0c),h", 0xFD, 0xC4, 0xF4);
            CodeEmitWorks("set 0,(iy),l", 0xFD, 0xC5, 0x00);
            CodeEmitWorks("set 0,(iy+6),l", 0xFD, 0xC5, 0x06);
            CodeEmitWorks("set 0,(iy-#0c),l", 0xFD, 0xC5, 0xF4);
            CodeEmitWorks("set 0,(iy)", 0xFD, 0xC6, 0x00);
            CodeEmitWorks("set 0,(iy+6)", 0xFD, 0xC6, 0x06);
            CodeEmitWorks("set 0,(iy-#0c)", 0xFD, 0xC6, 0xF4);
            CodeEmitWorks("set 0,(iy),a", 0xFD, 0xC7, 0x00);
            CodeEmitWorks("set 0,(iy+6),a", 0xFD, 0xC7, 0x06);
            CodeEmitWorks("set 0,(iy-#0c),a", 0xFD, 0xC7, 0xF4);

            CodeEmitWorks("set 1,(iy),b", 0xFD, 0xC8, 0x00);
            CodeEmitWorks("set 1,(iy+6),b", 0xFD, 0xC8, 0x06);
            CodeEmitWorks("set 1,(iy-#0c),b", 0xFD, 0xC8, 0xF4);
            CodeEmitWorks("set 1,(iy),c", 0xFD, 0xC9, 0x00);
            CodeEmitWorks("set 1,(iy+6),c", 0xFD, 0xC9, 0x06);
            CodeEmitWorks("set 1,(iy-#0c),c", 0xFD, 0xC9, 0xF4);
            CodeEmitWorks("set 1,(iy),d", 0xFD, 0xCA, 0x00);
            CodeEmitWorks("set 1,(iy+6),d", 0xFD, 0xCA, 0x06);
            CodeEmitWorks("set 1,(iy-#0c),d", 0xFD, 0xCA, 0xF4);
            CodeEmitWorks("set 1,(iy),e", 0xFD, 0xCB, 0x00);
            CodeEmitWorks("set 1,(iy+6),e", 0xFD, 0xCB, 0x06);
            CodeEmitWorks("set 1,(iy-#0c),e", 0xFD, 0xCB, 0xF4);
            CodeEmitWorks("set 1,(iy),h", 0xFD, 0xCC, 0x00);
            CodeEmitWorks("set 1,(iy+6),h", 0xFD, 0xCC, 0x06);
            CodeEmitWorks("set 1,(iy-#0c),h", 0xFD, 0xCC, 0xF4);
            CodeEmitWorks("set 1,(iy),l", 0xFD, 0xCD, 0x00);
            CodeEmitWorks("set 1,(iy+6),l", 0xFD, 0xCD, 0x06);
            CodeEmitWorks("set 1,(iy-#0c),l", 0xFD, 0xCD, 0xF4);
            CodeEmitWorks("set 1,(iy)", 0xFD, 0xCE, 0x00);
            CodeEmitWorks("set 1,(iy+6)", 0xFD, 0xCE, 0x06);
            CodeEmitWorks("set 1,(iy-#0c)", 0xFD, 0xCE, 0xF4);
            CodeEmitWorks("set 1,(iy),a", 0xFD, 0xCF, 0x00);
            CodeEmitWorks("set 1,(iy+6),a", 0xFD, 0xCF, 0x06);
            CodeEmitWorks("set 1,(iy-#0c),a", 0xFD, 0xCF, 0xF4);

            CodeEmitWorks("set 2,(iy),b", 0xFD, 0xD0, 0x00);
            CodeEmitWorks("set 2,(iy+6),b", 0xFD, 0xD0, 0x06);
            CodeEmitWorks("set 2,(iy-#0c),b", 0xFD, 0xD0, 0xF4);
            CodeEmitWorks("set 2,(iy),c", 0xFD, 0xD1, 0x00);
            CodeEmitWorks("set 2,(iy+6),c", 0xFD, 0xD1, 0x06);
            CodeEmitWorks("set 2,(iy-#0c),c", 0xFD, 0xD1, 0xF4);
            CodeEmitWorks("set 2,(iy),d", 0xFD, 0xD2, 0x00);
            CodeEmitWorks("set 2,(iy+6),d", 0xFD, 0xD2, 0x06);
            CodeEmitWorks("set 2,(iy-#0c),d", 0xFD, 0xD2, 0xF4);
            CodeEmitWorks("set 2,(iy),e", 0xFD, 0xD3, 0x00);
            CodeEmitWorks("set 2,(iy+6),e", 0xFD, 0xD3, 0x06);
            CodeEmitWorks("set 2,(iy-#0c),e", 0xFD, 0xD3, 0xF4);
            CodeEmitWorks("set 2,(iy),h", 0xFD, 0xD4, 0x00);
            CodeEmitWorks("set 2,(iy+6),h", 0xFD, 0xD4, 0x06);
            CodeEmitWorks("set 2,(iy-#0c),h", 0xFD, 0xD4, 0xF4);
            CodeEmitWorks("set 2,(iy),l", 0xFD, 0xD5, 0x00);
            CodeEmitWorks("set 2,(iy+6),l", 0xFD, 0xD5, 0x06);
            CodeEmitWorks("set 2,(iy-#0c),l", 0xFD, 0xD5, 0xF4);
            CodeEmitWorks("set 2,(iy)", 0xFD, 0xD6, 0x00);
            CodeEmitWorks("set 2,(iy+6)", 0xFD, 0xD6, 0x06);
            CodeEmitWorks("set 2,(iy-#0c)", 0xFD, 0xD6, 0xF4);
            CodeEmitWorks("set 2,(iy),a", 0xFD, 0xD7, 0x00);
            CodeEmitWorks("set 2,(iy+6),a", 0xFD, 0xD7, 0x06);
            CodeEmitWorks("set 2,(iy-#0c),a", 0xFD, 0xD7, 0xF4);

            CodeEmitWorks("set 3,(iy),b", 0xFD, 0xD8, 0x00);
            CodeEmitWorks("set 3,(iy+6),b", 0xFD, 0xD8, 0x06);
            CodeEmitWorks("set 3,(iy-#0c),b", 0xFD, 0xD8, 0xF4);
            CodeEmitWorks("set 3,(iy),c", 0xFD, 0xD9, 0x00);
            CodeEmitWorks("set 3,(iy+6),c", 0xFD, 0xD9, 0x06);
            CodeEmitWorks("set 3,(iy-#0c),c", 0xFD, 0xD9, 0xF4);
            CodeEmitWorks("set 3,(iy),d", 0xFD, 0xDA, 0x00);
            CodeEmitWorks("set 3,(iy+6),d", 0xFD, 0xDA, 0x06);
            CodeEmitWorks("set 3,(iy-#0c),d", 0xFD, 0xDA, 0xF4);
            CodeEmitWorks("set 3,(iy),e", 0xFD, 0xDB, 0x00);
            CodeEmitWorks("set 3,(iy+6),e", 0xFD, 0xDB, 0x06);
            CodeEmitWorks("set 3,(iy-#0c),e", 0xFD, 0xDB, 0xF4);
            CodeEmitWorks("set 3,(iy),h", 0xFD, 0xDC, 0x00);
            CodeEmitWorks("set 3,(iy+6),h", 0xFD, 0xDC, 0x06);
            CodeEmitWorks("set 3,(iy-#0c),h", 0xFD, 0xDC, 0xF4);
            CodeEmitWorks("set 3,(iy),l", 0xFD, 0xDD, 0x00);
            CodeEmitWorks("set 3,(iy+6),l", 0xFD, 0xDD, 0x06);
            CodeEmitWorks("set 3,(iy-#0c),l", 0xFD, 0xDD, 0xF4);
            CodeEmitWorks("set 3,(iy)", 0xFD, 0xDE, 0x00);
            CodeEmitWorks("set 3,(iy+6)", 0xFD, 0xDE, 0x06);
            CodeEmitWorks("set 3,(iy-#0c)", 0xFD, 0xDE, 0xF4);
            CodeEmitWorks("set 3,(iy),a", 0xFD, 0xDF, 0x00);
            CodeEmitWorks("set 3,(iy+6),a", 0xFD, 0xDF, 0x06);
            CodeEmitWorks("set 3,(iy-#0c),a", 0xFD, 0xDF, 0xF4);

            CodeEmitWorks("set 4,(iy),b", 0xFD, 0xE0, 0x00);
            CodeEmitWorks("set 4,(iy+6),b", 0xFD, 0xE0, 0x06);
            CodeEmitWorks("set 4,(iy-#0c),b", 0xFD, 0xE0, 0xF4);
            CodeEmitWorks("set 4,(iy),c", 0xFD, 0xE1, 0x00);
            CodeEmitWorks("set 4,(iy+6),c", 0xFD, 0xE1, 0x06);
            CodeEmitWorks("set 4,(iy-#0c),c", 0xFD, 0xE1, 0xF4);
            CodeEmitWorks("set 4,(iy),d", 0xFD, 0xE2, 0x00);
            CodeEmitWorks("set 4,(iy+6),d", 0xFD, 0xE2, 0x06);
            CodeEmitWorks("set 4,(iy-#0c),d", 0xFD, 0xE2, 0xF4);
            CodeEmitWorks("set 4,(iy),e", 0xFD, 0xE3, 0x00);
            CodeEmitWorks("set 4,(iy+6),e", 0xFD, 0xE3, 0x06);
            CodeEmitWorks("set 4,(iy-#0c),e", 0xFD, 0xE3, 0xF4);
            CodeEmitWorks("set 4,(iy),h", 0xFD, 0xE4, 0x00);
            CodeEmitWorks("set 4,(iy+6),h", 0xFD, 0xE4, 0x06);
            CodeEmitWorks("set 4,(iy-#0c),h", 0xFD, 0xE4, 0xF4);
            CodeEmitWorks("set 4,(iy),l", 0xFD, 0xE5, 0x00);
            CodeEmitWorks("set 4,(iy+6),l", 0xFD, 0xE5, 0x06);
            CodeEmitWorks("set 4,(iy-#0c),l", 0xFD, 0xE5, 0xF4);
            CodeEmitWorks("set 4,(iy)", 0xFD, 0xE6, 0x00);
            CodeEmitWorks("set 4,(iy+6)", 0xFD, 0xE6, 0x06);
            CodeEmitWorks("set 4,(iy-#0c)", 0xFD, 0xE6, 0xF4);
            CodeEmitWorks("set 4,(iy),a", 0xFD, 0xE7, 0x00);
            CodeEmitWorks("set 4,(iy+6),a", 0xFD, 0xE7, 0x06);
            CodeEmitWorks("set 4,(iy-#0c),a", 0xFD, 0xE7, 0xF4);

            CodeEmitWorks("set 5,(iy),b", 0xFD, 0xE8, 0x00);
            CodeEmitWorks("set 5,(iy+6),b", 0xFD, 0xE8, 0x06);
            CodeEmitWorks("set 5,(iy-#0c),b", 0xFD, 0xE8, 0xF4);
            CodeEmitWorks("set 5,(iy),c", 0xFD, 0xE9, 0x00);
            CodeEmitWorks("set 5,(iy+6),c", 0xFD, 0xE9, 0x06);
            CodeEmitWorks("set 5,(iy-#0c),c", 0xFD, 0xE9, 0xF4);
            CodeEmitWorks("set 5,(iy),d", 0xFD, 0xEA, 0x00);
            CodeEmitWorks("set 5,(iy+6),d", 0xFD, 0xEA, 0x06);
            CodeEmitWorks("set 5,(iy-#0c),d", 0xFD, 0xEA, 0xF4);
            CodeEmitWorks("set 5,(iy),e", 0xFD, 0xEB, 0x00);
            CodeEmitWorks("set 5,(iy+6),e", 0xFD, 0xEB, 0x06);
            CodeEmitWorks("set 5,(iy-#0c),e", 0xFD, 0xEB, 0xF4);
            CodeEmitWorks("set 5,(iy),h", 0xFD, 0xEC, 0x00);
            CodeEmitWorks("set 5,(iy+6),h", 0xFD, 0xEC, 0x06);
            CodeEmitWorks("set 5,(iy-#0c),h", 0xFD, 0xEC, 0xF4);
            CodeEmitWorks("set 5,(iy),l", 0xFD, 0xED, 0x00);
            CodeEmitWorks("set 5,(iy+6),l", 0xFD, 0xED, 0x06);
            CodeEmitWorks("set 5,(iy-#0c),l", 0xFD, 0xED, 0xF4);
            CodeEmitWorks("set 5,(iy)", 0xFD, 0xEE, 0x00);
            CodeEmitWorks("set 5,(iy+6)", 0xFD, 0xEE, 0x06);
            CodeEmitWorks("set 5,(iy-#0c)", 0xFD, 0xEE, 0xF4);
            CodeEmitWorks("set 5,(iy),a", 0xFD, 0xEF, 0x00);
            CodeEmitWorks("set 5,(iy+6),a", 0xFD, 0xEF, 0x06);
            CodeEmitWorks("set 5,(iy-#0c),a", 0xFD, 0xEF, 0xF4);

            CodeEmitWorks("set 6,(iy),b", 0xFD, 0xF0, 0x00);
            CodeEmitWorks("set 6,(iy+6),b", 0xFD, 0xF0, 0x06);
            CodeEmitWorks("set 6,(iy-#0c),b", 0xFD, 0xF0, 0xF4);
            CodeEmitWorks("set 6,(iy),c", 0xFD, 0xF1, 0x00);
            CodeEmitWorks("set 6,(iy+6),c", 0xFD, 0xF1, 0x06);
            CodeEmitWorks("set 6,(iy-#0c),c", 0xFD, 0xF1, 0xF4);
            CodeEmitWorks("set 6,(iy),d", 0xFD, 0xF2, 0x00);
            CodeEmitWorks("set 6,(iy+6),d", 0xFD, 0xF2, 0x06);
            CodeEmitWorks("set 6,(iy-#0c),d", 0xFD, 0xF2, 0xF4);
            CodeEmitWorks("set 6,(iy),e", 0xFD, 0xF3, 0x00);
            CodeEmitWorks("set 6,(iy+6),e", 0xFD, 0xF3, 0x06);
            CodeEmitWorks("set 6,(iy-#0c),e", 0xFD, 0xF3, 0xF4);
            CodeEmitWorks("set 6,(iy),h", 0xFD, 0xF4, 0x00);
            CodeEmitWorks("set 6,(iy+6),h", 0xFD, 0xF4, 0x06);
            CodeEmitWorks("set 6,(iy-#0c),h", 0xFD, 0xF4, 0xF4);
            CodeEmitWorks("set 6,(iy),l", 0xFD, 0xF5, 0x00);
            CodeEmitWorks("set 6,(iy+6),l", 0xFD, 0xF5, 0x06);
            CodeEmitWorks("set 6,(iy-#0c),l", 0xFD, 0xF5, 0xF4);
            CodeEmitWorks("set 6,(iy)", 0xFD, 0xF6, 0x00);
            CodeEmitWorks("set 6,(iy+6)", 0xFD, 0xF6, 0x06);
            CodeEmitWorks("set 6,(iy-#0c)", 0xFD, 0xF6, 0xF4);
            CodeEmitWorks("set 6,(iy),a", 0xFD, 0xF7, 0x00);
            CodeEmitWorks("set 6,(iy+6),a", 0xFD, 0xF7, 0x06);
            CodeEmitWorks("set 6,(iy-#0c),a", 0xFD, 0xF7, 0xF4);

            CodeEmitWorks("set 7,(iy),b", 0xFD, 0xF8, 0x00);
            CodeEmitWorks("set 7,(iy+6),b", 0xFD, 0xF8, 0x06);
            CodeEmitWorks("set 7,(iy-#0c),b", 0xFD, 0xF8, 0xF4);
            CodeEmitWorks("set 7,(iy),c", 0xFD, 0xF9, 0x00);
            CodeEmitWorks("set 7,(iy+6),c", 0xFD, 0xF9, 0x06);
            CodeEmitWorks("set 7,(iy-#0c),c", 0xFD, 0xF9, 0xF4);
            CodeEmitWorks("set 7,(iy),d", 0xFD, 0xFA, 0x00);
            CodeEmitWorks("set 7,(iy+6),d", 0xFD, 0xFA, 0x06);
            CodeEmitWorks("set 7,(iy-#0c),d", 0xFD, 0xFA, 0xF4);
            CodeEmitWorks("set 7,(iy),e", 0xFD, 0xFB, 0x00);
            CodeEmitWorks("set 7,(iy+6),e", 0xFD, 0xFB, 0x06);
            CodeEmitWorks("set 7,(iy-#0c),e", 0xFD, 0xFB, 0xF4);
            CodeEmitWorks("set 7,(iy),h", 0xFD, 0xFC, 0x00);
            CodeEmitWorks("set 7,(iy+6),h", 0xFD, 0xFC, 0x06);
            CodeEmitWorks("set 7,(iy-#0c),h", 0xFD, 0xFC, 0xF4);
            CodeEmitWorks("set 7,(iy),l", 0xFD, 0xFD, 0x00);
            CodeEmitWorks("set 7,(iy+6),l", 0xFD, 0xFD, 0x06);
            CodeEmitWorks("set 7,(iy-#0c),l", 0xFD, 0xFD, 0xF4);
            CodeEmitWorks("set 7,(iy)", 0xFD, 0xFE, 0x00);
            CodeEmitWorks("set 7,(iy+6)", 0xFD, 0xFE, 0x06);
            CodeEmitWorks("set 7,(iy-#0c)", 0xFD, 0xFE, 0xF4);
            CodeEmitWorks("set 7,(iy),a", 0xFD, 0xFF, 0x00);
            CodeEmitWorks("set 7,(iy+6),a", 0xFD, 0xFF, 0x06);
            CodeEmitWorks("set 7,(iy-#0c),a", 0xFD, 0xFF, 0xF4);
        }
    }
}