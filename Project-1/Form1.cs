using System;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear all text boxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();

            // (Preferred Shift)
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            // (Age Verification)
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
            }

            // Uncheck the confirmation checkbox
            checkBox1.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(textBox1.Text) || // First Name
                string.IsNullOrWhiteSpace(textBox2.Text) || // Last Name
                string.IsNullOrWhiteSpace(textBox3.Text) || // Address
                string.IsNullOrWhiteSpace(textBox5.Text) || // City
                string.IsNullOrWhiteSpace(textBox6.Text))   // Zip Code
            {
                MessageBox.Show("Please fill in all fields.");
                return; // Exit the method if any fields are empty
            }

            // Check if at least one preferred shift is selected
            bool shiftSelected = false;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    shiftSelected = true;
                    break;
                }
            }

            if (!shiftSelected)
            {
                MessageBox.Show("Please select at least one preferred shift.");
                return; // Exit if no shifts are selected
            }

            // Check if over 18 is selected
            bool over18Selected = checkedListBox2.GetItemChecked(0); // Yes
            if (!over18Selected)
            {
                MessageBox.Show("You must confirm that you are over 18 years old.");
                return; // Exit if not confirmed
            }

            // All validations passed
            MessageBox.Show("All information submitted successfully.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void checkedListBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
