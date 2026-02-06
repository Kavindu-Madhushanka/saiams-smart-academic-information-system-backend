using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Subjects
    {
        [Key]
        public int Id { get; set; }
        public string Subject_Name {  get; set; }=string.Empty;
        public string Subject_Code {  get; set; }=string.Empty;
        public int Credit { get; set; }
        public string Academic_Level {  get; set; }=string.Empty;
        public string Semester {  get; set; }=string.Empty;
        public string Type { get; set; } = string.Empty;


    }
}
