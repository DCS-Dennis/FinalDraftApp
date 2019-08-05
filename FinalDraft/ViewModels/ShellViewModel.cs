using Caliburn.Micro;
using FinalDraft.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalDraft.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private string _projectNumber = "FD12345";
        private DateTime _dateDue = DateTime.Now;
        private BindableCollection<ProjectModel> _projects = new BindableCollection<ProjectModel>();

        public ShellViewModel()
        {
            Projects.Add(new ProjectModel { ProjectNumber = "SD12344", Address = "123 Fake Street", DueDate="Aug 15 2019", Status="InProcess", Notes="New mweting Notes" });
            Projects.Add(new ProjectModel { ProjectNumber = "SD122244", Address = "123 10Th Street", DueDate = "Aug 15 2019", Status = "Wait", Notes = "" });
            Projects.Add(new ProjectModel { ProjectNumber = "SD111344", Address = "123 Second Street", DueDate = "Aug 20 2019", Status = "InProcess", Notes = "May meeting notes 123" });
            Projects.Add(new ProjectModel { ProjectNumber = "CD16344", Address = "1213 8Th Street", DueDate = "Dec 5 2019", Status = "Wait", Notes = "April meeting notes" });
            Projects.Add(new ProjectModel { ProjectNumber = "SS123334", Address = "1234 2nd Street", DueDate = "Nov 17 2019", Status = "InProcess", Notes = "Another meeting Notees" });
            Projects.Add(new ProjectModel { ProjectNumber = "AD12344", Address = "1235 9Th Street", DueDate = "Sept 15 2019", Status = "Wait", Notes = "Another meeting Notes" });

        }

        public string ProjectNumber
        {
            get
            {
                return _projectNumber;
            }
            set
            {
                _projectNumber = value;
                NotifyOfPropertyChange(() => ProjectNumber);
            }
        }

        public DateTime DateDue
        {
            get { return _dateDue = DateTime.Now; }
            set { _dateDue = value;
                NotifyOfPropertyChange(() => DateDue);
            }
        }


        public BindableCollection<ProjectModel> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }

        private ProjectModel _selectedProject;

        public ProjectModel SelectedProject
        {
            get
            {
                return _selectedProject;
            }
            set
            {
                _selectedProject = value;
                NotifyOfPropertyChange(() => SelectedProject);
            }
        }

        public bool CanClearText(string projectNumber)
        {
            return !String.IsNullOrEmpty(projectNumber);
        }
        public void ClearText(string projectNumber)
        {
            ProjectNumber = "";
            
        }

        public void LoadNewProject()
        {
            ActivateItem(new NewProjectViewModel());
        }

        public void LoadNewCustomer()
        {
            ActivateItem(new NewCustomerViewModel());
        }
    }
}
