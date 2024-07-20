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
using PSC09;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices.ComTypes;
using iTextSharp.text.pdf;

namespace PSC09
{

    public partial class frmProducts : Form
    {
        Bitmap bmp;
        private Image imgOriginal;
        PictureBox pb;

        string ruta = @"C:\Users\Admin\Documents\Proyecto Puesto\PSC09\PSC09\Imagenes"; // Crea una copia de la imagen en el directorio seleccionado
        string path = @"C:\Users\Admin\Documents\Proyecto Puesto\PSC09\PSC09\Imagenes\Userphoto.png"; // Selecciona una imagen en caso de que no haya alguna seleccionada
 

        Boolean existedata; // Agregamos existedata
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            this.Text = "Maestro de Producto";
            this.KeyPreview = true;
        }

        private void frmProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
       
        //----------------------------------------------------------------
        // TEXTBOX
        //----------------------------------------------------------------
        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtProducto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtNombre.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (txtProducto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                BuscarData(txtProducto.Text);    // viaja hacia el metodo y le envia el valor contenido en el textbox
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtNombre.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtCantidad.Focus();  // movera el cursor hacia el textbox Departamento
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtCantidad.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtCosto.Focus();  // movera el cursor hacia el textbox Departamento
                }
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtCosto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtPrecio.Focus();  // movera el cursor hacia el textbox Departamento
                }
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtPrecio.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtImpuesto.Focus();  // movera el cursor hacia el textbox Departamento
                }
            }
        }

        private void txtImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtImpuesto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtBarra.Focus();  // movera el cursor hacia el textbox Departamento
                }
            }
        }

        private void txtBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtBarra.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtTieneImpuesto.Focus();  // movera el cursor hacia el textbox Departamento
                }
            }
        }

        private void txtTieneImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtTieneImpuesto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    btnGuardar.Focus();  // movera el cursor hacia el textbox Departamento
                }
            }
        }

        //---------------------------------------------------------------------
        // BOTONES
        //---------------------------------------------------------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                if (txtNombre.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    if (txtCosto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                    {
                        if (txtPrecio.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                        {
                            if (txtImpuesto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                            {
                                if (txtBarra.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                                {
                                    if (existedata == true)  // pregunta que si el textbox es diferente de vacio
                                    {
                                        ActualizaData();
                                        ActualizarFoto(txtProducto.Text);
                                    }

                                    else
                                    {
                                        InsertaData();
                                        ActualizarFoto(txtProducto.Text);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtNombre.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (existedata == true)
            {
                DialogResult dialogResult = MessageBox.Show("Estas seguro(a) que quieres borrar el registro :(", "ITLA", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    BorrarData(txtProducto.Text);
                    LimpiarFormulario();
                    txtProducto.Focus();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            BuscarData(txtProducto.Text);
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "jpg[*.jpg*]|*.jpg|png[*.png]|[*.png]|Todos los Archivos[*.*]|*.*";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != null)
            {
                string imagen = openFileDialog1.FileName; // Aqui asigna a la variable imagen el archivo buscado o elegido por nosotros
                if (imagen == string.Empty || imagen == null) // Aqui pregunta si la variable imagen es diferente de vacio o null
                {
                    imagen = path;
                }

                lblRuta.Text = imagen;

                try
                {
                    System.IO.File.Copy(lblRuta.Text, ruta, true); // Realiza una copia de la imagen en otra ruta
                }

                catch

                {
                    //
                }

                // Asignamos los atributos al pictureBox ( PicImagen )

                bmp = new Bitmap(imagen);
                imgOriginal = Image.FromFile(imagen);

                btnImagen.Image = imgOriginal; // Coloca la imagen al pictureBox


            }

        }

        private void btnProducto_Click_1(object sender, EventArgs e)
        {
            frmVenProducto frm = new frmVenProducto();
            DialogResult res = frm.ShowDialog();

            if (frm.tf == true)
            {
                txtProducto.Text = frm.varf1;

                BuscarData(txtProducto.Text);
            }
        }

        //-------------------------------------------------------------
        // METODOS
        //-------------------------------------------------------------
        private void MostrarImagen(string numProducto)
        {
            btnImagen.Image = null;
            SqlConnection cxn = new SqlConnection(cnn.db);
            cxn.Open();
            SqlCommand cmd = new SqlCommand("SELECT IMAGEN FROM PRODUCTOS WHERE ITEM = '" + numProducto + "'", cxn);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                try
                {
                    btnImagen.Image = ConvertImage.ByteArrayToImage((byte[])rdr["IMAGEN"]);
                }
                catch
                {

                }
            }
        }
        private void ActualizarFoto(string numProducto)
        {
            byte[] byteArrayImagen = ConvertImage.ImageToByteArray(btnImagen.Image);

            SqlConnection cxn = new SqlConnection(cnn.db);
            cxn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE PRODUCTOS SET IMAGEN = @A1 WHERE ITEM = '" + numProducto + "'", cxn);
            cmd.Parameters.AddWithValue("@A1", byteArrayImagen);

            cmd.ExecuteNonQuery();
            cxn.Close();

        }
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtCantidad.Clear();
            txtCosto.Clear();
            txtPrecio.Clear();
            txtImpuesto.Clear();
            txtBarra.Clear();
            txtTieneImpuesto.Clear();

            existedata = false;
        }

        private void BuscarData(string nProd)
        {
            existedata = false;

            SqlConnection cnx = new SqlConnection(cnn.db); // Abrimos la base de datos
            cnx.Open();

            string stQuery = " SELECT ITEM, DESCRIPCION, CANTIDADENEXISTENCIA , PRECIODEVENTA, COSTO, IMPUESTO, TIENEIMPUESTO, BARCODE " +
                " FROM PRODUCTOS " +
                " WHERE ESTATUSPRODUCTO = 1 " +
                " AND ITEM ='" + nProd + "'AND ESTATUSPRODUCTO = 1";

            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader();

            if (rcd.Read())
            {
                existedata = true;

                txtNombre.Text = Convert.ToString(rcd["DESCRIPCION"]);
                txtCantidad.Text = Convert.ToString(rcd["CANTIDADENEXISTENCIA"]);
                txtCosto.Text = Convert.ToString(rcd["COSTO"]);
                txtPrecio.Text = Convert.ToString(rcd["PRECIODEVENTA"]);
                txtImpuesto.Text = Convert.ToString(rcd["IMPUESTO"]);
                txtBarra.Text = Convert.ToString(rcd["BARCODE"]);
                txtTieneImpuesto.Text = Convert.ToString(rcd["TIENEIMPUESTO"]);

                MostrarImagen(txtProducto.Text);

            }

        }
        private void BorrarData(string numProducto)
        {
            SqlConnection cxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cxn.Open();   // abrimos la base de datos

            string stQuery = "UPDATE PRODUCTOS SET ESTATUSPRODUCTO = 3 FROM PRODUCTOS WHERE ITEM = '" + numProducto + "'";
            SqlCommand cdm = new SqlCommand(stQuery, cxn);
            cdm.ExecuteNonQuery();
        }

        private void InsertaData()
        {
            //-----------------------------------------------------------
            // BORRA SI EL REGISTRO EXISTE
            //-----------------------------------------------------------
            SqlConnection cxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cxn.Open();   // abrimos la base de datos

            string tsQuery = "UPDATE PRODUCTOS SET ESTATUSPRODUCTO = 3 FROM PRODUCTOS WHERE ITEM = '" + txtProducto.Text + "'";
            SqlCommand cdm = new SqlCommand(tsQuery, cxn);
            cdm.ExecuteNonQuery();
            cxn.Close();


            SqlConnection cnx = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cnx.Open();   // abrimos la base de datos

            string stQuery = " INSERT INTO PRODUCTOS (ITEM, DESCRIPCION, CANTIDADENEXISTENCIA , COSTO, PRECIODEVENTA, IMPUESTO, BARCODE, TIENEIMPUESTO, ESTATUSPRODUCTO) " +
                " VALUES (@A0, @A1, @A2, @A3, @A4, @A5, @A6, @A7, 1)";

            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            cmd.Parameters.AddWithValue("@A0", txtProducto.Text); // Declaramos la variable y le asignamos valor por medio del textbox
            cmd.Parameters.AddWithValue("@A1", txtNombre.Text);
            cmd.Parameters.AddWithValue("@A2", txtCantidad.Text);
            cmd.Parameters.AddWithValue("@A3", txtCosto.Text);
            cmd.Parameters.AddWithValue("@A4", txtPrecio.Text);
            cmd.Parameters.AddWithValue("@A5", txtImpuesto.Text);
            cmd.Parameters.AddWithValue("@A6", txtBarra.Text);
            cmd.Parameters.AddWithValue("@A7", txtTieneImpuesto.Text);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            cnx.Close();
        }

        private void ActualizaData()
        {
            string tQuery = "UPDATE PRODUCTOS " +
                            "   SET DESCRIPCION          = @A2, " +
                            "       CANTIDADENEXISTENCIA = @A3, " +
                            "       COSTO                = @A4, " +
                            "       PRECIODEVENTA        = @A5, " +
                            "       IMPUESTO             = @A6, " +
                            "       BARCODE              = @A7  " +
                            "       TIENEIMPUESTO        = @A8  " +
                            "  FROM PRODUCTOS " +
                            " WHERE ITEM = @A1";

            SqlConnection cxn = new SqlConnection(cnn.db); cxn.Open();
            SqlCommand cdm = new SqlCommand(tQuery, cxn);

            cdm.Parameters.AddWithValue("@A1", txtProducto.Text);
            cdm.Parameters.AddWithValue("@A2", txtNombre.Text);
            cdm.Parameters.AddWithValue("@A3", txtCantidad.Text);
            cdm.Parameters.AddWithValue("@A4", txtCosto.Text);
            cdm.Parameters.AddWithValue("@A5", txtPrecio.Text);
            cdm.Parameters.AddWithValue("@A6", txtImpuesto.Text);
            cdm.Parameters.AddWithValue("@A7", txtBarra.Text);
            cdm.Parameters.AddWithValue("@A8", txtTieneImpuesto.Text);

            cdm.ExecuteNonQuery();

            cdm.Dispose();
            cxn.Close();
        }

        public enum Code128SubTypes
        {
            CODE128 = iTextSharp.text.pdf.Barcode.CODE128,
            CODE128_RAW = iTextSharp.text.pdf.Barcode.CODE128_RAW,
            CODE128_UCC = iTextSharp.text.pdf.Barcode.CODE128_UCC,

        }

        public static Bitmap Code128(string _code, Code128SubTypes codeType = Code128SubTypes.CODE128, bool printTextInCode = false, float Height = 0, 
            bool GenerateChecksum = true, bool ChecksumText = true)
        {
            if (_code.Trim() == "")
            {
                return null;
            }

            else
            {
                Barcode128 barcode = new Barcode128();

                barcode.CodeType = (int)codeType;
                barcode.StartStopText = true;
                barcode.GenerateChecksum = GenerateChecksum;
                barcode.ChecksumText = ChecksumText;
                if (Height != 0) barcode.BarHeight = Height;
                barcode.Code = _code;
                try
                {
                    System.Drawing.Bitmap bm = new System.Drawing.Bitmap(barcode.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White));
                    if (printTextInCode == false)
                    {
                        return bm;
                    }

                    else
                    {
                        Bitmap bmT;
                        bmT = new Bitmap(bm.Width, bm.Height + 14);
                        Graphics g = Graphics.FromImage(bmT);
                        g.FillRectangle(new SolidBrush(Color.White), 0, 0, bm.Width, bm.Height + 14);

                        Font drawFont = new Font("Arial", 0);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);

                        SizeF stringSize = new SizeF();
                        stringSize = g.MeasureString(_code, drawFont);
                        float xCenter = (bm.Width - stringSize.Width) / 2;
                        float x = xCenter;
                        float y = bm.Height;

                        StringFormat drawFormat = new StringFormat();
                        drawFormat.FormatFlags = StringFormatFlags.NoWrap;

                        g.DrawImage(bm, 0, 0);
                        g.DrawString(_code, drawFont, drawBrush, x, y, drawFormat);

                        return bmT;
                    }
                }

                catch (Exception ex)
                {
                    throw new Exception("error Codigo de Barra Code128, Desc:" + ex.Message);
                }
            }
        }
    }
}
