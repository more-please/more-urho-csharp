using System;
using Urho;

namespace Common
{
	namespace Extensions
	{
		public static class Floats
		{
			public static int Int(this double d)
			{
				return (int)d;
			}

			public static int Int(this float f)
			{
				return (int)f;
			}

			public static float Float(this double d)
			{
				return (float)d;
			}

			public static double Round(this double d)
			{
				return Math.Round(d);
			}

			public static double Round(this float f)
			{
				return Math.Round(f);
			}

			public static float RadiansToDegrees(this float f)
			{
				return MathHelper.RadiansToDegrees(f);
			}

			public static float DegreesToRadians(this float f)
			{
				return MathHelper.DegreesToRadians(f);
			}

			public static double Sin(this float f)
			{
				return Math.Sin(f);
			}

			public static float Sinf(this float f)
			{
				return (float)Math.Sin(f);
			}

			public static double Asin(this float f)
			{
				return Math.Asin(f);
			}

			public static float Asinf(this float f)
			{
				return (float)Math.Asin(f);
			}

			public static double Cos(this float f)
			{
				return Math.Cos(f);
			}

			public static float Cosf(this float f)
			{
				return (float)Math.Cos(f);
			}

			public static double Acos(this float f)
			{
				return Math.Acos(f);
			}

			public static float Acosf(this float f)
			{
				return (float)Math.Acos(f);
			}

			public static double Tan(this float f)
			{
				return Math.Tan(f);
			}

			public static float Tanf(this float f)
			{
				return (float)Math.Tan(f);
			}

			public static double Atan(this float f)
			{
				return Math.Atan(f);
			}

			public static float Atanf(this float f)
			{
				return (float)Math.Atan(f);
			}

			public static double Sqrt(this float f)
			{
				return Math.Sqrt(f);
			}

			public static float Sqrtf(this float f)
			{
				return (float)Math.Sqrt(f);
			}

			public static float Abs(this float f)
			{
				return Math.Abs(f);
			}

			public static bool IsNan(this float f)
			{
				return float.IsNaN(f);
			}

			public static bool IsInfinity(this float f)
			{
				return float.IsInfinity(f);
			}

			public static float Lerp(this float t, float a, float b)
			{
				return (1 - t) * a + t * b;
			}

			public static double Pow(this float a, float b)
			{
				return (double)Math.Pow(a, b);
			}

			public static float Powf(this float a, float b)
			{
				return (float)Math.Pow(a, b);
			}

			public static float Clamp(this float f, float min, float max)
			{
				return MathHelper.Clamp(f, min, max);
			}
		}
	}
}
