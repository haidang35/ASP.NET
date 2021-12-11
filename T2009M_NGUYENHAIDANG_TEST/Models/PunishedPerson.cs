using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace T2009M_NGUYENHAIDANG_TEST.Models
{
    public class PunishedPerson
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Student Code cannot be empty")]
        [Display(Name = "Mã sinh viên")]
        public string StudentCode { get; set; }
        [Required(ErrorMessage = "Formality cannot be empty")]
        [Display(Name = "Hình thức phạt")]
        public string Formality { get; set; }
        [Display(Name = "Số tiền nộp phạt")]
        public float AmountMoney { get; set; }
        [Display(Name = "Số cái chống đẩy")]
        public int Pushup { get; set; }
        [Display(Name = "Ngày nộp phạt")]
        [DataType(DataType.DateTime)]
        [ScaffoldColumn(false)]
        public DateTime CreatedAt  { get; set; }
    }
}