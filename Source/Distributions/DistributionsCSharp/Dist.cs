using System;

//
// Created by SharpDevelop.
// User: DH
// Date: 28/03/2015
// Time: 08:26
// 
// To change this template use Tools | Options | Coding | Edit Standard Headers.
//
static class Dist
{


	public static void SwapTails(ref double LeftTail, ref double RightTail)
	{
		double temp = 0;
		temp = LeftTail;
		LeftTail = RightTail;
		RightTail = temp;
	}

	public static double LogZPlusA(double z, double a)
	{
		// LogZPlusA = log(z+a) - log(a) for a>>z
		double y = 0;
		double S1 = 0;
		double s2 = 0;
		double s3 = 0;
		double i = 0;
		y = z / (2 * a + z);
		S1 = y;
		s2 = S1;
		i = 1;
		y = y * y;
		do {
			i = i + 2;
			s2 = s2 * y;
			s3 = s2 / i;
			S1 = S1 + s3;
		} while (!(S1 == S1 + s3));
		//  Debug.Print "Iterations:", (i - 1) / 2
		return 2 * S1;
	}

	public static double LnGamma(double z)
	{
		double[] bb = new double[11];
		double ln2pi = 0;
		double lnz = 0;
		double a = 0;
		double z3 = 0;
		double z2 = 0;
		double sum2 = 0;
		double sum = 0;
		int i = 0;
		bb[1] = -0.00277777777777778;
		bb[2] = 0.000793650793650794;
		bb[3] = -0.000595238095238095;
		bb[4] = 0.000841750841750842;
		bb[5] = -0.00191752691752692;
		bb[6] = 0.00641025641025641;
		bb[7] = -0.0295506535947712;
		bb[8] = 0.179644372368831;
		bb[9] = -1.3924322169059;
		bb[10] = 13.4028640441684;
		a = 1.0;
		while ((z < 15.0)) {
			a = a * z;
			z = z + 1.0;
		}


		lnz = (z - 0.5) * Math.Log(z);
		ln2pi = 0.918938533204673;
		z2 = 1.0 / (1.0 * z * z);
		sum2 = 1.0 / (12.0 * z);
		i = 0;
		z3 = 1.0 / z;
		do {
			i = i + 1;
			z3 = z3 * z2;
			sum = sum2;
			sum2 = sum + bb[i] * z3;
		} while (!(((sum2 == sum) | (i > 9))));
		sum2 = sum2 + lnz - z;
		sum2 = sum2 + ln2pi;
		return sum2 - Math.Log(a);
	}

