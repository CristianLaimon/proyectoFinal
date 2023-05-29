namespace proyectoFinal
{
    public partial class Form1 : Form
    {
        int tamanoReg;
        Archivo march;
        int ren = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tamanoReg = textBox1.MaxLength * 2 + textBox2.MaxLength * 2;
            march = new Archivo(tamanoReg, "nombres.dat");
        }
    }
}