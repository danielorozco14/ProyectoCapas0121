using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Negocio;

namespace Biblioteca.Presentacion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void errorMessage(string mssg)
        {
            MessageBox.Show(mssg, "Biblioteca - Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void okayMessage(string mssg)
        {
            MessageBox.Show(mssg, "Biblioteca - Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool formIsEmpty()
        {
            int cont = 0;
            if (txtBoxEmail.Text == string.Empty)
            {
                errorProvider1.SetError(txtBoxEmail, "Ingrese un correo valido");
                cont++;
            }
            if (txtBoxPassw.Text == string.Empty)
            {
                errorProvider2.SetError(txtBoxPassw, "Ingrese su contraseña");
                cont++;
            }

            if (cont > 0) return true;

            return false;
        }

        private void clean()
        {
            txtBoxEmail.Clear();
            errorProvider1.SetError(txtBoxEmail, "");

            txtBoxPassw.Clear();
            errorProvider2.SetError(txtBoxPassw, "");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.formIsEmpty())
                {
                    string email = Convert.ToString(txtBoxEmail.Text.Trim());
                    string password = Convert.ToString(txtBoxPassw.Text.Trim());

                    DataTable response = new DataTable();
                    response = PersonaService.login(email, password);

                    if(response.Rows.Count > 0)
                    {
                        if (Convert.ToBoolean(response.Rows[0][4]))
                        {
                            MainForm mainForm = new MainForm();
                            
                            int idUsuario = Convert.ToInt32(response.Rows[0][0]);
                            int idRol = Convert.ToInt32(response.Rows[0][1]);
                            string rol = Convert.ToString(response.Rows[0][2]);
                            string nombre = Convert.ToString(response.Rows[0][3]);

                            if (rol.Equals("Profesor"))
                            {
                                this.Hide();
                                mainForm.isProfesor(nombre);
                                mainForm.Show();
                            }
                            else if (rol.Equals("Administrador"))
                            {
                                this.Hide();
                                mainForm.isAdmin(nombre);
                                mainForm.Show();
                            }
                            else
                            {
                                this.errorMessage("Hubo un erroor");
                            }
                            //bool estado = Convert.ToBoolean(response.Rows[0][4]);
                        }
                        else
                        {
                            this.errorMessage("Hubo un error");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Las credenciales ingresadas son incorrectas", "Biblioteca - Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    this.errorMessage("Ingrese sus credenciales completas");
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