	public static double LnGammaZPLusA(double z, double a)
	{
		double[] bb = new double[11];
		double lnz = 0;
		//Dim a1 As Double, za1 As Double, aza1 As Double
		//Dim a2 As Double, za2 As Double, aza2 As Double
		double sum2 = 0;
		double sum3 = 0;
		double sum = 0;
		double d1 = 0;
		int i = 0;
		int j = 0;
		int k = 0;
		int n = 0;
		double[] C = new double[31];
		double[] d = new double[31];
		double[] e = new double[31];
		bb[1] = -0.00277777777777778;
		bb[2] = 0.000793650793650794;
		bb[3] = -0.000595238095238095;
		bb[4] = 0.000841750841750842;
		bb[5] = -0.00191752691752692;
		bb[6] = 0.00641025641025641;
		bb[7] = -0.0295506535947712;
		bb[8] = 0.179644372368831;
		bb[9] = -1.3924322169059;
		bb[10] = 13.4028640441684;
		d1 = LogZPlusA(z, a);
		lnz = (z + a - 0.5) * d1 + z * Math.Log(a) - z;
		//a1 = a
		//za1 = z + a
		//aza1 = a * (z + a)
		//a2 = a1 * a1
		//za2 = za1 * za1
		//aza2 = aza1 * aza1
		//sum2 = -z / (12# * aza1)
		//i = 0
		//Do
		//  i = i + 1
		//  a1 = a1 * a2
		//  za1 = za1 * za2
		//  aza1 = aza1 * aza2
		//  sum = sum2
		//  sum3 = bb(i) * (a1 - za1) / aza1
		//  Debug.Print i, sum3
		//  sum2 = sum + sum3
		//Loop Until ((sum2 = sum) Or (i > 9))
		//Debug.Print "sum2, lnz:", sum2, lnz

		sum2 = -z / (12.0 * a * (z + a));
		i = 0;
		n = 1;
		C[0] = 1;
		C[1] = 1;
		d[0] = 1;
		e[0] = 1;
		d[1] = 1 / (z + a);
		e[1] = z / (a * (z + a));
		do {
			i = i + 1;
			for (k = 1; k <= 2; k++) {
				n = n + 1;
				C[n] = 1;
				for (j = n - 1; j >= 1; j += -1) {
					C[j] = C[j] + C[j - 1];
				}
				d[n] = d[n - 1] * d[1];
				e[n] = e[n - 1] * e[1];
			}
			sum3 = 0;
			for (j = 1; j <= n; j++) {
				sum3 = sum3 + C[j] * d[n - j] * e[j];
			}
			sum3 = -bb[i] * sum3;
			sum = sum2;
			sum2 = sum2 + sum3;
		} while (!(((sum2 == sum) | (i > 9))));
		sum2 = sum2 + lnz;
		return sum2;
	}

	public static double Lnbeta1(double a, double b)
	{
		double t = 0;
		t = LnGamma(a);
		t = t + LnGamma(b);
		return t - LnGamma(a + b);
	}

	public static double Lnbeta(double a, double b)
	{
		double l2 = 0;
		//  L1 = Lnbeta1(a, b)
		l2 = LnBeta2(a, b);
		//  Debug.Print "a,b,1,2: ", a, b, L1, L2
		return l2;
	}

	public static double LnBeta2(double a, double b)
	{
		double t = 0;
		if (a > b)
			SwapTails(ref a, ref b);
		if (a < (b / 100)) {
			t = LnGamma(a) - LnGammaZPLusA(a, b);
		} else {
			t = Lnbeta1(a, b);
		}
		return t;
	}

	public static double Bn0(int n)
	{
		double functionReturnValue = 0;
		double ln2pi = 0;
		ln2pi = 1.83787706640935;
		double[] b1 = new double[16];
		double[] lnk = new double[3];
		double S1 = 0;
		double sign = 0;
		double sum = 0;
		int k = 0;
		//  If b1(0) = 0 Then
		b1[0] = 1.0;
		b1[1] = 0.166666666666667;
		b1[2] = -0.0333333333333333;
		b1[3] = 0.0238095238095238;
		b1[4] = -0.0333333333333333;
		b1[5] = 0.0757575757575758;
		b1[6] = -0.253113553113553;
		b1[7] = 1.16666666666667;
		b1[8] = -7.0921568627451;
		b1[9] = 54.9711779448622;
		b1[10] = -529.124242424242;
		b1[11] = 6192.1231884058;
		b1[12] = -86580.2531135531;
		b1[13] = 1425517.16666667;
		b1[14] = -27298231.0678161;
		b1[15] = 601580873.900642;

		lnk[0] = 0.693147180559945;
		lnk[1] = 1.09861228866811;
		lnk[2] = 1.38629436111989;
		//   End If
		if (n == 1) {
			functionReturnValue = -0.5;
			return functionReturnValue;
		}
		if (((n % 2) > 0)) {
			functionReturnValue = 0;
			return functionReturnValue;
		}
		if (n <= 30) {
			functionReturnValue = b1[n / 2];
			return functionReturnValue;
		}
		if ((((n / 2) % 2) > 0)) {
			sign = 1;
		} else {
			sign = -1;
		}
		sum = 1;
		k = 0;
		do {
			S1 = Math.Exp(-lnk[k] * n);
			sum = sum + S1;
			k = k + 1;
		} while (!((S1 / sum) < 1E-16));
		S1 = LnGamma(n + 1);
		S1 = S1 - n * ln2pi;
		S1 = Math.Exp(S1) * sum;
		functionReturnValue = 2 * sign * S1;
		return functionReturnValue;
	}

