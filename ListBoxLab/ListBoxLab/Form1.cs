using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxLab
{
    public partial class frmCars : Form
    {
        bool fl = true;

        public frmCars()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        public List<Car> list = new List<Car>();
        public Car obj = new Car();
        int i = 0;

        private void butAdd_Click(object sender, EventArgs e)
        {
            Car obj = new Car(tbMarka.Text, tbModel.Text, Convert.ToInt16(tbNumber.Text), tbSNB.Text, Convert.ToString(tbColor.Text));
            list.Add(obj);

            listBoxCars.Items.Clear();
            for (int i = 0; i <= list.Count; i++)
            {
                listBoxCars.Items.Insert(i, list[i].number);
                //listBoxCars.Items.Insert(i, tbNumber.Text);
                //listBoxCars.Items.Insert(i, Convert.ToString(list[i].number));
                //i--;
            }

            tbMarka.Text = "";
            tbModel.Text = "";
            tbNumber.Text = "";
            tbSNB.Text = "";
            tbColor.Text = "";
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //listBoxCars
            CheckIndex();
        }

        public void CheckIndex()
        {
            //if (tbNumber.Text == "")
            //{
            //    fl = false;
            //    MessageBox.Show("Введите коректные данные!");
            //    //DialogWindow f = new DialogWindow();
            //    //f.Show();
            //}
            //else if (Convert.ToInt32(richTextBox1.Text) < 0 || Convert.ToInt32(richTextBox1.Text) > listCars.Count())
            //{
            //    fl = false;
            //    DialogWindow f = new DialogWindow(textLabel);
            //    f.Show();
            //}
            //if (fl)
            //{
            //    index = Convert.ToInt32(richTextBox1.Text);
            //    groupBox1.Visible = true;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
    }
}
