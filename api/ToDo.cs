namespace az_todo;

public class ToDo
{
    public DateOnly CreatedDate { get; set; }

    public DateOnly? CompletedDate { get; set; }

    public bool Done { get; set; } = false;

    public string Name { get; set; }
}
