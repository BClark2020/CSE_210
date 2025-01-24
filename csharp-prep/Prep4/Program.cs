using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Clear();
		Program p = new Program();
		Console.WriteLine("Enter 0 to leave.");
		List<int> numbers = new List<int>();
		int new_number = 1 ;
		
		while(new_number != 0)
		{
			bool var = true;
			do
			{
				try
				{
					Console.Write("Enter an integer: ");
					new_number = int.Parse(Console.ReadLine());
					var = true;
				}
				catch(FormatException)
				{
					Console.WriteLine("ERROR: Please enter an INTEGER.");
					var = false;
				}
				
			}while(var != true);
			
			if (new_number != 0)
			{
				numbers.Add(new_number);	
			} 
			
		}
		p.NumberDisplay(numbers);
			
	}
	
	private void NumberDisplay(List<int> numbers)
	{
		int sum = 0;
		int average = 0;
		int largest = 0;
		int smallest = 1000000000;
			
		List<int> sorted = new List<int>();
		
		for (int i = 0; i < numbers.Count(); i++)
		{
			if (smallest > numbers[i])
			{
				smallest = numbers[i];
			}
			if (largest < numbers[i])
			{
				largest = numbers[i];
			}
			sum += numbers[i];
		}
		
		average = sum/numbers.Count();
		
		sorted = List_Sorter(numbers);
		
		Console.WriteLine($"List average: {average}");
		Console.WriteLine($"List sum: {sum}");
		Console.WriteLine($"Largest number: {largest}");
		Console.WriteLine($"Smallest number: {smallest}");
		Console.WriteLine("Your sorted list:");
		for (int i = 0; i < sorted.Count(); i++)
		{
			Console.WriteLine($"{sorted[i]}");
		}
	}
	
	
	private List<int> List_Sorter(List<int> numbers)
	{
		int loop = numbers.Count();
		List<int> sorted = new List<int>();
		for (int i = 0; i <  loop; i++)
		{
			int smaller = 1000000000;
			for (int z = 0; z < numbers.Count() ; z++)
			{
				if (smaller > numbers[z])
				{
					smaller = numbers[z];
				}
			}
			sorted.Add(smaller);
			numbers.Remove(smaller);	
		}
		
		return sorted;
	}
	
}