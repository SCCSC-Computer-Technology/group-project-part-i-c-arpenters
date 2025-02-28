using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_Draft
{
    public partial class Data : Form
    {

        public Data()
        {
            InitializeComponent();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsDataSet.Wrestling' table. You can move, or remove it, as needed.
            this.wrestlingTableAdapter.Fill(this.sportsDataSet.Wrestling);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
