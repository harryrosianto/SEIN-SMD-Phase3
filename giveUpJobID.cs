using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleUI_SamsungAGV
{
    public partial class giveUpJobID : Form
    {
        public static string jobIDValue = "";
        public giveUpJobID()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            jobIDValue = jobIDText.Text;
            this.Close();
        }
    }
}
