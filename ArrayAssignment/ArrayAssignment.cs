using System;
					
public class Program
{
	public int[] nums = new int[5];
	
	public void Main()
	{
		for (int i = 0; i < 5; i++)
		{
			nums[i] = i + 1;
		}
		
		nums[0] = 0;
		nums[1] = 0;
		nums[0] = 2;
		nums[1] = 1;
		
		foreach (int i in nums)
		{
			Console.WriteLine(i);
		}
	}
}