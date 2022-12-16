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
    public class DeleteLeavingVM : BaseVM
    {
        List<Leaving> studentSource;
        public List<Leaving> LeavingSource
        {
            get => studentSource;
            set
            {
                studentSource = value;
                SignalChanged();
            }
        }

        public Leaving SelectedLeaving { get; set; }

        public ViewCommand SaveButton { get; set; }

        private DateTime standartTime;

        void LeavingList()
        {
            //if ((SelectedLastName != null) && (SelectedGroupNum != null) && (DateStartPeriod != standartTime) && (DateEndPeriod != standartTime))
            //{
            //    var studentsFromDB = user12Context.GetInstance().Students.Include(s => s.Leavings).ToList();
            //    List<Student> students = new List<Student>();

            //    var lessonTeachers = user12Context.GetInstance().LessonTeachers.Include(lt => lt.Lesson).Include(lt => lt.Teacher).ToList();

            //    foreach (Student student in studentsFromDB)
            //    {
            //        var lessonTeacher = lessonTeachers.Where(lt => lt.Teacher == SelectedLastName);

            //        var isStudentFitsRequest = student.GroupId == SelectedGroupNum.GroupId;

            //        isStudentFitsRequest = student.Leavings.Any(l =>
            //                                                    lessonTeacher.Any(lt =>
            //                                                                      lt.LessonId == l.LessonId));

            //        if (isStudentFitsRequest)
            //        {
            //            student.Leavings = student.Leavings.Where(l => lessonTeacher.Any(lt =>
            //                                                                             lt.LessonId == l.LessonId)).ToList();



            //            students.Add(student);
            //        }
            //    }

            //    StudentsSource = students;
            //}
        }

        public DeleteLeavingVM(Teacher selectedLastName, Group selectedGroupNum, DateTime dateStartPeriod, DateTime dateEndPeriod, Student selectedStudent)
        {
            LeavingSource = user12Context.GetInstance().Leavings.ToList();
        }
    }
}
