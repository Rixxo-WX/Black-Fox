using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlackFox
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        Logic logic = new Logic();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            label2.Visible = false;
            Validate();
            richTextBox1.BorderStyle = BorderStyle.None;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.BorderSize = 0;
        }
        private void Validate()
        {
            if (logic.validation() == false) //Swticht to true on release build
            {
                Launch.Visible = false;
                label2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logic.Launch();
            Validate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            logic.Fire();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logic.Smoke();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logic.Sparkles();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            logic.ForceField();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logic.BuilderTools();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            logic.Suicide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string luaScriptText = richTextBox1.Text;
            logic.RunLuaScript(luaScriptText);
            richTextBox1.Text = String.Empty;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string speedValue = richTextBox2.Text;
            logic.SuperSpeed(speedValue);
            richTextBox2.Text = String.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
