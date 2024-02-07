using System;
using System.Threading;

public class Program
{
	public float number1, number2;
	
	public void Main()
	{
		// welcome
		Console.WriteLine("Welcome to letter and number swap");
		
		#region LETTER SWAP

		// instructions
		Console.WriteLine("Please input any string of charecters to be reversed");
		
		// gets input
		string myString;
		myString = Console.ReadLine();
		
		// puts each letter into an array
		char[] charArray = myString.ToCharArray();
		
		// reverses the array
		Array.Reverse(charArray);
		
		// combinds charicters in the array
		string newString = "";
 
		foreach (char tempChar in charArray)
		{
		    newString += tempChar;
		}
		
		// writes output
		Console.WriteLine(newString);
		
		#endregion
			
		// ask if you wish to go to the other half of the assignment
		Console.WriteLine("Do you wish to proceed to the next portion of the assignment");
		Console.WriteLine("Y / N");
		
		// gets response
		string answer = Console.ReadLine();
		if (answer != "Y")
		{
			if (answer != "y")
			{
				Console.WriteLine("Please exti or restart the program");
				return;
			}
		}

		#region NUMBER SWAP

		// welcome
		Console.WriteLine("Welcome to the other half of the assignment where 2 numbers get swapped");
			
		// instructions 1
		Console.WriteLine("Please input a number to be swapped");

		// get input 1
		number1 = float.Parse(Console.ReadLine());
		
		// instructions 2
		Console.WriteLine("Please input another number to be swapped");
		
		// get input 1
		number2 = float.Parse(Console.ReadLine());
		
		// swaps number values
		float temp = number1;
		number1 = number2;
		number2 = temp;

		// writes output
		Console.WriteLine(string.Format("after swap, first number: {0} second number: {1}", number1, number2));

		#endregion
			
		// credits
		Thread.Sleep(500);
		Console.WriteLine("This calculator was made by LittleTimmy52 (Lucas).");
		
		// advertisement
		Console.WriteLine("This is sponsered by Florida kid simulator");
		Console.WriteLine("Download today at https://florida-kid-simulator.weebly.com/");
	}
}