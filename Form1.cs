namespace proyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tamañoRegistro;
        Archivo archivo;
        int ren = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            tamañoRegistro = txtApellido.MaxLength * 2 + txtNombre.MaxLength * 2;
            archivo = new Archivo(tamañoRegistro, "nombres.dat");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nombre datos = new Nombre(txtNombre.Text.ToUpper(), txtApellido.Text.ToUpper());
            archivo.EcribirRegistos(datos, archivo.NumRegistros);
            listBox1.Items.Add(datos.Nombres + "" + datos.Apellidos);
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
    }
}