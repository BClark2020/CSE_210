using System;
class Program
{
	
	static void Main(string[] args)
	{
		Resume _res = new Resume();
		bool _var = true;
		do
		{
			Console.Clear();
			Job _job = new Job();
			Console.WriteLine("Job Title: ");
			_job._jobTitle = Console.ReadLine();
			Console.WriteLine("Company: ");
			_job._company = Console.ReadLine();
			
			bool _var1 = true;
			do
			{
				try
				{
					Console.WriteLine("Start Year: ");
					_job._startYear = int.Parse(Console.ReadLine());

				}
				catch (FormatException)
				{
					
					Console.WriteLine("ERROR: Please enter an integer.");
					_var1 = false;
				}	
			}while(_var1 == true);
			
			_var1 = true;
			do
			{
				try
				{
					Console.WriteLine("End Year: ");
					_job._endYear = int.Parse(Console.ReadLine());

				}
				catch (FormatException)
				{
					
					Console.WriteLine("ERROR: Please enter an integer.");
					_var1 = false;
				}	
			}while(_var1 == true);
			
			_res._jobs.Add(_job);
		
		}while(_var == true);
		
		_res.Display();
	}
}