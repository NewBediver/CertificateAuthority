# Certification Authority

<a alt="C#Core"> <img src="https://img.shields.io/badge/C%23-.NET%20Core-blue" /> </a>
<a alt="MSSQLEF"> <img src="https://img.shields.io/badge/MSSQL-EF%20Core-red" /> </a>

My diploma project in the last year of university. This program is a simplified Certification Authority implemented on Windows Forms. Here you can find emplementation of [GOST 34.10-2018](https://files.stroyinf.ru/Data2/1/4293732/4293732954.pdf) cryptographic digital signature algorithm and [GOST 34.11-2018](https://files.stroyinf.ru/Data/705/70506.pdf) cryptographic hash function algorithm. To run this program you need .NET Framework and any SQL Server (I used MSSQL. Write your connection string in appsettings.json).

### Main features:
- Create/Verify GOST 34.10-2018 digital signature with key length of 256/512 bit 
- Calculate GOST 34.11-2018 hash from any message (256/512 bit length)
- Create self-signed X.509 certificate with Rosstandart Elliptic Curve parameters
- Create signed X.509 certificate with your information
- Create and manage DB with valid and cancelled certificates and the users information

### Database structure
![DB](/Screenshots/DB.png)

<details>
  <summary>Screenshots</summary>
  
  ### Main Form
  ![main](/Screenshots/Main.png)
  
  ***
  
  ### GOST 34.11-2018 submenu
  
  256 bit length             |  512 bit length
:-------------------------:|:-------------------------:
![Gost34112018256len](/Screenshots/Hash/256.png)  |  ![Gost34112018512len](/Screenshots/Hash/512.png)
  
  ***
  
  ### GOST 34.10-2018 submenu
  
  256 bit length             |  512 bit length
:-------------------------:|:-------------------------:
![Gost34102018256len](/Screenshots/Signature/256.png)  |  ![Gost34102018512len](/Screenshots/Signature/512.png)

  ***
  
  ### Create certificate
  ![createcert](/Screenshots/MainForms/CreateCert.png)
  ### Verify certificate
  ![verifycert](/Screenshots/MainForms/VerifyCert.png)
  ### Calculate signature
  ![calculatesign](/Screenshots/MainForms/CalculateSign.png)
  ### Verify signature
  ![verifysign](/Screenshots/MainForms/VerifySign.png)

</details>

### GPL3 LICENSE SYNOPSIS

Here's what the license entails:

```markdown
1. Anyone can copy, modify and distribute this software.
2. You have to include the license and copyright notice with each and every distribution.
3. You can use this software privately.
4. You can use this software for commercial purposes.
5. If you dare build your business solely from this code, you risk open-sourcing the whole code base.
6. If you modify it, you have to indicate changes made to the code.
7. Any modifications of this code base MUST be distributed with the same license, GPLv3.
8. This software is provided without warranty.
9. The software author or license can not be held liable for any damages inflicted by the software.
```

More information on about the [LICENSE can be found here](http://choosealicense.com/licenses/gpl-3.0/).