	public static double Bernoulli(int n, double h)
	{
		double functionReturnValue = 0;
		double hn = 0;
		double Bin = 0;
		double sum = 0;
		int i = 0;
		int k = 0;
		if (h == 0) {
			functionReturnValue = Bn0(n);
			return functionReturnValue;
		}
		sum = 0;
		Bin = 1;
		hn = 1;
		for (i = 1; i <= n; i++) {
			hn = hn * h;
		}
		for (k = 0; k <= n; k++) {
			sum = sum + Bin * Bn0(k) * hn;
			Bin = Bin / (k + 1) * (n - k);
			hn = hn / h;
		}
		functionReturnValue = sum;
		return functionReturnValue;
	}



	public static double cdens(double n, double X)
	{
		double functionReturnValue = 0;
		double b = 0;
		double m = 0;
		double LastLngamma = 0;
		b = n / 2.0;
		m = X / 2.0;
		if ((X <= 0.0)) {
			functionReturnValue = 0.0;
		} else {
			LastLngamma = LnGamma(b);
			functionReturnValue = 0.5 * Math.Exp(Math.Log(m) * (b - 1.0) - LastLngamma - m);
		}
		return functionReturnValue;
	}





	public static void cdis2(double n, double X, ref double LeftTail, ref double RightTail, ref double density)
	{
		int j = 0;
		int i = 0;
		double[] sum = new double[3];
		double eps = 0;
		double m = 0;
		double b = 0;
		double k = 0;
		double xsum = 0;
		double a0 = 0;
		double A1 = 0;
		double A2 = 0;
		double an = 0;
		double b0 = 0;
		double b1 = 0;
		double b2 = 0;
		double bn = 0;
		double MinRelError = 0;
		bool c3 = false;
		MinRelError = 1E-16;
		if ((X <= 0.0)) {
			LeftTail = 0.0;
			RightTail = 1.0;
			density = 0.0;
			return;
		}
		density = cdens(n, X);
		if (((X <= 12.0) | (X <= n))) {
			c3 = true;
		} else {
			c3 = false;
		}
		b = n / 2.0;
		m = X / 2.0;
		k = 2.0 * density;
		a0 = 1.0;
		b0 = 1.0;
		bn = 0.0;
		j = 0;
		sum[0] = 1.0;
		sum[1] = 1.0;
		if (c3) {
			k = k * m / b;
			A1 = b + 1.0 - m;
			b1 = b + 1.0;
			bn = b + 1.0;
		} else {
			A1 = m + 1.0 - b;
			b1 = m;
		}
		do {
			j = j + 1;
			for (i = 0; i <= 1; i++) {
				if (c3) {
					if (i == 1) {
						an = -(b + j) * m;
					} else {
						an = j * m;
					}
					bn = bn + 1.0;
				} else {
					if (i == 1) {
						an = j + 1.0 - b;
						bn = m;
					} else {
						an = j;
						bn = 1.0;
					}
				}
				A2 = bn * A1 + an * a0;
				b2 = bn * b1 + an * b0;
				A2 = A2 / b2;
				A1 = A1 / b2;
				b1 = b1 / b2;
				b2 = 1.0;
				a0 = A1;
				A1 = A2;
				b0 = b1;
				b1 = b2;
				sum[i] = A2;
			}
			xsum = (sum[0] + sum[1]) * 0.5;
			eps = (sum[0] - sum[1]) / xsum;
		} while (!((Math.Abs(eps) < MinRelError)));
		k = k / xsum;
		LeftTail = 1.0 - k;
		RightTail = k;
		if (c3) {
			SwapTails(ref LeftTail, ref RightTail);
		}
	}



