using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3280_Assignment3
{
    public partial class Form1 : Form
    {
        #region Attributes
        //number of students in the class
        private int num_student;

        //number of assignments in the class
        private int num_assign;

        //number of assignment accessed
        private int num_assign_access; 

        //score on assignment
        private int score_assign; 

        //location in student array
        private int array_location; 

        //student name array
        private string[] student_array = new string[] { };

        //assignment scores array
        private int[,] assign_array = new int[,] { }; 

        #endregion

        #region Methods
        public Form1()
        {
            InitializeComponent();
        }

        #region Counts Box

        /// <summary>
        /// Find what student_array length will be
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void num_student_text_TextChanged(object sender, EventArgs e)
        {
            int student_int = 0; 

            //make sure # is an int
            if(!Int32.TryParse(num_student_text.Text, out student_int))
            {
                invalid_input1.Text = "Entry is Invalid"; 
            } else
            {
                invalid_input1.Text = ""; 
            }

            //make sure # is less than 10 
            if(student_int < 1 || student_int > 10)
            {
                invalid_input1.Text = "Entry is Invalid"; 
            } else
            {
                invalid_input1.Text = ""; 
            }

            if (invalid_input1.Text == "" && invalid_input2.Text == "")
            {
                submit_btn.Enabled = true;
            }

            //set # up top
            num_student = student_int; 
        }

        /// <summary>
        /// Find what assign_array length will be
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void num_assign_text_TextChanged(object sender, EventArgs e)
        {
            int num_assign_int = 0;

            //make sure # is an int
            if (!Int32.TryParse(num_assign_text.Text, out num_assign_int))
            {
                invalid_input2.Text = "Entry is Invalid";
            } else
            {
                invalid_input2.Text = ""; 
            }

            //make sure # is less than 99
            if (num_assign_int < 1 || num_assign_int > 99)
            {
                invalid_input2.Text = "Entry is Invalid";
            }  else
            {
                invalid_input2.Text = ""; 
            }

            if (invalid_input1.Text == "" && invalid_input2.Text == "")
            {
                submit_btn.Enabled = true;
            }

            //set # up top
            num_assign = num_assign_int;
        }

        /// <summary>
        /// Sets student_array and assign_array lengths
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit_btn_Click(object sender, EventArgs e)
        {          
            //create an array to hold students' names
            student_array = new string[num_student];

            for(int i = 0; i < num_student; i++)
            {
                student_array[i] = "Student #" + (i + 1); 
            }

            //create an array to hold students' assignments
            assign_array = new int[num_assign, num_student];

            for (int i = 0; i < num_assign; i++)
            {
             for(int j = 0; j < num_student; j++)
                {
                    assign_array[i, j] = 0; 
                }
            }
            assign_num_label.Text = "Enter Assignment Number (1-" + num_assign + "):"; 
            array_location = 0; 
            first_student_btn.Enabled = true;
            prev_student_btn.Enabled = true; 
            next_student_btn.Enabled = true;
            last_student_btn.Enabled = true; 
        }

        /// <summary>
        /// Resets program to initial condition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_btn_Click(object sender, EventArgs e)
        {
            //reset arrays
            student_array = new string[] { };
            assign_array = new int[,] { };
            //clear labels
            assign_score_label.Text = "Enter Assignment Number:";
            invalid_input1.Text = "";
            invalid_input2.Text = ""; 
            invalid_entry3.Text = "";
            invalid_entry4.Text = "";
            invalid_entry5.Text = "";

            //set everything to 0
            
        num_student = 0;
         num_assign = 0;
         num_assign_access = 0;
         score_assign = 0;
         array_location = 0;

            //clear bottom box
            richTextBox1.Text = ""; 
    }

        #endregion

        #region Navigate box
        /// <summary>
        /// Accesses first student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void first_student_btn_Click(object sender, EventArgs e)
        {
            array_location = 0;
            student_num_label.Text = student_array[array_location].ToString();
        }

        /// <summary>
        /// Accesses previous student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prev_student_btn_Click(object sender, EventArgs e)
        {
            if(student_array[array_location - 1] != null)
            {
                array_location = array_location - 1;
                student_num_label.Text = student_array[array_location].ToString();
            } else
            {
                next_student_btn.Enabled = false; 
            }
            
        }

        /// <summary>
        /// Accesses next student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void next_student_btn_Click(object sender, EventArgs e)
        {
            if (student_array[array_location + 1] != null)
            {
                array_location = array_location + 1;
                student_num_label.Text = student_array[array_location].ToString();
            } else
            {
                next_student_btn.Enabled = false; 
            }
        }

        /// <summary>
        /// Accesses last student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void last_student_btn_Click(object sender, EventArgs e)
        {
            array_location = student_array.Length - 1;
            student_num_label.Text = student_array[array_location].ToString();
        }

        #endregion

        #region Name box

        private void save_name_btn_Click(object sender, EventArgs e)
        {
            student_array[array_location] = student_num_text.Text;   
        }

        #endregion

        #region Student Info

        private void assign_num_text_TextChanged(object sender, EventArgs e)
        {
            int assign_num_int = 0;

            //make sure # is an int
            if (!Int32.TryParse(assign_num_text.Text, out assign_num_int))
            {
                invalid_entry3.Text = "Entry is Invalid";
            }
            else
            {
                invalid_entry3.Text = "";
            }

            //make sure # is less than our number of assignments
            if (assign_num_int < 1 || assign_num_int > num_assign)
            {
                invalid_entry3.Text = "Entry is Invalid";
            }
            else
            {
                invalid_entry3.Text = "";
            }

            //set # up top
            num_assign_access = assign_num_int;
        }

        private void assign_score_text_TextChanged(object sender, EventArgs e)
        {
            int score_num_int = 0;

            //make sure # is an int
            if (!Int32.TryParse(assign_score_text.Text, out score_num_int))
            {
                invalid_entry4.Text = "Entry is Invalid";
            }
            else
            {
                invalid_entry4.Text = "";
                score_num_int = Int32.Parse(assign_score_text.Text);
            }

            //make sure # is less than 100 
            if (score_num_int < 0 || score_num_int > 100)
            {
                invalid_entry4.Text = "Entry is Invalid";
            }
            else
            {
                invalid_entry4.Text = "";
            }

            if (invalid_entry3.Text == "" && invalid_entry4.Text == "")
            {
                
                score_assign = score_num_int;
                save_score_btn.Enabled = true; 
            }

        }
        private void save_score_btn_Click(object sender, EventArgs e)
        {
            assign_array[array_location, num_assign_access - 1] = score_assign;
            display_score_btn.Enabled = true; 
        }


        #endregion

        #region listbox 
        private void display_score_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "STUDENT\t"; 


            //Loop through using the Length method
            for (int i = 0; i < student_array.Length; i++)
            {
                richTextBox1.Text += student_array[i].ToString();
                richTextBox1.Text += "\t";
            }

            richTextBox1.Text += "\nSCORE\t\t"; 
                for (int i = 0; i < assign_array.GetLength(0); i++)
            {
                for (int j = 0; j < assign_array.GetLength(1); j++)
                {
                    richTextBox1.Text += assign_array[i, j].ToString() + "\t\t";
                }
                richTextBox1.Text += "\n";
            }
            richTextBox1.Text += "\nAVG\t\t";
            //calculate average grade
            for (int i = 0; i < assign_array.GetLength(0); i++)
            {
                int average = 0;
                char letter; 
                for (int j = 0; j < assign_array.GetLength(1); j++)
                {
                    average += assign_array[i,j]; 
                    
                }
                average = average / num_assign;
                
                //calculate letter grade
                if(average > 93)
                {
                    letter = 'A'; 
                } else if (average > 83)
                {
                    letter = 'B'; 
                }
                else if (average > 73)
                {
                    letter = 'C';
                }
                else if (average > 63)
                {
                    letter = 'D';
                } else
                {
                    letter = 'F'; 
                }

                richTextBox1.Text += average.ToString() + "  ";
                richTextBox1.Text += "\t";
                richTextBox1.Text += "\tGRADE\t";
                richTextBox1.Text += letter.ToString() + "  ";
                richTextBox1.Text += "\t";
            }

        }




        #endregion

        #endregion


    }
}
