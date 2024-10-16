namespace GrupparbeteFoodapplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            string text = "Hello, world!";
            int tal1 = 3;
            int tal2 = 7;
            int result = tal1 + tal2;


           MessageBox.Show($"{text}\n{result}");
        }
    }
}
