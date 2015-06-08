
#import emb
import math
import gmpy2
from gmpy2 import mpfr
from mpmath import *

def TestLong(a,b):
    #print("Number of arguments", emb.numargs())

    x = 21
    s='a*x+1'
    result=eval(s)
    print(result)

    return a*b


def TestDouble(a,b):
    #print("Number of arguments", emb.numargs())

    x = 21
    s='a*x+1'
    result=eval(s)
    print(result)

    return a*b


def TestStringFunc(a,b):
    #print("Number of arguments", emb.numargs())

    x = 21.3
    
    s = 'MyString'
    print(a)
    print(b)
    return s



def TestStringMpf0():
    #print("Number of arguments", emb.numargs())
    mp.dps = 100

    x = mp.sqrt(2)
    s = nstr(x, 30)
    return s


def TestStringMpf1(a):
    #print("Number of arguments", emb.numargs())
    mp.dps = 100

    x = mpf(a)
    x = mp.sqrt(x)
    s = nstr(x, 30)
    return s


def TestStringMpf2(a,b):
    #print("Number of arguments", emb.numargs())
    mp.dps = 100

    x = mpf(a)
    x = mp.sqrt(x)
    y = mpf(b)
    z = x * y

    s = nstr(z, 30)
    return s



def callfunc2(a,b):
    #print("Number of arguments", emb.numargs())

    gmpy2.get_context().precision=100
    print(gmpy2.sqrt(5))

    mp.dps = 50
    print(mpf(2) ** mpf('0.5'))

    x = 21.3
    s='a*x+1 * math.sin(3)'
    result=eval(s)
    print(result)

    mycode = """print ('hello world from mycode')"""
	
    exec(mycode)

    def f(x):
        x = x + 12
        return x
    
    print (f(4))

    print("Will compute", a, "times", b)
    c = 0
    for i in range(0, a):
        c = c + b
    return c