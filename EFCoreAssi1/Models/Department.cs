using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAssi1.Models
{
    public class Department
    {
        #region Convention

        // public int ID { get; set; }
        // public string Name { get; set; }
        // public int Ins_ID { get; set; }
        // public DateTime HiringDate { get; set; }

        #endregion

        #region Data Annotations

        // [Key]
        // public int ID { get; set; }
        //
        // [Required]
        // [Column(TypeName = "varchar")]
        // [StringLength(100, MinimumLength = 3)]
        // public string Name { get; set; }
        //
        // [Required]
        // public int Ins_ID { get; set; }
        //
        // [Required]
        // [Column(TypeName = "Date")]
        // [DataType(DataType.Date)]
        // public DateTime HiringDate { get; set; }

        #endregion
    }
}