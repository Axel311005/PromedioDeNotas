namespace PromedioDeNotas
{
    public partial class Callificacions : Form
    {
        public Callificacions()
        {
            InitializeComponent();
        }

        Calificacionescs objC = new();

        
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            objC.nombreEstudiante=txtNombre.Text;


            int[] cali =
            {
            int.Parse(txtNota1.Text),
            int.Parse(txtNota2.Text),
            int.Parse(txtNota3.Text)
            };

            objC.Calificaciones=cali;

            Agregar();


        }

        private void Agregar()
        {
            if (validar() == "")
            {
                ListViewItem fila=new ListViewItem(objC.nombreEstudiante);
                fila.SubItems.Add(txtNota1.Text);
                fila.SubItems.Add(txtNota2.Text);
                fila.SubItems.Add(txtNota3.Text);
                double promedio = objC.ObtenerPromedio();
                fila.SubItems.Add(promedio.ToString());
                lvTabla.Items.Add(fila);
                limpiarDatos();
            }
            else
            {
                MessageBox.Show($"El error esta en que {validar()}");
            }
        }

        private void limpiarDatos()
        {
            txtNombre.Clear();
            txtNota1.Clear();   
            txtNota2.Clear();   
            txtNota3.Clear();       
        }

        private string validar()
        {
            if(int.Parse(txtNota1.Text) <0 || int.Parse(txtNota1.Text) > 100)
            {
                return "La nota no puede ser mayor a 100 ni menor a 00";
            }else if (int.Parse(txtNota2.Text) < 0 || int.Parse(txtNota2.Text) > 100)
            {
                return "La nota no puede ser mayor a 100 ni menor a 00";
            }else if (int.Parse(txtNota3.Text) < 0 || int.Parse(txtNota3.Text) > 100)
            {
                return "La nota no puede ser mayor a 100 ni menor a 00";
            }
            else if(txtNombre.Text.Trim().Length == 0)
            {
                return "El nombre";
            }
            else if (txtNota1.Text.Trim().Length == 0)
            {
                return "Nota1";
            }
            else if (txtNota2.Text.Trim().Length == 0)
            {
                return "Nota2";
            }
            else if (txtNota3.Text.Trim().Length == 0)
            {
                return "Nota3";
            }
            return "";
        }
    }
}