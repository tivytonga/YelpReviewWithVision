namespace YelpReviewApp.Models
{
    public class UserModel
    {
        public string id { get; set; }
        public string profile_url { get; set; }
        public string image_url { get; set; }
        public string name { get; set; }
        public VisionModel emotion { get; set; }
    }

}
