using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static jsondecoder.Form2;

namespace jsondecoder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint idleTime = IdleTimeFinder.GetIdleTime();
            string message = $"Idle Time: {idleTime} milliseconds";
            MessageBox.Show(message, "Idle Time Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal struct LASTINPUTINFO
        {
            // Token: 0x040004EC RID: 1260
            public uint cbSize;

            // Token: 0x040004ED RID: 1261
            public uint dwTime;
        }


    }







    public class IdleTimeFinder
    {
        // Token: 0x060008FD RID: 2301
        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        // Token: 0x060008FE RID: 2302
        [DllImport("Kernel32.dll")]
        private static extern uint GetLastError();

        // Token: 0x060008FF RID: 2303 RVA: 0x0001F590 File Offset: 0x0001D790
        public static uint GetIdleTime()
        {
            uint result;
            try
            {
                LASTINPUTINFO lastinputinfo = default(LASTINPUTINFO);
                lastinputinfo.cbSize = (uint)Marshal.SizeOf(lastinputinfo);
                bool flag = !IdleTimeFinder.GetLastInputInfo(ref lastinputinfo);
                if (flag && !IdleTimeFinder.LastErrorSended)
                {
                    string messageTemplate = "GetIdleTime failed {error} sequence {sequence}";
                    result = IdleTimeFinder.GetLastError();

                    IdleTimeFinder.LastErrorSended = true;
                }
                int num = Environment.TickCount - (int)lastinputinfo.dwTime;
                if (num < 10000)
                {
                    IdleTimeFinder.IsActiveCount++;
                }
                else
                {
                    IdleTimeFinder.IsActiveCount = 0;
                }
                if (IdleTimeFinder.IsActiveCount == 3000)
                {

                }
                result = (uint)num;
            }
            catch (Exception exception)
            {

                result = 0U;
            }
            return result;
        }

        // Token: 0x06000900 RID: 2304 RVA: 0x0001F654 File Offset: 0x0001D854
        public static long GetLastInputTime()
        {
            LASTINPUTINFO lastinputinfo = default(LASTINPUTINFO);
            lastinputinfo.cbSize = (uint)Marshal.SizeOf(lastinputinfo);
            if (!IdleTimeFinder.GetLastInputInfo(ref lastinputinfo))
            {
                throw new Exception(IdleTimeFinder.GetLastError().ToString());
            }
            return (long)((ulong)lastinputinfo.dwTime);
        }

        // Token: 0x040004EE RID: 1262
        public static int IsActiveCount;

        // Token: 0x040004EF RID: 1263
        public static bool LastErrorSended;
    }
}
