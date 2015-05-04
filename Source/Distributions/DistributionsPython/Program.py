import clr
import sys
import math
import System
#from mpNew import *

class Program(object):


    def LnGamma(self, a):
        t = math.lgamma(a)
        return t


    def Lnbeta(self, a, b):
        t = math.lgamma(a)
        t = t + math.lgamma(b)
        t = t - math.lgamma(a + b)
        return t



    def ndens(self, X):
        Result =  (-X * X * 0.5) + math.log(math.sqrt(2 * math.pi))
        return Result



    def tdens(self, n, X):
        C = (1.0 + (X * X) / (n * 1.0))
        h = math.lgamma2((n + 1.0) / 2.0) - math.lgamma(n / 2.0) 
        h = math.exp(h)
        h = h / math.sqrt(math.pi) / math.sqrt(n)
        Result = h * (C ** (-((n / 2.0) + (1.0 / 2.0))))
        return Result


    def cdens(self, n, X):
        b = n / 2.0
        m = X / 2.0
        Result = 0.0
        if (X <= 0.0):
            Result = 0.0
        else:
            LastLngamma = math.lgamma(b)
            Result = 0.5 * math.exp(math.log(m) * (b - 1.0) - LastLngamma - m)
        return Result


    def ndis(self, x):
        Result = 0.5 * math.erfc(-x / math.sqrt(2))
        return Result



    def cdis2(self, n, X):
        MinRelError = 1.0E-16
        if (X <= 0):
            LeftTail = 0.0
            RightTail = 1.0
            density = 0.0
            return LeftTail, RightTail, density
        density = self.cdens(n, X)
        if ((X <= 12) | (X <= n)):
            c3 = True
        else:
            c3 = False
        b = n / 2.0
        m = X / 2.0
        k = 2.0 * density
        a0 = 1.0
        b0 = 1.0
        bn = 0.0
        j = 0.0
        sum0 = 1.0
        sum1 = 1.0
        if c3:
            k = k * m / b
            A1 = b + 1.0 - m
            b1 = b + 1.0
            bn = b + 1.0
        else:
            A1 = m + 1.0 - b
            b1 = m
        eps = 1.0
        while (math.fabs(eps) > MinRelError):
            j = j + 1.0
            i = 0
            while i <= 1:
                if c3:
                    if i == 1:
                        an = -(b + j) * m
                    else:
                        an = j * m
                    bn = bn + 1.0
                else:
                    if i == 1:
                        an = j + 1.0 - b
                        bn = m
                    else:
                        an = j
                        bn = 1
                A2 = bn * A1 + an * a0
                b2 = bn * b1 + an * b0
                A2 = A2 / b2
                A1 = A1 / b2
                b1 = b1 / b2
                b2 = 1.0
                a0 = A1
                A1 = A2
                b0 = b1
                b1 = b2
                if i == 1:
                    sum1 = A2
                else:
                    sum0 = A2
                i = i + 1
            xsum = (sum0 + sum1) /2.0
            eps = math.fabs(sum0 - sum1) / xsum
        k = k / xsum
        LeftTail = 1.0 - k
        RightTail = k
        if c3:
            #self.SwapTails(LeftTail, RightTail)
            temp = LeftTail
            LeftTail = RightTail
            RightTail = temp

        return LeftTail, RightTail, density


    def cdis(self, n, X):
        self.cdis2(n, X, LeftTail, RightTail, density)
        cdis = LeftTail


    def betadens(self, a, b, Q, p):
        k = -self.Lnbeta(a, b)
        k = k + (b - 1.0) * math.log(p) + (a - 1.0) * math.log(Q)
        density = math.exp(k)
        return density


    def betadis(self, a, b, Q, p):
        MinRelError = 1.0E-16
        if (Q <= 0):
            LeftTail = 0.0
            RightTail = 1.0
            density = 0.0
            return LeftTail, RightTail, density
        if (p <= 0):
            LeftTail = 1.0
            RightTail = 0.0
            density = 0.0
            return LeftTail, RightTail, density
        density = self.betadens(a, b, Q, p)
        X = (b * Q) / (a * p)
        limit = 4.0 - a
        if limit < 1.0:
            limit = 1.0
        fit = (X < limit)
        if not fit:
            #self.SwapTails(a, b)
            #self.SwapTails(p, Q)
            temp = a
            a = b
            b = temp
            temp = p
            p = Q
            Q = temp
        qp = Q / p
        a0 = 1.0
        A1 = a + 1.0 - (b - 1.0) * qp
        b0 = 1.0
        b1 = a + 1.0
        j = 0.0
        bn = a + 1.0
        eps = 1.0
        sum0 = 1.0
        sum1 = 1.0
        while (math.fabs(eps) > MinRelError):
            j = j + 1.0
            i = 0
            while i <= 1:
                if i == 1:
                    an = -(a + j) * (b - j - 1.0) * qp
                else:
                    an = j * (a + b - 1.0 + j) * qp
                bn = bn + 1.0
                A2 = bn * A1 + an * a0
                b2 = bn * b1 + an * b0
                A2 = A2 / b2
                A1 = A1 / b2
                b1 = b1 / b2
                b2 = 1.0
                a0 = A1
                A1 = A2
                b0 = b1
                b1 = b2
                if i == 1:
                    sum1 = A2
                else:
                    sum0 = A2
                i = i + 1
            xsum = (sum0 + sum1) /2.0
            eps = math.fabs(sum0 - sum1) / xsum
        RightTail = density * Q / (a * xsum)
        LeftTail = 1.0 - RightTail
        if fit:
            #self.SwapTails(LeftTail, RightTail)
            temp = LeftTail
            LeftTail = RightTail
            RightTail = temp
        return LeftTail, RightTail, density


    def Fdis(self, m, n, a):
        if a <= 0:
            LeftTail = 0
            RightTail = 1
            density = 0
            return LeftTail, RightTail, density
        X = 1.0 * m * a / (m * a + n)
        y = 1.0 * n / (m * a + n)
        p = m / 2.0
        Q = n / 2.0
        LeftTail, RightTail, density =self.betadis(p, Q, X, y)
        return LeftTail, RightTail, density


    def tdis(self, n, t):
        if t == 0:
            LeftTail = 0.5
            RightTail = 0.5
            tdis = 0
            density = 0
            return LeftTail, RightTail, density
        LeftTail, RightTail, density = self.Fdis(1, n, t * t)
        RightTail = RightTail / 2
        LeftTail = 1 - RightTail #Debug.Print LeftTail, RightTail
        if t < 0:
            temp = LeftTail
            LeftTail = RightTail
            RightTail = temp
        return LeftTail, RightTail, density



    def cdisOwen(self, n, X):
        C = -math.exp(-X * 0.5)
        F = 1.0
        k = n % 2
        if k != 0:
            C = C * math.sqrt(2.0 * X / math.pi) # C=ndens(x)
            F = 1.0 - 2.0 * self.ndis(-math.sqrt(X))
        k = k + 2
        i = k
        while i <= n:
            F = F + C
            C = C * X / i
            i = i + 2
        return F



    def tdisOwen(self, n, X):
        a = X / math.sqrt(n)
        b = 1 + a * a
        k = n % 2
        F = 0.5
        if k != 0:
            C = a / (b * math.pi)
            F = F + math.atan(a) / math.pi
        else:
            C = a / (2 * math.sqrt(b))
        k = k + 2
        i = k
        while i <= n:
            F = F + C
            C = C * (1.0 - (1.0 / i)) / b
            i = i + 2
        return F


 #    Function FdisOwen(ByVal m As Long, ByVal n As Double, ByVal X As Double) As Double
    def FdisOwen(self, m, n, X):
        k = m % 2
        if k == 0:
            z = 1.0 * n / (n + m * X)
            result = z ** (n * 0.5)
            if m > 2:
                U = 1.0 - z
                sum = 1.0
                a = 1.0
                i = 1
                while i <= (m - 2) / 2:
                    a = a * U * (2.0 * i + n - 2.0) / (2.0 * i)
                    sum = sum + a
                    i = i + 1
                result = result * sum
        else:
            z = Math.Sqrt(m * X)
            result = 2.0 * self.tdisOwen(n, -z)
            if m > 1:
                U = z * z / (z * z + n)
                sum = z
                a = z
                i = 2
                while i <= (m - 1) / 2:
                    a = a * U * (2.0 * i + n - 3.0) / (2.0 * i - 1.0)
                    sum = sum + a
                    i = i + 1
                result = result + 2.0 * sum * self.tdens(n, z)
        return result


    def demoLnGamma(self):
        a = 1000000000
        b = 1000000000
        lnG = self.LnGamma(a)
        lnB = self.Lnbeta(a, b)
        s = "My Result: "
        print s, lnG, lnB


    def DemoTdens(self):
        n = 16
        X = 2
        Result = self.tdens(n, X)
        print Result



    def DemoCdis(self):
        n = 13
        X = 2.0
        Result = self.cdisOwen(n, X)
        print Result


    def DemoFdis(self):
        m = 12
        n = 2
        X = 2.0
        Result = self.FdisOwen(m, n, X)
        LeftTail, RightTail, density = self.Fdis(m, n, X)
        print LeftTail, RightTail


    def DemoCdis2(self):
        n = 13
        X = 2.0
        LeftTail, RightTail, density = self.cdis2(n, X)
        print LeftTail, RightTail, density


    def DemoCdens(self):
        n = 13
        X = 2.0
        Result = self.cdens(n, X)
        print Result


    def DemoBetadens(self):
        a = 13.0
        b = 15.0
        q = 0.4
        p = 1 - q
        Result = self.betadens(a, b, q, p)
        print Result


    def BetaDisdemo(self):
        a = 100
        b = 100
        p = 0.4
        Q = 1 - p
        LeftTail, RightTail, density = self.betadis(a, b, Q, p)
        print LeftTail, RightTail, density


    def DemoFdis(self):
        m = 12
        n = 2
        X = 2.0
        Result = self.FdisOwen(m, n, X)
        print Result
        LeftTail, RightTail, density = self.Fdis(m, n, X)
        print LeftTail, RightTail


    def DemoTdis(self):
        n = 13
        X = -2.0
        Result = self.tdisOwen(n, X)
        print Result
        LeftTail, RightTail, density = self.tdis(n, X)
        print LeftTail, RightTail



    def ndisx(LeftTailSoll, RightTailSoll):
        temp = 0
        if LeftTailSoll < RightTailSoll:
            temp = DistX.ndisx1(LeftTailSoll, RightTailSoll)
        else:
            temp = DistX.ndisx1(RightTailSoll, LeftTailSoll)
        if LeftTailSoll > RightTailSoll:
            temp = -temp
        return temp



    def ndisx1(LeftTailSoll, RightTailSoll):
        split1 = 0.425
        split2 = 5.0
        const1 = 0.180625
        const2 = 1.6
        a0 = 3.38713287279637
        A1 = 133.141667891784
        A2 = 1971.59095030655
        a3 = 13731.6937655095
        a4 = 45921.9539315499
        A5 = 67265.7709270087
        a6 = 33430.5755835881
        A7 = 2509.08092873012
        b1 = 42.3133307016009
        b2 = 687.187007492058
        B3 = 5394.19602142475
        b4 = 21213.7943015866
        B5 = 39307.8958000927
        B6 = 28729.0857357219
        B7 = 5226.49527885285
        C0 = 1.42343711074968
        C1 = 4.63033784615655
        c2 = 5.76949722146069
        c3 = 3.6478483247632
        c4 = 1.27045825245237
        c5 = 0.241780725177451
        c6 = 0.0227238449892692
        C7 = 0.000774545014278341
        d1 = 2.05319162663776
        d2 = 1.6763848301838
        D3 = 0.6897673349851
        D4 = 0.14810397642748
        D5 = 0.0151986665636165
        D6 = 0.000547593808499535
        D7 = 1.05075007164442E-09
        E0 = 6.6579046435011
        e1 = 5.46378491116411
        e2 = 1.78482653991729
        E3 = 0.296560571828505
        E4 = 0.0265321895265761
        E5 = 0.00124266094738808
        E6 = 2.71155556874349E-05
        E7 = 2.01033439929229E-07
        f1 = 0.599832206555888
        f2 = 0.136929880922736
        f3 = 0.0148753612908506
        f4 = 0.000786869131145613
        f5 = 1.84631831751005E-05
        f6 = 1.42151175831645E-07
        f7 = 2.04426310338994E-15
        ppnd16 = 0
        r = 0
        p = 0
        Q = 0
        p = LeftTailSoll
        Q = LeftTailSoll - 0.5
        if (Math.Abs(Q) <= split1):
            r = const1 - Q * Q
            ppnd16 = Q * (((((((A7 * r + a6) * r + A5) * r + a4) * r + a3) * r + A2) * r + A1) * r + a0) / (((((((B7 * r + B6) * r + B5) * r + b4) * r + B3) * r + b2) * r + b1) * r + 1)
            return ppnd16
        else:
            if (Q < 0):
                r = p
            else:
                r = 1 - p
            if r <= 0:
                #{     ifault=1}
                ppnd16 = 0
                return ppnd16
            r = Math.Sqrt(-Math.Log(r))
            if (r <= split2):
                r = r - const2
                ppnd16 = (((((((C7 * r + c6) * r + c5) * r + c4) * r + c3) * r + c2) * r + C1) * r + C0) / (((((((D7 * r + D6) * r + D5) * r + D4) * r + D3) * r + d2) * r + d1) * r + 1)
            else:
                r = r - split2
                ppnd16 = (((((((E7 * r + E6) * r + E5) * r + E4) * r + E3) * r + e2) * r + e1) * r + E0) / (((((((f7 * r + f6) * r + f5) * r + f4) * r + f3) * r + f2) * r + f1) * r + 1)
            if Q < 0:
                ppnd16 = -ppnd16
            return ppnd16



    def LambertW(X):
        return (((((125 * X - 64) * X + 36) * X - 24) * X + 24) * X) / 24



    def cdisx_Lambert(LeftTail, RightTail, n):
        t = 0
        d = 0
        k = 0
        a = 0
        result = 0
        a = 1 / (0.5 * n - 1)
        k = Dist.LnGamma(0.5 * n)
        d = a * (Math.Log(LeftTail) + k)
        t = -a * Math.Exp(LeftTail + d)
        #    Debug.Print "a: ", a, "k: ", k, "d: ", d, "t: ", t
        result = -2 * DistX.LambertW(t) / a
        return result


    def cdisx_Canal(LeftTail, RightTail, n):
        h = 0
        L = 0
        mean = 0
        stdev = 0
        U = 0
        m = 0
        m2 = 0
        m3 = 0
        g = 0
        z = 0
        result = 0
        z = DistX.ndisx(LeftTail, RightTail)
        m = 1 / n
        m2 = m * m
        m3 = m2 * m
        mean = (14580 - 1944 * m - 189 * m2 + 200 * m3) / 17496
        stdev = Math.Sqrt(Math.Abs(648 * m + 72 * m2 - 37 * m3)) / 108
        g = Math.Sqrt(0.5 * m3) / 162
        z = z - g + (z * g) * (z - (2 * z * z - 5) * g)
        L = 6 * (z * stdev + mean)
        h = DistX.Cbrt(2 * (L + Math.Sqrt(13 + L * (L - 5))) - 5)
        U = 0.5 + 0.5 * h - 1.5 / h
        U = U * U * U
        result = n * U * U
        return result



    def cdisx_approx(LeftTail, RightTail, n):
        t = 0
        d = 0
        k = 0
        a = 0
        result = 0
        UseLambert = False
        h = 0
        L = 0
        mean = 0
        stdev = 0
        U = 0
        m = 0
        m2 = 0
        m3 = 0
        g = 0
        z = 0
        UseLambert = True
        if UseLambert:
            a = 1 / (0.5 * (n + 2) - 1)
            k = Dist.LnGamma(0.5 * (n + 2))
            d = a * (Math.Log(LeftTail) + k)
            t = -a * Math.Exp(LeftTail + d)
            print("t: ", t)
            if Math.Abs(t) > 0.1:
                UseLambert = False
        if UseLambert:
            print("Use Lambert")
            result = -(((((125 * t - 64) * t + 36) * t - 24) * t + 24) * t) / (12 * a)
        else:
            print("Use Canal")
            z = ndisx(LeftTail, RightTail)
            m = 1 / n
            m2 = m * m
            m3 = m2 * m
            mean = (14580 - 1944 * m - 189 * m2 + 200 * m3) / 17496
            stdev = Math.Sqrt(Math.Abs(648 * m + 72 * m2 - 37 * m3)) / 108
            g = Math.Sqrt(0.5 * m3) / 162
            z = z - g + (z * g) * (z - (2 * z * z - 5) * g)
            L = 6 * (z * stdev + mean)
            h = DistX.Cbrt(2 * (L + Math.Sqrt(13 + L * (L - 5))) - 5)
            U = 0.5 + 0.5 * h - 1.5 / h
            U = U * U * U
            result = n * U * U
        return result



    def cdisx_new(LeftTail, RightTail, m):
        Left1 = 0
        Right1 = 0
        deriv = 0
        diff = 0
        delta = 0
        x1 = 0
        if m < 0.5:
            print("m must be >= 0.5")
            return 1
        MinRelError = 1E-13
        RelError = 1.0
        X = DistX.cdisx_approx(LeftTail, RightTail, m)
        X = Math.Abs(X)
        k = 0
        UseLeftTail = False
        if LeftTail < RightTail:
            UseLeftTail = True
        while ((RelError > MinRelError) & (k < 100)):
            k = k + 1
            LeftTail, RightTail, density = cdis2(m, X)
            if UseLeftTail:
                diff = LeftTail - Left1
            else:
                diff = Right1 - RightTail
            delta = 0
            if deriv != 0:
                delta = diff / deriv
            x1 = X + delta
            if x1 <= 0:
                x1 = X / 2
            X = x1
            RelError = Math.Abs(delta) / X
        return X



    def demoCdisx():
        m = 10.5
        LeftTail = 1E-15
        RightTail = 1 - LeftTail
        #		double RightTail = 1E-220;
        #		double LeftTail = 1 - RightTail;
        R0 = DistX.cdisx_new(LeftTail, RightTail, m)
        print("R0      : ", R0)
        r1 = DistX.cdisx_Lambert(LeftTail, RightTail, m + 2)
        print("LambertL: ", r1, ", ", Math.Abs(r1 - R0) / R0)
        r2 = DistX.cdisx_Canal(LeftTail, RightTail, m)
        print("Canal   : ", r2, ", ", Math.Abs(r2 - R0) / R0)
        print("")



    def Main(self):
        self.DemoCdis2()
        
        
MyObj = Program()
print "Starting..."
MyObj.Main()
print("Press any key to continue")
#print sys.path
#mp.dps = 100
#a = mp.pi()
#print a
System.Console.ReadKey()

