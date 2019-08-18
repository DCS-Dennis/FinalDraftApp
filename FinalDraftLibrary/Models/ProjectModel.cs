using System;
using System.Collections.Generic;
using System.Text;

namespace FinalDraft.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string ProjectId_Num { get; set; }
        public string CivicAddress { get; set; }

        public string Lot { get; set; }
        public string Blk { get; set; }
        public string Plan { get; set; }
        public bool ShowPrelim { get; set; }
        public bool ShowChecklist { get; set; }
        public int CustomerId { get; set; }
        public int InvoicingId { get; set; }
        public int MeetingCommunicationsId { get; set; }
        public int DocumentsId { get; set; }
        public int ArchitecturalRequirmentsId { get; set; }

        public string DueDate { get; set; }

        public string Status { get; set; }

        public string Notes { get; set; }


    }
}
