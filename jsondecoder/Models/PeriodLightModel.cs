using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    // Token: 0x0200027B RID: 635
    public class PeriodLightModel
    {
        // Token: 0x17000403 RID: 1027
        // (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0000A77E File Offset: 0x0000897E
        // (set) Token: 0x06000EE3 RID: 3811 RVA: 0x0000A786 File Offset: 0x00008986
        public Guid Id { get; set; }

        // Token: 0x17000404 RID: 1028
        // (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0000A78F File Offset: 0x0000898F
        // (set) Token: 0x06000EE5 RID: 3813 RVA: 0x0000A797 File Offset: 0x00008997
        public Guid ProjectId { get; set; }

        // Token: 0x17000405 RID: 1029
        // (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0000A7A0 File Offset: 0x000089A0
        // (set) Token: 0x06000EE7 RID: 3815 RVA: 0x0000A7A8 File Offset: 0x000089A8
        public double Duration { get; set; }

        // Token: 0x17000406 RID: 1030
        // (get) Token: 0x06000EE8 RID: 3816 RVA: 0x0000A7B1 File Offset: 0x000089B1
        // (set) Token: 0x06000EE9 RID: 3817 RVA: 0x0000A7B9 File Offset: 0x000089B9
        public string NoteId { get; set; }
    }
}
