using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeCollege.Models
{
    public partial class Leaving
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Computed)] 
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? LessonId { get; set; }
        public DateTime? LeavingDate { get; set; }
        public int? LessonNum { get; set; }

        public virtual Lesson? Lesson { get; set; }
        public virtual Student? Student { get; set; }
    }
}