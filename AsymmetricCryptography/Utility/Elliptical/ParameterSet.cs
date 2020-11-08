﻿namespace DigitalSignature.Utility.Elliptical
{
    /// <summary>
    /// Coefficients from P 1323565.1.024—2019
    /// </summary>
    public class ParameterSet
    {
        public enum ID
        {
            ParamSetA512,
            ParamSetB512,
            ParamSetB256,
            ParamSetC256,
            ParamSetD256,
            ParamSetGOST34102018256bit,
            ParamSetGOST34102018512bit
        }

        public string Name { get; }
        public string OID { get; }
        public byte[] P { get; }
        public byte[] A { get; }
        public byte[] B { get; }
        public byte[] M { get; }
        public byte[] Q { get; }
        public byte[] X { get; }
        public byte[] Y { get; }

        public ParameterSet(ID id)
        {
            switch (id)
            {
                #region id-tc26-gost-3410-12-512-paramSetA
                case ID.ParamSetA512:
                {
                    Name = "id-tc26-gost-3410-12-512-paramSetA";
                    OID = "1.2.643.7.1.2.1.2.1.";
                    P = new byte[]
                    {
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfd, 0xc7
                    };
                    A = new byte[]
                    {
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfd, 0xc4
                    };
                    B = new byte[]
                    {
                        0xe8, 0xc2, 0x50, 0x5d, 0xed, 0xfc, 0x86, 0xdd,
                        0xc1, 0xbd, 0x0b, 0x2b, 0x66, 0x67, 0xf1, 0xda,
                        0x34, 0xb8, 0x25, 0x74, 0x76, 0x1c, 0xb0, 0xe8,
                        0x79, 0xbd, 0x08, 0x1c, 0xfd, 0x0b, 0x62, 0x65,
                        0xee, 0x3c, 0xb0, 0x90, 0xf3, 0x0d, 0x27, 0x61,
                        0x4c, 0xb4, 0x57, 0x40, 0x10, 0xda, 0x90, 0xdd,
                        0x86, 0x2e, 0xf9, 0xd4, 0xeb, 0xee, 0x47, 0x61,
                        0x50, 0x31, 0x90, 0x78, 0x5a, 0x71, 0xc7, 0x60
                    };
                    M = new byte[]
                    {
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0x27, 0xe6, 0x95, 0x32, 0xf4, 0x8d, 0x89, 0x11,
                        0x6f, 0xf2, 0x2b, 0x8d, 0x4e, 0x05, 0x60, 0x60,
                        0x9b, 0x4b, 0x38, 0xab, 0xfa, 0xd2, 0xb8, 0x5d,
                        0xca, 0xcd, 0xb1, 0x41, 0x1f, 0x10, 0xb2, 0x75
                    };
                    Q = new byte[]
                    {
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0x27, 0xe6, 0x95, 0x32, 0xf4, 0x8d, 0x89, 0x11,
                        0x6f, 0xf2, 0x2b, 0x8d, 0x4e, 0x05, 0x60, 0x60,
                        0x9b, 0x4b, 0x38, 0xab, 0xfa, 0xd2, 0xb8, 0x5d,
                        0xca, 0xcd, 0xb1, 0x41, 0x1f, 0x10, 0xb2, 0x75
                    };
                    X = new byte[]
                    {
                        0x03
                    };
                    Y = new byte[]
                    {
                        0x75, 0x03, 0xcf, 0xe8, 0x7a, 0x83, 0x6a, 0xe3,
                        0xa6, 0x1b, 0x88, 0x16, 0xe2, 0x54, 0x50, 0xe6,
                        0xce, 0x5e, 0x1c, 0x93, 0xac, 0xf1, 0xab, 0xc1,
                        0x77, 0x80, 0x64, 0xfd, 0xcb, 0xef, 0xa9, 0x21,
                        0xdf, 0x16, 0x26, 0xbe, 0x4f, 0xd0, 0x36, 0xe9,
                        0x3d, 0x75, 0xe6, 0xa5, 0x0e, 0x3a, 0x41, 0xe9,
                        0x80, 0x28, 0xfe, 0x5f, 0xc2, 0x35, 0xf5, 0xb8,
                        0x89, 0xa5, 0x89, 0xcb, 0x52, 0x15, 0xf2, 0xa4
                    };
                    break;
                }
                #endregion
                #region id-tc26-gost-3410-12-512-paramSetB
                case ID.ParamSetB512:
                {
                    Name = "id-tc26-gost-3410-12-512-paramSetB";
                    OID = "1.2.643.7.1.2.1.2.2.";
                        P = new byte[]
                    {
                        0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x6f
                    };
                    A = new byte[]
                    {
                        0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x6c
                    };
                    B = new byte[]
                    {
                        0x68, 0x7d, 0x1b, 0x45, 0x9d, 0xc8, 0x41, 0x45,
                        0x7e, 0x3e, 0x06, 0xcf, 0x6f, 0x5e, 0x25, 0x17,
                        0xb9, 0x7c, 0x7d, 0x61, 0x4a, 0xf1, 0x38, 0xbc,
                        0xbf, 0x85, 0xdc, 0x80, 0x6c, 0x4b, 0x28, 0x9f,
                        0x3e, 0x96, 0x5d, 0x2d, 0xb1, 0x41, 0x6d, 0x21,
                        0x7f, 0x8b, 0x27, 0x6f, 0xad, 0x1a, 0xb6, 0x9c,
                        0x50, 0xf7, 0x8b, 0xee, 0x1f, 0xa3, 0x10, 0x6e,
                        0xfb, 0x8c, 0xcb, 0xc7, 0xc5, 0x14, 0x01, 0x16
                    };
                    M = new byte[]
                    {
                        0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01,
                        0x49, 0xa1, 0xec, 0x14, 0x25, 0x65, 0xa5, 0x45,
                        0xac, 0xfd, 0xb7, 0x7b, 0xd9, 0xd4, 0x0c, 0xfa,
                        0x8b, 0x99, 0x67, 0x12, 0x10, 0x1b, 0xea, 0x0e,
                        0xc6, 0x34, 0x6c, 0x54, 0x37, 0x4f, 0x25, 0xbd
                    };
                    Q = new byte[]
                    {
                        0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01,
                        0x49, 0xa1, 0xec, 0x14, 0x25, 0x65, 0xa5, 0x45,
                        0xac, 0xfd, 0xb7, 0x7b, 0xd9, 0xd4, 0x0c, 0xfa,
                        0x8b, 0x99, 0x67, 0x12, 0x10, 0x1b, 0xea, 0x0e,
                        0xc6, 0x34, 0x6c, 0x54, 0x37, 0x4f, 0x25, 0xbd
                    };
                    X = new byte[]
                    {
                        0x02
                    };
                    Y = new byte[]
                    {
                        0x1a, 0x8f, 0x7e, 0xda, 0x38, 0x9b, 0x09, 0x4c,
                        0x2c, 0x07, 0x1e, 0x36, 0x47, 0xa8, 0x94, 0x0f,
                        0x3c, 0x12, 0x3b, 0x69, 0x75, 0x78, 0xc2, 0x13,
                        0xbe, 0x6d, 0xd9, 0xe6, 0xc8, 0xec, 0x73, 0x35,
                        0xdc, 0xb2, 0x28, 0xfd, 0x1e, 0xdf, 0x4a, 0x39,
                        0x15, 0x2c, 0xbc, 0xaa, 0xf8, 0xc0, 0x39, 0x88,
                        0x28, 0x04, 0x10, 0x55, 0xf9, 0x4c, 0xee, 0xec,
                        0x7e, 0x21, 0x34, 0x07, 0x80, 0xfe, 0x41, 0xbd
                    };
                    break;
                }
                #endregion
                #region id-tc26-gost-3410-2012-256-paramSetB
                case ID.ParamSetB256:
                {
                    Name = "id-tc26-gost-3410-2012-256-paramSetB";
                    OID = "1.2.643.7.1.2.1.1.2.";
                    P = new byte[]
                    {
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfd, 0x97
                    };
                    A = new byte[]
                    {
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfd, 0x94
                    };
                    B = new byte[]
                    {
                        0xa6
                    };
                    M = new byte[]
                    {
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0x6c, 0x61, 0x10, 0x70, 0x99, 0x5a, 0xd1, 0x00,
                        0x45, 0x84, 0x1b, 0x09, 0xb7, 0x61, 0xb8, 0x93
                    };
                    Q = new byte[]
                    {
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                        0x6c, 0x61, 0x10, 0x70, 0x99, 0x5a, 0xd1, 0x00,
                        0x45, 0x84, 0x1b, 0x09, 0xb7, 0x61, 0xb8, 0x93
                    };
                    X = new byte[]
                    {
                        0x01
                    };
                    Y = new byte[]
                    {
                        0x8D, 0x91, 0xe4, 0x71, 0xe0, 0x98, 0x9c, 0xda,
                        0x27, 0xdf, 0x50, 0x5a, 0x45, 0x3f, 0x2b, 0x76,
                        0x35, 0x29, 0x4f, 0x2d, 0xdf, 0x23, 0xe3, 0xb1,
                        0x22, 0xac, 0xc9, 0x9c, 0x9e, 0x9f, 0x1e, 0x14
                    };
                    break;
                }
                #endregion
                #region id-tc26-gost-3410-2012-256-paramSetC
                case ID.ParamSetC256:
                {
                    Name = "id-tc26-gost-3410-2012-256-paramSetC";
                    OID = "1.2.643.7.1.2.1.1.3.";
                    P = new byte[]
                    {
                        0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0C, 0x99
                    };
                    A = new byte[]
                    {
                        0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0C, 0x96
                    };
                    B = new byte[]
                    {
                        0x3e, 0x1a, 0xf4, 0x19, 0xa2, 0x69, 0xa5, 0xf8,
                        0x66, 0xa7, 0xd3, 0xc2, 0x5c, 0x3d, 0xf8, 0x0a,
                        0xe9, 0x79, 0x25, 0x93, 0x73, 0xff, 0x2b, 0x18,
                        0x2f, 0x49, 0xd4, 0xce, 0x7e, 0x1b, 0xbc, 0x8b
                    };
                    M = new byte[]
                    {
                        0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01,
                        0x5f, 0x70, 0x0c, 0xff, 0xf1, 0xa6, 0x24, 0xe5,
                        0xe4, 0x97, 0x16, 0x1b, 0xcc, 0x8a, 0x19, 0x8f
                    };
                    Q = new byte[]
                    {
                        0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01,
                        0x5f, 0x70, 0x0c, 0xff, 0xf1, 0xa6, 0x24, 0xe5,
                        0xe4, 0x97, 0x16, 0x1b, 0xcc, 0x8a, 0x19, 0x8f
                    };
                    X = new byte[]
                    {
                        0x81
                    };
                    Y = new byte[]
                    {
                        0x3f, 0xa8, 0x12, 0x43, 0x59, 0xf9, 0x66, 0x80,
                        0xb8, 0x3d, 0x1c, 0x3e, 0xb2, 0xc0, 0x70, 0xe5,
                        0xc5, 0x45, 0xc9, 0x85, 0x8d, 0x03, 0xec, 0xfb,
                        0x74, 0x4b, 0xf8, 0xd7, 0x17, 0x71, 0x7e, 0xfc
                    };
                    break;
                }
                #endregion
                #region id-tc26-gost-3410-2012-256-paramSetD
                case ID.ParamSetD256:
                {
                    Name = "id-tc26-gost-3410-2012-256-paramSetD";
                    OID = "1.2.643.7.1.2.1.1.4.";
                    P = new byte[]
                    {
                        0x9b, 0x9f, 0x60, 0x5f, 0x5a, 0x85, 0x81, 0x07,
                        0xab, 0x1e, 0xc8, 0x5e, 0x6b, 0x41, 0xc8, 0xaa,
                        0xcf, 0x84, 0x6e, 0x86, 0x78, 0x90, 0x51, 0xd3,
                        0x79, 0x98, 0xf7, 0xb9, 0x02, 0x2d, 0x75, 0x9b
                    };
                    A = new byte[]
                    {
                        0x9b, 0x9f, 0x60, 0x5f, 0x5a, 0x85, 0x81, 0x07,
                        0xab, 0x1e, 0xc8, 0x5e, 0x6b, 0x41, 0xc8, 0xaa,
                        0xcf, 0x84, 0x6e, 0x86, 0x78, 0x90, 0x51, 0xd3,
                        0x79, 0x98, 0xf7, 0xb9, 0x02, 0x2d, 0x75, 0x98
                    };
                    B = new byte[]
                    {
                        0x80, 0x5a
                    };
                    M = new byte[]
                    {
                        0x9b, 0x9f, 0x60, 0x5f, 0x5a, 0x85, 0x81, 0x07,
                        0xab, 0x1e, 0xc8, 0x5e, 0x6b, 0x41, 0xc8, 0xaa,
                        0x58, 0x2c, 0xa3, 0x51, 0x1e, 0xdd, 0xfb, 0x74,
                        0xf0, 0x2f, 0x3a, 0x65, 0x98, 0x98, 0x0b, 0xb9
                    };
                    Q = new byte[]
                    {
                        0x9b, 0x9f, 0x60, 0x5f, 0x5a, 0x85, 0x81, 0x07,
                        0xab, 0x1e, 0xc8, 0x5e, 0x6b, 0x41, 0xc8, 0xaa,
                        0x58, 0x2c, 0xa3, 0x51, 0x1e, 0xdd, 0xfb, 0x74,
                        0xf0, 0x2f, 0x3a, 0x65, 0x98, 0x98, 0x0b, 0xb9
                    };
                    X = new byte[]
                    {
                        0x00
                    };
                    Y = new byte[]
                    {
                        0x41, 0xec, 0xe5, 0x57, 0x43, 0x71, 0x1a, 0x8c,
                        0x3c, 0xbf, 0x37, 0x83, 0xcd, 0x08, 0xc0, 0xee,
                        0x4d, 0x4d, 0xc4, 0x40, 0xd4, 0x64, 0x1a, 0x8f,
                        0x36, 0x6e, 0x55, 0x0d, 0xfd, 0xb3, 0xbb, 0x67
                    };
                    break;
                }
                #endregion
                #region GOST-34.10-2018-Example1
                case ID.ParamSetGOST34102018256bit:
                    {
                        Name = "GOST 34.10-2018-Example1";
                        OID = "None";
                        P = new byte[]
                        {
                            0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x31
                        };
                        A = new byte[]
                        {
                            0x07
                        };
                        B = new byte[]
                        {
                            0x5f, 0xbf, 0xf4, 0x98, 0xaa, 0x93, 0x8c, 0xe7,
                            0x39, 0xb8, 0xe0, 0x22, 0xfb, 0xaf, 0xef, 0x40,
                            0x56, 0x3f, 0x6e, 0x6a, 0x34, 0x72, 0xfc, 0x2a,
                            0x51, 0x4c, 0x0c, 0xe9, 0xda, 0xe2, 0x3b, 0x7e
                        };
                        M = new byte[]
                        {
                            0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01,
                            0x50, 0xfe, 0x8a, 0x18, 0x92, 0x97, 0x61, 0x54,
                            0xc5, 0x9c, 0xfc, 0x19, 0x3a, 0xcc, 0xf5, 0xb3
                        };
                        Q = new byte[]
                        {
                            0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01,
                            0x50, 0xfe, 0x8a, 0x18, 0x92, 0x97, 0x61, 0x54,
                            0xc5, 0x9c, 0xfc, 0x19, 0x3a, 0xcc, 0xf5, 0xb3
                        };
                        X = new byte[]
                        {
                            0x02
                        };
                        Y = new byte[]
                        {
                            0x08, 0xe2, 0xa8, 0xa0, 0xe6, 0x51, 0x47, 0xd4,
                            0xbd, 0x63, 0x16, 0x03, 0x0e, 0x16, 0xd1, 0x9c,
                            0x85, 0xc9, 0x7f, 0x0a, 0x9c, 0xa2, 0x67, 0x12,
                            0x2b, 0x96, 0xab, 0xbc, 0xea, 0x7e, 0x8f, 0xc8

                        };
                        break;
                    }
                    #endregion
            }
        }
    }
}
