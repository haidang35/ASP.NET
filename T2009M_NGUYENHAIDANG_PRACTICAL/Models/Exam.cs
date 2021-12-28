using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace T2009M_NGUYENHAIDANG_PRACTICAL.Models
{
    public enum ExamStatus { 
        Done = 1,
        UpComing = 2,
        OnGoing = 0,
    }
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Subject Name")]
        public string Subject { get; set; }
        [Required]
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        public string StartTime { get; set; }
        [Required]
        [Display(Name = "Exam Date")]
        [DataType(DataType.Date)]
        public DateTime ExamDate { get; set; }
        [Required]
        [Display(Name = "Duration")]
        public int Duration { get; set; }
        [Required]
        [Display(Name = "Class Room")]
        public string ClassRoom { get; set; }
        [Required]
        [Display(Name = "Faculty")]
        public string Faculty { get; set; }
        [Display(Name = "Exam Status")]
        public ExamStatus Status { get; set; }
    }
}