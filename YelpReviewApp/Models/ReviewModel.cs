namespace YelpReviewApp.Models
{
    public class ReviewModel
    {
        public string id { get; set; }
        public string url { get; set; }
        public string text { get; set; }
        public int rating { get; set; }
        public string time_created { get; set; }
        public UserModel user { get; set; }
    }

}