	public static double cdis(double n, double X)
	{
		double LeftTail = 0;
		double RightTail = 0;
		double density = 0;
		cdis2(n, X, ref LeftTail, ref RightTail, ref density);
		return LeftTail;
	}





	public static void betadis(double a, double b, double Q, double p, ref double LeftTail, ref double RightTail, ref double density)
	{
		bool fit = false;
		int j = 0;
		int i = 0;
		double[] sum = new double[2];
		double eps = 0;
		double qp = 0;
		double k = 0;
		double xsum = 0;
		double a0 = 0;
		double A1 = 0;
		double A2 = 0;
		double an = 0;
		double b0 = 0;
		double b1 = 0;
		double b2 = 0;
		double bn = 0;
		double X = 0;
		double limit = 0;
		double MinRelError = 0;
		MinRelError = 1E-14;
		if ((Q <= 0)) {
			LeftTail = 0;
			RightTail = 1;
			density = 0;
			return;
		}
		if ((p <= 0)) {
			LeftTail = 1;
			RightTail = 0;
			density = 0;
			return;
		}
		//  k = LnGamma(a + b) - LnGamma(a) - LnGamma(b)
		k = -Lnbeta(a, b);
		k = k + (b - 1) * Math.Log(p) + (a - 1) * Math.Log(Q);
		density = Math.Exp(k);
		X = (b * Q) / (a * p);
		limit = 4.5 - a;
		if (limit < 1) {
			limit = 1;
		}
		fit = (X < limit);
		if (!fit) {
			SwapTails(ref a, ref b);
			SwapTails(ref p, ref Q);
		}
		qp = Q / p;
		a0 = 1;
		A1 = a + 1 - (b - 1) * qp;
		b0 = 1;
		b1 = a + 1;
		j = 0;
		bn = a + 1;
		sum[0] = 1;
		sum[1] = 1;
		do {
			j = j + 1;
			for (i = 0; i <= 1; i++) {
				if (i == 1) {
					an = -(a + j) * (b - j - 1) * qp;
				} else {
					an = j * (a + b - 1 + j) * qp;
				}
				bn = bn + 1;
				A2 = bn * A1 + an * a0;
				b2 = bn * b1 + an * b0;
				A2 = A2 / b2;
				A1 = A1 / b2;
				b1 = b1 / b2;
				b2 = 1;
				a0 = A1;
				A1 = A2;
				b0 = b1;
				b1 = b2;
				sum[i] = A2;
			}
			xsum = (sum[0] + sum[1]) * 0.5;
			eps = Math.Abs(sum[0] - sum[1]) / xsum;
		} while (!((eps < MinRelError)));
		Console.WriteLine("j:" + j.ToString());
		RightTail = density * Q / (a * xsum);
		LeftTail = 1 - RightTail;
		if (fit) {
			SwapTails(ref LeftTail, ref RightTail);
		}
	}



	public static double Fdis(double m, double n, double a)
	{
		double functionReturnValue = 0;
		double X = 0;
		double y = 0;
		double p = 0;
		double Q = 0;
		double density = 0;
		double LeftTail = 0;
		double RightTail = 0;
		if (a <= 0) {
			functionReturnValue = 0;
			return functionReturnValue;
		}
		X = m * a / (m * a + n);
		y = n / (m * a + n);
		p = m / 2;
		Q = n / 2;
		betadis(p, Q, X, y, ref LeftTail, ref RightTail, ref density);
		functionReturnValue = RightTail;
		return functionReturnValue;
	}

