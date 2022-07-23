using System.ComponentModel.DataAnnotations;

namespace BeMyHealth_WebApi.Dto
{
    public class CustomSubscriptionDto
    {
       
        public string? SubscriptionName { get; set; }
        public string Duration { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }       
    }
}
