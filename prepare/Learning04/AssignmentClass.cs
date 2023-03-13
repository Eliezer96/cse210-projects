


public class AssignmentClass
{


    protected string _studnetName;

    private string _topic;

    public AssignmentClass(string name, string topic)
    {
        _studnetName = name;
        _topic = topic;

    }


    public string GetSummary()
    {
        return $"{_studnetName} - {_topic}";
    }
}