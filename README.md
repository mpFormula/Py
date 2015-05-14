### Welcome to mpFormulaPy!
The mpFormulaPy library provides a comprehensive set of real and complex functions in multiprecision arithmetic. For a subset of functions there is also support for decimal and interval arithmetic. mpFormulaPy is based on the [Python](https://www.python.org/) runtime and the [mpmath](http://mpmath.org/) library, both of which implement multiprecision arithmetic. Additional planned functionality includes integration in [Microsoft Excel](https://products.office.com/en-us/excel) (Windows)  and [LibreOffice Calc](https://www.libreoffice.org/) (Windows, Mac OSX, GNU/Linux), with multiprecision support for the numerical functions of these spreadsheet programs.
The current version is 0.1, alpha1 (pre-release), and much of the planned functionality is still missing.


### Manual
The manual is also available separately as pdf file: [mpFormulaPy.pdf](https://github.com/mpFormula/Py/raw/master/Manual/mpFormulaPy.pdf).


### Quick start under Windows
System requirements: Windows (Desktop) with [.NET Framework 4.x (Full)](http://www.microsoft.com/en-us/download/details.aspx?id=17718).

Download the ZIP file and unzip it into a directory for which you have write access.
Within the unzipped directory double-click on `mpFormula.bat`. This will start the Python Console of the  [SharpDevelop](http://www.icsharpcode.net/OpenSource/SD/) IDE.
To confirm that mpFormulaPy is working, type the following within the Python Console:

```
>>> from mpFormulaPy import *
>>> pi
﻿mpf('3.141592653589793238462643402')
>>>
```
Still in the Sharpdevelop IDE, click on `Tools -> mpFormulaPy Manual`, to open the manual in your default pdf viewer.

Within the manual, navigate to `Getting Started - Tutorials`, and follow the examples.
You can copy and paste the Python code of the examples from the manual into the Python Console.


### Quick start with Microsoft Excel (Windows)
To use the mpFormulaPy functions from within Excel, you need to install the mpFormulaPy add-in for Excel: Within Excel open the Add-Ins dialogue. Click on Browse, and navigate to the mpFormulaPy directory. Within this directory, open the mpNum directory, and select `mpFormula32.xll` or  `mpFormula64.xll`, matching your version of Excel (32 bit or 64 bit).


### Quick start with LibreOffice Calc (Windows, Mac OSX, GNU/Linux)
To use the mpFormulaPy functions from within LibreOffice Calc, you need to install the mpFormulaPy add-in for LibreOffice (see the manual, appendix B, for details).


### Additional Information
The site ["Numerical Explorations"](https://duhadler.wordpress.com/) contains background information related to Python and Verified Computing in general, and mpFormulaPy in particular.


### License
The mpFormulaPy Library and Toolbox is free software. It is licensed under the GNU Lesser General Public License, Version 3 ([LGPLv3](https://www.gnu.org/licenses/lgpl.html)).





