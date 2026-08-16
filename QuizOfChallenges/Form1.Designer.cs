namespace QuizOfChallenges
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.الرئيسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بياناتالطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.صورةالطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالبياناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اغلاقالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلالبياناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الرئيسيةToolStripMenuItem,
            this.ملفToolStripMenuItem,
            this.تعديلالبياناتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الرئيسيةToolStripMenuItem
            // 
            this.الرئيسيةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بياناتالطالبToolStripMenuItem,
            this.صورةالطالبToolStripMenuItem,
            this.عرضالبياناتToolStripMenuItem});
            this.الرئيسيةToolStripMenuItem.Name = "الرئيسيةToolStripMenuItem";
            this.الرئيسيةToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.الرئيسيةToolStripMenuItem.Text = "الرئيسية";
            // 
            // بياناتالطالبToolStripMenuItem
            // 
            this.بياناتالطالبToolStripMenuItem.Name = "بياناتالطالبToolStripMenuItem";
            this.بياناتالطالبToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.بياناتالطالبToolStripMenuItem.Text = "بيانات الطالب";
            this.بياناتالطالبToolStripMenuItem.Click += new System.EventHandler(this.بياناتالطالبToolStripMenuItem_Click);
            // 
            // صورةالطالبToolStripMenuItem
            // 
            this.صورةالطالبToolStripMenuItem.Name = "صورةالطالبToolStripMenuItem";
            this.صورةالطالبToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.صورةالطالبToolStripMenuItem.Text = "صورة الطالب";
            this.صورةالطالبToolStripMenuItem.Click += new System.EventHandler(this.صورةالطالبToolStripMenuItem_Click);
            // 
            // عرضالبياناتToolStripMenuItem
            // 
            this.عرضالبياناتToolStripMenuItem.Name = "عرضالبياناتToolStripMenuItem";
            this.عرضالبياناتToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.عرضالبياناتToolStripMenuItem.Text = "عرض البيانات";
            this.عرضالبياناتToolStripMenuItem.Click += new System.EventHandler(this.عرضالبياناتToolStripMenuItem_Click);
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اغلاقToolStripMenuItem,
            this.اغلاقالكلToolStripMenuItem});
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // اغلاقToolStripMenuItem
            // 
            this.اغلاقToolStripMenuItem.Name = "اغلاقToolStripMenuItem";
            this.اغلاقToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.اغلاقToolStripMenuItem.Text = "اغلاق";
            this.اغلاقToolStripMenuItem.Click += new System.EventHandler(this.اغلاقToolStripMenuItem_Click);
            // 
            // اغلاقالكلToolStripMenuItem
            // 
            this.اغلاقالكلToolStripMenuItem.Name = "اغلاقالكلToolStripMenuItem";
            this.اغلاقالكلToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.اغلاقالكلToolStripMenuItem.Text = "اغلاق الكل";
            this.اغلاقالكلToolStripMenuItem.Click += new System.EventHandler(this.اغلاقالكلToolStripMenuItem_Click);
            // 
            // تعديلالبياناتToolStripMenuItem
            // 
            this.تعديلالبياناتToolStripMenuItem.Name = "تعديلالبياناتToolStripMenuItem";
            this.تعديلالبياناتToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.تعديلالبياناتToolStripMenuItem.Text = "تعديل البيانات";
            this.تعديلالبياناتToolStripMenuItem.Click += new System.EventHandler(this.تعديلالبياناتToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(158, 131);
            this.txtStudentName.Multiline = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(398, 33);
            this.txtStudentName.TabIndex = 3;
            this.txtStudentName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(611, 136);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(138, 25);
            this.lblStudentName.TabIndex = 4;
            this.lblStudentName.Text = ":اسم الطالب";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(89, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 51);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(857, 503);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الرئيسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بياناتالطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem صورةالطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالبياناتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اغلاقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اغلاقالكلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلالبياناتToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnExit;
    }
}

