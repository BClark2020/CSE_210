public class Resume
{
	public Job job = new Job();
	public string _name = "";
	public List<Job> _jobs = new List<Job>();
	
	public void Display()
	{
		Console.Clear();
		Console.WriteLine($"Name: {_name}");

		foreach(Job job in _jobs)
		{
			job.Display();
		}

	}
	
}