
using System;

public static class DistX
{


	public static void print(	params object[] formats)
	{
		if (formats.Length == 0) {
			Console.WriteLine();
		} else {
			foreach (object format in formats) {
				try {
					Console.Write(format.ToString());
					// If there is an exception, do nothing. 
				} catch {
				}
			}
		}
		Console.WriteLine();
	}



	public static double Cbrt(double X)
	{
		return Math.Pow(X, (1 / 3));
	}



	public static double ndisx(double LeftTailSoll, double RightTailSoll)
	{
		double temp = 0;
		if (LeftTailSoll < RightTailSoll)
			temp = ndisx1(LeftTailSoll, RightTailSoll);
		else
			temp = ndisx1(RightTailSoll, LeftTailSoll);
		if (LeftTailSoll > RightTailSoll)
			temp = -temp;
		return temp;
	}


	public static double ndisx1(double LeftTailSoll, double RightTailSoll)
	{
		double split1 = 0.425;
		double split2 = 5.0;
		double const1 = 0.180625;
		double const2 = 1.6;
		double a0 = 3.38713287279637;
		double A1 = 133.141667891784;
		double A2 = 1971.59095030655;
		double a3 = 13731.6937655095;
		double a4 = 45921.9539315499;
		double A5 = 67265.7709270087;
		double a6 = 33430.5755835881;
		double A7 = 2509.08092873012;
		double b1 = 42.3133307016009;
		double b2 = 687.187007492058;
		double B3 = 5394.19602142475;
		double b4 = 21213.7943015866;
		double B5 = 39307.8958000927;
		double B6 = 28729.0857357219;
		double B7 = 5226.49527885285;
		double C0 = 1.42343711074968;
		double C1 = 4.63033784615655;
		double c2 = 5.76949722146069;
		double c3 = 3.6478483247632;
		double c4 = 1.27045825245237;
		double c5 = 0.241780725177451;
		double c6 = 0.0227238449892692;
		double C7 = 0.000774545014278341;
		double d1 = 2.05319162663776;
		double d2 = 1.6763848301838;
		double D3 = 0.6897673349851;
		double D4 = 0.14810397642748;
		double D5 = 0.0151986665636165;
		double D6 = 0.000547593808499535;
		double D7 = 1.05075007164442E-09;
		double E0 = 6.6579046435011;
		double e1 = 5.46378491116411;
		double e2 = 1.78482653991729;
		double E3 = 0.296560571828505;
		double E4 = 0.0265321895265761;
		double E5 = 0.00124266094738808;
		double E6 = 2.71155556874349E-05;
		double E7 = 2.01033439929229E-07;
		double f1 = 0.599832206555888;
		double f2 = 0.136929880922736;
		double f3 = 0.0148753612908506;
		double f4 = 0.000786869131145613;
		double f5 = 1.84631831751005E-05;
		double f6 = 1.42151175831645E-07;
		double f7 = 2.04426310338994E-15;

		double ppnd16 = 0;
		double r = 0;
		double p = 0;
		double Q = 0;
		p = LeftTailSoll;
		Q = LeftTailSoll - 0.5;
		if ((Math.Abs(Q) <= split1)) {
			r = const1 - Q * Q;
			ppnd16 = Q * (((((((A7 * r + a6) * r + A5) * r + a4) * r + a3) * r + A2) * r + A1) * r + a0) / (((((((B7 * r + B6) * r + B5) * r + b4) * r + B3) * r + b2) * r + b1) * r + 1);
			return ppnd16;
		} else {
			if ((Q < 0))
				r = p;
			else
				r = 1 - p;
			if (r <= 0) {
//{     ifault=1}
				ppnd16 = 0;
				return ppnd16;
			}
			r = Math.Sqrt(-Math.Log(r));
			if ((r <= split2)) {
				r = r - const2;
				ppnd16 = (((((((C7 * r + c6) * r + c5) * r + c4) * r + c3) * r + c2) * r + C1) * r + C0) / (((((((D7 * r + D6) * r + D5) * r + D4) * r + D3) * r + d2) * r + d1) * r + 1);
			} else {
				r = r - split2;
				ppnd16 = (((((((E7 * r + E6) * r + E5) * r + E4) * r + E3) * r + e2) * r + e1) * r + E0) / (((((((f7 * r + f6) * r + f5) * r + f4) * r + f3) * r + f2) * r + f1) * r + 1);
			}
			if (Q < 0)
				ppnd16 = -ppnd16;
			return ppnd16;
		}
	}






	public static double LambertW(double X)
	{
		return (((((125 * X - 64) * X + 36) * X - 24) * X + 24) * X) / 24;
	}


	public static double cdisx_Lambert(double LeftTail, double RightTail, double n)
	{
		double t = 0;
		double d = 0;
		double k = 0;
		double a = 0;
		double result = 0;
		a = 1 / (0.5 * n - 1);
		k = Dist.LnGamma(0.5 * n);
		d = a * (Math.Log(LeftTail) + k);
		t = -a * Math.Exp(LeftTail + d);
		//    Debug.Print "a: ", a, "k: ", k, "d: ", d, "t: ", t
		result = -2 * LambertW(t) / a;
		return result;
	}




