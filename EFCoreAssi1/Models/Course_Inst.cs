using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAssi1.Models
{
    public class CourseInstructor
    {
        #region Convention

        // public int Inst_ID { get; set; }
        // public int Course_ID { get; set; }
        // public int? Evaluate { get; set; }

        #endregion

        #region Data Annotations

        // [Key]
        // public int Inst_ID { get; set; }
        //
        // [Key]
        // public int Course_ID { get; set; }
        //
        // [Range(1, 100)]
        // public int? Evaluate { get; set; }

        #endregion
    }
}