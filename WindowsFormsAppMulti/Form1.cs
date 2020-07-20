using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMulti
{
    public partial class Form1 : Form
    {
        private int randomNumber = 0;
        private int countCommand = 0;
        Stack<int> backup;
        public Form1()
        {
            InitializeComponent();
            btnDouble.Enabled = false;
            btnPlus.Enabled = false;
            btnClear.Enabled = false;
            btnBackup.Enabled = false;
            backup = new Stack<int>();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            backup.Push(1);
            countCommand++;
            lblCountCommand.Text = "Количество команд:" + countCommand.ToString();
            EndSolve();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            backup.Push(2);
            countCommand++;
            lblCountCommand.Text = "Количество команд:" + countCommand.ToString();
            EndSolve();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            countCommand = 0;
            lblCountCommand.Text = "Количество команд:" + countCommand.ToString();
            backup.Clear();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnDouble.Enabled = true;
            btnPlus.Enabled = true;
            btnClear.Enabled = true;
            btnBackup.Enabled = true;
            Random random = new Random();
            randomNumber = random.Next(1, 100);
            lblRandom.Text = "Заданное число: " + randomNumber.ToString();
            lblNumber.Text = "0";
            countCommand = 0;
            lblCountCommand.Text = "Количество команд:" + countCommand.ToString();
            backup.Clear();
        }

        private void EndSolve()
        {
            bool end = randomNumber == int.Parse(lblNumber.Text) ? true : false;
            if (end)
            {
                MessageBox.Show("Поздравляю, Вы молодцы! Нажмите кнопку 'Играть'");
                btnDouble.Enabled = false;
                btnPlus.Enabled = false;
                btnClear.Enabled = false;
                btnBackup.Enabled = false;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (backup.Count != 0)
            {
                int point = backup.Pop();
                if (point == 1)
                {
                    lblNumber.Text = (int.Parse(lblNumber.Text) - 1).ToString();
                    countCommand--;
                    lblCountCommand.Text = "Количество команд:" + countCommand.ToString();
                }
                else if (point == 2)
                {
                    lblNumber.Text = (int.Parse(lblNumber.Text) / 2).ToString();
                    countCommand--;
                    lblCountCommand.Text = "Количество команд:" + countCommand.ToString();
                }
            }
        }
    }
}
