using System.Collections.Generic;
using System;
					
public class Program
{
	public List<int> nums = new List<int>();
	
	public void Main()
	{
		for (int i = 1; i < 6; i++)
		{
			nums.Add(i);
		}
		
		nums.Remove(0);
		nums.Remove(1);
		
		nums.Insert(0, 2);
		nums.Insert(1, 1);
		
		foreach (int i in nums)
		{
			Console.WriteLine(i);
		}
	}
}