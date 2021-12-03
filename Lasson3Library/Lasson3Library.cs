using System;

namespace GitLasson3Library
{
	public class Lasson3Library
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="A"></param>
		/// <param name="B"></param>
		/// <returns></returns>
		public static double Task1(double A, double B)
		{
			if (A > B)
			{
				return (A + B);
			}
			else if (A == B)
			{
				return (A * B);
			}
			else
			{
				return (A - B);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="X"></param>
		/// <param name="Y"></param>
		/// <returns></returns>
		public static string Task2(double X, double Y)
		{
			string Temp = "0";
			if (X > 0 && Y > 0)
			{
				Temp = ("1 part");
			}
			else if (X < 0 && Y < 0)
			{
				Temp = ("3 part");
			}
			else if (X > 0 && Y < 0)
			{
				Temp = ("4 part");
			}
			else if (X < 0 && Y > 0)
			{
				Temp = ("2 part");
			}
			else if (X == 0 && Y > 0)
			{
				Temp = ("2-1 part");
			}
			else if (X == 0 && Y < 0)
			{
				Temp = ("3-4 part");
			}
			else if (X < 0 && Y == 0)
			{
				Temp = ("2-3 part");
			}
			else if (X > 0 && Y == 0)
			{
				Temp = ("1-4 part");
			}
			else
			{
				Temp = ("Centre");
			}
			return Temp;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="A"></param>
		/// <param name="B"></param>
		/// <param name="C"></param>
		/// <returns></returns>
		public static (double max, double average, double min) Task3(double A, double B, double C)
		{
			double max = 0;
			double min = 0;
			double average = 0;

			if (A >= B && A >= C)
			{
				max = A;
			}

			else if (B >= A && B >= C)
			{
				max = B;
			}

			else if (C >= A && C >= B)
			{
				max = C;
			}

			if (A <= B && A <= C)
			{
				min = A;
			}

			else if (B <= A && B <= C)
			{
				min = B;
			}

			else if (C <= A && C <= B)
			{
				min = C;
			}

			if (A < max && A > min)
			{
				average = A;
			}

			else if (B < max && B > min)
			{
				average = B;
			}

			else if (C < max && C > min)
			{
				average = C;
			}

			else if (A <= max && A >= min)
			{
				average = A;
			}

			else if (B <= max && B >= min)
			{
				average = B;
			}

			else if (C <= max && C >= min)
			{
				average = C;
			}


			return (max, average, min);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="A"></param>
		/// <param name="B"></param>
		/// <param name="C"></param>
		/// <returns></returns>
		public static (double X1, double X2) Task4(double A, double B, double C)
		{

			double X1;
			double X2;
			double Dis = B * B - 4 * A * C;

			if (Dis == 0)
			{
				X1 = (-B * -B) / (2 * A);
				X2 = X1;
				return (X1, X2);
			}
			else if (Dis < 0)
			{

				return (0, 0);
			}
			else if (Dis > 0)
			{
				X1 = - (B / (2 * A)) + Math.Sqrt(Dis / 4 * A * A);
				X2= -(B / (2 * A)) - Math.Sqrt(Dis / 4 * A * A);
				return (X1, X2);
			}
		}
	}
}
