namespace Semana_3._3__MultiList_CompraCaja_.NET_6._0
{
    public partial class Form1 : Form
    {
        List<Caja> cajas = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void mostrarCajas(List<Caja> lista)
        {
            listViewCaja.Items.Clear();

            foreach (Caja caja in lista)
            {
                ListViewItem fila = new(caja.Codigo);
                fila.SubItems.Add(caja.NombreCajero);
                listViewCaja.Items.Add(fila);
            }
        }

        private void btnRegistrarCaja_Click(object sender, EventArgs e)
        {
            //Validacion
            if (tbCodigo.Text == "" || tbNombreCajero.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos de la caja");
                return;
            }

            //Verificación de código repetido
            bool exists =
                cajas.Exists(elemento => elemento.Codigo.Equals(tbCodigo.Text));
            if (exists)
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            //Crear el objeto
            Caja caja = new()
            {
                Codigo = tbCodigo.Text,
                NombreCajero = tbNombreCajero.Text,
                Compras = new()
            };

            //Agregarlo a la lista
            cajas.Add(caja);

            //Mostrar en el ListView
            mostrarCajas(cajas);
        }

        private void btnLimpiarCaja_Click(object sender, EventArgs e)
        {
            //Mostrar en el ListView
            mostrarCajas(cajas);
        }

        private void mostrarCompras(List<Compra> lista)
        {
            listViewCompra.Items.Clear();
            double montoTotal = 0;

            foreach (Compra compra in lista)
            {
                ListViewItem fila = new(compra.DNICliente);
                fila.SubItems.Add(compra.Monto.ToString());
                fila.SubItems.Add(compra.Fecha);
                listViewCompra.Items.Add(fila);
                montoTotal += compra.Monto;
            }

            Compra? compraMenorMonto = lista.MinBy(elemento => elemento.Monto.ToString());
            if (compraMenorMonto != null) lblMenorMonto.Text = compraMenorMonto.DNICliente;

            lblMontoTotal.Text = montoTotal.ToString();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            //Validacion
            bool seleccionado = listViewCaja.SelectedItems.Count != 0;
            if (!seleccionado || tbDNICliente.Text == "" || tbMonto.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos de la compra");
                return;
            }

            //Encontrar el album selecionado
            String codigo = listViewCaja.SelectedItems[0].Text;
            Caja? cajaSeleccionado = cajas.Find(elemento => elemento.Codigo.Equals(codigo));
            if (cajaSeleccionado == null) return;

            //Hallamos la lista de héroes del álbum
            List<Compra> compras = cajaSeleccionado.Compras;

            //Crear el objeto
            Compra compra = new()
            {
                DNICliente = tbDNICliente.Text,
                Monto = double.Parse(tbMonto.Text),
                Fecha = dateTimePickerFecha.Text,
            };

            //Agregarlo a la lista de Héroes del album
            cajaSeleccionado.Compras.Add(compra);

            //Mostrar en el ListView
            mostrarCompras(cajaSeleccionado.Compras);
        }

        private void listViewCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validación
            bool seleccionado = listViewCaja.SelectedItems.Count != 0;
            if (!seleccionado) return;

            //Hallar el álbum
            String codigo = listViewCaja.SelectedItems[0].Text;
            Caja? cajaSeleccionado = cajas.Find(elemento => elemento.Codigo.Equals(codigo));
            if (cajaSeleccionado == null) return;

            mostrarCompras(cajaSeleccionado.Compras);
        }

        private void btnLimpiarCompra_Click(object sender, EventArgs e)
        {
            //Mostrar en el ListView
            mostrarCompras(new List<Compra>());
        }

        private void listViewCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validación
            bool seleccionado = listViewCompra.SelectedItems.Count != 0;
            if (!seleccionado) return;

            //Hallar el dni del cliente
            String dnicliente = listViewCompra.SelectedItems[0].Text;

            //Buscar las cajas que tengan la compra con ese código
            List<Caja> cajasTemp = new();
            foreach (Caja caja in cajas)
            {
                bool existe = caja.Compras.Exists(elemento => elemento.DNICliente.Equals(dnicliente));
                if (existe) cajasTemp.Add(caja);
            }

            //Mostrar álbumes
            mostrarCajas(cajasTemp);
        }
    }
}