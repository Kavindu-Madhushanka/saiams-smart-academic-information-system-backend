using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Lectures
    {
        [Key]
        public int id { get; set; }
        public int user_id {  get; set; }
        public string full_name {  get; set; }=string.Empty;
        public string staff_id {  get; set; }= string.Empty;
        public string email {  get; set; }=string.Empty;
        public string phone_number {  get; set; }=string.Empty;
        public string faculty {  get; set; }=string.Empty;
        public string department {  get; set; }=string.Empty;
        public string academic_role {  get; set; }=string.Empty;
    }
}
