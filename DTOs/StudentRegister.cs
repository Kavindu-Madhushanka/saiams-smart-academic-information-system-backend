namespace backend.DTOs
{
    public class StudentRegister
    {
        public string studentName {  get; set; }=string.Empty;
        public string registationNumber { get; set; } = string.Empty;
        public string faculty { get; set; } = string.Empty;
        public string department {  get; set; } = string.Empty;
        public string academicYear {  get; set; } = string.Empty;
        public string email {  get; set; } = string.Empty;
        public string password {  get; set; } = string.Empty;
        public string role {  get; set; } = string.Empty;
    }
}
