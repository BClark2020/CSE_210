using System;

class Program
{
	
	static void Main(string[] args)
	{
		Console.Clear();
		Resume _res = new Resume();
		Console.Write("Please enter your name: ");
		_res._name = Console.ReadLine();
		bool _var = true;
		do
		{
			Console.Clear();
			Console.WriteLine("Enter, \"stop\" to exit.");
			Job _job = new Job();
			Console.Write("Job Title: ");
			_job._jobTitle = Console.ReadLine();
			if (_job._jobTitle == "stop")
			{
				_var = false;
			}
			else
			{
				
				Console.Write("Company: ");
				_job._company = Console.ReadLine();
				
				bool _var1 = true;
				do
				{
					try
					{
						Console.Write("Start Year: ");
						_job._startYear = int.Parse(Console.ReadLine());
						_var1 = true;

					}
					catch (FormatException)
					{
						
						Console.WriteLine("ERROR: Please enter an integer.");
						_var1 = false;
					}	
				}while(_var1 != true);
				
				_var1 = true;
				do
				{
					try
					{
						Console.Write("End Year: ");
						_job._endYear = int.Parse(Console.ReadLine());
						_var1 = true;

					}
					catch (FormatException)
					{
						
						Console.WriteLine("ERROR: Please enter an integer.");
						_var1 = false;
					}	
				}while(_var1 != true);
				
				_res._jobs.Add(_job);

			}
		
		}while(_var == true);
		
		_res.Display();
	}
}