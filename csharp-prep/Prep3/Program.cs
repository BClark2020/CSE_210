using System;
using Microsoft.VisualBasic;

class NumberGame
{
	public void game()
	{
		Random random = new Random(); 
		int magic_number = random.Next(1, 101); 
		int guess = 0;
		int count = 1;
		
		Starting_Display();
		
		bool var = true;
		do
		{
			try
			{
				Console.Clear();
				Console.Write("Please enter your guess: ");
				guess = int.Parse(Console.ReadLine());
				var = true;
			}
			catch (FormatException)
			{
				Console.WriteLine("ERROR: Please enter an interger");
				var = false;
				Thread.Sleep(2000);
			}
		}while (var != true);
		
		var = true;
		while (var == true)
		
		{
			count++; 
			if (guess > magic_number)
			{
				Console.WriteLine("Guess Lower!");
			}
			else if (guess < magic_number)
			{
				Console.WriteLine("Guess Higher!");
			}
			else if (guess == 126)
			{
				Winning_Display(magic_number, count);
				Console.WriteLine("AUTOMATIC WIN!!!!");
				var = false;
			}
			else
			{
				Secrect_Win(magic_number, count);
				var = false;
			}
		}
		
	}
	
	private void Starting_Display()
	{
		Console.Clear();
		Console.WriteLine("WELCOME TO THE NUMBER GAME");
		Thread.Sleep(1500);
		Console.WriteLine("A random number between 1 and 100 will be selected.");
		Thread.Sleep(1500);
		Console.WriteLine("Your goal is to guess the number in fewest attempts possible!");
		Thread.Sleep(1500);
		Console.WriteLine("Good Luck!!");
		Thread.Sleep(2000);
	}
	
	private void Winning_Display(int magic_number, int count)
	{
		Console.WriteLine($"Congradulations, you guessed {magic_number} in {count} tries!!");
	}
	
	private void Secrect_Win (int magic_number, int count)
	{
		Console.WriteLine($"YOU FOUND THE SECRECT WIN!");
		Thread.Sleep(1500);
		Console.WriteLine($"The number was {magic_number} but that doesn't matter.");
		Console.WriteLine("Thats because 126 is my favoirte number!");
	}
	
}
class Program
{
	static void Main(string[] args)
	{
		NumberGame game = new NumberGame();
		game.game();
	}
}