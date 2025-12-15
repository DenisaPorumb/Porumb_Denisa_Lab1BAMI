namespace Porumb_Denisa_Lab1.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Student
    {
        public string Name { get; set; } 
        public int Age { get; set; }
    }
}
