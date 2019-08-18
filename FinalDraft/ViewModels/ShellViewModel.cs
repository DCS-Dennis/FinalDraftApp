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
            Projects.Add(new ProjectModel { ProjectId_Num = "SD12344", CivicAddress = "123 Fake Street", DueDate="Aug 15 2019", Status="InProcess", Notes="New mweting Notes" });
            Projects.Add(new ProjectModel { ProjectId_Num = "SD122244", CivicAddress = "123 10Th Street", DueDate = "Aug 15 2019", Status = "Wait", Notes = "" });
            Projects.Add(new ProjectModel { ProjectId_Num = "SD111344", CivicAddress = "123 Second Street", DueDate = "Aug 20 2019", Status = "InProcess", Notes = "May meeting notes 123" });
            Projects.Add(new ProjectModel { ProjectId_Num = "CD16344", CivicAddress = "1213 8Th Street", DueDate = "Dec 5 2019", Status = "Wait", Notes = "April meeting notes" });
            Projects.Add(new ProjectModel { ProjectId_Num = "SS123334", CivicAddress = "1234 2nd Street", DueDate = "Nov 17 2019", Status = "InProcess", Notes = "Another meeting Notees" });
            Projects.Add(new ProjectModel { ProjectId_Num = "AD12344", CivicAddress = "1235 9Th Street", DueDate = "Sept 15 2019", Status = "Wait", Notes = "Another meeting Notes" });

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
