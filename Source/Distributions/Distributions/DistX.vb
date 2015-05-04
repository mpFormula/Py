'
' Created by SharpDevelop.
' User: dhadler
' Date: 05/04/2015
' Time: 19:49
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Module DistX
    




    Sub print(<[ParamArray]()> formats() As Object)
      If formats.Length = 0 Then
         Console.WriteLine()
      Else    
         For Each format As Object In formats
            Try
               Console.Write(format.ToString())
            ' If there is an exception, do nothing. 
            Catch 
            End Try    
         Next 
      End If 
       Console.WriteLine()
    End Sub 
   
   

    Sub print2(<[ParamArray]()> formats() As Object)
      If formats.Length = 0 Then
         Console.WriteLine()
      Else    
         For Each format As Object In formats
            Try
               Console.Write(format.ToString())
            ' If there is an exception, do nothing. 
            Catch 
            End Try    
         Next 
      End If 
       Console.WriteLine()
    End Sub 
   
   
   
   
Function Cbrt(X As Double) As Double
    Cbrt = X ^ (1 / 3)
End Function



Function ndisx(ByVal LeftTailSoll As Double, ByVal RightTailSoll As Double) As Double
Dim temp As Double
  If LeftTailSoll < RightTailSoll Then temp = ndisx1(LeftTailSoll, RightTailSoll) Else temp = ndisx1(RightTailSoll, LeftTailSoll)
  If LeftTailSoll > RightTailSoll Then temp = -temp
  Return temp
End Function

Function ndisx1(ByVal LeftTailSoll As Double, ByVal RightTailSoll As Double) As Double
Dim split1 As Double =  0.425
Dim split2 As Double =  5#
Dim const1 As Double =  0.180625
Dim const2 As Double =  1.6
Dim a0 As Double =  3.38713287279637
Dim A1 As Double =  133.141667891784
Dim A2 As Double =  1971.59095030655
Dim a3 As Double =  13731.6937655095
Dim a4 As Double =  45921.9539315499
Dim A5 As Double =  67265.7709270087
Dim a6 As Double =  33430.5755835881
Dim A7 As Double =  2509.08092873012
Dim b1 As Double =  42.3133307016009
Dim b2 As Double =  687.187007492058
Dim B3 As Double =  5394.19602142475
Dim b4 As Double =  21213.7943015866
Dim B5 As Double =  39307.8958000927
Dim B6 As Double =  28729.0857357219
Dim B7 As Double =  5226.49527885285
Dim C0 As Double =  1.42343711074968
Dim C1 As Double =  4.63033784615655
Dim c2 As Double =  5.76949722146069
Dim c3 As Double =  3.6478483247632
Dim c4 As Double =  1.27045825245237
Dim c5 As Double =  0.241780725177451
Dim c6 As Double =  2.27238449892692E-02
Dim C7 As Double =  7.74545014278341E-04
Dim d1 As Double =  2.05319162663776
Dim d2 As Double =  1.6763848301838
Dim D3 As Double =  0.6897673349851
Dim D4 As Double =  0.14810397642748
Dim D5 As Double =  1.51986665636165E-02
Dim D6 As Double =  5.47593808499535E-04
Dim D7 As Double =  1.05075007164442E-09
Dim E0 As Double =  6.6579046435011
Dim e1 As Double =  5.46378491116411
Dim e2 As Double =  1.78482653991729
Dim E3 As Double =  0.296560571828505
Dim E4 As Double =  2.65321895265761E-02
Dim E5 As Double =  1.24266094738808E-03
Dim E6 As Double =  2.71155556874349E-05
Dim E7 As Double =  2.01033439929229E-07
Dim f1 As Double =  0.599832206555888
Dim f2 As Double =  0.136929880922736
Dim f3 As Double =  1.48753612908506E-02
Dim f4 As Double =  7.86869131145613E-04
Dim f5 As Double =  1.84631831751005E-05
Dim f6 As Double =  1.42151175831645E-07
Dim f7 As Double =  2.04426310338994E-15

Dim ppnd16 As Double, r As Double, p As Double, Q As Double
  p = LeftTailSoll
  Q = LeftTailSoll - 0.5
  If (Math.Abs(Q) <= split1) Then
    r = const1 - Q * Q
    ppnd16 = Q * (((((((A7 * r + a6) * r + A5) * r + a4) * r + a3) * r + A2) * r + A1) * r + a0) / _
             (((((((B7 * r + B6) * r + B5) * r + b4) * r + B3) * r + b2) * r + b1) * r + 1)
    Return ppnd16
  Else
    If (Q < 0) Then r = p Else r = 1 - p
    If r <= 0 Then
 '{     ifault=1}
      ppnd16 = 0
      Return ppnd16
    End If
    r = Math.Sqrt(-Math.Log(r))
    If (r <= split2) Then
      r = r - const2
      ppnd16 = (((((((C7 * r + c6) * r + c5) * r + c4) * r + c3) * r + c2) * r + C1) * r + C0) / _
       (((((((D7 * r + D6) * r + D5) * r + D4) * r + D3) * r + d2) * r + d1) * r + 1)
    Else
      r = r - split2
      ppnd16 = (((((((E7 * r + E6) * r + E5) * r + E4) * r + E3) * r + e2) * r + e1) * r + E0) / _
        (((((((f7 * r + f6) * r + f5) * r + f4) * r + f3) * r + f2) * r + f1) * r + 1)
    End If
    If Q < 0 Then ppnd16 = -ppnd16
    Return ppnd16
  End If
End Function




Function LambertW(ByVal X As Double) As Double
    Return (((((125 * X - 64) * X + 36) * X - 24) * X + 24) * X) / 24
