'
' Created by SharpDevelop.
' User: DH
' Date: 28/03/2015
' Time: 08:26
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Dist
    

Sub SwapTails(ByRef LeftTail As Double,ByRef  RightTail As Double)
Dim temp As Double
  temp = LeftTail
  LeftTail = RightTail
  RightTail = temp
End Sub

Function LogZPlusA(ByVal z As Double, ByVal a As Double) As Double
' LogZPlusA = log(z+a) - log(a) for a>>z
Dim y As Double, S1 As Double, s2 As Double, s3 As Double, i As Double
  y = z / (2 * a + z)
  S1 = y: s2 = S1: i = 1
  y = y * y
  Do
    i = i + 2
    s2 = s2 * y
    s3 = s2 / i
    S1 = S1 + s3
  Loop Until S1 = S1 + s3
'  Debug.Print "Iterations:", (i - 1) / 2
  LogZPlusA = 2 * S1
End Function

Function LnGamma(ByVal z As Double) As Double
Dim bb(0 To 10) As Double
Dim ln2pi As Double, lnz As Double, a As Double, z3 As Double
Dim z2 As Double, sum2 As Double, sum As Double
Dim i As Integer
bb(1) = -2.77777777777778E-03
bb(2) = 7.93650793650794E-04
bb(3) = -5.95238095238095E-04
bb(4) = 8.41750841750842E-04
bb(5) = -1.91752691752692E-03
bb(6) = 6.41025641025641E-03
bb(7) = -2.95506535947712E-02
bb(8) = 0.179644372368831
bb(9) = -1.3924322169059
bb(10) = 13.4028640441684
a = 1#
While (z < 15#)
  a = a * z
  z = z + 1#
End While 


lnz = (z - 0.5) * Math.Log(z)
ln2pi = 0.918938533204673
z2 = 1# / (1# * z * z)
sum2 = 1# / (12# * z)
i = 0
z3 = 1# / z
Do
  i = i + 1
  z3 = z3 * z2
  sum = sum2
  sum2 = sum + bb(i) * z3
Loop Until ((sum2 = sum) Or (i > 9))
sum2 = sum2 + lnz - z
sum2 = sum2 + ln2pi
LnGamma = sum2 - Math.Log(a)
End Function

Function LnGammaZPLusA(ByVal z As Double, ByVal a As Double) As Double
Dim bb(0 To 10) As Double
Dim lnz As Double
'Dim a1 As Double, za1 As Double, aza1 As Double
'Dim a2 As Double, za2 As Double, aza2 As Double
Dim sum2 As Double, sum3 As Double, sum As Double, d1 As Double
Dim i As Integer, j As Integer, k As Integer, n As Integer
Dim C(0 To 30) As Double, d(0 To 30) As Double, e(0 To 30) As Double
bb(1) = -2.77777777777778E-03
bb(2) = 7.93650793650794E-04
bb(3) = -5.95238095238095E-04
bb(4) = 8.41750841750842E-04
bb(5) = -1.91752691752692E-03
bb(6) = 6.41025641025641E-03
bb(7) = -2.95506535947712E-02
bb(8) = 0.179644372368831
bb(9) = -1.3924322169059
bb(10) = 13.4028640441684
d1 = LogZPlusA(z, a)
lnz = (z + a - 0.5) * d1 + z * Math.Log(a) - z
'a1 = a
'za1 = z + a
'aza1 = a * (z + a)
'a2 = a1 * a1
'za2 = za1 * za1
'aza2 = aza1 * aza1
'sum2 = -z / (12# * aza1)
'i = 0
'Do
'  i = i + 1
'  a1 = a1 * a2
'  za1 = za1 * za2
'  aza1 = aza1 * aza2
'  sum = sum2
'  sum3 = bb(i) * (a1 - za1) / aza1
'  Debug.Print i, sum3
'  sum2 = sum + sum3
'Loop Until ((sum2 = sum) Or (i > 9))
'Debug.Print "sum2, lnz:", sum2, lnz

sum2 = -z / (12# * a * (z + a))
i = 0: n = 1: C(0) = 1: C(1) = 1
d(0) = 1: e(0) = 1
d(1) = 1 / (z + a): e(1) = z / (a * (z + a))
Do
  i = i + 1
  For k = 1 To 2
    n = n + 1: C(n) = 1
    For j = n - 1 To 1 Step -1
      C(j) = C(j) + C(j - 1)
    Next j
    d(n) = d(n - 1) * d(1)
    e(n) = e(n - 1) * e(1)
  Next k
  sum3 = 0
  For j = 1 To n
    sum3 = sum3 + C(j) * d(n - j) * e(j)
  Next j
  sum3 = -bb(i) * sum3
  sum = sum2
  sum2 = sum2 + sum3
Loop Until ((sum2 = sum) Or (i > 9))
sum2 = sum2 + lnz
LnGammaZPLusA = sum2
End Function

Function Lnbeta1(ByVal a As Double, ByVal b As Double) As Double
Dim t As Double
  t = LnGamma(a)
  t = t + LnGamma(b)
  Lnbeta1 = t - LnGamma(a + b)
End Function

Function Lnbeta(ByVal a As Double, ByVal b As Double) As Double
Dim l2 As Double
'  L1 = Lnbeta1(a, b)
  l2 = LnBeta2(a, b)
'  Debug.Print "a,b,1,2: ", a, b, L1, L2
  Lnbeta = l2
End Function

Function LnBeta2(ByVal a As Double, ByVal b As Double) As Double
Dim t As Double
  If a > b Then Call SwapTails(a, b)
  If a < (b / 100) Then
    t = LnGamma(a) - LnGammaZPLusA(a, b)
  Else
    t = Lnbeta1(a, b)
  End If
  LnBeta2 = t
End Function

Function Bn0(ByVal n As Integer) As Double
Dim ln2pi As Double   
ln2pi = 1.83787706640935
Dim b1(0 To 15) As Double
Dim lnk(0 To 2) As Double
Dim S1 As Double, sign As Double, sum As Double
Dim k As Integer
'  If b1(0) = 0 Then
     b1(0) = 1#
     b1(1) = 0.166666666666667
     b1(2) = -3.33333333333333E-02
     b1(3) = 2.38095238095238E-02
     b1(4) = -3.33333333333333E-02
     b1(5) = 7.57575757575758E-02
     b1(6) = -0.253113553113553
     b1(7) = 1.16666666666667
     b1(8) = -7.0921568627451
     b1(9) = 54.9711779448622
     b1(10) = -529.124242424242
     b1(11) = 6192.1231884058
     b1(12) = -86580.2531135531
     b1(13) = 1425517.16666667
     b1(14) = -27298231.0678161
     b1(15) = 601580873.900642

     lnk(0) = 0.693147180559945
     lnk(1) = 1.09861228866811
     lnk(2) = 1.38629436111989
'   End If
  If n = 1 Then
    Bn0 = -0.5
    Exit Function
  End If
  If ((n Mod 2) > 0) Then
    Bn0 = 0
    Exit Function
  End If
  If n <= 30 Then
    Bn0 = b1(n \ 2)
    Exit Function
  End If
  If (((n \ 2) Mod 2) > 0) Then
    sign = 1
  Else
    sign = -1
  End If
  sum = 1
  k = 0
  Do
    S1 = Math.Exp(-lnk(k) * n)
    sum = sum + S1
    k = k + 1
  Loop Until (S1 / sum) < 1E-16
  S1 = LnGamma(n + 1)
  S1 = S1 - n * ln2pi
  S1 = Math.Exp(S1) * sum
  Bn0 = 2 * sign * S1
End Function

Function Bernoulli(ByVal n As Integer, ByVal h As Double) As Double
Dim hn As Double, Bin As Double, sum As Double
Dim i As Integer, k As Integer
  If h = 0 Then
    Bernoulli = Bn0(n)
    Exit Function
  End If
  sum = 0
  Bin = 1
  hn = 1
  For i = 1 To n
    hn = hn * h
  Next i
  For k = 0 To n
    sum = sum + Bin * Bn0(k) * hn
    Bin = Bin / (k + 1) * (n - k)
    hn = hn / h
  Next k
  Bernoulli = sum
End Function



    Function cdens(ByVal n As Double, ByVal X As Double) As Double
    Dim b As Double, m As Double, LastLngamma As Double
      b = n / 2.0
      m = X / 2.0
      If (X <= 0.0) Then
        cdens = 0.0
      Else
        LastLngamma = LnGamma(b)
        cdens = 0.5 * Math.Exp(Math.Log(m) * (b - 1.0) - LastLngamma - m)
      End If
    End Function




    
    Sub cdis2(ByVal n As Double, ByVal X As Double, ByRef LeftTail As Double, _
      ByRef RightTail As Double, ByRef density As Double)
    Dim j As Integer, i As Integer
    Dim sum(0 To 2) As Double
    Dim eps As Double, m As Double, b As Double, k As Double
    Dim xsum As Double, a0 As Double, A1 As Double, A2 As Double
    Dim an As Double, b0 As Double, b1 As Double, b2 As Double, bn As Double
    Dim MinRelError As Double
    Dim c3 As Boolean
    MinRelError = 1E-16
    If (X <= 0.0) Then
      LeftTail = 0.0
      RightTail = 1.0
      density = 0.0
      Exit Sub
    End If
      density = cdens(n, X)
      If ((X <= 12.0) Or (X <= n)) Then
        c3 = True
      Else
        c3 = False
      End If
      b = n / 2.0
      m = X / 2.0
      k = 2.0 * density
      a0 = 1.0
      b0 = 1.0
      bn = 0.0
      j = 0
      sum(0) = 1.0
      sum(1) = 1.0
      If c3 Then
        k = k * m / b
        A1 = b + 1.0 - m
        b1 = b + 1.0
        bn = b + 1.0
      Else
        A1 = m + 1.0 - b
        b1 = m
      End If
      Do
        j = j + 1
        For i = 0 To 1
          If c3 Then
            If i = 1 Then
              an = -(b + j) * m
            Else
              an = j * m
            End If
            bn = bn + 1#
          Else
            If i = 1 Then
              an = j + 1.0 - b
              bn = m
            Else
              an = j
              bn = 1.0
            End If
          End If
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
          sum(i) = A2
        Next i
        xsum = (sum(0) + sum(1)) * 0.5
        eps = (sum(0) - sum(1)) / xsum
      Loop Until (Math.Abs(eps) < MinRelError)
      k = k / xsum
      LeftTail = 1.0 - k
      RightTail = k
      If c3 Then
        Call SwapTails(LeftTail, RightTail)
      End If
    End Sub
    


    Function cdis(ByVal n As Double, ByVal X As Double) As Double
    Dim LeftTail As Double, RightTail As Double, density As Double
      Call cdis2(n, X, LeftTail, RightTail, density)
      cdis = LeftTail
    End Function
    
    


    
    Sub betadis(ByVal a As Double, ByVal b As Double, ByVal Q As Double, _
      ByVal p As Double, ByRef LeftTail As Double, ByRef RightTail As Double, _
      ByRef density As Double)
    Dim fit As Boolean
    Dim j As Integer, i As Integer
    Dim sum(0 To 1) As Double
    Dim eps As Double, qp As Double, k As Double
    Dim xsum As Double
    Dim a0 As Double, A1 As Double, A2 As Double, an As Double
    Dim b0 As Double, b1 As Double, b2 As Double, bn As Double
    Dim X As Double, limit As Double, MinRelError As Double
    MinRelError = 0.00000000000001
    If (Q <= 0) Then
      LeftTail = 0
      RightTail = 1
      density = 0
      Exit Sub
    End If
    If (p <= 0) Then
      LeftTail = 1
      RightTail = 0
      density = 0
      Exit Sub
    End If
    '  k = LnGamma(a + b) - LnGamma(a) - LnGamma(b)
      k = -Lnbeta(a, b)
      k = k + (b - 1) * Math.Log(p) + (a - 1) * Math.Log(Q)
      density = Math.Exp(k)
      X = (b * Q) / (a * p)
      limit = 4.5 - a
      If limit < 1 Then
        limit = 1
      End If
      fit = (X < limit)
      If Not fit Then
        Call SwapTails(a, b)
        Call SwapTails(p, Q)
      End If
      qp = Q / p
      a0 = 1
      A1 = a + 1 - (b - 1) * qp
      b0 = 1
      b1 = a + 1
      j = 0
      bn = a + 1
      sum(0) = 1
      sum(1) = 1
      Do
        j = j + 1
        For i = 0 To 1
          If i = 1 Then
            an = -(a + j) * (b - j - 1) * qp
          Else
            an = j * (a + b - 1 + j) * qp
          End If
          bn = bn + 1
          A2 = bn * A1 + an * a0
          b2 = bn * b1 + an * b0
          A2 = A2 / b2
          A1 = A1 / b2
          b1 = b1 / b2
          b2 = 1
          a0 = A1
          A1 = A2
          b0 = b1
          b1 = b2
          sum(i) = A2
        Next i
        xsum = (sum(0) + sum(1)) * 0.5
        eps = Math.Abs(sum(0) - sum(1)) / xsum
      Loop Until (eps < MinRelError)
      Console.WriteLine("j:" & j.ToString())
      RightTail = density * Q / (a * xsum)
      LeftTail = 1 - RightTail
      If fit Then
        Call SwapTails(LeftTail, RightTail)
      End If
    End Sub
    
    

    Function Fdis(ByVal m As Double, ByVal n As Double, ByVal a As Double) As Double
    Dim X As Double, y As Double, p As Double, Q As Double
    Dim density As Double, LeftTail As Double, RightTail As Double
      If a <= 0 Then
        Fdis = 0
        Exit Function
      End If
      X = m * a / (m * a + n)
      y = n / (m * a + n)
      p = m / 2
      Q = n / 2
      Call betadis(p, Q, X, y, LeftTail, RightTail, density)
      Fdis = RightTail
    End Function
    
    Sub Fdis_a(ByVal m As Double, ByVal n As Double, ByVal a As Double, ByRef LeftTail As Double, ByRef RightTail As Double)
    Dim X As Double, y As Double, p As Double, Q As Double
    Dim density As Double
      If a <= 0 Then
        LeftTail = 0
        RightTail = 1
        Exit Sub
      End If
      X = m * a / (m * a + n)
      y = n / (m * a + n)
      p = m / 2
      Q = n / 2
      Call betadis(p, Q, X, y, LeftTail, RightTail, density)
    End Sub



    Function tdis(ByVal n As Double, ByVal t As Double, ByRef LeftTail As Double, ByRef RightTail As Double) As Double
    Dim temp As Double
    If t = 0 Then
      LeftTail = 0.5
      RightTail = 0.5
      tdis = 0.5
      Exit Function
    End If
    Call Fdis_a(1, n, t * t, LeftTail, RightTail)
      RightTail = RightTail / 2
      LeftTail = 1 - RightTail
    'Debug.Print LeftTail, RightTail
    If t < 0 Then
      temp = LeftTail
      LeftTail = RightTail
      RightTail = temp
    End If
    tdis = LeftTail
    End Function


    
    
    
    
    Sub ndis2(ByVal UseLog As Boolean, ByVal X As Double, LeftTail As Double, RightTail As Double, density As Double)
    Dim sqrt2pi As Double
    sqrt2pi = 0.398942280401433
    Dim i As Double, m As Double, x2 As Double, S1 As Double, s2 As Double
    Dim t As Double, A1 As Double, A2 As Double, b1 As Double, b2 As Double
    Dim sign As Boolean
       If X = 0 Then
         LeftTail = 0.5
         density = sqrt2pi
         If UseLog Then
           LeftTail = Math.Log(LeftTail)
           density = Math.Log(density)
         End If
         RightTail = LeftTail: Exit Sub
       End If
       sign = False: x2 = X * X
       density = Math.Exp(-x2 * 0.5) * sqrt2pi
       
       If X < 0 Then X = -X: sign = True
       If X < 2.5 Then
        S1 = X: s2 = X: m = 1
        Do: m = m + 2
          s2 = s2 * x2 / m
          S1 = S1 + s2
        Loop Until (s2 < S1 * 1E-16)
         LeftTail = 0.5 + S1 * density
         If UseLog Then
           RightTail = Math.Log(1 - LeftTail)
           LeftTail = Math.Log(LeftTail)
         Else
           RightTail = 1 - LeftTail
         End If
       Else
         A1 = 1: A2 = X: b1 = X: b2 = x2 + 1: i = 1
         Do: i = i + 1
           t = A2: A2 = X * A2 + i * A1: A1 = t
           t = b2: b2 = X * b2 + i * b1: b1 = t
         Loop Until (A2 * b1 = b2 * A1)
         If UseLog Then
           RightTail = (-x2 / 2) + Math.Log(sqrt2pi * A2 / b2)
           LeftTail = LogZPlusA(-Math.Exp(RightTail), 1)
         Else
           RightTail = density * A2 / b2
           LeftTail = 1 - RightTail
         End If
       End If
       If sign Then Call SwapTails(LeftTail, RightTail)
       If UseLog Then density = (-x2 * 0.5) + Math.Log(sqrt2pi)
    End Sub
    
    Public Function ndis(ByVal X As Double) As Double
    Dim LeftTail As Double, RightTail As Double, density As Double
      Call ndis2(False, X, LeftTail, RightTail, density)
      ndis = LeftTail
    End Function
    
    
    
    
    Function tdens(ByVal n As Double, X As Double) As Double
    Dim C As Double, h As Double
      C = (1 + X * X / n)
      h = Math.Exp(LnGamma((n + 1) / 2) - LnGamma(n / 2)) / Math.Sqrt(Math.PI) / Math.Sqrt(n)
      tdens = h * C ^ (-(n / 2 + 1 / 2))
    End Function
    

    
    Function cdisOwen(n As Long, X As Double) As Double
    Dim C As Double, F As Double, k As Long, i As Long
    C = -Math.Exp(-X / 2)
    F = 1
    k = n Mod 2
    If k <> 0 Then
      C = C * Math.Sqrt(2 * X / Math.PI)    ' C=ndens(x)
      F = 1 - 2 * ndis(-Math.Sqrt(X))
    End If
    k = k + 2
    For i = k To n Step 2
      F = F + C
      C = C * X / i
    Next i
    cdisOwen = F
    End Function
    
    
    Function tdisOwen(X As Double, n As Long) As Double
    Dim a As Double, b As Double, C As Double, F As Double, k As Long, i As Long
    a = X / Math.Sqrt(n)
    b = 1 + a * a
    k = n Mod 2
    If k <> 0 Then
      C = a / (b * Math.PI)
      F = 0.5 + Math.Atan(a) / Math.PI
    Else
      C = a / (2 * Math.Sqrt(b))
      F = 0.5
    End If
    k = k + 2
    For i = k To n Step 2
      F = F + C
      C = C * (1 - 1 / i) / b
    Next i
    tdisOwen = F
    End Function


'    Function FdisOwen(ByVal m As Long, ByVal n As Double, ByVal X As Double) As Double
    Function FdisOwen(ByVal m As Long, ByVal n As Long, ByVal X As Double) As Double        
        Dim U As Double, sum As Double, a As Double, z As Double
    Dim result As Double, i As Long, k As Long
    k = m Mod 2
    If k = 0 Then
      z = n / (n + m * X)
      result = z ^ (n / 2)
      If m > 2 Then
        U = 1 - z
        sum = 1:  a = 1
        For i = 1 To (m - 2) \ 2
          a = a * U * (2 * i + n - 2) / (2 * i)
          sum = sum + a
        Next i
        result = result * sum
      End If
    Else
      z = Math.Sqrt(m * X)
'      result = 2 * tdis(n, -z, L, r)
      result = 2 * tdisOwen(-z, n)      
      If m > 1 Then
        U = z * z / (z * z + n)
        sum = z:  a = z
        For i = 2 To (m - 1) \ 2
          a = a * U * (2 * i + n - 3) / (2 * i - 1)
          sum = sum + a
        Next i
        result = result + 2 * sum * tdens(n, z)
      End If
    End If
    FdisOwen = result
    End Function


    
    Sub BetaDisdemo()
    Dim a As Double, b As Double, Q As Double, p As Double, L As Double, r As Double, density As Double
    a = 100
    b = 100
    p = 0.50004000001
    Q = 1 - p
    Call betadis(a, b, Q, p, L, r, density)
    
    Console.WriteLine("L: " & L.ToString() & "   R: " & r.ToString() & "   density: " & density.ToString())
    
    End Sub    
    
    
    Sub demoLnGamma()
    Dim a As Double, b As Double
    Dim lnG As Double, lnB As Double
      a = 1000000000
      b = 1000000000
      lnG = LnGamma(a)
      lnB = Lnbeta(a, b)
      Console.WriteLine("lnG: " & lnG.ToString() & "   lnB: " & lnB.ToString())
    End Sub
    
    
    
    Sub DemoCdis()
    Dim n As Double, X As Double
    Dim LeftTail As Double, RightTail As Double, density As Double
    n = 13300.1
    X = 13300.95
    Call cdis2(n, X, LeftTail, RightTail, density)
    Console.WriteLine("LeftTail: " & LeftTail.ToString() & "   RightTail: " & RightTail.ToString()& "   density: " & density.ToString())
   
    End Sub
    
    

    Sub Main()
        Console.WriteLine("Hello World!")
        
'        demoLnGamma()
'        BetaDisdemo()
'        DemoCdis()
        demoCdisx()
        
        Console.Write("Press any key to continue . . . ")
        Console.ReadKey(True)
    End Sub
End Module
