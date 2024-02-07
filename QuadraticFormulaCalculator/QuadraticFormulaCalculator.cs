using System;
using System.Threading;
					
public class Program
{
	public float a, b, c, answer1, answer2;
	public string tempA, tempB, tempC;
	
	public void Main()
	{
		// welcome
		Console.WriteLine("Welcome to quadratic formula calculator");
		
		#region GET VALUES
		
		// instructions a
		Console.WriteLine("insert the value of a");
		
		// collect input a
		tempA = Console.ReadLine();
		
		// if not a number stop program
		if (float.TryParse(tempA, out a))
		{
		    a = float.Parse(tempA);
		}else
		{
			Console.WriteLine("that is not a number restart the program");
			return;
		}
		
		// instructions b
		Console.WriteLine("insert the value of b");
		
		// collect input b
		tempB = Console.ReadLine();
		
		// if not a number stop program
		if (float.TryParse(tempB, out b))
		{
		    b = float.Parse(tempB);
		}else
		{
			Console.WriteLine("that is not a number restart the program");
			return;
		}
		
		// instructions c
		Console.WriteLine("insert the value of c");
		
		// collect input c
		tempC = Console.ReadLine();
		
		// if not a number stop program
		if (float.TryParse(tempC, out c))
		{
		    c = float.Parse(tempC);
		}else
		{
			Console.WriteLine("that is not a number restart the program");
			return;
		}
		
		#endregion
			
		#region CALCULATIONS
		
		float temp1 = (float) Math.Pow(b, 2) - (4 * a * c);
		float temp2;
		
		// if the inside of the square root is negative
		if (temp1 < 0)
		{
			// make it positive and square root the devide
			temp2 = (float) Math.Sqrt(Math.Abs(temp1)) / 2 * a;
			
			// print answer with i at the end
			Console.WriteLine("answer is: " + (-b / (2 * a)) + " ± " + temp2 + "i");
		}else if (temp1 == 0)
		{
			// if temp is 0 just do first part
			
			// print answer
			Console.WriteLine("answer is: " + (-b / (2 * a)));
			
		}else
		{
			// if inside the root is positive
			
			// square root then devide
			temp2 = (float) Math.Sqrt(temp1) / (2 * a);
			
			// print answer
			Console.WriteLine("answer is: " + (-b / (2 * a)) + " ± " + temp2);
		}
		
		#endregion
			
		// credits
		Thread.Sleep(500);
		Console.WriteLine("This calculator was made by LittleTimmy52 (Lucas).");
		
		// advertisement
		Console.WriteLine("This is sponsered by Florida kid simulator");
		Console.WriteLine("Download today at https://florida-kid-simulator.weebly.com/");
	}
}