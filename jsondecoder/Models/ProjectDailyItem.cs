using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    public class ProjectDailyItem
    {
        // Token: 0x170002FD RID: 765
        // (get) Token: 0x06000844 RID: 2116 RVA: 0x000076B8 File Offset: 0x000058B8
        // (set) Token: 0x06000845 RID: 2117 RVA: 0x000076C0 File Offset: 0x000058C0
        public double Duration { get; set; }

        // Token: 0x170002FE RID: 766
        // (get) Token: 0x06000846 RID: 2118 RVA: 0x000076C9 File Offset: 0x000058C9
        // (set) Token: 0x06000847 RID: 2119 RVA: 0x000076D1 File Offset: 0x000058D1
        public double DurationWeekly { get; set; }

        // Token: 0x170002FF RID: 767
        // (get) Token: 0x06000848 RID: 2120 RVA: 0x000076DA File Offset: 0x000058DA
        // (set) Token: 0x06000849 RID: 2121 RVA: 0x000076E2 File Offset: 0x000058E2
        public Guid Id { get; set; }

        // Token: 0x17000300 RID: 768
        // (get) Token: 0x0600084A RID: 2122 RVA: 0x000076EB File Offset: 0x000058EB
        // (set) Token: 0x0600084B RID: 2123 RVA: 0x000076F3 File Offset: 0x000058F3
        public string Name { get; set; }

        // Token: 0x17000301 RID: 769
        // (get) Token: 0x0600084C RID: 2124 RVA: 0x000076FC File Offset: 0x000058FC
        // (set) Token: 0x0600084D RID: 2125 RVA: 0x00007704 File Offset: 0x00005904
        public string Desc { get; set; }

        // Token: 0x17000302 RID: 770
        // (get) Token: 0x0600084E RID: 2126 RVA: 0x0000770D File Offset: 0x0000590D
        // (set) Token: 0x0600084F RID: 2127 RVA: 0x00007715 File Offset: 0x00005915
        public string Status { get; set; }

        // Token: 0x17000303 RID: 771
        // (get) Token: 0x06000850 RID: 2128 RVA: 0x0000771E File Offset: 0x0000591E
        // (set) Token: 0x06000851 RID: 2129 RVA: 0x00007726 File Offset: 0x00005926
        public bool Billable { get; set; }

        // Token: 0x17000304 RID: 772
        // (get) Token: 0x06000852 RID: 2130 RVA: 0x0000772F File Offset: 0x0000592F
        // (set) Token: 0x06000853 RID: 2131 RVA: 0x00007737 File Offset: 0x00005937
        public List<NoteClientModel> Notes { get; set; }

        // Token: 0x06000854 RID: 2132 RVA: 0x0001EB04 File Offset: 0x0001CD04
        public override string ToString()
        {
            return string.Format("{0}: {1}, {2}: {3}, {4}: {5}, {6}: {7}, {8}: {9}, {10}: {11}", new object[]
            {
                "Duration",
                this.Duration,
                "Id",
                this.Id,
                "Name",
                this.Name,
                "Desc",
                this.Desc,
                "Status",
                this.Status,
                "Notes",
                this.Notes
            });
        }
    }
}
