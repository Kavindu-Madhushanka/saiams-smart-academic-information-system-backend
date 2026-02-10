using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class LectureSubject
    {
        [Key]
        public int id { get; set; }
        public int lecture_id { get; set; }
        public int subject_id { get; set; }
        public string subject_type {  get; set; }=string.Empty;

        
    }
}
