namespace backend.DTOs
{
    public class AddLecture
    {
        public string fullName { get; set; } = string.Empty;
        public string staffId { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string phoneNumber { get; set; } = string.Empty;
        public string faculty { get; set; } = string.Empty;
        public string department { get; set; } = string.Empty;
        public string academicRole { get; set; } = string.Empty;
        public string role { get; set; }= string.Empty;
        public string password {  get; set; } = string.Empty;
    }
}
