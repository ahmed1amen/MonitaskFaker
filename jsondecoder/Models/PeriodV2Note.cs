using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    public class PeriodV2Note
    {

        public PeriodV2Note(NoteClientModel note)
        {
         //   this.InternalId = note.InternalId;
        }

    
        public Guid InternalId { get; set; }
    }
}
