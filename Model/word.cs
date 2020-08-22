using FlashCard.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Model
{
    public class Word
    {
        Status status = Enum.Status.willRecall;
        public string tagName { get; set; }
        public string mean { get; set; }
        public DateTime startTime { get; set; }
        public string ATTT { get; set; }
        public string IPA { get; set; }
        public string pathOfSpeech { get; set; }

        public string Example { get; set; }
        public Status Status { get { return status; } set { status = value; } }
    }
}