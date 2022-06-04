namespace BlazorApp.Data;

public class HelloService
{
    private static List<string> _names = new List<string> {
        "wk1",
        "wk2",
        "wk3"
    };

    public string GetName()
    {
        return "wk";
    }

    public void AddName(string name)
    {
        _names.Add(name);
    }

    public List<string> GetNames()
    {
        return _names;
    }
}
