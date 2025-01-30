using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;



public class Journal
{
	List<string> _prompts = new List<string>()
	{
		"What is something noticable that happened today?",
		"What is something you are excited about doing today?",
		"How did you see the hand of the Lord in your life today?",
		"What is something you are greateful for?"
	};
	
	string _file = "";
	public List<Entry> _entries = new List<Entry>();
	public void menu()
	{
		while(true)
		{
			Console.Clear();
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
		if(_file == "")
		{
			foreach(Entry entry in _entries)
			{
				entry.Display();
			}
		}
	}
	
	private void Save()
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
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error saving journal: {ex.Message}");
		}
	}
	
	private void Load()
	{
		Console.WriteLine("Enter a file to load: ");
		_file = Console.ReadLine();
		
		try
		{
			_entries.Clear();

			using (StreamReader reader = new StreamReader(_file))
			{
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
			}

			Console.WriteLine("Journal loaded successfully.");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error loading journal: {ex.Message}");
		}
		
	}
	
}

public class Entry
{
	public DateTime _date; 
	public string _entry;
	public string _prompt;
	public void writeEntry(List<string> _prompts)
	{
		
		_date = DateTime.Now;
		Random random = new Random(); 
	
		Console.Clear();
		_prompt = _prompts[random.Next(_prompts.Count)];
		
		Console.WriteLine("Prompt: " + _prompt);
		Console.Write("Entry: ");
		_entry = (Console.ReadLine()); 
	}
	
	public void Display()
	{
		Console.WriteLine(_date + ":\n" + _prompt + "\n" + _entry);
	}
	
}
class Program
{
	static void Main(string[] args)
	{
		Journal _journal = new Journal();
		_journal.menu();
		
	}
}