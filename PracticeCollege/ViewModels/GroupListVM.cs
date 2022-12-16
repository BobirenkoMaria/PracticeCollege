using PracticeCollege.Models;
using PracticeCollege.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCollege.ViewModels
{
    public class GroupListVM : BaseVM
    {
        List<Group> groupSource;
        private Group _selectedGroup;

        public List<Group> GroupSource
        {
            get { return groupSource; }
            set
            {
                groupSource = value;
                SignalChanged();
            }
        }

        public Group SelectedGroup
        {
            get => _selectedGroup;
            set
            {
                _selectedGroup = value;
                SignalChanged();
            }
        }

        public ViewCommand DeleteWrite { get; set; }
        public GroupListVM()
        {
            GroupSource = user12Context.GetInstance().Groups.ToList();

            DeleteWrite = new(() =>
            {
                user12Context.GetInstance().Groups.Remove(SelectedGroup);
                user12Context.GetInstance().SaveChanges();
            });
        }
    }
}
