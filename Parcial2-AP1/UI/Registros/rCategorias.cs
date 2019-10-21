using Parcial2_AP1.BLL;
using Parcial2_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_AP1.UI.Registros
{
    public partial class rCategorias : Form
    {
        public rCategorias()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }

        private Categorias LlenaClase()
        {
            Categorias categoria = new Categorias();

            categoria.CategoriaID = (int)IdNumericUpDown.Value;
            categoria.Descripcion = DescripcionTextBox.Text;

            return categoria;
        }

        private void LlenaCampo(Categorias categoria)
        {
            IdNumericUpDown.Value = categoria.CategoriaID;
            DescripcionTextBox.Text = categoria.Descripcion;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Categorias> Metodos = new RepositorioBase<Categorias>();
            Categorias categoria = Metodos.Buscar((int)IdNumericUpDown.Value);

            return (categoria != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El campo Descripcion no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> Metodos = new RepositorioBase<Categorias>();
            Categorias categoria;
            bool paso = false;

            if (!Validar())
                return;

            categoria = LlenaClase();

            if (IdNumericUpDown.Value == 0)
                paso = Metodos.Guardar(categoria);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una categoria que no existe!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = Metodos.Modificar(categoria);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            RepositorioBase<Categorias> Metodos = new RepositorioBase<Categorias>();
            int id;
            int.TryParse(Convert.ToString(IdNumericUpDown.Value), out id);

            Limpiar();
            if (Metodos.Buscar(id) != null)
            {
                if (Metodos.Eliminar(id))
                    MessageBox.Show("Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se puede eliminar una categoria que no existe!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> Metodos = new RepositorioBase<Categorias>();
            int id;
            Categorias categoria = new Categorias();
            int.TryParse(Convert.ToString(IdNumericUpDown.Value), out id);

            Limpiar();

            categoria = Metodos.Buscar(id);

            if (categoria != null)
                LlenaCampo(categoria);
            else
                MessageBox.Show("Categoria no encontrada", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
