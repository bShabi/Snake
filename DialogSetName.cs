using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class DialogSetName : Form
    {
        //public string Name { get; private set; }

        public DialogSetName()
        {
            InitializeComponent();
            btnClick.Click += BtnClick_Click;
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtNameValue.Text))
            {
                MessageBox.Show("Empty Text Box!");
                return;
            }
            Name = txtNameValue.Text;
            this.Close();

        }
    }
}
