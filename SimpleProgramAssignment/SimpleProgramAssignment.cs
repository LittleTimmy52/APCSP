using System;
using System.Collections.Generic;

/*
The purpose is to enlighten users on products of a number and 0-9
The function is to add 2 numbers together than multiply them by numbers ranging from 0-9
*/

public class Program
{
	// define variables
	public int inp1;
	public int inp2;
	List<int> nums = new List<int>();
	
	public void Main()
	{
		// get inputs
		inp1 = Convert.ToInt32(Console.ReadLine());
		inp2 = Convert.ToInt32(Console.ReadLine());
		
		// add inp1 and inp2 together then multiplys it by r then adds it to the list
		int r = 0;
		while (r !=10)
		{
			// the math
			int tmp = inp1 + inp2;
			int res = tmp * r;
				
			// add to list
			nums.Add(res);
			
			// increment
			r++;
		}
		
		// displays all numbers
		foreach (int i in nums)
		{
			Disp(i);
		}
	}
	
	public void Disp(int num)
	{		
		if (num > 1000)
		{
			Console.WriteLine("Number is above 1000");
		}else
		{
					Console.WriteLine(num);
		}
	}
}