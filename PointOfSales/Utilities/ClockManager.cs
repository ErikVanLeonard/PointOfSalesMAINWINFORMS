using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSales.Utilities
{
    public class ClockManager
    {
        private Timer timer;
        private ToolStripLabel labelReloj;

        public ClockManager(ToolStripLabel relojLabel)
        {
            labelReloj = relojLabel;

            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += UpdateClock;
            timer.Start();
        }

        private void UpdateClock(object sender, EventArgs e)
        {
            labelReloj.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

    }
}
