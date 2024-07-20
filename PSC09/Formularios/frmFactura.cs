using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PSC09
{
    public partial class frmFactura : Form
    {

        Boolean ExisteData;
        double zImpuesto;
        double zTotal;
        double zSubtotal;
        double lnImpuesto;
        public frmFactura()
        {
            InitializeComponent();
            EstiloDataGridView();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            this.Text = "Factura";
            this.KeyPreview = true;

            lblFechaFactura.Text = DateTime.Now.ToString("ddMMyyyy");

            ExisteData = false;

            lblFactura.Text = Busco.BuscaUltimoNumero("1"); // AQUI TRAE EL ULTIMO NUMERO DE LA FACTURA

        }

        private void frmFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        //------------------------------------------------------
        //                 TEXTBOX Y LABELS
        //------------------------------------------------------
        #region Textbox y Labels
        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtCliente.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtArticulo.Focus();  // movera el cursor hacia el textbox Articulo
                }
            }
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (txtCliente.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                BuscarCliente(txtCliente.Text);    // viaja hacia el metodo y le envia el valor contenido en el textbox
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                btnCliente.PerformClick();
            }
        }

        private void txtArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtArticulo.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtCantidad.Focus();  // movera el cursor hacia el textbox Cantidad
                }
            }
        }

        private void txtArticulo_Leave(object sender, EventArgs e)
        {
            if (txtArticulo.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                BuscarArticulo(txtArticulo.Text);    // viaja hacia el metodo y le envia el valor contenido en el textbox
            }
        }

        private void txtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                btnArticulo.PerformClick();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtCantidad.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    btnGuardar.Focus();  // movera el cursor hacia el textbox Departamento
                }
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {

            double nmCant = Convert.ToDouble(txtCantidad.Text);
            double nmPrec = Convert.ToDouble(lblPrecio.Text);
   
            if (nmCant > 0) // Preguntamos que si el textbox cantidad es mayor que 0
            {
                if (nmPrec > 0) // Preguntamos que si el label precio es mayor que 0
                {
                    double price = Convert.ToDouble(lblPrecio.Text);
                    double quantity = Convert.ToDouble(txtCantidad.Text);
                    double total = price * quantity; // Total sin impuesto

                    if (lblPagaImpuesto.Text == "1") // Calculara el impuesto
                        lblImpuestoLn.Text = (total * lnImpuesto).ToString();

                    if (lblPagaImpuesto.Text == "0") // No calculara el impuesto
                        lblImpuestoLn.Text = "0";

                    lblTotalLn.Text = total.ToString();

                }
            }
        }
        #endregion
        //------------------------------------------------------
        //                     BOTONES
        // -----------------------------------------------------
        #region Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text.Trim() != string.Empty)
            {
                InsertarData();
                LimpiarFormulario();
                txtCliente.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtCliente.Focus();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (ExisteData == true)
            {
                BorrarData(lblFactura.Text);
                LimpiarFormulario();
                txtCliente.Focus();
                ExisteData = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertarLn_Click(object sender, EventArgs e)
        {
            if (txtArticulo.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                if (lblArticulo.Text.Trim() != string.Empty)  // pregunta que si el label es diferente de vacio
                {
                    if (txtCantidad.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                    {
                        if (lblPrecio.Text.Trim() != string.Empty)  // pregunta que si el label es diferente de vacio
                        {
                            if (lblImpuestoLn.Text.Trim() != string.Empty)  // pregunta que si el label es diferente de vacio
                            {
                                if (lblTotalLn.Text.Trim() != string.Empty)  // pregunta que si el label es diferente de vacio
                                {
                                    if (ExisteData == true)  
                                    {
                                        InsertaLinea();
                                        ActualizaSecuenciaFactura();
                                        TotalizarFactura();
                                        LimpiarFormulario();
                                        txtArticulo.Focus();
                                        
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarLn_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                BorrarLineaDelDataGridView();
            }
            
        }

        private void btnLimpiarDet_Click(object sender, EventArgs e)
        {
            LimpiarDetalle();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }


        private void btnArticulo_Click(object sender, EventArgs e)
        {

        }
        #endregion
        //------------------------------------------------------
        //                     METODOS
        //------------------------------------------------------
        #region Metodos
        private void LimpiarFormulario()
        {
            ExisteData = false;

            lblFactura.Text = "";
            txtCliente.Clear();
            lblPagaImpuesto.Text = "";
            lblFechaFactura.Text = "";

            lblNombre.Text = "";
            lblNombrePaga.Text = "";

            lblSubTotal.Text = "";
            lblImpuesto.Text = "";
            lblTotal.Text = "";

            this.dgv.Rows.Clear();
            this.dgv.Refresh();

            LimpiarDetalle();

            lblFactura.Text = Busco.BuscaUltimoNumero("1"); // Aqui trae el ultimo numero de factura

        }
        private void LimpiarDetalle()
        {
            txtArticulo.Clear();
            lblArticulo.Text = "";
            txtCantidad.Clear();
            lblPrecio.Text = "";
            lblImpuestoLn.Text = "";
            lblTotalLn.Text = "";

        }

        private void EstiloDataGridView()
        {
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("Col00", "");
            this.dgv.Columns.Add("Col01", "");
            this.dgv.Columns.Add("Col02", "");
            this.dgv.Columns.Add("Col03", "");
            this.dgv.Columns.Add("Col04", "");
            this.dgv.Columns.Add("Col05", "");

            DataGridViewColumn
            column = dgv.Columns[00]; column.Width = 100;
            column = dgv.Columns[01]; column.Width = 420;
            column = dgv.Columns[02]; column.Width = 100;
            column = dgv.Columns[03]; column.Width = 100;
            column = dgv.Columns[04]; column.Width = 100;
            column = dgv.Columns[05]; column.Width = 100;

            this.dgv.BorderStyle = BorderStyle.None;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            this.dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            this.dgv.BackgroundColor = Color.LightGray;

            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void BuscarCliente(string nmrCliente)
        {
            SqlConnection cnx = new SqlConnection(cnn.db); // Abrimos la base de datos
            cnx.Open();
            string tsQuery = "SELECT NOMBRE, PAGAIMPUESTO FROM CLIENTES WHERE IDCLIENTE = " + nmrCliente;
            SqlCommand cmd = new SqlCommand(tsQuery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader();

            if (rcd.Read())
            {
                lblNombre.Text = Convert.ToString(rcd["NOMBRE"]);
                lblPagaImpuesto.Text = Convert.ToString(rcd["PAGAIMPUESTO"]);

                if (lblPagaImpuesto.Text == "1")
                {
                    lblNombrePaga.Text = "Paga Impuesto";
                }

                else
                {
                    lblNombrePaga.Text = "No Paga Impuesto";
                }
            }

            cmd.Dispose();
            cnx.Close();
        }

        private void BuscarArticulo(string nmArticulo)
        {
            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open();
            string tsQuery = "SELECT ITEM, DESCRIPCION, PRECIODEVENTA, IMPUESTO FROM PRODUCTOS WHERE ITEM ='" + nmArticulo + "'";
            SqlCommand cmd = new SqlCommand(tsQuery, cnx);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            { 
                lblArticulo.Text = Convert.ToString(rdr["DESCRIPCION"]);
                lblPrecio.Text = Convert.ToString(rdr["PRECIODEVENTA"]);
                lnImpuesto = Convert.ToDouble(rdr["IMPUESTO"]);

            }

            cmd.Dispose();
            cnx.Close();

        }

        private void InsertaLinea()
        {

            dgv.Rows.Add();
            int xRows = dgv.Rows.Count - 1;

            dgv[0, xRows].Value = txtArticulo.Text;
            dgv[1, xRows].Value = lblArticulo.Text;
            dgv[2, xRows].Value = txtCantidad.Text;
            dgv[3, xRows].Value = lblPrecio.Text;
            dgv[4, xRows].Value = lblImpuestoLn.Text;
            dgv[5, xRows].Value = lblTotalLn.Text;

        }

        private void BorrarLineaDelDataGridView()
        {
            int CuantasLineasTengo = Convert.ToInt32(dgv.RowCount); // Almacenamos en la variable el numero de lineas que tenemos

            if (CuantasLineasTengo == 1) // Preguntamos si hay al menos una linea en el puesto 1
            {
                dgv.Rows.RemoveAt(dgv.RowCount - 1);

            }

            else
            {
                dgv.Rows.Remove(dgv.CurrentRow); // Removemos la linea actual
            }

            txtArticulo.Focus(); // Enfocamos al textbox articulo

        }

        private void TotalizarFactura()
        {
            try
            {
                zImpuesto = 0;
                zSubtotal = 0;
                zTotal = 0;
                lblSubTotal.Text = "";
                lblImpuesto.Text = "";
                lblTotal.Text = "";

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    Double nImpuesto = Convert.ToDouble(dgv.CurrentRow.Cells[4].Value.ToString());
                    Double nSubTotal = Convert.ToDouble(dgv.CurrentRow.Cells[5].Value.ToString());
                    Double nTotal = nSubTotal + nImpuesto;

                    zImpuesto = zImpuesto + nImpuesto;
                    zSubtotal = zSubtotal + nSubTotal;
                    zTotal = zTotal + nTotal;
                }

                lblSubTotal.Text = Convert.ToString(zSubtotal);
                lblImpuesto.Text = Convert.ToString(zImpuesto);
                lblTotal.Text = Convert.ToString(zTotal);
            }

            catch
            {
                //
            }
        }

        private void InsertarData()
        {

            if (dgv.RowCount > 0)
            {
                if (lblTotal.Text != string.Empty)
                {
                    string stQuery = "INSERT INTO HFACTURA (FACTURA, CLIENTE, FECHA, SUBTOTAL, IMPUESTO, MONTOFACTURADO, ACTIVO ) " +
                                     "VALUES (@A0,@A1,@A2,@A3,@A4,@A5,@A6)";

                    SqlConnection cnt = new SqlConnection(cnn.db); cnt.Open();
                    SqlCommand cmd = new SqlCommand(stQuery, cnt);

                    cmd.Parameters.AddWithValue("@A0", lblFactura.Text);
                    cmd.Parameters.AddWithValue("@A1", txtCliente.Text);
                    cmd.Parameters.AddWithValue("@A2", lblFechaFactura.Text);
                    cmd.Parameters.AddWithValue("@A3", lblSubTotal.Text);
                    cmd.Parameters.AddWithValue("@A4", lblImpuesto.Text);
                    cmd.Parameters.AddWithValue("@A5", lblTotal.Text);
                    cmd.Parameters.AddWithValue("@A6", "1");

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cnt.Close();

                    InsertaDetalleFactura();
                }
            }
        }

        private void InsertaDetalleFactura()
        {
            string stQueri = "INSERT INTO DFACTURA " +
                             " ( FACTURA,          " +
                             "   ARTICULO,         " +
                             "   CANTIDAD,         " +
                             "   PRECIODEVENTA,    " +
                             "   IMPUESTO,         " +
                             "   MONTOPORLINEA,    " +
                             "   CLIENTE,          " +
                             "   FECHA,            " +
                             "   SECUENCIA,        " +
                             "   ACTIVO )          " +
                             "VALUES (@A0,@A1,@A2,@A3,@A4,@A5,@A6,@A7,@A8,@A9)";

            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open();

            for (int xrow = 0; xrow < dgv.Rows.Count - 1; xrow++)
            {
                string nmArt = dgv.Rows[xrow].Cells[0].Value.ToString();
                string nmCan = dgv.Rows[xrow].Cells[2].Value.ToString();
                string nmPre = dgv.Rows[xrow].Cells[3].Value.ToString();
                string nmImp = dgv.Rows[xrow].Cells[4].Value.ToString();
                string nmTot = dgv.Rows[xrow].Cells[5].Value.ToString();

                SqlCommand cmm = new SqlCommand(stQueri, cnx);

                cmm.Parameters.AddWithValue("@A0", lblFactura.Text);
                cmm.Parameters.AddWithValue("@A1", nmArt);
                cmm.Parameters.AddWithValue("@A2", nmCan);
                cmm.Parameters.AddWithValue("@A3", nmPre);
                cmm.Parameters.AddWithValue("@A4", nmImp);
                cmm.Parameters.AddWithValue("@A5", nmTot);
                cmm.Parameters.AddWithValue("@A6", txtCliente.Text);
                cmm.Parameters.AddWithValue("@A7", lblFechaFactura.Text);
                cmm.Parameters.AddWithValue("@A8", xrow.ToString());
                cmm.Parameters.AddWithValue("@A9", "1");
            }
        }

        private void BorrarData(string numFactura)
        {
            if (ExisteData == true)
            {
                SqlConnection cns = new SqlConnection(cnn.db); cns.Open();
                string ssQuery = "DELETE FROM HFACTURA WHERE FACTURA ='" + numFactura + "'";
                SqlCommand cms = new SqlCommand(ssQuery, cns);
                cms.ExecuteNonQuery();

                SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open();
                string tsQuery = "DELETE FROM DFACTURA WHERE FACTURA ='" + numFactura + "'";
                SqlCommand cmd = new SqlCommand(tsQuery, cnx);
                cmd.ExecuteNonQuery();
            }
        }

        private void BuscarFactura(string nmrFactura)
        {
            ExisteData = false;

            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open();
            string tsQuery = "SELECT A.FACTURA, " +
                            "   A.CLIENTE,          " +
                            "   A.FECHA,            " +
                            "   A.SUBTOTAL,         " +
                            "   A.IMPUESTO,         " +
                            "   A.MONTOFACTURADO,   " +
                            "   B.NOMBRE,           " +
                            "   B.PAGAIMPUESTO      " +
                            "   FROM HFACTURA A INNER JOIN CLIENTES B ON A.CLIENTE = B.IDCLIENTE " +
                            "   WHERE A.FACTURA = '" + nmrFactura + "'" +
                            "   AND A.ACTIVO = 0";

            SqlCommand cmd = new SqlCommand(tsQuery, cnx);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                ExisteData = true;

                lblFactura.Text = Convert.ToString(rdr["FACTURA"]);
                lblFechaFactura.Text = Convert.ToString(rdr["FECHA"]);
                txtCliente.Text = Convert.ToString(rdr["CLIENTE"]);

                lblPagaImpuesto.Text = Convert.ToString(rdr["PAGAIMPUESTO"]);
                lblNombre.Text = Convert.ToString(rdr["NOMBRE"]);

                lblSubTotal.Text = Convert.ToString(rdr["SUBTOTAL"]);
                lblImpuesto.Text = Convert.ToString(rdr["IMPUESTO"]);
                lblTotal.Text = Convert.ToString(rdr["MONTOFACTURADO"]);

                BuscaDetalle(lblFactura.Text);

                TotalizarFactura();
            }

            cmd.Dispose();
            cnx.Close();

        }

        private void BuscaDetalle(string nmrFactura)
        {
            this.dgv.Rows.Clear(); // Limpia el datagridview
            this.dgv.Refresh(); // Refresca y le devuelve las especificaciones anteriores

            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open();

            string stQuery = "SELECT A.ARTICULO,    " +
                            "   B.DESCRIPCION,      " +
                            "   A.CANTIDAD,         " +
                            "   A.PRECIODEVENTA,    " +
                            "   A.IMPUESTO,         " +
                            "   A.MONTOPORLINEA,    " +
                            "   FROM DFACTURA A INNER JOIN PRODUCTOS B ON A.ARTICULO = B.ITEM " +
                            "   WHERE A.FACTURA ='" + nmrFactura +
                            "'  ORDER BY A.FACTURA, A.SECUENCIA ASC";

            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader();

            while (rcd.Read())
            {
                dgv.Rows.Add(); // Le suma uno al contador del datagridview
                int xRows = dgv.Rows.Count - 1;

                dgv[0, xRows].Value = Convert.ToString(rcd["ARTICULO"]);
                dgv[1, xRows].Value = Convert.ToString(rcd["DESCRIPCION"]);
                dgv[2, xRows].Value = Convert.ToString(rcd["CANTIDAD"]);
                dgv[3, xRows].Value = Convert.ToString(rcd["PRECIODEVENTA"]);
                dgv[4, xRows].Value = Convert.ToString(rcd["IMPUESTO"]);
                dgv[5, xRows].Value = Convert.ToString(rcd["MONTOPORLINEA"]);
            }
        }

        private void ActualizaSecuenciaFactura()
        {
            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open();

            string upQuery = "UPDATE SECUENCIA " +
                             "  SET ULTIMO   ='" + lblFactura.Text +
                             "' FROM SECUENCIA " +
                             " WHERE ID = '1'  " ;

            SqlCommand cmd = new SqlCommand(upQuery, cnx);
            cmd.ExecuteNonQuery();
        }

        #endregion
    }
}
