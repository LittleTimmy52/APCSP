using System;
using System.Linq;
 
public class Example
{
	public bool[] bools = {true, false, true, true, false};
		
	public void Main()
	{
		Console.WriteLine("[" + string.Join(", ", bools) + "]");
		
		string boolArrStr = ConvertBoolToString(bools);
		Console.WriteLine(boolArrStr);
		
		bools[0] = false;
		bools[1] = false;
		bools[2] = false;
		bools[3] = true;
		bools[4] = false;
		Console.WriteLine("[" + string.Join(", ", bools) + "]");
		
		bools = ConvertStringToBool(boolArrStr);
		Console.WriteLine("[" + string.Join(", ", bools) + "]");
	}
	
	private string ConvertBoolToString(bool[] TF)
	{
		int[] boolAsInt = new int[TF.Length];
		for (int i = 0; i < TF.Length; i++)
		{
			boolAsInt[i] = Convert.ToInt32(TF[i]);
		}
		
		return "[" + string.Join(", ", boolAsInt) + "]";
	}
	
	private bool[] ConvertStringToBool(string str)
	{
		int[] boolAsInt = str.Substring(1, str.Length - 2)
	                         .Split(',')
	                         .Select(s => int.Parse(s))
	                         .ToArray();
		
		bool[] tmp = new bool[boolAsInt.Length];
		for (int i = 0; i < boolAsInt.Length; i++)
		{
			tmp[i] = Convert.ToBoolean(boolAsInt[i]);
		}
		
		return tmp;
	}
}
