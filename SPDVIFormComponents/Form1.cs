using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVIFormComponents
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            ResizeForm(800, 600);
            changeButtonText();
            button2.Text = "Enabled = " + button1.Enabled;
            button3.Text = "Visible = " + button1.Visible;

        }
        void ResizeForm(int x, int y)
        {
            this.Size = new Size(x, y);
        }
        private void button1_Move(object sender, System.EventArgs e)
        {
            changeButtonText();
        }
        void changeButtonText()
        {
            button1.Text = "Target\nX = " + button1.Location.X + "\nY=" + button1.Location.Y;
        }
        private void mainForm_Move(object sender, System.EventArgs e)
        {
            this.Text = "("+this.Location.X+", "+this.Location.Y+") Winforms Components - Common Controls";
        }
        private void mainForm_Sized(object sender, System.EventArgs e)
        {
            formSizeLabel.Text = "Form Size: " + this.Size.ToString();
        }
        public void moveButton(int x, int y)
        {
            button1.Location = new Point(x, y);
        }
        private void downButton_Click(object sender, EventArgs e)
        {
            moveButton(button1.Location.X, button1.Location.Y + 5);
        }
        private void upButton_Click_1(object sender, EventArgs e)
        {
            moveButton(button1.Location.X, button1.Location.Y - 5);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            moveButton(button1.Location.X+5, button1.Location.Y);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            moveButton(button1.Location.X-5, button1.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = !button1.Enabled;
            button2.Text = "Enabled = " + button1.Enabled;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = !button1.Visible;
            button3.Text = "Visible = " + button1.Visible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveButton(this.Size.Width / 2, this.Size.Height / 2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = (FormBorderStyle)Enum.Parse(typeof(FormBorderStyle), comboBox1.SelectedItem.ToString());
        }
    }
}
