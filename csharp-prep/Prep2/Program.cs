using System;

class Gradebook
{
	public string GetGrade()
	{
		int grade = 0;
		bool var = true;
		do
		{
			try
			{
				Console.Clear();
				Console.Write("Enter your grade: ");
				grade = int.Parse(Console.ReadLine());
				var = true;
			}
			catch (FormatException)
			{
				var = false;
				Console.WriteLine("ERROR: Please enter an integer.");
				Thread.Sleep(2000);
			}
		} while (var != true);
		
		string letter_grade = CompareGrade(grade);
		
		return letter_grade;	
	}
	
	
	private string CompareGrade(int grade)
	{
		string letter = "F";
		int second = 0;
		
		string sgrade = grade.ToString();
		try 
		{
			char ssecond = sgrade[1];
		   second = int.Parse(ssecond.ToString());
		}
		catch (IndexOutOfRangeException)
		{
			second = 0;
		}
		
		
		if (grade >= 90)
		{
			letter = "A";
		}
		else if (grade >= 80)
		{
			letter = "B";
		}
		else if (grade >= 70)
		{
			letter = "C";
		}
		else if (grade >= 60)
		{
			letter = "D";
		}
		else
		{
			letter = "F";
		}
		
		
		if (second >= 7 && letter != "A" && letter != "F")
		{
			letter = "+"+letter;
		}
		else if (second <= 3 && letter != "F")
		{
			letter = "-"+letter;
		}
		
		return letter;
	}
}
class Program
{
	static void Main(string[] args)
	{
		Gradebook g = new Gradebook();
		string grade = g.GetGrade();
			
		Console.WriteLine($"Your grade is an {grade}.");	
	}
}