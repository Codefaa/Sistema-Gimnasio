using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidad_BE;
using Negocio_BLL;
using Seguridad;
using System.Text.RegularExpressions;

namespace Presentacion_UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            BEunLogin = new BELogin();
            BLLunLogin = new BLLLogin();
            encriptar = new Encriptar();
        }

        BELogin BEunLogin;
        BLLLogin BLLunLogin;
        Encriptar encriptar;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool respuesta1 = Regex.IsMatch(txtUsuario.Text, "^([A-Z]{1}[a-z]+)");
                bool respuesta2 = Regex.IsMatch(txtContraseña.Text, "^([a-z]+[0-9]+)");

                if(respuesta1 == false || respuesta2 == false)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {
                    BEunLogin = new BELogin(txtUsuario.Text, encriptar.GenerarMD5(txtContraseña.Text));

                    if (BLLunLogin.Logear(BEunLogin) == 1)
                    {
                        this.Hide();

                        frmMenu abrir = new frmMenu();
                        abrir.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecto");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
