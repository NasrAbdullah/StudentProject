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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
           
        }
       
        private void Button1_Click(object sender, EventArgs e)
        {
            if(txtCollege.Text == "")
            {
                MessageBox.Show("please enter college? ");
            }
            StudentData.College = txtCollege.Text;
            StudentData.department = txtdepart.Text;

            if (rdoLevel1.Checked)
            {
                StudentData.Level = "الاول";
            }
            else if (rdoLeve2.Checked)
            {
                StudentData.Level = "الثاني";
            }
            else if (rdoLeve3.Checked)
            {
                StudentData.Level = "الثالث";
            }
            else if (rdoLeve4.Checked)
            {
                StudentData.Level = "الرابع";
            }


            // term
            if(rdoterm1.Checked)
            {
                StudentData.Term = "الترم الاول";
            }
            else if (rdoterm2.Checked)
            {
                StudentData.Term = "الترم الثاني";
            }

            MessageBox.Show("تم حفظ البيانات بنجاح", "بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = StudentData.studentName;
        }
  
    }
}
