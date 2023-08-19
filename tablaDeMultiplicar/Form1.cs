namespace tablaDeMultiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hell World");
            Console.WriteLine("Hell World");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int numero = int.Parse(textBox1.Text);

            for (int i = 1; i < 10; i++)
            {
                listBox1.Items.Add(numero + " X " + i + " = " + (i * numero));
            }
            textBox1.ResetText();            
            textBox1.Focus();
        }
    }
}