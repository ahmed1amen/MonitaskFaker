using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    public class UploadModel
    {

        public List<Period> Periods { get; set; }
        public List<NoteClientModel> Notes { get; set; }
    }
}
