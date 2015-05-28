# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""
from decimal import *
getcontext().prec = 1000
a = Decimal('123E+300')
b = Decimal('456E-300')
c = a + b
d = c - a
print (a)
print (b)
print (c)
print (d)

