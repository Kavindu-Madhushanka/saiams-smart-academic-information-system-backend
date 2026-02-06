namespace backend.DTOs
{
    public class AddSubjects
    {
        public string subjectCode {  get; set; }=string.Empty;
        public string subjectName { get; set; } = string.Empty;
        public int credit {  get; set; }
        public string academicLevel { get; set; } = string.Empty;
        public string semester {  get; set; } = string.Empty;
        public string type {  get; set; } = string.Empty;
    }
}
