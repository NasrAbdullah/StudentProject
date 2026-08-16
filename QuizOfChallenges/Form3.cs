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
    public partial class Form3 : Form
    { 
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // هنا نحدد له ماذا يمكننا ان نعرض 
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";


            // هذا الشرط يتحقق عندما ندخل للملفات هل اختارنا صورة ام ضغطنا الغاء
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PicStudentImage.Image = Image.FromFile(openFileDialog1.FileName);


                StudentData.StudentImage = PicStudentImage.Image;

                MessageBox.Show("تم حفظ الصورة بنجاح", "نجاح" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
