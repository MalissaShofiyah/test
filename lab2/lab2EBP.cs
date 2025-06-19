using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Red_CheckedChanged(object sender, EventArgs e)
        {
            if (BRed.Checked)
            {
                lblColor.BackColor = Color.Red;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

            
        }

        private void BGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (BGreen.Checked)
            {
                lblColor.BackColor = Color.Green;
            }
        }

        private void BBlue_CheckedChanged(object sender, EventArgs e)
        {

            if (BBlue.Checked)
            {
                lblColor.BackColor = Color.Blue;
            }
        }

        private void btnVanish_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbAnimal.SelectedIndex.ToString())
            {
                case "Cat":
                    picBox.Image = Image.FromFile("Cat.jpg");
                    break;
                case "Dog":
                    picBox.Image = Image.FromFile("Dog.jpg");
                    break;
                case "Bird":
                    picBox.Image = Image.FromFile("Bird.jpg");
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Visible = true;
                label1.Text = "C Sharp";
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            DateTime lblTimeStart = TimeStart.Value;
            DateTime lblTimeEnd = TimeEnd.Value;
            TimeSpan t = lblTimeEnd - lblTimeStart;

            txtTime.Text = t.ToString();
        }

        private void btnDays_Click(object sender, EventArgs e)
        {
            DateTime lblDateStart = DateStart.Value;
            DateTime lblDateEnd = DateEnd.Value;
            int d = (lblDateEnd - lblDateStart).Days;

            txtDays.Text = d.ToString();
        }
    }
}
