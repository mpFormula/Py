import clr; clr.AddReference("mpFormulaXLClassLib"); from mpFormulaXLClassLib import *



import clr; import sys; sys.path.append(r"I:\Data\mpFormulaTDM\mpFormulaC\Source\mpNumerix2\mpNumerix2\bin\Release"); clr.AddReference ("mpNumerix2.dll"); from mpNumerix2 import mp, mpNum; mp = mp();  mp.SetPrecision(40);

import clr; import sys; sys.path.append(r"C:\Extra\mpFormulaTDM\Toolbox\Source\mpNumerix2\mpNumerix2\bin\Release"); clr.AddReference ("mpNumerix2.dll"); from mpNumerix2 import mp, mpNum; mp = mp();  mp.SetPrecision(40);


import clr; clr.AddReference('MatrixClass2'); from MatrixClass2 import mp as np, mpNum; np.FloatingPointType=3; np.Prec10=60;

import sys; sys.path.append(r"I:\Data\mpFormulaTDM\mpFormulaXL\mpNum\AddIns\BackendBindings\PythonBinding\Lib")



IronPython 2.7.4 (2.7.0.40) on .NET 4.0.30319.1026 (32-bit)
Type "help", "copyright", "credits" or "license" for more information.
>>> import sys; sys.path.append(r"C:\Extra\mpFormulaTDM\mpFormulaXL\mpNum")
>>> import clr; clr.AddReference("mpFormulaXLClassLib")
>>> from mpFormulaXLClassLib import *
>>> a = mp.CNum("123")
>>> a
﻿<mpFormulaXLClassLib.mpNum object at 0x000000000000002B [mpFormulaXLClassLib.mpNum]>
>>> b = mpNum("2000")
>>> b
<mpFormulaXLClassLib.mpNum object at 0x000000000000002C [mpFormulaXLClassLib.mpNum]>
>>> a.Str(20)
'123.0'
>>> b.Str(20)
'2000.0'
>>> x = float("12345")
>>> x
12345.0
>>> i = long("2435345623456235462613451345134561345")
>>> i
2435345623456235462613451345134561345L
>>> 