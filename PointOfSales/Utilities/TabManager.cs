using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSales.Utilities
{
    public class TabManager
    {
        private TabControl tabControl;

        public TabManager(TabControl tabControl)
        {
            this.tabControl = tabControl;
        }

        public void CambiarPestana(Keys keyCode)
        {
            if (tabControl.TabPages.Count == 0) return;

            switch (keyCode)
            {
                case Keys.F1:
                    tabControl.SelectedIndex = 0;
                    break;
                case Keys.F2:
                    if (tabControl.TabPages.Count > 1)
                        tabControl.SelectedIndex = 1;
                    break;
                case Keys.F3:
                    if (tabControl.TabPages.Count > 2)
                        tabControl.SelectedIndex = 2;
                    break;
                case Keys.F4:
                    if (tabControl.TabPages.Count > 3)
                        tabControl.SelectedIndex = 3;
                    break;
                case Keys.F5:
                    if (tabControl.TabPages.Count > 4)
                        tabControl.SelectedIndex = 4;
                    break;
            }
        }

    }
}
