namespace PhoneReceiverApi.Models
{
    public class PhoneRecord
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}