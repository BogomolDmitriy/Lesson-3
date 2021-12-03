using System;
using GitLasson3Library;

public class Ramification
{
	public static void Main()
	{
		int userInput;
		do
		{
			userInput = Convert.ToInt32(Console.ReadLine());
			switch (userInput)
			{
				case 1:
					{
						// Task№1
						Console.WriteLine($"Task№1{Environment.NewLine}The user enters 2 numbers (A and B).{Environment.NewLine}" +
									$"If A> B, count A + B, if A = B, count A * B, if A <B, count A-B");

						bool result;
						double A;
						double B;
						do
						{
							Console.Write("Enter A=");
							result = double.TryParse(Console.ReadLine(), out A);
						} while (!result);

						do
						{
							Console.Write("Enter B=");
							result = double.TryParse(Console.ReadLine(), out B);
						} while (!result);

						Console.WriteLine($"Console solution{Environment.NewLine}" +
							$"{Lasson3Library.Task1(A, B)}");
						Console.ReadKey();
						Console.Clear();
						break;
					}

				case 2:
					{
						// Task№2
						bool result;
						double X;
						double Y;
						Console.WriteLine($"Task№2{Environment.NewLine}The user enters 2 numbers (X and Y)." +
							$"{Environment.NewLine}Determine which quarter the point with coordinates (X, Y) belongs to.");

						do
						{
							Console.Write("Enter X=");
							result = double.TryParse(Console.ReadLine(), out X);
						} while (!result);

						do
						{
							Console.Write("Enter Y=");
							result = double.TryParse(Console.ReadLine(), out Y);
						} while (!result);

						Console.WriteLine($"point is in the {Lasson3Library.Task2(X, Y)} quarter");

						Console.ReadKey();
						Console.Clear();
						break;
					}

				case 3:
					{
						bool result;
						double A;
						double B;
						double C;
						// Task№3
						Console.WriteLine($"Task№3{Environment.NewLine}The user enters 3 numbers (A, B and C)." +
							$"{Environment.NewLine}Output them to the console in ascending order.");

						do
						{
							Console.Write("Enter A=");
							result = double.TryParse(Console.ReadLine(), out A);
						} while (!result);

						do
						{
							Console.Write("Enter B=");
							result = double.TryParse(Console.ReadLine(), out B);
						} while (!result);

						do
						{
							Console.Write("Enter C=");
							result = double.TryParse(Console.ReadLine(), out C);
						} while (!result);

						(double max, double average, double min) = Lasson3Library.Task3(A, B, C);

						Console.WriteLine($"max = {max}{Environment.NewLine}" +
							$"average = {average}{Environment.NewLine}" +
							$"min = {min}");

						Console.ReadKey();
						Console.Clear();
						break;
					}

				case 4:
					{
						// Task№4
						bool result;
						double A;
						double B;
						double C;
						Console.WriteLine($"Task№4{Environment.NewLine}The user enters 3 numbers (A, B and C).{Environment.NewLine}" +
							$"Output to the console the solution (X values) of the quadratic equation of the standard form, AX^2 + BX + C = 0");

						do
						{
							Console.Write("Enter A=");
							result = double.TryParse(Console.ReadLine(), out A);
						} while (!result);

						do
						{
							Console.Write("Enter B=");
							result = double.TryParse(Console.ReadLine(), out B);
						} while (!result);

						do
						{
							Console.Write("Enter C=");
							result = double.TryParse(Console.ReadLine(), out C);
						} while (!result);

						(double X1, double X2) = Lasson3Library.Task4(A, B, C);

						Console.WriteLine($"Solving a quadratic equation {Environment.NewLine}" +
							$"X1 = {X1}{Environment.NewLine}X2 = {X2}");
						break;
					}
			}
		} while (userInput != 0);

	}
}
