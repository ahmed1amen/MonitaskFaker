using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    public class Activity
    {
        // Token: 0x1700044A RID: 1098
        // (get) Token: 0x06000F79 RID: 3961 RVA: 0x0000AC54 File Offset: 0x00008E54
        // (set) Token: 0x06000F7A RID: 3962 RVA: 0x0000AC5C File Offset: 0x00008E5C
        public string Data { get; set; }

        // Token: 0x1700044B RID: 1099
        // (get) Token: 0x06000F7B RID: 3963 RVA: 0x0000AC65 File Offset: 0x00008E65
        // (set) Token: 0x06000F7C RID: 3964 RVA: 0x0000AC6D File Offset: 0x00008E6D
        public DateTime Date { get; set; }

        // Token: 0x1700044C RID: 1100
        // (get) Token: 0x06000F7D RID: 3965 RVA: 0x0000AC76 File Offset: 0x00008E76
        // (set) Token: 0x06000F7E RID: 3966 RVA: 0x0000AC7E File Offset: 0x00008E7E
        public string Type { get; set; }
    }
}
