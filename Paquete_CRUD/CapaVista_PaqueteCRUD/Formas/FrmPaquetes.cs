using System;
using System.Globalization;
using System.Windows.Forms;
using CapaControlador_PaqueteCRUD;

namespace CapaVista_PaqueteCRUD.Formas
{
    public partial class FrmPaquetes : Form
    {
        private readonly ControladorPaquete paqueteCtrl = new ControladorPaquete();

        public FrmPaquetes()
        {
            InitializeComponent();
            panelDatos.Enabled = false;
        }

        private void FrmPaquetes_Load(object sender, EventArgs e)
        {
            cmbBusquedaPaquete.SeleccionCambiada += CmbBusquedaPaquete_SeleccionCambiada;
            CargarListado();
        }

        private void CmbBusquedaPaquete_SeleccionCambiada(object sender, EventArgs e)
        {
            if (cmbBusquedaPaquete.ValorSeleccionado == null) return;

            int id = Convert.ToInt32(cmbBusquedaPaquete.ValorSeleccionado);
            foreach (DataGridViewRow fila in gridPaquetes.Rows)
            {
                if (Convert.ToInt32(fila.Cells["IdPaquete"].Value) == id)
                {
                    gridPaquetes.ClearSelection();
                    fila.Selected = true;
                    gridPaquetes.CurrentCell = fila.Cells[0];
                    CargarFilaEnFormulario(fila);
                    break;
                }
            }
        }

        private void CargarListado()
        {
            try
            {
                gridPaquetes.DataSource = paqueteCtrl.ConsultarTodos();

                // Combo inteligente: id_paquete (valor) y codigo_rastreo_paquete (texto).
                cmbBusquedaPaquete.LlenarCombo("paquete", "id_paquete", "codigo_rastreo_paquete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            gridPaquetes.DataSource = paqueteCtrl.FiltrarRegistros(txtFiltro.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            panelDatos.Enabled = true;
            paqueteCtrl.OperacionActual = OperacionCrud.Agregado;
            cajaPedido.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gridPaquetes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila del listado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarFilaEnFormulario(gridPaquetes.CurrentRow);
        }

        // Comun para btnModificar y para cuando se elige un paquete desde el combo inteligente.
        private void CargarFilaEnFormulario(DataGridViewRow fila)
        {
            panelDatos.Enabled = true;
            paqueteCtrl.OperacionActual = OperacionCrud.Modificado;

            paqueteCtrl.IdPaquete = Convert.ToInt32(fila.Cells["IdPaquete"].Value);
            cajaPedido.Text = fila.Cells["IdPedido"].Value.ToString();
            txtCodigo.Text = fila.Cells["CodigoRastreoPaquete"].Value.ToString();
            inputPeso.Text = fila.Cells["PesoPaquete"].Value.ToString();
            txtAltoPaquete.Text = fila.Cells["AltoPaquete"].Value.ToString();
            txtAnchoPaquete.Text = fila.Cells["AnchoPaquete"].Value.ToString();
            txtLargoPaquete.Text = fila.Cells["LargoPaquete"].Value.ToString();
            txtDescrip.Text = fila.Cells["DescripcionPaquete"].Value.ToString();
            cboFragil.SelectedItem = fila.Cells["FragilPaquete"].Value.ToString();
            txtValorDeclarado.Text = fila.Cells["ValorDeclaradoPaquete"].Value.ToString();
            txtTipoPaq.Text = fila.Cells["TipoPaquete"].Value.ToString();
            txtEstadoPaq.Text = fila.Cells["EstadoPaquete"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridPaquetes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila del listado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Desea realmente borrar este registro?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            paqueteCtrl.OperacionActual = OperacionCrud.Borrado;
            paqueteCtrl.IdPaquete = Convert.ToInt32(gridPaquetes.CurrentRow.Cells["IdPaquete"].Value);

            string resultado = paqueteCtrl.GuardarInformacion();
            MessageBox.Show(resultado);
            CargarListado();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idPedido;
            decimal peso, alto, ancho, largo, valorDeclarado;

            int.TryParse(cajaPedido.Text, out idPedido);
            decimal.TryParse(inputPeso.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out peso);
            decimal.TryParse(txtAltoPaquete.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out alto);
            decimal.TryParse(txtAnchoPaquete.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out ancho);
            decimal.TryParse(txtLargoPaquete.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out largo);
            decimal.TryParse(txtValorDeclarado.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out valorDeclarado);

            paqueteCtrl.IdPedido = idPedido;
            paqueteCtrl.CodigoRastreoPaquete = txtCodigo.Text;
            paqueteCtrl.PesoPaquete = peso;
            paqueteCtrl.AltoPaquete = alto;
            paqueteCtrl.AnchoPaquete = ancho;
            paqueteCtrl.LargoPaquete = largo;
            paqueteCtrl.DescripcionPaquete = txtDescrip.Text;
            paqueteCtrl.FragilPaquete = cboFragil.SelectedItem?.ToString() ?? string.Empty;
            paqueteCtrl.ValorDeclaradoPaquete = valorDeclarado;
            paqueteCtrl.TipoPaquete = txtTipoPaq.Text;
            paqueteCtrl.EstadoPaquete = txtEstadoPaq.Text;

            bool valido = new Ayudas.ValidadorFormulario(paqueteCtrl).EsValido();
            if (!valido) return;

            string resultado = paqueteCtrl.GuardarInformacion();
            MessageBox.Show(resultado);
            CargarListado();
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            panelDatos.Enabled = false;
            cajaPedido.Clear();
            txtCodigo.Clear();
            inputPeso.Clear();
            txtAltoPaquete.Clear();
            txtAnchoPaquete.Clear();
            txtLargoPaquete.Clear();
            txtDescrip.Clear();
            cboFragil.SelectedIndex = -1;
            txtValorDeclarado.Clear();
            txtTipoPaq.Clear();
            txtEstadoPaq.Clear();
        }
    }
}
