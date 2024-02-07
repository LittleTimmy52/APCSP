using System;

public class Program
{
	public int mChoise;
	public int sChoise;
	public int dChoise;
	public bool combo = false;
	
	public string[] meals = { "Baked beans", "Stale toast", "Expired fish n chips wiv old crackers", "Moldy biscuts" };
	public string[] sides = { "Cold baked beans", "Musty crisps", "Old pickels" };
	public string[] drinks = { "Tea", "Bo''le o' wa''er" };
	
	public void Main()
	{
		// welcome
		Console.WriteLine("Welcome to LittleTimmy52's");
		Console.WriteLine(" ");
		
		// run code
		Options();
		Meal();
	}
	
	public void Options()
	{
		// meals
		Console.WriteLine("Meals");
		Console.WriteLine("1. Baked beans 20p");
		Console.WriteLine("2. Stale toast 20p");
		Console.WriteLine("3. Expired fish n chips wiv old crackers 20p");
		Console.WriteLine("4. Moldy stale biscuts 20p");
		
		// spacer
		Console.WriteLine(" ");
		
		// sides
		Console.WriteLine("Sides");
		Console.WriteLine("1. Cold baked beans 20p");
		Console.WriteLine("2. Musty crisps 20p");
		Console.WriteLine("3. Old pickels 20p");
		
		// spacer
		Console.WriteLine(" ");
		
		// drinks
		Console.WriteLine("Drinks");
		Console.WriteLine("1. Tea 20p");
		Console.WriteLine("2. A bo''le o' wa''er 20p");
		
		// spacer
		Console.WriteLine(" ");
	}
	
	public void Meal()
	{
		Console.WriteLine("What meal would you like to order");
		
		// get answer
		int answer = Convert.ToInt32(Console.ReadLine());
		
		if (answer == 1)
		{
			// sets choice calls combo
			mChoise = 0;
			Combo();
		}else if (answer == 2)
		{
			// sets choise calls combo
			mChoise = 1;
			Combo();
		}else if (answer == 3)
		{
			// sets choise calls combo
			mChoise = 2;
			Combo();
		}else if (answer == 4)
		{
			// sets choise calls combo
			mChoise = 3;
			Combo();
		}else
		{
			// reloads this function
			Console.WriteLine("Not a valid choise");
			Meal();
	    }
	}
	
	public void Combo()
	{		
		Console.WriteLine("Would you make it a combo for 25p? (Y/N)");
		
		// gets answer
	    string answer = Console.ReadLine();
			
		if (answer == "Y" || answer == "y")
		{
			// makes it a combo calls drinks
			combo = true;
			Drinks();
		}else if (answer == "N" || answer == "n")
		{
			// makes it not a combo calls sides
			combo = false;
			Sides();
		}else
		{
			// reloads this function
			Console.WriteLine("Not a valid choise");
			Combo();
		}
	}
	
	public void Sides()
	{
		Console.WriteLine("What side would you like to order");
		
		// gets answer
	    int answer = Convert.ToInt32(Console.ReadLine());
		
		if(answer == 1)
		{
			// sets choise calls frinks
			sChoise = 0;
			Drinks();
		}else if(answer == 2)
		{
			// sets choise calls drinks
			sChoise = 1;
			Drinks();
		}else if(answer == 3)
		{
			// sets choise calls drinks
			sChoise = 2;
			Drinks();
		}else
		{
			// reloads this function
		    Console.WriteLine("Not a valid choise");
			Sides();
		}
	}
	
	public void Drinks()
	{
		Console.WriteLine("What drink would you like to order");
		
		// gets answer
		int answer = Convert.ToInt32(Console.ReadLine());
		
		if (answer == 1)
		{
			// sets choise calls order
			dChoise = 0;
			Order();
		}else if (answer == 2)
		{
			// sets choise calls order
			dChoise = 1;
			Order();
		}else
		{
			// reloads this function
			Console.WriteLine("that is not a valid choise");
			Drinks();
		}
	}
	
	public void Order()
	{
		Console.WriteLine("Your total order is as follows:");
		
		if(combo == true)
		{
			// displays order and total if its a combo
			Console.WriteLine(meals[mChoise] + " combo 25p");
			Console.WriteLine(drinks[dChoise] + " 20p");
			Console.WriteLine("Total: 45p");
		}else
		{
			// displays order if its not a combo
			Console.WriteLine(meals[mChoise] + " 20p");
			Console.WriteLine(sides[sChoise] + " 20p");
			Console.WriteLine(drinks[dChoise] + " 20p");
			Console.WriteLine("Total: 60p");
		}
		
		// calls end
		End();
	}
	
	public void End()
	{
		Console.WriteLine("Rerun program?");
		
		// gets answer
		string answer = Console.ReadLine();
		
		if(answer == "Y" || answer == "y")
		{
			// reruns program
			Main();
		}
	}
}