	public static void Fdis_a(double m, double n, double a, ref double LeftTail, ref double RightTail)
	{
		double X = 0;
		double y = 0;
		double p = 0;
		double Q = 0;
		double density = 0;
		if (a <= 0) {
			LeftTail = 0;
			RightTail = 1;
			return;
		}
		X = m * a / (m * a + n);
		y = n / (m * a + n);
		p = m / 2;
		Q = n / 2;
		betadis(p, Q, X, y, ref LeftTail, ref RightTail, ref density);
	}



	public static double tdis(double n, double t, ref double LeftTail, ref double RightTail)
	{
		double functionReturnValue = 0;
		double temp = 0;
		if (t == 0) {
			LeftTail = 0.5;
			RightTail = 0.5;
			functionReturnValue = 0.5;
			return functionReturnValue;
		}
		Fdis_a(1, n, t * t, ref LeftTail, ref RightTail);
		RightTail = RightTail / 2;
		LeftTail = 1 - RightTail;
		//Debug.Print LeftTail, RightTail
		if (t < 0) {
			temp = LeftTail;
			LeftTail = RightTail;
			RightTail = temp;
		}
		functionReturnValue = LeftTail;
		return functionReturnValue;
	}






	public static void ndis2(bool UseLog, double X, double LeftTail, double RightTail, double density)
	{
		double sqrt2pi = 0;
		sqrt2pi = 0.398942280401433;
		double i = 0;
		double m = 0;
		double x2 = 0;
		double S1 = 0;
		double s2 = 0;
		double t = 0;
		double A1 = 0;
		double A2 = 0;
		double b1 = 0;
		double b2 = 0;
		bool sign = false;
		if (X == 0) {
			LeftTail = 0.5;
			density = sqrt2pi;
			if (UseLog) {
				LeftTail = Math.Log(LeftTail);
				density = Math.Log(density);
			}
			RightTail = LeftTail;
			return;
		}
		sign = false;
		x2 = X * X;
		density = Math.Exp(-x2 * 0.5) * sqrt2pi;

		if (X < 0){X = -X;sign = true;}
		if (X < 2.5) {
			S1 = X;
			s2 = X;
			m = 1;
			do {
				m = m + 2;
				s2 = s2 * x2 / m;
				S1 = S1 + s2;
			} while (!((s2 < S1 * 1E-16)));
			LeftTail = 0.5 + S1 * density;
			if (UseLog) {
				RightTail = Math.Log(1 - LeftTail);
				LeftTail = Math.Log(LeftTail);
			} else {
				RightTail = 1 - LeftTail;
			}
		} else {
			A1 = 1;
			A2 = X;
			b1 = X;
			b2 = x2 + 1;
			i = 1;
			do {
				i = i + 1;
				t = A2;
				A2 = X * A2 + i * A1;
				A1 = t;
				t = b2;
				b2 = X * b2 + i * b1;
				b1 = t;
			} while (!((A2 * b1 == b2 * A1)));
			if (UseLog) {
				RightTail = (-x2 / 2) + Math.Log(sqrt2pi * A2 / b2);
				LeftTail = LogZPlusA(-Math.Exp(RightTail), 1);
			} else {
				RightTail = density * A2 / b2;
				LeftTail = 1 - RightTail;
			}
		}
		if (sign)
			SwapTails(ref LeftTail, ref RightTail);
		if (UseLog)
			density = (-x2 * 0.5) + Math.Log(sqrt2pi);
	}

	public static double ndis(double X)
	{
		double LeftTail = 0;
		double RightTail = 0;
		double density = 0;
		ndis2(false, X, LeftTail, RightTail, density);
		return LeftTail;
	}




	public static double tdens(double n, double X)
	{
		double C = 0;
		double h = 0;
		C = (1 + X * X / n);
		h = Math.Exp(LnGamma((n + 1) / 2) - LnGamma(n / 2)) / Math.Sqrt(Math.PI) / Math.Sqrt(n);
		return h * Math.Pow(C, (-(n / 2 + 1 / 2)));
	}



