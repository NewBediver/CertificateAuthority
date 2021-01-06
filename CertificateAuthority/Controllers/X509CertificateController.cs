using CertificateAuthority.SignatureForms;
using CertificateRepository.Controller;
using CertificateRepository.Model;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Extension;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CertificateAuthority.Components
{
    class X509CertificateController
    {
        public static byte[] GetSignedCertificate(AlgParSet parameters, Subj subj)
        {
            X509Certificate root = new X509CertificateParser().ReadCertificate(GetRootCertificate());
            Cert data = CreateDatabaseInfoFromCertificate(root);

            Cert certificate = new Cert();
            certificate.Ver_Cert = DatabaseInstance.GetInstance().Vers.FirstOrDefault();
            var keys = GenerateKeyPair(parameters);
            certificate.SignAlg_Cert = new SignAlg
            {
                AlgParSet_SignAlg = parameters,
                PrivateKey_SignAlg = PrivateKeyInfoFactory.CreatePrivateKeyInfo(keys.Private).ToAsn1Object().GetEncoded(),
                PublicKey_SignAlg = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(keys.Public).ToAsn1Object().GetEncoded()
            };
            certificate.Issuer_Cert = data.Issuer_Cert;
            certificate.Subj_Cert = subj;
            do
            {
                certificate.SerialNumber_Cert = BigIntegers.CreateRandomBigInteger(512, new SecureRandom()).ToString();
            }
            while (DatabaseInstance.GetInstance().Certs.FirstOrDefault(elm => elm.SerialNumber_Cert == certificate.SerialNumber_Cert) != null);
            certificate.ValidFrom_Cert = DateTime.Now;
            certificate.ValidBy_Cert = DateTimeOffset.Now.AddYears(5).UtcDateTime;
            certificate.SignSerialNumber_Cert = data.SerialNumber_Cert;

            var cert = CreateCertificateFromDatabaseInfo(certificate);
            certificate.SignValue_Cert = string.Join("", BitConverter.ToString(cert.GetSignature()).Split('-'));

            DatabaseInstance.GetInstance().Certs.Add(certificate);
            DatabaseInstance.GetInstance().SaveChanges();

            return cert.GetEncoded();
        }

        public static byte[] GetRootCertificate()
        {
            Issuer certificationAuthority = GetCurrentCertificationAuthority();
            if (certificationAuthority == null)
            {
                throw new Exception("Cannot find certification authority!");
            }

            var certificate = DatabaseInstance.GetInstance().Certs
                .Include(elm => elm.Ver_Cert)
                .Include(elm => elm.SignAlg_Cert).ThenInclude(elm => elm.AlgParSet_SignAlg).ThenInclude(elm => elm.AlgName_AlgParSet)
                .Include(elm => elm.SignAlg_Cert).ThenInclude(elm => elm.AlgParSet_SignAlg).ThenInclude(elm => elm.HashType_AlgParSet)
                .Include(elm => elm.SignAlg_Cert).ThenInclude(elm => elm.AlgParSet_SignAlg).ThenInclude(elm => elm.Len_AlgParSet)
                .Include(elm => elm.Subj_Cert).ThenInclude(elm => elm.Gender_Subj)
                .Include(elm => elm.Subj_Cert).ThenInclude(elm => elm.Citizen_Subj)
                .Include(elm => elm.Subj_Cert).ThenInclude(elm => elm.City_Subj).ThenInclude(elm => elm.Region_City).ThenInclude(elm => elm.Country_Region)
                .Include(elm => elm.Issuer_Cert).ThenInclude(elm => elm.City_Issuer).ThenInclude(elm => elm.Region_City).ThenInclude(elm => elm.Country_Region)
                .FirstOrDefault(elm => elm.Issuer_Cert == certificationAuthority && elm.Subj_Cert.Name_Subj == certificationAuthority.Name_Issuer);
            if (certificate == null)
            {
                certificate = new Cert();
                certificate.Ver_Cert = DatabaseInstance.GetInstance().Vers.FirstOrDefault();
                var keys = GenerateKeyPair(DatabaseInstance.GetInstance().AlgParSets
                    .Include(elm => elm.Len_AlgParSet)
                    .FirstOrDefault(elm => elm.OID_AlgParSet == "1.2.643.7.1.2.1.1.1"));
                certificate.SignAlg_Cert = new SignAlg
                {
                    AlgParSet_SignAlg = DatabaseInstance.GetInstance().AlgParSets.FirstOrDefault(elm => elm.OID_AlgParSet == "1.2.643.7.1.2.1.1.1"),
                    PrivateKey_SignAlg = PrivateKeyInfoFactory.CreatePrivateKeyInfo(keys.Private).ToAsn1Object().GetEncoded(),
                    PublicKey_SignAlg = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(keys.Public).ToAsn1Object().GetEncoded()
                };
                certificate.Issuer_Cert = certificationAuthority;
                certificate.Subj_Cert = new Subj
                {
                    Surname_Subj = "",
                    Name_Subj = certificationAuthority.Name_Issuer,
                    BirthDate_Subj = DateTime.Now,
                    Gender_Subj = DatabaseInstance.GetInstance().Genders.FirstOrDefault(),
                    Citizen_Subj = DatabaseInstance.GetInstance().Citizens.FirstOrDefault(),
                    City_Subj = certificationAuthority.City_Issuer,
                    Phone_Subj = certificationAuthority.Phone_Issuer,
                    EMail_Subj = certificationAuthority.EMail_Issuer,
                    PassportSerias_Subj = "",
                    PassportNumber_Subj = "",
                    INN_Subj = certificationAuthority.INN_Issuer,
                    SNILS_Subj = ""
                };
                do
                {
                    certificate.SerialNumber_Cert = BigIntegers.CreateRandomBigInteger(512, new SecureRandom()).ToString();
                }
                while (DatabaseInstance.GetInstance().Certs.FirstOrDefault(elm => elm.SerialNumber_Cert == certificate.SerialNumber_Cert) != null);
                certificate.ValidFrom_Cert = DateTime.Now;
                certificate.ValidBy_Cert = DateTimeOffset.Now.AddYears(5).UtcDateTime;
                certificate.SignSerialNumber_Cert = "";

                var cert = CreateCertificateFromDatabaseInfo(certificate);
                certificate.SignValue_Cert = string.Join("", BitConverter.ToString(cert.GetSignature()).Split('-'));

                DatabaseInstance.GetInstance().Certs.Add(certificate);
                DatabaseInstance.GetInstance().SaveChanges();

                return cert.GetEncoded();
            }

            return CreateCertificateFromDatabaseInfo(certificate).GetEncoded();
        }

        private static Issuer GetCurrentCertificationAuthority()
        {
            return DatabaseInstance.GetInstance().Issuers
                .Include(elm => elm.City_Issuer).ThenInclude(elm => elm.Region_City).ThenInclude(elm => elm.Country_Region)
                .FirstOrDefault(elm => elm.Name_Issuer == "Komsomolsk-on-Amur State University");
        }

        private static AsymmetricCipherKeyPair GenerateKeyPair(AlgParSet parameters)
        {
            while (true)
            {
                using var form = new KeyGenerationForm();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var parametersObject = GetDigitalSignatureAlgoParameterSetOID(parameters);
                    var ecp = new ECNamedDomainParameters(parametersObject, ECGost3410NamedCurves.GetByOidX9(parametersObject));
                    var gostParams = new ECGost3410Parameters(ecp, parametersObject, GetDigitalSignatureAlgoOID(parameters), null);
                    SecureRandom rand = new SecureRandom();
                    rand.SetSeed(form.Seed.ToArray());
                    var pars = new ECKeyGenerationParameters(gostParams, rand);
                    var generator = new ECKeyPairGenerator();
                    generator.Init(pars);

                    return generator.GenerateKeyPair();
                }
            }
        }

        private static DerObjectIdentifier GetDigitalSignatureAlgoOID(AlgParSet parameters)
        {
            return parameters.Len_AlgParSet.Value_Len switch
            {
                256 => RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256,
                512 => RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512,
                _ => throw new Exception("Wrong parameters length!"),
            };
        }

        private static DerObjectIdentifier GetHashAlgoOID(AlgParSet parameters)
        {
            return parameters.Len_AlgParSet.Value_Len switch
            {
                256 => RosstandartObjectIdentifiers.id_tc26_gost_3411_12_256,
                512 => RosstandartObjectIdentifiers.id_tc26_gost_3411_12_512,
                _ => throw new Exception("Wrong parameters length!"),
            };
        }

        private static DerObjectIdentifier GetDigitalSignatureAlgoParameterSetOID(AlgParSet parameters)
        {
            if (parameters.OID_AlgParSet == "1.2.643.7.1.2.1.2.1") return RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSetA;
            else if (parameters.OID_AlgParSet == "1.2.643.7.1.2.1.2.2") return RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSetB;
            else if (parameters.OID_AlgParSet == "1.2.643.7.1.2.1.2.3") return RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSetC;
            else if (parameters.OID_AlgParSet == "1.2.643.7.1.2.1.1.1") return RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256_paramSetA;
            else if (parameters.OID_AlgParSet == "1.2.643.7.1.2.1.1.2") return RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256_paramSetA/*B*/;
            else if (parameters.OID_AlgParSet == "1.2.643.7.1.2.1.1.3") return RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256_paramSetA/*C*/;
            else if (parameters.OID_AlgParSet == "1.2.643.7.1.2.1.1.4") return RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256_paramSetA/*D*/;

            throw new Exception("Wrong parameters OID!");
        }

        private static X509Certificate CreateCertificateFromDatabaseInfo(Cert certificate)
        {
            #region Issuer Attributes
            IList issuerAttrs = new ArrayList();
            issuerAttrs.Add(certificate.Issuer_Cert.Name_Issuer);
            issuerAttrs.Add(certificate.Issuer_Cert.Phone_Issuer);
            issuerAttrs.Add(certificate.Issuer_Cert.EMail_Issuer);
            issuerAttrs.Add(certificate.Issuer_Cert.City_Issuer.Region_City.Country_Region.Name_Country);
            issuerAttrs.Add(certificate.Issuer_Cert.OGRN_Issuer);
            issuerAttrs.Add(certificate.Issuer_Cert.INN_Issuer);

            IList issuerOrd = new ArrayList();
            issuerOrd.Add(X509Name.CN);
            issuerOrd.Add(X509Name.T);
            issuerOrd.Add(X509Name.E);
            issuerOrd.Add(X509Name.C);
            // OGRN
            issuerOrd.Add(new DerObjectIdentifier("1.2.643.100.1"));
            // INN
            issuerOrd.Add(new DerObjectIdentifier("1.2.643.3.131.1.1"));
            #endregion

            #region Subject attributes
            IList subjAttrs = new ArrayList();
            subjAttrs.Add(certificate.Subj_Cert.Name_Subj + (certificate.Subj_Cert.Surname_Subj != string.Empty ? " " + certificate.Subj_Cert.Surname_Subj : ""));
            subjAttrs.Add(certificate.Subj_Cert.City_Subj.Region_City.Country_Region.Name_Country);
            subjAttrs.Add(certificate.Subj_Cert.Phone_Subj);
            subjAttrs.Add(certificate.Subj_Cert.EMail_Subj);
            subjAttrs.Add(certificate.Subj_Cert.INN_Subj);

            IList subjOrd = new ArrayList();
            subjOrd.Add(X509Name.CN);
            subjOrd.Add(X509Name.C);
            subjOrd.Add(X509Name.T);
            subjOrd.Add(X509Name.E);
            // INN
            subjOrd.Add(new DerObjectIdentifier("1.2.643.3.131.1.1"));
            #endregion

            X509Certificate rootCert = null;
            if (certificate.Issuer_Cert.Name_Issuer != certificate.Subj_Cert.Name_Subj)
            {
                rootCert = new X509CertificateParser().ReadCertificate(GetRootCertificate());

                subjAttrs.Add(certificate.Subj_Cert.BirthDate_Subj.ToString("yyyyMMddHHmmssZ"));
                subjAttrs.Add(certificate.Subj_Cert.Gender_Subj.Name_Gender);
                subjAttrs.Add(certificate.Subj_Cert.Citizen_Subj.Name_Citizen);
                subjAttrs.Add(certificate.Subj_Cert.PassportSerias_Subj + " " + certificate.Subj_Cert.PassportNumber_Subj);
                subjAttrs.Add(certificate.Subj_Cert.SNILS_Subj);

                subjOrd.Add(X509Name.DateOfBirth);
                subjOrd.Add(X509Name.Gender);
                subjOrd.Add(X509Name.CountryOfCitizenship);
                subjOrd.Add(X509Name.SerialNumber);
                // SNILS
                subjOrd.Add(new DerObjectIdentifier("1.2.643.100.3"));
            }

            AsymmetricCipherKeyPair kp = new AsymmetricCipherKeyPair(
                PublicKeyFactory.CreateKey(certificate.SignAlg_Cert.PublicKey_SignAlg),
                PrivateKeyFactory.CreateKey(certificate.SignAlg_Cert.PrivateKey_SignAlg)
            );

            X509V3CertificateGenerator certGen = new X509V3CertificateGenerator();
            certGen.SetSerialNumber(new BigInteger(certificate.SerialNumber_Cert));
            certGen.SetIssuerDN(new X509Name(issuerOrd, issuerAttrs));
            certGen.SetNotBefore(certificate.ValidFrom_Cert);
            certGen.SetNotAfter(certificate.ValidBy_Cert);
            certGen.SetSubjectDN(new X509Name(subjOrd, subjAttrs));
            certGen.SetPublicKey(kp.Public);

            if (rootCert == null)
            {
                certGen.AddExtension(X509Extensions.BasicConstraints, true, new BasicConstraints(true));
                certGen.AddExtension(X509Extensions.AuthorityKeyIdentifier, true, new AuthorityKeyIdentifierStructure(kp.Public));
                certGen.AddExtension(X509Extensions.SubjectKeyIdentifier, false, new SubjectKeyIdentifierStructure(kp.Public));

                ISignatureFactory factory = new Asn1SignatureFactory("GOST3411withECGOST3410", kp.Private, new SecureRandom());
                X509Certificate x509 = certGen.Generate(factory);

                return x509;
            }
            else
            {
                certGen.AddExtension(X509Extensions.BasicConstraints, true, new BasicConstraints(false));
                certGen.AddExtension(X509Extensions.AuthorityKeyIdentifier, true, new AuthorityKeyIdentifierStructure(rootCert.GetPublicKey()));
                certGen.AddExtension(X509Extensions.SubjectKeyIdentifier, false, new SubjectKeyIdentifierStructure(kp.Public));

                ISignatureFactory factory = new Asn1SignatureFactory("GOST3411withECGOST3410", PrivateKeyFactory.CreateKey(CreateDatabaseInfoFromCertificate(rootCert).SignAlg_Cert.PrivateKey_SignAlg), new SecureRandom());
                X509Certificate x509 = certGen.Generate(factory);

                return x509;
            }
        }

        private static Cert CreateDatabaseInfoFromCertificate(X509Certificate cert)
        {
            return DatabaseInstance.GetInstance().Certs
                .Include(elm => elm.Ver_Cert)
                .Include(elm => elm.SignAlg_Cert).ThenInclude(elm => elm.AlgParSet_SignAlg).ThenInclude(elm => elm.AlgName_AlgParSet)
                .Include(elm => elm.SignAlg_Cert).ThenInclude(elm => elm.AlgParSet_SignAlg).ThenInclude(elm => elm.HashType_AlgParSet)
                .Include(elm => elm.SignAlg_Cert).ThenInclude(elm => elm.AlgParSet_SignAlg).ThenInclude(elm => elm.Len_AlgParSet)
                .Include(elm => elm.Subj_Cert).ThenInclude(elm => elm.Gender_Subj)
                .Include(elm => elm.Subj_Cert).ThenInclude(elm => elm.Citizen_Subj)
                .Include(elm => elm.Subj_Cert).ThenInclude(elm => elm.City_Subj).ThenInclude(elm => elm.Region_City).ThenInclude(elm => elm.Country_Region)
                .Include(elm => elm.Issuer_Cert).ThenInclude(elm => elm.City_Issuer).ThenInclude(elm => elm.Region_City).ThenInclude(elm => elm.Country_Region)
                .FirstOrDefault(elm => elm.SerialNumber_Cert == cert.SerialNumber.ToString());
        }
    }
}
