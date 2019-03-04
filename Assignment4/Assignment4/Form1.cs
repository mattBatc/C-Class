using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {

        string[] answers = {
                "It is certain", "It is decidedly so","Without a doubt",
                "Yes, definitely","You may rely on it","As I see it, yes"
                ,"Most likely","Outlook good","Yes", "Signs point to yes"
                ,"Reply hazy try again ","Ask again later","Better not tell you now"
                ,"Cannot predict now", "Concentrate and ask again","Don't count on it"
                ,"My reply is no","My sources say no","Outlook not so good","Very doubtful"};
        public Form1()
        {
            InitializeComponent();
            


        }

        private void BtnGetAnswer_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rand = r.Next(0,20);
            TBAnswer.Text = answers[rand];
        }
    }
}
