namespace NvkLesson03.Models
{
    public class NvkAccount
    {
        public int NvkId { get; set; }
        public string NvkName { get; set; }

        public string NvkEmail { get; set; }
        public string NvkPhone { get; set; }
        public string NvkAvatar { get; set; } 
        public string NvkAddress { get; set; }

        public string NvkBio { get; set; }
        public int NvkGender { get; set; }

        public DateTime NvkBirthday { get; set; } 

    }
}
