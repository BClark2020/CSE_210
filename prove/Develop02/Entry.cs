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
		Console.WriteLine(_date + ":\n" + _prompt + "\n" + _entry + "\n");
	}
	
}