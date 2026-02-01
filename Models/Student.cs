namespace backend.Models
{
    public class Student
    {
        public int st_id { get; set; }
        public int st_user_id {  get; set; }
        public string st_registation_no { get; set;}=string.Empty;
        public string st_fullname { get; set; } = string.Empty;
        public string faculty { get; set; } = string.Empty;
        public string department { get; set; } = string.Empty;

        public string academic_year { get; set; } = string.Empty;
        public string st_email { get; set; } = string.Empty;


    }
}
 