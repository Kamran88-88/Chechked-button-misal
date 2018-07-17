using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        List<User> list = new List<User>() { new User() { Name = "Kamran", Surname = "Aliyev", Age = 25 }, new User() { Name = "Orxan", Surname = "Hasanov", Age = 30 } };
 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var search = Controls.OfType<CheckBox>().Where(x => x.Checked == true).ToList();
            bool result = false;
            foreach (var item in search)
            {
                switch (item.Text)
                {
                    case "Name":
                        result = list.Exists(x => x.Name == textBox1.Text);
                        break;
                    case "Surname":
                        result = list.Exists(x => x.Surname == textBox1.Text);
                        break;
                    case "Age":
                        result = list.Exists(x => x.Age.ToString() == textBox1.Text);
                        break;
                }

                if (result)
                {
                    break;
                }
            }

            if (result)
            {
                MessageBox.Show("Bele User var");
            }
            else
            {
                MessageBox.Show("Bele User yoxdur");
            }
                
        }
    }

    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
