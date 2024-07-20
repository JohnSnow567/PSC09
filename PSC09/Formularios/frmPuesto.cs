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
    // Jonathan Martinez 2023-1417

    public partial class frmPuesto : Form
    {
        Boolean ExisteData;
        public frmPuesto()
        {
            InitializeComponent();
        }

        private void frmPuesto_Load(object sender, EventArgs e)
        {
            this.Text = "Maestro de Puesto de trabajo";
            this.KeyPreview = true;
        }

        private void frmPuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }

        // ------------------------------------------------------
        // TEXTBOX
        // ------------------------------------------------------

        private void txtPosicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtPosicion.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtNombre.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtPosicion_Leave(object sender, EventArgs e)
        {
            if (txtPosicion.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                BuscarPosicion(txtPosicion.Text);    // viaja hacia el metodo y le envia el valor contenido en el textbox
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtNombre.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtDepartamento.Focus();  // movera el cursor hacia el textbox Departamento
                }
            }
        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtDepartamento.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtFabrica.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtDepartamento_Leave(object sender, EventArgs e)
        {
            if (txtDepartamento.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                departamento(txtDepartamento.Text);  // viaja hacia el metodo y le envia el valor contenido en el textbox
            }
        }

        private void txtFabrica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtFabrica.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    btnGuardar.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtFabrica_Leave(object sender, EventArgs e)
        {
            if (txtFabrica.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                fabrica(txtFabrica.Text);  // viaja hacia el metodo y le envia el valor contenido en el textbox
            }
        }


        // ------------------------------------------------------
        // BOTONES
        // ------------------------------------------------------

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtPosicion.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (ExisteData == false)
            {
                BorrarData(txtPosicion.Text);
                LimpiarFormulario();
                txtPosicion.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------------------------------------
        // METODOS
        //------------------------------------------------------
        private void LimpiarFormulario()
        {
            txtDepartamento.Clear();
            txtFabrica.Clear();
            txtNombre.Clear();
            txtPosicion.Clear();

            lblDepartamento.Text = "";
            lblFabrica.Text = "";

            ExisteData = false;
        }

        private void BuscarPosicion(string numPuesto)
        {
            ExisteData = false;

            string miQuery = "SELECT T1.NOMBREDEPOSICION, " +
                "T1.FABRICA, " +
                "T1.DEPARTAMENTO, " +
                "T2.NOMBREDEFABRICA, " +
                "T3.NOMBREDEPARTAMENTO " +
                "FROM POSICIONES T1 " +
                "INNER JOIN FABRICA T2 ON T1.FABRICA = T2.IDFABRICA " +
                "INNER JOIN DEPARTAMENTO T3 ON T1.DEPARTAMENTO = T3.IDDEPARTAMENTO " +
                "WHERE T1.IDPOSICION ='" + numPuesto + "'";

            SqlConnection cxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cxn.Open();   // abrimos la base de datos

            SqlCommand cmd = new SqlCommand(miQuery, cxn);  // aqui enviamos el script al motor de SQL
            SqlDataReader rdr = cmd.ExecuteReader();  // ejecutamos el script enviado

            if (rdr.Read())  // aqui va a preguntar si trajo registro
            {
                txtNombre.Text = rdr["NOMBREDEPOSICION"].ToString();
                txtDepartamento.Text = rdr["FABRICA"].ToString();
                txtFabrica.Text = rdr["DEPARTAMENTO"].ToString();
                lblFabrica.Text = rdr["NOMBREDEFABRICA"].ToString();
                lblDepartamento.Text = rdr["NOMBREDEPARTAMENTO"].ToString();
            }
        }
        private void departamento(string numDepto)
        {
            string miQuery = "SELECT nombredepartamento FROM DEPARTAMENTO WHERE IDDEPARTAMENTO = @A1";

            SqlConnection cxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cxn.Open();   // abrimos la base de datos

            
            SqlCommand cmd = new SqlCommand(miQuery, cxn);  // aqui enviamos el script al motor de SQL
            cmd.Parameters.AddWithValue("@A1", numDepto);
            SqlDataReader rdr = cmd.ExecuteReader();  // ejucatamos el script enviado

            if (rdr.Read()) // aqui va a preguntar si trajo registro
            {
                lblDepartamento.Text = rdr[""].ToString();
            } 
        }

        private void fabrica(string numFabrica)
        {
            string miQuery = "SELECT NOMBREFABRICA FROM FABRICA WHERE IDFABRICA = @A1";

            SqlConnection cxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cxn.Open();   // abrimos la base de datos


            SqlCommand cmd = new SqlCommand(miQuery, cxn);  // aqui enviamos el script al motor de SQL
            cmd.Parameters.AddWithValue("@A1", numFabrica);
            SqlDataReader rdr = cmd.ExecuteReader();  // ejucatamos el script enviado

            if (rdr.Read()) // aqui va a preguntar si trajo registro
            {
                lblFabrica.Text = rdr[""].ToString();
            }
        }

        private void InsertData()
        {
            //----------------------------------------------------
            // BORRA SI EL REGISTRO EXISTE
            //----------------------------------------------------

            SqlConnection cxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cxn.Open();   // abrimos la base de datos

            string miQuery = "DELETE FROM POSICIONES WHERE IDPOSICION ='" + txtPosicion.Text + "'";
            SqlCommand cdm = new SqlCommand(miQuery, cxn);
            cdm.ExecuteNonQuery();
            cxn.Close();

            //----------------------------------------------------
            // INSERTA LA DATA A LA TABLA
            //----------------------------------------------------

            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open(); // abrimos la base de datos

            string imQuery = "INSERT INTO POSICIONES (IDPOSICION, NOMBREDEPOSICION, DEPARTAMENTO, FABRICA, ESTATUS) " +
                " VALUES (@A0, @A1, @A2, @A3, 1)";

            SqlCommand cmd = new SqlCommand(imQuery, cnx);
            cmd.Parameters.AddWithValue("@A0", txtPosicion.Text); //Declaramos las variables y les asignamos un valor por medio del textbox
            cmd.Parameters.AddWithValue("@A1", txtNombre.Text);
            cmd.Parameters.AddWithValue("@A2", txtDepartamento.Text);
            cmd.Parameters.AddWithValue("@A3", txtFabrica.Text);
           

            cmd.ExecuteNonQuery(); // Este comando ejecutara el script, debe tomar en cuenta que se utiliza ExecuteNonQuery solo
                                   // para realizar insert, delete y update
        }

        private void BuscarData(string nData)
        {
            ExisteData = false;

            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();

            string miQuery = " SELECT A.IDPOSICION," +
                "A.NOMBREDEPOSICION, " +
                "A.DEPARTAMENTO, " +
                "A.FABRICA, " +
                "B.NOMBREDEPARTAMENTO, " +
                "C.NOMBREDEFABRICA, " +
                "A.ESTATUS, " +
                "FROM POSICIONES A " +
                "INNER JOIN DEPARTAMENTO B ON A.DEPARTAMENTO = B.IDDEPARTAMENTO " +
                "INNER JOIN FABRICA C ON A.FABRICA = C.IDFABRICA " +
                " WHERE A.ESTATUS = 1 " +
                "AND A.IDPOSICION ='" + nData + "'";

            SqlCommand cmd = new SqlCommand(miQuery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader();

            if (rcd.Read())
            {
                ExisteData = true;

                txtNombre.Text = Convert.ToString(rcd["NOMBREDEPOSICION"]);
                txtDepartamento.Text = Convert.ToString(rcd["DEPARTAMENTO"]);
                txtFabrica.Text = Convert.ToString(rcd["FABRICA"]);
                lblFabrica.Text = Convert.ToString(rcd["NOMBREDEFABRICA"]);
                lblDepartamento.Text = Convert.ToString(rcd["NOMBREDEPARTAMENTO"]);

            }
        }

        private void BorrarData(string numpos)
        {
            SqlConnection cxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cxn.Open();   // abrimos la base de datos

            string stQuery = "DELETE FROM POSICIONES WHERE IDPOSICION ='" + numpos + "'";
            SqlCommand cdm = new SqlCommand(stQuery, cxn);
            cdm.ExecuteNonQuery();
            cxn.Close();
        }
    }

}
