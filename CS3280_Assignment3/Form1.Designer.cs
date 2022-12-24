
namespace CS3280_Assignment3
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
            this.count_box = new System.Windows.Forms.GroupBox();
            this.invalid_input2 = new System.Windows.Forms.Label();
            this.invalid_input1 = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.num_assign_text = new System.Windows.Forms.TextBox();
            this.num_student_text = new System.Windows.Forms.TextBox();
            this.num_assign_label = new System.Windows.Forms.Label();
            this.num_student_label = new System.Windows.Forms.Label();
            this.nav_box = new System.Windows.Forms.GroupBox();
            this.prev_student_btn = new System.Windows.Forms.Button();
            this.first_student_btn = new System.Windows.Forms.Button();
            this.last_student_btn = new System.Windows.Forms.Button();
            this.next_student_btn = new System.Windows.Forms.Button();
            this.student_info_box1 = new System.Windows.Forms.GroupBox();
            this.invalid_entry3 = new System.Windows.Forms.Label();
            this.student_num_text = new System.Windows.Forms.TextBox();
            this.student_num_label = new System.Windows.Forms.Label();
            this.save_name_btn = new System.Windows.Forms.Button();
            this.student_info_box2 = new System.Windows.Forms.GroupBox();
            this.invalid_entry5 = new System.Windows.Forms.Label();
            this.invalid_entry4 = new System.Windows.Forms.Label();
            this.assign_num_text = new System.Windows.Forms.TextBox();
            this.assign_score_text = new System.Windows.Forms.TextBox();
            this.save_score_btn = new System.Windows.Forms.Button();
            this.assign_num_label = new System.Windows.Forms.Label();
            this.assign_score_label = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.display_score_btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.count_box.SuspendLayout();
            this.nav_box.SuspendLayout();
            this.student_info_box1.SuspendLayout();
            this.student_info_box2.SuspendLayout();
            this.SuspendLayout();
            // 
            // count_box
            // 
            this.count_box.Controls.Add(this.invalid_input2);
            this.count_box.Controls.Add(this.invalid_input1);
            this.count_box.Controls.Add(this.submit_btn);
            this.count_box.Controls.Add(this.num_assign_text);
            this.count_box.Controls.Add(this.num_student_text);
            this.count_box.Controls.Add(this.num_assign_label);
            this.count_box.Controls.Add(this.num_student_label);
            this.count_box.Location = new System.Drawing.Point(31, 12);
            this.count_box.Name = "count_box";
            this.count_box.Size = new System.Drawing.Size(387, 100);
            this.count_box.TabIndex = 0;
            this.count_box.TabStop = false;
            this.count_box.Text = "Counts";
            // 
            // invalid_input2
            // 
            this.invalid_input2.AutoSize = true;
            this.invalid_input2.Location = new System.Drawing.Point(274, 64);
            this.invalid_input2.Name = "invalid_input2";
            this.invalid_input2.Size = new System.Drawing.Size(0, 13);
            this.invalid_input2.TabIndex = 6;
            // 
            // invalid_input1
            // 
            this.invalid_input1.AutoSize = true;
            this.invalid_input1.Location = new System.Drawing.Point(274, 22);
            this.invalid_input1.Name = "invalid_input1";
            this.invalid_input1.Size = new System.Drawing.Size(0, 13);
            this.invalid_input1.TabIndex = 5;
            // 
            // submit_btn
            // 
            this.submit_btn.Enabled = false;
            this.submit_btn.Location = new System.Drawing.Point(277, 40);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(89, 23);
            this.submit_btn.TabIndex = 4;
            this.submit_btn.Text = "Submit Counts";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // num_assign_text
            // 
            this.num_assign_text.Location = new System.Drawing.Point(150, 57);
            this.num_assign_text.Name = "num_assign_text";
            this.num_assign_text.Size = new System.Drawing.Size(100, 20);
            this.num_assign_text.TabIndex = 3;
            this.num_assign_text.TextChanged += new System.EventHandler(this.num_assign_text_TextChanged);
            // 
            // num_student_text
            // 
            this.num_student_text.Location = new System.Drawing.Point(150, 22);
            this.num_student_text.Name = "num_student_text";
            this.num_student_text.Size = new System.Drawing.Size(100, 20);
            this.num_student_text.TabIndex = 2;
            this.num_student_text.TextChanged += new System.EventHandler(this.num_student_text_TextChanged);
            // 
            // num_assign_label
            // 
            this.num_assign_label.AutoSize = true;
            this.num_assign_label.Location = new System.Drawing.Point(24, 57);
            this.num_assign_label.Name = "num_assign_label";
            this.num_assign_label.Size = new System.Drawing.Size(120, 13);
            this.num_assign_label.TabIndex = 1;
            this.num_assign_label.Text = "Number of assignments:";
            // 
            // num_student_label
            // 
            this.num_student_label.AutoSize = true;
            this.num_student_label.Location = new System.Drawing.Point(24, 25);
            this.num_student_label.Name = "num_student_label";
            this.num_student_label.Size = new System.Drawing.Size(102, 13);
            this.num_student_label.TabIndex = 0;
            this.num_student_label.Text = "Number of students:";
            // 
            // nav_box
            // 
            this.nav_box.Controls.Add(this.prev_student_btn);
            this.nav_box.Controls.Add(this.first_student_btn);
            this.nav_box.Controls.Add(this.last_student_btn);
            this.nav_box.Controls.Add(this.next_student_btn);
            this.nav_box.Location = new System.Drawing.Point(31, 133);
            this.nav_box.Name = "nav_box";
            this.nav_box.Size = new System.Drawing.Size(526, 81);
            this.nav_box.TabIndex = 1;
            this.nav_box.TabStop = false;
            this.nav_box.Text = "Navigate";
            // 
            // prev_student_btn
            // 
            this.prev_student_btn.Enabled = false;
            this.prev_student_btn.Location = new System.Drawing.Point(150, 36);
            this.prev_student_btn.Name = "prev_student_btn";
            this.prev_student_btn.Size = new System.Drawing.Size(88, 23);
            this.prev_student_btn.TabIndex = 7;
            this.prev_student_btn.Text = "<Prev Student";
            this.prev_student_btn.UseVisualStyleBackColor = true;
            this.prev_student_btn.Click += new System.EventHandler(this.prev_student_btn_Click);
            // 
            // first_student_btn
            // 
            this.first_student_btn.Enabled = false;
            this.first_student_btn.Location = new System.Drawing.Point(27, 36);
            this.first_student_btn.Name = "first_student_btn";
            this.first_student_btn.Size = new System.Drawing.Size(92, 23);
            this.first_student_btn.TabIndex = 6;
            this.first_student_btn.Text = "<<First Student";
            this.first_student_btn.UseVisualStyleBackColor = true;
            this.first_student_btn.Click += new System.EventHandler(this.first_student_btn_Click);
            // 
            // last_student_btn
            // 
            this.last_student_btn.Enabled = false;
            this.last_student_btn.Location = new System.Drawing.Point(399, 36);
            this.last_student_btn.Name = "last_student_btn";
            this.last_student_btn.Size = new System.Drawing.Size(95, 23);
            this.last_student_btn.TabIndex = 9;
            this.last_student_btn.Text = ">>Last Student";
            this.last_student_btn.UseVisualStyleBackColor = true;
            this.last_student_btn.Click += new System.EventHandler(this.last_student_btn_Click);
            // 
            // next_student_btn
            // 
            this.next_student_btn.Enabled = false;
            this.next_student_btn.Location = new System.Drawing.Point(277, 36);
            this.next_student_btn.Name = "next_student_btn";
            this.next_student_btn.Size = new System.Drawing.Size(89, 23);
            this.next_student_btn.TabIndex = 8;
            this.next_student_btn.Text = ">Next Student";
            this.next_student_btn.UseVisualStyleBackColor = true;
            this.next_student_btn.Click += new System.EventHandler(this.next_student_btn_Click);
            // 
            // student_info_box1
            // 
            this.student_info_box1.Controls.Add(this.invalid_entry3);
            this.student_info_box1.Controls.Add(this.student_num_text);
            this.student_info_box1.Controls.Add(this.student_num_label);
            this.student_info_box1.Controls.Add(this.save_name_btn);
            this.student_info_box1.Location = new System.Drawing.Point(31, 240);
            this.student_info_box1.Name = "student_info_box1";
            this.student_info_box1.Size = new System.Drawing.Size(526, 78);
            this.student_info_box1.TabIndex = 1;
            this.student_info_box1.TabStop = false;
            this.student_info_box1.Text = "Student Info";
            // 
            // invalid_entry3
            // 
            this.invalid_entry3.AutoSize = true;
            this.invalid_entry3.Location = new System.Drawing.Point(459, 35);
            this.invalid_entry3.Name = "invalid_entry3";
            this.invalid_entry3.Size = new System.Drawing.Size(0, 13);
            this.invalid_entry3.TabIndex = 11;
            this.invalid_entry3.Visible = false;
            // 
            // student_num_text
            // 
            this.student_num_text.Location = new System.Drawing.Point(90, 32);
            this.student_num_text.Name = "student_num_text";
            this.student_num_text.Size = new System.Drawing.Size(201, 20);
            this.student_num_text.TabIndex = 4;
            // 
            // student_num_label
            // 
            this.student_num_label.AutoSize = true;
            this.student_num_label.Location = new System.Drawing.Point(24, 35);
            this.student_num_label.Name = "student_num_label";
            this.student_num_label.Size = new System.Drawing.Size(63, 13);
            this.student_num_label.TabIndex = 2;
            this.student_num_label.Text = "Student #1:";
            // 
            // save_name_btn
            // 
            this.save_name_btn.Location = new System.Drawing.Point(343, 30);
            this.save_name_btn.Name = "save_name_btn";
            this.save_name_btn.Size = new System.Drawing.Size(75, 23);
            this.save_name_btn.TabIndex = 10;
            this.save_name_btn.Text = "Save Name";
            this.save_name_btn.UseVisualStyleBackColor = true;
            this.save_name_btn.Click += new System.EventHandler(this.save_name_btn_Click);
            // 
            // student_info_box2
            // 
            this.student_info_box2.Controls.Add(this.invalid_entry5);
            this.student_info_box2.Controls.Add(this.invalid_entry4);
            this.student_info_box2.Controls.Add(this.assign_num_text);
            this.student_info_box2.Controls.Add(this.assign_score_text);
            this.student_info_box2.Controls.Add(this.save_score_btn);
            this.student_info_box2.Controls.Add(this.assign_num_label);
            this.student_info_box2.Controls.Add(this.assign_score_label);
            this.student_info_box2.Location = new System.Drawing.Point(31, 344);
            this.student_info_box2.Name = "student_info_box2";
            this.student_info_box2.Size = new System.Drawing.Size(526, 100);
            this.student_info_box2.TabIndex = 1;
            this.student_info_box2.TabStop = false;
            this.student_info_box2.Text = "Student Info";
            // 
            // invalid_entry5
            // 
            this.invalid_entry5.AutoSize = true;
            this.invalid_entry5.Location = new System.Drawing.Point(455, 66);
            this.invalid_entry5.Name = "invalid_entry5";
            this.invalid_entry5.Size = new System.Drawing.Size(0, 13);
            this.invalid_entry5.TabIndex = 13;
            this.invalid_entry5.Visible = false;
            // 
            // invalid_entry4
            // 
            this.invalid_entry4.AutoSize = true;
            this.invalid_entry4.Location = new System.Drawing.Point(455, 32);
            this.invalid_entry4.Name = "invalid_entry4";
            this.invalid_entry4.Size = new System.Drawing.Size(0, 13);
            this.invalid_entry4.TabIndex = 12;
            this.invalid_entry4.Visible = false;
            // 
            // assign_num_text
            // 
            this.assign_num_text.Location = new System.Drawing.Point(191, 25);
            this.assign_num_text.Name = "assign_num_text";
            this.assign_num_text.Size = new System.Drawing.Size(100, 20);
            this.assign_num_text.TabIndex = 5;
            this.assign_num_text.TextChanged += new System.EventHandler(this.assign_num_text_TextChanged);
            // 
            // assign_score_text
            // 
            this.assign_score_text.Location = new System.Drawing.Point(191, 63);
            this.assign_score_text.Name = "assign_score_text";
            this.assign_score_text.Size = new System.Drawing.Size(100, 20);
            this.assign_score_text.TabIndex = 6;
            this.assign_score_text.TextChanged += new System.EventHandler(this.assign_score_text_TextChanged);
            // 
            // save_score_btn
            // 
            this.save_score_btn.Enabled = false;
            this.save_score_btn.Location = new System.Drawing.Point(312, 46);
            this.save_score_btn.Name = "save_score_btn";
            this.save_score_btn.Size = new System.Drawing.Size(75, 23);
            this.save_score_btn.TabIndex = 11;
            this.save_score_btn.Text = "Save Score";
            this.save_score_btn.UseVisualStyleBackColor = true;
            this.save_score_btn.Click += new System.EventHandler(this.save_score_btn_Click);
            // 
            // assign_num_label
            // 
            this.assign_num_label.AutoSize = true;
            this.assign_num_label.Location = new System.Drawing.Point(24, 32);
            this.assign_num_label.Name = "assign_num_label";
            this.assign_num_label.Size = new System.Drawing.Size(132, 13);
            this.assign_num_label.TabIndex = 3;
            this.assign_num_label.Text = "Enter Assignment Number:";
            // 
            // assign_score_label
            // 
            this.assign_score_label.AutoSize = true;
            this.assign_score_label.Location = new System.Drawing.Point(24, 66);
            this.assign_score_label.Name = "assign_score_label";
            this.assign_score_label.Size = new System.Drawing.Size(95, 13);
            this.assign_score_label.TabIndex = 4;
            this.assign_score_label.Text = "Assignment Score:";
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(465, 38);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 37);
            this.reset_btn.TabIndex = 5;
            this.reset_btn.Text = "Reset Scores";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // display_score_btn
            // 
            this.display_score_btn.Enabled = false;
            this.display_score_btn.Location = new System.Drawing.Point(221, 465);
            this.display_score_btn.Name = "display_score_btn";
            this.display_score_btn.Size = new System.Drawing.Size(101, 23);
            this.display_score_btn.TabIndex = 13;
            this.display_score_btn.Text = "Display Scores";
            this.display_score_btn.UseVisualStyleBackColor = true;
            this.display_score_btn.Click += new System.EventHandler(this.display_score_btn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 494);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(526, 155);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 826);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.display_score_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.nav_box);
            this.Controls.Add(this.student_info_box1);
            this.Controls.Add(this.student_info_box2);
            this.Controls.Add(this.count_box);
            this.Name = "Form1";
            this.Text = "hih ";
            this.count_box.ResumeLayout(false);
            this.count_box.PerformLayout();
            this.nav_box.ResumeLayout(false);
            this.student_info_box1.ResumeLayout(false);
            this.student_info_box1.PerformLayout();
            this.student_info_box2.ResumeLayout(false);
            this.student_info_box2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox count_box;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.TextBox num_assign_text;
        private System.Windows.Forms.TextBox num_student_text;
        private System.Windows.Forms.Label num_assign_label;
        private System.Windows.Forms.Label num_student_label;
        private System.Windows.Forms.GroupBox nav_box;
        private System.Windows.Forms.Button prev_student_btn;
        private System.Windows.Forms.Button first_student_btn;
        private System.Windows.Forms.Button last_student_btn;
        private System.Windows.Forms.Button next_student_btn;
        private System.Windows.Forms.GroupBox student_info_box1;
        private System.Windows.Forms.TextBox student_num_text;
        private System.Windows.Forms.Label student_num_label;
        private System.Windows.Forms.Button save_name_btn;
        private System.Windows.Forms.GroupBox student_info_box2;
        private System.Windows.Forms.TextBox assign_num_text;
        private System.Windows.Forms.TextBox assign_score_text;
        private System.Windows.Forms.Button save_score_btn;
        private System.Windows.Forms.Label assign_num_label;
        private System.Windows.Forms.Label assign_score_label;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button display_score_btn;
        private System.Windows.Forms.Label invalid_input2;
        private System.Windows.Forms.Label invalid_input1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label invalid_entry3;
        private System.Windows.Forms.Label invalid_entry5;
        private System.Windows.Forms.Label invalid_entry4;
    }
}