	public static double cdisx_Canal(double LeftTail, double RightTail, double n)
	{
		double h = 0;
		double L = 0;
		double mean = 0;
		double stdev = 0;
		double U = 0;
		double m = 0;
		double m2 = 0;
		double m3 = 0;
		double g = 0;
		double z = 0;
		double result = 0;
		z = ndisx(LeftTail, RightTail);
		m = 1 / n;
		m2 = m * m;
		m3 = m2 * m;
		mean = (14580 - 1944 * m - 189 * m2 + 200 * m3) / 17496;
		stdev = Math.Sqrt(Math.Abs(648 * m + 72 * m2 - 37 * m3)) / 108;
		g = Math.Sqrt(0.5 * m3) / 162;
		z = z - g + (z * g) * (z - (2 * z * z - 5) * g);
		L = 6 * (z * stdev + mean);
		h = Cbrt(2 * (L + Math.Sqrt(13 + L * (L - 5))) - 5);
		U = 0.5 + 0.5 * h - 1.5 / h;
		U = U * U * U;
		result = n * U * U;

		return result;
	}



	public static double cdisx_approx(double LeftTail, double RightTail, double n)
	{
		double t = 0;
		double d = 0;
		double k = 0;
		double a = 0;
		double result = 0;
		bool UseLambert = false;
		double h = 0;
		double L = 0;
		double mean = 0;
		double stdev = 0;
		double U = 0;
		double m = 0;
		double m2 = 0;
		double m3 = 0;
		double g = 0;
		double z = 0;
		UseLambert = true;
		if (UseLambert) {
			a = 1 / (0.5 * (n + 2) - 1);
			k = Dist.LnGamma(0.5 * (n + 2));
			d = a * (Math.Log(LeftTail) + k);
			t = -a * Math.Exp(LeftTail + d);
			print("t: ", t);
			if (Math.Abs(t) > 0.1)
				UseLambert = false;
		}
		if (UseLambert) {
			print("Use Lambert");
			result = -(((((125 * t - 64) * t + 36) * t - 24) * t + 24) * t) / (12 * a);
		} else {
			print("Use Canal");
			z = ndisx(LeftTail, RightTail);
			m = 1 / n;
			m2 = m * m;
			m3 = m2 * m;
			mean = (14580 - 1944 * m - 189 * m2 + 200 * m3) / 17496;
			stdev = Math.Sqrt(Math.Abs(648 * m + 72 * m2 - 37 * m3)) / 108;
			g = Math.Sqrt(0.5 * m3) / 162;
			z = z - g + (z * g) * (z - (2 * z * z - 5) * g);
			L = 6 * (z * stdev + mean);
			h = Cbrt(2 * (L + Math.Sqrt(13 + L * (L - 5))) - 5);
			U = 0.5 + 0.5 * h - 1.5 / h;
			U = U * U * U;
			result = n * U * U;
		}
		return result;
	}




	public static double cdisx_new(double LeftTail, double RightTail, double m)
	{
		double Left1 = 0;
		double Right1 = 0;
		double deriv = 0;
		double diff = 0;
		double delta = 0;
		double x1 = 0;
		if (m < 0.5) {
			print("m must be >= 0.5");
			return 1;
		}
		double MinRelError = 1E-13;
		double RelError = 1.0;
		double X = cdisx_approx(LeftTail, RightTail, m);
		X = Math.Abs(X);
		long k = 0;
		bool UseLeftTail = false;
		if (LeftTail < RightTail)
			UseLeftTail = true;

		while (((RelError > MinRelError) & (k < 100))) {
			k = k + 1;
			Dist.cdis2(m, X, ref Left1, ref Right1, ref deriv);
			if (UseLeftTail) {
				diff = LeftTail - Left1;
			} else {
				diff = Right1 - RightTail;
			}
			delta = 0;
			if (deriv != 0)
				delta = diff / deriv;
			x1 = X + delta;
			if (x1 <= 0)
				x1 = X / 2;
			X = x1;
			RelError = Math.Abs(delta) / X;
		}
		return X;
	}





	public static void demoCdisx()
	{
		double m = 10.5;
		double LeftTail = 1E-15;
		double RightTail = 1 - LeftTail;
//		double RightTail = 1E-220;
//		double LeftTail = 1 - RightTail;
		double R0 = cdisx_new(LeftTail, RightTail, m);
		print("R0      : ", R0);
		double r1 = cdisx_Lambert(LeftTail, RightTail, m + 2);
		print("LambertL: ", r1, ", ", Math.Abs(r1 - R0) / R0);
		double r2 = cdisx_Canal(LeftTail, RightTail, m);
		print("Canal   : ", r2, ", ", Math.Abs(r2 - R0) / R0);
		print("");
	}



}
