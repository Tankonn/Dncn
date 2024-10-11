namespace Dacn.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public string ReviewerName { get; set; }
        public string ImagePath { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }  // Số sao đánh giá
    }
}
