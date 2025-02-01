using System;

public class Journal
{
	List<string> _prompts = new List<string>()
	{
		"What is something noticable that happened today?",
		"What is something you are excited about doing today?",
		"How did you see the hand of the Lord in your life today?",
		"What is something you are greateful for?"
	};
	public List<Entry> _entries = new List<Entry>();
	List<string> files = new List<string>();
	string _current_file;
	bool saved = true;
	public void menu()
	{
		while(true)
		{
			Console.Clear();
			if (saved == true)
			{
				Console.WriteLine($"Current file: {_current_file}\n");
			}
			else if (saved == false)
			{
				Console.WriteLine($"Current file: {_current_file}*\n");	
			}
			Console.WriteLine("MENU:");	
			Console.WriteLine("1.) New entry");	
			Console.WriteLine("2.) Display Journal");	
			Console.WriteLine("3.) Save Journal");
			Console.WriteLine("4.) Load Journal");
			Console.WriteLine("5.) Exit");
			Console.Write("\nSelect an option: ");			
			string _menu = Console.ReadLine(); 	
			
			switch(_menu)
			{
				case "1":
					// Creates a new entry instance to save each time with all its variables
					Entry _entry = new Entry();
					_entry.writeEntry(_prompts);
					_entries.Add(_entry);
					saved = false;
					break;
				
				case "2":
					Display(); 
					break;
				
				case "3":
					Save();
					break;
				
				case "4":
					Load();
					break;
				
				case "5":
				
					return;
				
				default:
					Console.WriteLine("ERROR: that input is not recognized.");
					Thread.Sleep(2000);
					break;
			}
		}
		
	}
	
	private void Display()
	{
		
		foreach(Entry entry in _entries)
		{
			entry.Display();
		}	
		
		string pause = Console.ReadLine();
	}
	
	private void Save()
	{
		string _file = "";
		string overwrite ="";
		Console.WriteLine("Enter a name for this journal: ");
		_file = Console.ReadLine();
		if (_file == "filenames.txt")
		{
			Console.WriteLine("Sorry, you cannot overwrite this file.");
		}
		else
		{
			loadFiles();
			if (files.Contains(_file) && _current_file != _file)
			{
				bool _var = true;
				do
				{
					Console.WriteLine("Are you sure you want to overwrite this file?");
					overwrite = Console.ReadLine();
					if (overwrite == "yes" || overwrite == "no"|| overwrite ==  "Yes" || overwrite ==  "No")
					{
						
						_var = true;
					}		
					else
					{
						Console.WriteLine("Please enter a yes or no.");
						_var = false;
					}
					
				}while(_var != true);
			}
			else if (files.Contains(_file))
			{
				saveFiles();
			}
			else
			{
				files.Add(_file);
				saveFiles();
			}
			
			
			if(overwrite == "yes"|| overwrite == "Yes" || overwrite == "")
			{
				try
				{
					using (StreamWriter writer = new StreamWriter(_file))
					{
						foreach (Entry entry in _entries)
						{
							writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
						}
					}

					Console.WriteLine("Journal saved successfully.");
					_current_file = _file;
					saved = true;
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error saving journal: {ex.Message}");
				}
			}
			else
			{
				return;
			}
		}
	
	}
	
	private void Load()
	{
		string _file;
		Console.WriteLine("Enter a file to load: ");
		_file = (Console.ReadLine());
		try
		{
			_entries.Clear();

			using (StreamReader reader = new StreamReader(_file))
			{
				Console.WriteLine("Loading entries");
				string line;
				while ((line = reader.ReadLine()) != null)
				{		 
					Entry _entry = new Entry();
					string[] parts = line.Split('|');
					_entry._date = DateTime.Parse(parts[0]);
					_entry._prompt = parts[1];
					_entry._entry = parts[2];
					_entries.Add(_entry);
				}
				Thread.Sleep(1000);
			}

			Console.WriteLine("Journal loaded successfully.");
			Thread.Sleep(2000);
			_current_file = _file;
			saved = true;
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error loading journal: {ex.Message}");
		}
	
	}

	private void loadFiles()
	{
		files.Clear();
		
		using (StreamReader reader = new StreamReader("filenames.txt"))
		{
			string line;
			while((line = reader.ReadLine()) != null)
			{
				files.Add(line);
			}
		}	
		saveFiles();	
	}	

	public void saveFiles()
	{
		using (StreamWriter writer = new StreamWriter("filenames.txt"))
		{
			foreach(string file in files)
			{
				writer.WriteLine(file);
			}
		}
	}
}