using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizOfChallenges
{
    public partial class Form4 : Form
    {
        Form2 frm2 = new Form2();

        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            if(this.Width < 500)
            {
                this.Width = 600;
                button1.Text = ">>";

            }
            else
            {
                this.Width = 350;
                button1.Text = ">>";
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            this.Width = 370;

            pictureBox1.Image = StudentData.StudentImage;
            label5.Text =  StudentData.studentName;
            label1.Text = "الكلية: " + StudentData.College;
            label2.Text = "القسم:" + StudentData.department;
            label3.Text =  "المستوى:" + StudentData.Level;
            label4.Text =  StudentData.Term;
            
        }
    }
}
