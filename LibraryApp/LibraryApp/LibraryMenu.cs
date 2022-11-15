using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class LibraryMenu : Form
    {
        public LibraryMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnReplaceBooks_Click(object sender, EventArgs e)
        {
            //open replacing books form
            Hide();
            Form replacingBooks = new ReplacingBooks();
            replacingBooks.FormClosed += (s, args) => Close();
            replacingBooks.ShowDialog();
        }
        
        private void BtnIdentifyAreas_Click(object sender, EventArgs e)
        {
            //button feature is disabled
            //txtDisabledIA.Text = "This feature is disabled.";
            //txtDisabledIA.Enabled = true;

            //open identifying areas form
            Hide();
            Form identifyingAreas = new IdentifyingAreas();
            identifyingAreas.FormClosed += (s, args) => Close();
            identifyingAreas.ShowDialog();
        }

        private void BtnCallNumbers_Click(object sender, EventArgs e)
        {
            //button feature is disabled
            //txtDisabledFCN.Text = "This feature is disabled.";
            //txtDisabledFCN.Enabled = true;

            //open finding call numbers form
            Hide();
            Form findingCallNumbers = new FindingCallNumbers();
            findingCallNumbers.FormClosed += (s, args) => Close();
            findingCallNumbers.ShowDialog();
        }
   
    }
}
