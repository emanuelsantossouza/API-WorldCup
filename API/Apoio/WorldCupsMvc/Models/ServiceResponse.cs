namespace WorldCupsMvc.Models
{
    public class ServiceResponse
    {
        public Object Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}