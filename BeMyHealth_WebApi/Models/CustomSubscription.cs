using System.ComponentModel.DataAnnotations;

namespace BeMyHealth_WebApi.Models
{
    public class CustomSubscription
    {
        [Key]
        public int SubscriptionID { get; set; }
        public string? SubscriptionName { get; set; }
        public string Duration { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }     
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
