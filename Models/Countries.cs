namespace Прототип_API.Models
{
    public class Countries
    {
        public List<Response_> response { get; set; }
    }
    public class Response_
    {
        public string name { get; set; }
        public string flag { get; set; }
    }

}
