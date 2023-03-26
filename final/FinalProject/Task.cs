

public class Task
{

    private string _name;
    private string _duedate;
    private string _description;

    private List<string> _allTasks = new List<string>();


    public Task(string name, string duedate, string description)
    {
        _name = name;
        _duedate = duedate;
        _description = description;

    }


    public void SaveTask()
    {
        Console.Write("Enter path => ");
        String fileName = Console.ReadLine();
        

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

            for (int i = 0; i < _allTasks.Count; i++)
            {
                outputFile.WriteLine(_allTasks[i]);
            }
    
        }

    }


    public void LoadTask()
    {

    }


    public void TaskCompletion()
    {

    }



    public void ListTasks()
    {

    }


}