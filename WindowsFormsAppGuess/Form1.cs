using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGuess
{
    public partial class Form1 : Form
    {
        Random random;
        int numberGuess = 0;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            textBoxEnter.Enabled = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Погнали! Нажми 'Играть'!";
            numberGuess = random.Next(1, 100);
            textBoxEnter.Enabled = true;
            textBoxEnter.Text = string.Empty;
        }

        private void textBoxEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBoxEnter.Text, out int result))
                {
                    if (result < numberGuess) lblMessage.Text = "Введите число больше!";
                    else if (result > numberGuess) lblMessage.Text = "Введите число меньше!";
                    else
                    {
                        lblMessage.Text = "Поздравляю! Угадали! Нажми 'Играть'!";
                        textBoxEnter.Enabled = false;
                    }
                }
                else lblMessage.Text = "Не число!";
            }
        }
    }
}
