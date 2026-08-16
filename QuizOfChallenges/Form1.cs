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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //يقفل كل البرنامج
            Application.Exit();
          //  this.Close();
        }

        private void بياناتالطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SaveStudentName())
            {
                Form2 frm2 = new Form2();

                frm2.Show();
            }

            
          
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            else if (Application.OpenForms.Count > 1)
            {
                Application.OpenForms[Application.OpenForms.Count - 1].Close();
            }

           

        }

        private void اغلاقالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // هنا نبدا من اخر فورم تم فتحها وهي تبدا من الصفر لذا فعلنا -1
            
            for(int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                //هنا عرفنا متغير من نوع  فورم وخنا فيه اخر فورم مفتوحة
                Form openForm = Application.OpenForms[i];

                // فعلنا الشرط اذا لم تكن الرئيسية اقفلها
                if (openForm != this)
                {
                    openForm.Close();
                }


            }
        }
        private bool SaveStudentName()
        {
            if(string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("يرجى كتابة اسم الطالب اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            StudentData.studentName = txtStudentName.Text.Trim();

            return true;

        }

        private void صورةالطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveStudentName())
            {
                Form3 frm3 = new Form3();

                frm3.Show();
            }

        }

        private void عرضالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveStudentName())
            {
                Form4 frm4 = new Form4();

                frm4.Show();
            }
        }

        private void تعديلالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveStudentName())
            {
                Form5 frm5 = new Form5();

                frm5.Show();
            }
        }
    }
}
  