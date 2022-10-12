namespace ConsoleConfigApp;

public class Comment
{
    public int Id { get; set; }

    public string Expression { get; set; }

    public Article Article { get; set; }
}