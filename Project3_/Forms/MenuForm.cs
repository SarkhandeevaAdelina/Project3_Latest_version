using Project3_.Models;
using Project3_.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_.Forms
{
    public partial class MenuForm : Form
    {
        private User user;
        private List<Ration> rations = new List<Ration>();

        public MenuForm(User user)
        {
            InitializeComponent();
            this.user = user;      
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(user.Gender))
            {
                tableLayoutPanelMenu.RowStyles[0] = new RowStyle(SizeType.Absolute, 0);
                tableLayoutPanelMenu.RowStyles[1] = new RowStyle(SizeType.Percent, 100);
                List<Ration> rations = Ration.GetUserRations(user);
                for (int i = rations.Count - 1; i >= 0; i--)
                {
                    panelMenu.Controls.Add(new DayMenuUserControl(rations[i]) { Dock = DockStyle.Top });
                }
                
            }
        }

        private void MenuForm_Shown(object sender, EventArgs e)
        {
            panelMenu.AutoScrollPosition = new Point(0, 0);
        }
    }
}
