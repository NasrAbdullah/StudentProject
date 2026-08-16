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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
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
            if (rdoterm1.Checked)
            {
                StudentData.Term = "الترم الاول";
            }
            else if (rdoterm2.Checked)
            {
                StudentData.Term = "الترم الثاني";
            }

            MessageBox.Show("تم تعديل البيانات بنجاح", "بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtCollege.Text = StudentData.College;
            txtdepart.Text = StudentData.department;


            if(StudentData.Level == "الاول")
            {
                rdoLevel1.Checked = true;
            }
            else if (StudentData.Level == "الثاني")
            {
              
                rdoLeve2.Checked = true;
            }
            else if (StudentData.Level == "الثالث")
            {
                rdoLeve3.Checked = true;
            }
            else if (StudentData.Level == "الرابع")
            {
                rdoLeve4.Checked = true;
            }

            

            if(StudentData.Term == "الترم الاول")
            {
                rdoterm1.Checked = true;
            }
            else if (StudentData.Term == "الترم الثاني")
            {
                rdoterm2.Checked = true;
            }

            PicStudentImage.Image = StudentData.StudentImage;
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            // هنا نحدد له ماذا يمكننا ان نعرض 
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";


            // هذا الشرط يتحقق عندما ندخل للملفات هل اختارنا صورة ام ضغطنا الغاء
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PicStudentImage.Image = Image.FromFile(openFileDialog1.FileName);


                StudentData.StudentImage = PicStudentImage.Image;

                MessageBox.Show("تم حفظ الصورة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // this.Close();
            }
        }
    }
}