	public static double cdisOwen(long n, double X)
	{
		double C = 0;
		double F = 0;
		long k = 0;
		long i = 0;
		C = -Math.Exp(-X / 2);
		F = 1;
		k = n % 2;
		if (k != 0) {
			C = C * Math.Sqrt(2 * X / Math.PI);
			// C=ndens(x)
			F = 1 - 2 * ndis(-Math.Sqrt(X));
		}
		k = k + 2;
		for (i = k; i <= n; i += 2) {
			F = F + C;
			C = C * X / i;
		}
		return F;
	}


	public static double tdisOwen(double X, long n)
	{
		double a = 0;
		double b = 0;
		double C = 0;
		double F = 0;
		long k = 0;
		long i = 0;
		a = X / Math.Sqrt(n);
		b = 1 + a * a;
		k = n % 2;
		if (k != 0) {
			C = a / (b * Math.PI);
			F = 0.5 + Math.Atan(a) / Math.PI;
		} else {
			C = a / (2 * Math.Sqrt(b));
			F = 0.5;
		}
		k = k + 2;
		for (i = k; i <= n; i += 2) {
			F = F + C;
			C = C * (1 - 1 / i) / b;
		}
		return F;
	}


	//    Function FdisOwen(ByVal m As Long, ByVal n As Double, ByVal X As Double) As Double
	public static double FdisOwen(long m, long n, double X)
	{
		double U = 0;
		double sum = 0;
		double a = 0;
		double z = 0;
		double result = 0;
		long i = 0;
		long k = 0;
		k = m % 2;
		if (k == 0) {
			z = n / (n + m * X);
			result = Math.Pow(z, (n / 2));
			if (m > 2) {
				U = 1 - z;
				sum = 1;
				a = 1;
				for (i = 1; i <= (m - 2) / 2; i++) {
					a = a * U * (2 * i + n - 2) / (2 * i);
					sum = sum + a;
				}
				result = result * sum;
			}
		} else {
			z = Math.Sqrt(m * X);
			//      result = 2 * tdis(n, -z, L, r)
			result = 2 * tdisOwen(-z, n);
			if (m > 1) {
				U = z * z / (z * z + n);
				sum = z;
				a = z;
				for (i = 2; i <= (m - 1) / 2; i++) {
					a = a * U * (2 * i + n - 3) / (2 * i - 1);
					sum = sum + a;
				}
				result = result + 2 * sum * tdens(n, z);
			}
		}
		return result;
	}



	public static void BetaDisdemo()
	{
		double a = 0;
		double b = 0;
		double Q = 0;
		double p = 0;
		double L = 0;
		double r = 0;
		double density = 0;
		a = 100;
		b = 100;
		p = 0.50004000001;
		Q = 1 - p;
		betadis(a, b, Q, p, ref L, ref r, ref density);

		Console.WriteLine("L: " + L.ToString() + "   R: " + r.ToString() + "   density: " + density.ToString());

	}


	public static void demoLnGamma()
	{
		double a = 0;
		double b = 0;
		double lnG = 0;
		double lnB = 0;
		a = 1000000000;
		b = 1000000000;
		lnG = LnGamma(a);
		lnB = Lnbeta(a, b);
		Console.WriteLine("lnG: " + lnG.ToString() + "   lnB: " + lnB.ToString());
	}



	public static void DemoCdis()
	{
		double n = 0;
		double X = 0;
		double LeftTail = 0;
		double RightTail = 0;
		double density = 0;
		n = 13300.1;
		X = 13300.95;
		cdis2(n, X, ref LeftTail, ref RightTail, ref density);
		Console.WriteLine("LeftTail: " + LeftTail.ToString() + "   RightTail: " + RightTail.ToString() + "   density: " + density.ToString());

	}



	public static void Main()
	{
		Console.WriteLine("Hello World!");

		//        demoLnGamma()
		//        BetaDisdemo()
//		DemoCdis();
		DistX.demoCdisx();

		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
