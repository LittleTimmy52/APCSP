using System;

public class Program{
	public int mChoise;
	public int sChoise;
	public int dChoise;
	public bool combo = false;
	public string[] meals = { "Baked beans 20p", "Stale toast 20p", "Expired fish n chips wiv old crackers 20p", "Moldy biscuts 20p" };
	public string[] sides = { "Cold baked beans 20p", "Musty crisps 20p", "Old pickels 20p", "" };
	public string[] drinks = { "Tea 20p ", "Bo''le o' wa''er 20p ", "" };
	public string[] size = { "size: S", "size: M", "size: L", "" };
	public int sizeChoise;
	public float total;
	public void Main(){
		total = 0;
		Console.WriteLine("Meals\n1. Baked beans 20p\n2. Stale toast 20p\n3. Expired fish n chips wiv old crackers 20p\n4. Moldy stale biscuts 20p\nSides\n1. Cold baked beans 20p\n2. Musty crisps 20p\n3. Old pickels 20p\nDrinks\n1. Tea 20p\n2. A bo''le o' wa''er 20p\nWhat meal would you like to order");
		int answer = Convert.ToInt32(Console.ReadLine());
		if (answer == 1){mChoise = 0; total += 20; Combo();
		}else if (answer == 2){mChoise = 1; total += 20; Combo();
		}else if (answer == 3){mChoise = 2; total += 20; Combo();
		}else if (answer == 4){mChoise = 3; total += 20; Combo();
		}else{ Console.WriteLine("not a choise"); Main();}}
	public void Combo(){		
		Console.WriteLine("Would you make it a combo for 25p? (Y/N)");
	    string answer = Console.ReadLine();
		if (answer == "Y" || answer == "y"){combo = true; total += 5; Drinks();
		}else if(answer == "N" || answer == "n"){combo = false; Sides();
		}else{Combo();}}
	public void Sides(){
		Console.WriteLine("What side would you like to order (anything other number is none)");
	    int answer = Convert.ToInt32(Console.ReadLine());
		if(answer == 1){ sChoise = 0; total += 20; Drinks();
		}else if(answer == 2){sChoise = 1; total += 20; Drinks();
		}else if(answer == 3){sChoise = 2; total += 20; Drinks();
		}else{sChoise = 3; Drinks();}}
	public void Drinks(){
		Console.WriteLine("What drink would you like to order (anything other number is none)");
		int answer = Convert.ToInt32(Console.ReadLine());
		if (answer == 1){dChoise = 0; total += 20; Size();
		}else if (answer == 2){dChoise = 1; total += 20; Size();
		}else{dChoise = 2; sizeChoise = 3; Order();}}
	public void Size(){
		Console.WriteLine("What size (S/M/L)");
		string ans = Console.ReadLine();
		if (ans == "S" || ans == "s"){sizeChoise = 0; Order();
		}else if (ans == "M" || ans == "m"){sizeChoise = 1; Order();
		}else if (ans == "L" || ans == "l"){sizeChoise = 2; Order();
		}else{Console.WriteLine("not a choise"); Size();}}
	public void Order(){
		Console.WriteLine("Your total order is as follows:");
		if(combo == true){Console.WriteLine(meals[mChoise]); Console.WriteLine(drinks[dChoise] + size[sizeChoise]); Console.WriteLine("Total: " + total);
		}else{Console.WriteLine(meals[mChoise]); Console.WriteLine(sides[sChoise]); Console.WriteLine(drinks[dChoise] + size[sizeChoise]); Console.WriteLine("Total: " + total);}}}