using System;
using System.Collections.Generic;
using System.Text;

namespace FinalDraftLibrary.Models
{
    public class Invoicing
    {
        public int Id { get; set; }
        public string NewPlan { get; set; }
        public string CopyPlan { get; set; }
        public string Other { get; set; }
        public string MainFloor { get; set; }
        public string SecondFloor { get; set; }
        public string Garage { get; set; }
        public string DecksVeranda { get; set; }
        public string BasementDev { get; set; }
        public string LegalSuite { get; set; }
        public string EngineersSeal { get; set; }
        public string Other1 { get; set; }
        public string Notes { get; set; }
    }
}
