import clr
import sys


class MyClass:
    def __init__(self):
        print "I'm in a compiled class (I hope)"

    def somemethod(self):
        print "in some method"

    def isodd(self, n):
        return 1 == n % 2
       
    def sum(self, a, b):
        return a + b      

print sys.path

print "Hello, World!"
print "Hello, World!"
print "Hello, World!"

a = 3.5
b = 7.3
t = MyClass()
print t.sum(a, b)


#from mpmath import *


print "Press any key to continue..." 
#System.Console.ReadKey(True)


print "Hello, World!"
print "Hello, World!"
print "Hello, World!"

import System 
print "Press any key to continue..." 
System.Console.ReadKey(True)
