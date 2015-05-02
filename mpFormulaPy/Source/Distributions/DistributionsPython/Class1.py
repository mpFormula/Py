
class Class1:
    def __init__(self):
        pass


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
            eps = (sum0 - sum1) / xsum
        k = k / xsum
        LeftTail = 1.0 - k
        RightTail = k
        if c3:
            self.SwapTails(LeftTail, RightTail)
        return LeftTail, RightTail, density

