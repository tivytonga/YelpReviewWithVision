namespace YelpReviewApp.Models
{
    public class VisionModel
    {
        //Google.Cloud.Vision.V1.Likelihood
        public string joyLikelihood { get; set; }
        public string angerLikelihood { get; set; }
        public string sorrowLikelihood { get; set; }
        public string surpriseLikelihood { get; set; }
    }

}
