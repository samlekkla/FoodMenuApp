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
            int tal1 = 2;
            int tal2 = 2;
            int result = tal1 + tal2;

            MessageBox.Show($"{result}\n {text}");

            // MessageBox.Show($"{text}\n{result}");
            //Testtest22
            MessageBox.Show(string.Empty);
        }
    }
}
