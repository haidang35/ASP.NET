using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace T2009M_NGUYENHAIDANG_TEST.Models
{
    public enum FormalityPunished
    {
        Money = 1,
        Pushup = 2,
    }
    public class PunishedPerson
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Student Code cannot be empty")]
        [Display(Name = "Mã sinh viên")]
        public string StudentCode { get; set; }
        [Required(ErrorMessage = "Formality cannot be empty")]
        [Display(Name = "Hình thức phạt")]
        public FormalityPunished Formality { get; set; }
        [Required(ErrorMessage = "Amount cannot be empty")]
        [Display(Name = "Số tiền nộp phạt / chống đẩy")]
        public float Amount { get; set; }
        [Display(Name = "Ngày nộp phạt")]
        [DataType(DataType.DateTime)]
        [ScaffoldColumn(false)]
        public DateTime CreatedAt  { get; set; }
    }
}