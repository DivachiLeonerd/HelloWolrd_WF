namespace Say_Hello_WF
{
    public partial class Form1 : Form
    {
        private Random rand;

        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

        private byte[] GetRandomBytes(int n)
        {
            // Fill an array of bytes of length "n" with random numbers.
            var randomBytes = new byte[n];
            rand.NextBytes(randomBytes);
            return randomBytes;
        }

        private void SayHelloButton_Click(object sender, EventArgs e)
        {
            // Declare an array of bytes and fill it with random numbers
            byte[] rgb = GetRandomBytes(3);
            sayHello_TextBox.Text = "Hello World!";
            sayHello_TextBox.ForeColor = Color.FromArgb(255, rgb[0], rgb[1], rgb[2]);
        }
    }
}