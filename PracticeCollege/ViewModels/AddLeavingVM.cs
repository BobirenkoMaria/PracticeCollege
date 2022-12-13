using PracticeCollege.Models;
using PracticeCollege.Tools;
using PracticeCollege.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCollege.ViewModels
{
    public class AddLeavingVM
    {
        public List<Student> StudentsSource { get; set; }
        public List<Lesson> LessonsSource { get; set; }
        public int LessonNum { get; set; }
        public DateTime LeavingDate { get; set; } = DateTime.Now;

        public AddLeavingVM()
        {
            StudentsSource = user12Context.GetInstance().Students.ToList();
            LessonsSource = user12Context.GetInstance().Lessons.ToList();
        }
    }
}
