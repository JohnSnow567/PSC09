using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSC09
{
    public partial class frmVenFactura2 : Form
    {
        public string var1;
        public string var2;
        public string var3;
        public Boolean existeVar;
        public frmVenFactura2()
        {
            InitializeComponent();
            EstiloDataGridView();
        }

        private void frmVenFactura2_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void frmVenFactura2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        //---------------------------------------
        // TEXTBOX Y BOTONES
        //---------------------------------------
        #region Textbox y Botones
        private void btnSelecciona_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                var1 = dgv.CurrentRow.Cells[0].Value.ToString(); // FACTURA
                var2 = dgv.CurrentRow.Cells[1].Value.ToString(); // FECHA
                var3 = dgv.CurrentRow.Cells[2].Value.ToString(); // MONTO

                existeVar = true;
                this.Close();

            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecciona.PerformClick();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void btnBuscar_Leave(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtBuscar.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    btnBuscar.Focus();  // movera el cursor hacia el textbox Departamento
                }
            }
        }

        #endregion
        //---------------------------------------
        //   METODOS
        //---------------------------------------
        #region Metodos

        private void EstiloDataGridView()
        {
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = true;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("Col00", "IdCliente");
            this.dgv.Columns.Add("Col01", "Nombre");
            this.dgv.Columns.Add("Col02", "PagaImpuesto");

            DataGridViewColumn
            column = dgv.Columns[00]; column.Width = 100;
            column = dgv.Columns[01]; column.Width = 100;
            column = dgv.Columns[02]; column.Width = 150;

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

        private void BuscarData()
        {

            existeVar = false;
            this.dgv.Rows.Clear();
            this.dgv.Refresh();


            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();

            string stQuery = "SELECT IDCLIENTE, NOMBRE, PAGAIMPUESTO " +
                             " FROM CLIENTES " +
                             " WHERE NOMBRE LIKE  '%" + txtBuscar.Text + "%' ORDER BY NOMBRE ASC";

            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader();

            while (rcd.Read())
            {
                dgv.Rows.Add(); // Le suma otro al contador del datagridview
                int xRows = dgv.Rows.Count - 1;

                dgv[0, xRows].Value = rcd["IDCLIENTE"].ToString();
                dgv[1, xRows].Value = rcd["NOMBRE"].ToString();
                dgv[2, xRows].Value = rcd["PAGAIMPUESTO"].ToString();
            }
            cmd.Dispose();
            cnx.Close();
        }

        #endregion
    }
}
