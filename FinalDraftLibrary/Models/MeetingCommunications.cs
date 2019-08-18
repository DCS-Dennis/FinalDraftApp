using System;
using System.Collections.Generic;
using System.Text;

namespace FinalDraftLibrary.Models
{
    class MeetingCommunications
    {
        public int Id { get; set; }
        public int MeetingType { get; set; }
        public DateTime MeetingDate { get; set; }
        public string Initials { get; set; }
        public string Recieved { get; set; }
        public string Notes { get; set; }
    }
}
