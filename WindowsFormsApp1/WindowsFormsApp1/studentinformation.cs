using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class studentinformation : Form
    {
        List<string> id = new List<string> { };
        List<string> name = new List<string> { };
        List<string> mobile = new List<string> { };
        List<int> age = new List<int> { };
        List<string> address = new List<string> { };
        List<double> gpa = new List<double> { };

        public studentinformation()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text.Length !=4)
            {
                MessageBox.Show("Enter your id of 4 character");
            }
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Please enter id");
                return;
            }

            if (id.Contains(idTextBox.Text))
            {
                MessageBox.Show("id must be unique");
                return;
            }
            
            if (nameTextBox.Text.Length >= 30)
            {
                MessageBox.Show("Enter your name of maximum 30 character");
            }
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Please enter name");
                return;
            }
            if (mobileTextBox.Text.Length != 11)
            {
                MessageBox.Show("Enter your mobile number of 11 character");
            }
            if (String.IsNullOrEmpty(mobileTextBox.Text))
            {
                MessageBox.Show("Please enter mobile number");
                return;
            }
            
            if (mobile.Contains(mobileTextBox.Text))
            {
                MessageBox.Show("Mobile number is already exists");
                return;
            }

            if ( Convert.ToDouble(gpaTextBox.Text) >= 4.01)
            {
                MessageBox.Show("Please enter GPA in scale of 4");
                return;
            }
            if (String.IsNullOrEmpty(gpaTextBox.Text))
            {
                MessageBox.Show("Please enter GPA");
                return;
            }

            

            AddStudent(idTextBox.Text, nameTextBox.Text, mobileTextBox.Text, 
                Convert.ToInt32(ageTextBox.Text), addressTextBox.Text,Convert.ToDouble(gpaTextBox.Text));
            MessageBox.Show("Information added");
            ClearList();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string Message = "";

            for (int i = 0; i < id.Count(); i++)
            {
                Message += "ID: " + id[i] + "\n" + "Name: " + name[i] + "\n" + 
                    "Mobile No: " + mobile[i] + "\n" + "Age: " + age[i] + "\n" + "Address: "
                    + address[i] + "\n" +"GPA"+gpa[i]+ "\n";  
            }
            ClearList();
            richTextBox.Text = Message;
            
            var min = gpa.Min();
            var max = gpa.Max();
            var sum = gpa.Sum();
            var average = gpa.Average();
            var maxNumberName = gpa.IndexOf(gpa.Max());
            var minNumberName = gpa.IndexOf(gpa.Min());

            maxnameTextBox.Text = name[maxNumberName];
            minnameTextBox.Text = name[minNumberName];
            maxnumTextBox.Text = max.ToString();
            minnumTextBox.Text = min.ToString();
            totalTextBox.Text = sum.ToString();
            averageTextBox.Text = average.ToString();



        }
        public void AddStudent(string ID,string Name, string Mobile,int Age, string Address, double GPA)
        {

            id.Add(ID);
            name.Add(Name);
            mobile.Add(Mobile);
            age.Add(Age);
            address.Add(Address);
            gpa.Add(GPA);
           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (idRadioButton.Checked==true)
            {
                if(id.Contains(idTextBox.Text))
                {
                    int index = id.IndexOf(idTextBox.Text);
                        MessageBox.Show("ID: " + id[index] + "\n" + "Name: " + name[index] + "\n" +
                    "Mobile No: " + mobile[index] + "\n" + "Age: " + age[index] + "\n" + "Address: "
                    + address[index] + "\n" + "GPA" + gpa[index] + "\n");

                    richTextBox.Text = ("ID: " + id[index] + "\n" + "Name: " + name[index] + "\n" +
                    "Mobile No: " + mobile[index] + "\n" + "Age: " + age[index] + "\n" + "Address: "
                    + address[index] + "\n" + "GPA" + gpa[index] + "\n");

                }
            }
            
          else  if (nameRadioButton.Checked == true)
            {
                if (name.Contains(nameTextBox.Text))
                {
                    int index = name.IndexOf(nameTextBox.Text);
                        MessageBox.Show("ID: " + id[index] + "\n" + "Name: " + name[index] + "\n" +
                    "Mobile No: " + mobile[index] + "\n" + "Age: " + age[index] + "\n" + "Address: "
                    + address[index] + "\n" + "GPA" + gpa[index] + "\n");

                    richTextBox.Text = ("ID: " + id[index] + "\n" + "Name: " + name[index] + "\n" +
                    "Mobile No: " + mobile[index] + "\n" + "Age: " + age[index] + "\n" + "Address: "
                    + address[index] + "\n" + "GPA" + gpa[index] + "\n");

                }
               

            }
          

         else   if (mobileRadioButton.Checked == true)
            {
                if (mobile.Contains(mobileTextBox.Text))
                {
                    int index = mobile.IndexOf(mobileTextBox.Text);
                        MessageBox.Show("ID: " + id[index] + "\n" + "Name: " + name[index] + "\n" +
                    "Mobile No: " + mobile[index] + "\n" + "Age: " + age[index] + "\n" + "Address: "
                    + address[index] + "\n" + "GPA" + gpa[index] + "\n");

                    richTextBox.Text = ("ID: " + id[index] + "\n" + "Name: " + name[index] + "\n" +
                    "Mobile No: " + mobile[index] + "\n" + "Age: " + age[index] + "\n" + "Address: "
                    + address[index] + "\n" + "GPA" + gpa[index] + "\n");
                    
                    

                }
               
            }
           else
            {
                MessageBox.Show("Data not found");
            }
            ClearList();


        }
        private void ClearList()
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            mobileTextBox.Clear();
            ageTextBox.Clear();
            addressTextBox.Clear();
            gpaTextBox.Clear();
        }

        
    }
}
