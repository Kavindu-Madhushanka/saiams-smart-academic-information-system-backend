namespace backend.DTOs
{
    public class AddLectureSubject
    {
        public int lecture_id { get; set; }
        public int subject_id { get; set; }
        public string subject_type { get; set; }=string.Empty;

    }
}
