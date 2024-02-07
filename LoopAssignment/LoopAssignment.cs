using System;
					
public class Program
{
	public double num, num1, num2;
	
	public void Main()
	{
		Console.WriteLine("input limit");
		num = Convert.ToDouble(Console.ReadLine());
		for(num1 = 0; num1 <= num; num1 += 2)
		{
			num2 += num1;
		}
		Console.WriteLine(num2);
	}
}