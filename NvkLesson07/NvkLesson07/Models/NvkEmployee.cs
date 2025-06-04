namespace NvkLesson07.Models
{
    public class NvkEmployee
    {
            public int NvkId { get; set; }
            public string NvkName { get; set; }
            public DateTime NvkBirthday { get; set; }
            public string NvkEmail { get; set; }
            public string NvkPhone { get; set; }
            public decimal NvkSalary { get; set; }
            public bool NvkStatus { get; set; } // true = active, false = inactive
        
    }
}
