using HashCryptography;
using HashCryptography.Implementation;
using NUnit.Framework;

namespace TestProject.HashCryptographyTest
{
    [TestFixture]
    class GOST34112018Policy512bitTest
    {
        [SetUp]
        public void Setup()
        {
            m_Function = new HashFunction(new GOST34112018Policy512bit());
        }

        [Test]
        public void GOSTTestExample1()
        {
            byte[] testCase =
            {
                0x32, 0x31, 0x30,
                0x39, 0x38, 0x37, 0x36, 0x35, 0x34, 0x33, 0x32, 0x31, 0x30,
                0x39, 0x38, 0x37, 0x36, 0x35, 0x34, 0x33, 0x32, 0x31, 0x30,
                0x39, 0x38, 0x37, 0x36, 0x35, 0x34, 0x33, 0x32, 0x31, 0x30,
                0x39, 0x38, 0x37, 0x36, 0x35, 0x34, 0x33, 0x32, 0x31, 0x30,
                0x39, 0x38, 0x37, 0x36, 0x35, 0x34, 0x33, 0x32, 0x31, 0x30,
                0x39, 0x38, 0x37, 0x36, 0x35, 0x34, 0x33, 0x32, 0x31, 0x30
            };

            byte[] expectedAns =
            {
                0x48, 0x6f, 0x64, 0xc1, 0x91, 0x78, 0x79, 0x41,
                0x7f, 0xef, 0x08, 0x2b, 0x33, 0x81, 0xa4, 0xe2,
                0x11, 0xc3, 0x24, 0xf0, 0x74, 0x65, 0x4c, 0x38,
                0x82, 0x3a, 0x7b, 0x76, 0xf8, 0x30, 0xad, 0x00,
                0xfa, 0x1f, 0xba, 0xe4, 0x2b, 0x12, 0x85, 0xc0,
                0x35, 0x2f, 0x22, 0x75, 0x24, 0xbc, 0x9a, 0xb1,
                0x62, 0x54, 0x28, 0x8d, 0xd6, 0x86, 0x3d, 0xcc,
                0xd5, 0xb9, 0xf5, 0x4a, 0x1a, 0xd0, 0x54, 0x1b
            };


            byte[] testAns = m_Function.GetHash(testCase);


            Assert.AreEqual(expectedAns.Length, testAns.Length);
            for (int i = 0; i < expectedAns.Length; ++i)
            {
                Assert.AreEqual(expectedAns[i], testAns[i]);
            }
        }

        [Test]
        public void GOSTTestExample2()
        {
            byte[] testCase =
            {
                0xfb, 0xe2, 0xe5, 0xf0, 0xee, 0xe3, 0xc8, 0x20,
                0xfb, 0xea, 0xfa, 0xeb, 0xef, 0x20, 0xff, 0xfb,
                0xf0, 0xe1, 0xe0, 0xf0, 0xf5, 0x20, 0xe0, 0xed,
                0x20, 0xe8, 0xec, 0xe0, 0xeb, 0xe5, 0xf0, 0xf2,
                0xf1, 0x20, 0xff, 0xf0, 0xee, 0xec, 0x20, 0xf1,
                0x20, 0xfa, 0xf2, 0xfe, 0xe5, 0xe2, 0x20, 0x2c,
                0xe8, 0xf6, 0xf3, 0xed, 0xe2, 0x20, 0xe8, 0xe6,
                0xee, 0xe1, 0xe8, 0xf0, 0xf2, 0xd1, 0x20, 0x2c,
                0xe8, 0xf0, 0xf2, 0xe5, 0xe2, 0x20, 0xe5, 0xd1
            };

            byte[] expectedAns =
            {
                0x28, 0xfb, 0xc9, 0xba, 0xda, 0x03, 0x3b, 0x14,
                0x60, 0x64, 0x2b, 0xdc, 0xdd, 0xb9, 0x0c, 0x3f,
                0xb3, 0xe5, 0x6c, 0x49, 0x7c, 0xcd, 0x0f, 0x62,
                0xb8, 0xa2, 0xad, 0x49, 0x35, 0xe8, 0x5f, 0x03,
                0x76, 0x13, 0x96, 0x6d, 0xe4, 0xee, 0x00, 0x53,
                0x1a, 0xe6, 0x0f, 0x3b, 0x5a, 0x47, 0xf8, 0xda,
                0xe0, 0x69, 0x15, 0xd5, 0xf2, 0xf1, 0x94, 0x99,
                0x6f, 0xca, 0xbf, 0x26, 0x22, 0xe6, 0x88, 0x1e
            };


            byte[] testAns = m_Function.GetHash(testCase);


            Assert.AreEqual(expectedAns.Length, testAns.Length);
            for (int i = 0; i < expectedAns.Length; ++i)
            {
                Assert.AreEqual(expectedAns[i], testAns[i]);
            }
        }

        private HashFunction m_Function;
    }
}