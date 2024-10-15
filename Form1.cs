namespace GrupparbeteFoodapplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "Hello World!";
            int tal1 = 1; int tal2 = 2;

            int result = tal1 + tal2;

            MessageBox.Show($"{result}\n{text}");


        }
    }
}
