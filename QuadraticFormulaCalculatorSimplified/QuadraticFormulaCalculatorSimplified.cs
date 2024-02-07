using System;
					
public class Program
{
	public float a, b, c;
	
	public void Main()
	{
		a = float.Parse(Console.ReadLine());
		b = float.Parse(Console.ReadLine());
		c = float.Parse(Console.ReadLine());
		float temp1 = (float) Math.Pow(b, 2) - (4 * a * c);
		float temp2;
		if (temp1 < 0)
		{
			temp2 = (float) Math.Sqrt(Math.Abs(temp1)) / 2 * a;
			Console.WriteLine("answer is: " + (-b / (2 * a)) + " ± " + temp2 + "i");
		}else
		{
			temp2 = (float) Math.Sqrt(temp1) / (2 * a);
			Console.WriteLine("answer is: " + (-b / (2 * a)) + " ± " + temp2);
		}
	}
}