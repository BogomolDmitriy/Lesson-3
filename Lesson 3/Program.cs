using System;
using GitLasson3Library;

public class Test
{
	public static void Main()
	{
		// Task№1
		Console.WriteLine($"Task№1{Environment.NewLine}The user enters 2 numbers (A and B).{Environment.NewLine}" +
			$"If A> B, count A + B, if A = B, count A * B, if A <B, count A-B");
		
		Console.Write("Enter A=");
		double A1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter B=");
		double B1 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine($"Console solution{Environment.NewLine}" +
			$"{Lasson3Library.Task1(A1,B1)}");
		Console.ReadKey();
		Console.Clear();

		// Task№2
		Console.WriteLine($"Task№2{Environment.NewLine}The user enters 2 numbers (X and Y)." +
			$"{Environment.NewLine}Determine which quarter the point with coordinates (X, Y) belongs to.");
		
		Console.Write("Enter X=");
		double X2 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter Y=");
		double Y2 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine($"point is in the {Lasson3Library.Task2(X2,Y2)} quarter");

		Console.ReadKey();
		Console.Clear();

		// Task№3
		Console.WriteLine($"Task№3{Environment.NewLine}The user enters 3 numbers (A, B and C)." +
			$"{Environment.NewLine}Output them to the console in ascending order.");

		Console.Write("Enter A=");
		double A3 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter B=");
		double B3 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter C=");
		double C3 = Convert.ToDouble(Console.ReadLine());

		(double max, double average, double min) = Lasson3Library.Task3(A3, B3, C3);

		Console.WriteLine($"max = {max}{Environment.NewLine}" +
			$"average = {average}{Environment.NewLine}" +
			$"min = {min}");

		Console.ReadKey();
		Console.Clear();

		// Task№4
		Console.WriteLine($"Task№4{Environment.NewLine}The user enters 3 numbers (A, B and C).{Environment.NewLine}" +
			$"Output to the console the solution (X values) of the quadratic equation of the standard form, AX^2 + BX + C = 0");

		Console.Write("Enter A=");
		double A4 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter B=");
		double B4 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter C=");
		double C4 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine($"Solving a quadratic equation = {Lasson3Library.Task4(A4, B4, C4)}");
	}
}
