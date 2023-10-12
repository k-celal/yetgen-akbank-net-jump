namespace MVCClient.Models
{
    public class HomeIndexVievModel
    {
        public string Prompt { get; set; }
        public int ImageCount { get; set; }

        public List<string> ImageUrls { get; set; }

        public string ChatGPTResponse { get; set; }

        public HomeIndexVievModel() { 
            ImageUrls= new List<string>();
        }
    }
}
