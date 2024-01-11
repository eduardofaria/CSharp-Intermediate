namespace CSharp_Intermediate;

public class HttpCookie
{
    private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();

    public DateTime Expiry { get; set; }

    public HttpCookie()
    {
        
    }


    //Without Dictionary
    public void SetItem(string key, string value){}
    public void GetItem(string key) {}


    //With Dictionary
    public string this[string key]
    {
        get => _dictionary[key];

        set => _dictionary[key] = value;
    }

}