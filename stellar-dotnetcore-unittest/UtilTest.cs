﻿using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using stellar_dotnetcore_sdk;

namespace stellar_dotnetcore_unittest
{
    [TestClass]
    public class UtilTest
    {
        [TestMethod]
        public void TestBytesToHexAndHexToBytes()
        {
            var test = "This is a test of this method, 1234567890:;''<>!@#$%^&*()";
            var byteTest = Encoding.Default.GetBytes(test);

            var bytesToHex = Util.BytesToHex(byteTest);
            var hexToBytes = Util.HexToBytes(bytesToHex);

            var bytesToString = Encoding.Default.GetString(hexToBytes);

            Assert.AreEqual(test, bytesToString);
        }

        [TestMethod]
        public void TestPaddedByteArrayWithBytes()
        {
            var testBytes = Encoding.Default.GetBytes("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            var result = Util.PaddedByteArray(testBytes, 40);

            for (var i = 26; i < result.Length; i++)
                Assert.AreEqual(result[i], 0);
        }

        [TestMethod]
        public void TestPaddedByteArrayWithString()
        {
            var testString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var result = Util.PaddedByteArray(testString, 40);

            for (var i = 26; i < result.Length; i++)
                Assert.AreEqual(result[i], 0);
        }

        [TestMethod]
        public void TestPaddedByteArrayToString()
        {
            var testString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var result = Util.PaddedByteArray(testString, 40);

            var stringResult = Util.PaddedByteArrayToString(result);

            Assert.IsTrue(!stringResult.Contains("0"));
        }
    }
}