End Function


Function cdisx_Lambert(ByVal LeftTail As Double, ByVal RightTail As Double, ByVal n As Double) As Double
Dim t As Double, d As Double, k As Double, a As Double, result As Double
    a = 1 / (0.5 * n - 1)
    k = LnGamma(0.5 * n)
    d = a * (Math.Log(LeftTail) + k)
    t = -a * Math.Exp(LeftTail + d)
'    Debug.Print "a: ", a, "k: ", k, "d: ", d, "t: ", t
    result = -2 * LambertW(t) / a
    Return result
End Function




Function cdisx_Canal(ByVal LeftTail As Double, ByVal RightTail As Double, ByVal n As Double) As Double
Dim h As Double, L As Double, mean As Double, stdev As Double, U As Double
Dim m As Double, m2 As Double, m3 As Double, g As Double, z As Double
Dim result As Double
    z = ndisx(LeftTail, RightTail)
    m = 1 / n: m2 = m * m: m3 = m2 * m
    mean = (14580 - 1944 * m - 189 * m2 + 200 * m3) / 17496
    stdev = Math.Sqrt(Math.Abs(648 * m + 72 * m2 - 37 * m3)) / 108
    g = Math.Sqrt(0.5 * m3) / 162
    z = z - g + (z * g) * (z - (2 * z * z - 5) * g)
    L = 6 * (z * stdev + mean)
    h = Cbrt(2 * (L + Math.Sqrt(13 + L * (L - 5))) - 5)
    U = 0.5 + 0.5 * h - 1.5 / h
    U = U * U * U
    result = n * U * U
    
    Return result
End Function



Function cdisx_approx(ByVal LeftTail As Double, ByVal RightTail As Double, ByVal n As Double) As Double
Dim t As Double, d As Double, k As Double, a As Double, result As Double, UseLambert As Boolean
Dim h As Double, L As Double, mean As Double, stdev As Double, U As Double
Dim m As Double, m2 As Double, m3 As Double, g As Double, z As Double
    UseLambert = True
    If UseLambert Then
        a = 1 / (0.5 * (n + 2) - 1)
        k = LnGamma(0.5 * (n + 2))
        d = a * (Math.Log(LeftTail) + k)
        t = -a * Math.Exp(LeftTail + d)
        print ("t: ", t)
        If Math.Abs(t) > 0.1 Then UseLambert = False
    End If
    If UseLambert Then
        print ("Use Lambert")
        result = -(((((125 * t - 64) * t + 36) * t - 24) * t + 24) * t) / (12 * a)  'Result = -2 * LambertW(t) / a
    Else
        print ("Use Canal")
        z = ndisx(LeftTail, RightTail)
        m = 1 / n: m2 = m * m: m3 = m2 * m
        mean = (14580 - 1944 * m - 189 * m2 + 200 * m3) / 17496
        stdev = Math.Sqrt(Math.Abs(648 * m + 72 * m2 - 37 * m3)) / 108
        g = Math.Sqrt(0.5 * m3) / 162
        z = z - g + (z * g) * (z - (2 * z * z - 5) * g)
        L = 6 * (z * stdev + mean)
        h = Cbrt(2 * (L + Math.Sqrt(13 + L * (L - 5))) - 5)
        U = 0.5 + 0.5 * h - 1.5 / h
        U = U * U * U
        result = n * U * U
    End If
    Return result
End Function




Function cdisx_new(ByVal LeftTail As Double, ByVal RightTail As Double, ByVal m As Double) As Double
Dim Left1 As Double, Right1 As Double, deriv As Double, diff As Double, delta As Double
Dim x1 As Double
If m < 0.5 Then
    print ("m must be >= 0.5")
    Return 1
End If
Dim MinRelError As Double = 0.0000000000001
Dim RelError As Double = 1.0
Dim X As Double = cdisx_approx(LeftTail, RightTail, m)
X = Math.Abs(X)
'   Debug.Print "xstart:", X
Dim k As Long = 0
Dim UseLeftTail As Boolean = False
If LeftTail < RightTail Then UseLeftTail = True

While ((RelError > MinRelError) And (k < 100))
    k = k + 1
    Call cdis2(m, X, Left1, Right1, deriv)
    If UseLeftTail Then
      diff = LeftTail - Left1
    Else
      diff = Right1 - RightTail
    End If
    delta = 0
    If deriv <> 0 Then delta = diff / deriv
    '    Debug.Print X, delta, X + delta, deriv, Abs(delta) / X
    x1 = X + delta
    If x1 <= 0 Then x1 = X / 2
    X = x1
    RelError = Math.Abs(delta) / X
End While 
'  If ((k > 0)) Then Debug.Print "k, n, L, R, x, RelError: ", k, m, LeftTail, RightTail, X, RelError
Return X
End Function



Sub demoCdisx()
    Dim m As Double= 10.5
    Dim LeftTail As Double = 1E-15
    Dim RightTail As Double = 1 - LeftTail
'    Dim RightTail As Double = 1E-220
'    Dim LeftTail As Double = 1 - RightTail
    Dim R0  As Double = cdisx_new(LeftTail, RightTail, m)
    print2("R0      : ", R0)
    Dim r1  As Double = cdisx_Lambert(LeftTail, RightTail, m + 2)
    print2("LambertL: ", r1,", ", Math.Abs(r1 - R0) / R0)
    Dim r2  As Double = cdisx_Canal(LeftTail, RightTail, m)
    print2("Canal   : ", r2,", ", Math.Abs(r2 - R0) / R0)
    print2("")
End Sub



    
End Module
