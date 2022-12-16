using PracticeCollege.Models;
using PracticeCollege.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCollege.ViewModels
{
    public class AddTeacherVM : BaseVM
    {
        public string TeacherSurName { get; set; }
        public string TeacherName { get; set; }
        public string TeacherPatronymicName { get; set; }

        public bool IsCurator { get; set; }

        List<Group> groupSource;
        public List<Group> GroupSource
        {
            get => groupSource;
            set
            {
                groupSource = value;
                SignalChanged();
            }
        }

        public Group SelectedGroup { get; set; }

        public ViewCommand SaveCommand { get; set; }

        public AddTeacherVM()
        {
            GroupSource = user12Context.GetInstance().Groups.ToList();

            SaveCommand = new ViewCommand(() =>
            {
                Teacher teacher = new Teacher()
                {
                    SurName = TeacherSurName,
                    Name = TeacherName,
                    PatronomicName = TeacherPatronymicName,
                    Group = SelectedGroup,
                    StatusCurator = IsCurator,
                };

                user12Context.GetInstance().Teachers.Add(teacher);
                user12Context.GetInstance().SaveChanges();
            });
        }
    }
}