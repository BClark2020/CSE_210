public class Job
{
	public string _jobTitle ="";
	public string _company = "";
	public int _startYear = 0;
	public int _endYear = 0;
	
	public void Display()
	{
		Console.WriteLine($"Title: {_jobTitle},\nCompany: {_company},\nStart year: {_startYear},\nEnd year: {_endYear}");
	}
}