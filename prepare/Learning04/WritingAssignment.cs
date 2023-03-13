

public class WrittingAssignment : AssignmentClass
{

    private string _title;



    public WrittingAssignment(string name, string topic, string title) : base(name, topic)
    {
            _title = title;
    }



    public string GetWritingInformation()
    {
        return $"{_title} by {_studnetName}";
    }
}