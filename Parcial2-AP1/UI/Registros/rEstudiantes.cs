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
    public partial class rEstudiantes : Form
    {
        public List<CategoriasDetalle> Detalle { get; set; }
        public rEstudiantes()
        {
            InitializeComponent();
            this.Detalle = new List<CategoriasDetalle>();
        }

        private void CargarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            FechaDateTimePicker.Value = DateTime.Now;
            EstudianteTextBox.Text = string.Empty;
            CategoriaComboBox.ResetText();
            CantidadTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            ImporteTextBox.Text = string.Empty;
            TotalTextBox.Text = string.Empty;

            this.Detalle = new List<CategoriasDetalle>();
            CargarGrid();
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();

            estudiante.Id = (int)IdNumericUpDown.Value;
            estudiante.Nombre = EstudianteTextBox.Text;
            estudiante.Fecha = FechaDateTimePicker.Value;
            estudiante.Total = Convert.ToDecimal(TotalTextBox.Text);

            estudiante.CategoriaDetalle = this.Detalle;
            return estudiante;
        }

        private void LlenaCampo(Estudiantes estudiante)
        {
            IdNumericUpDown.Value = estudiante.Id;
            EstudianteTextBox.Text = estudiante.Nombre;
            FechaDateTimePicker.Value = estudiante.Fecha;
            TotalTextBox.Text = Convert.ToString(estudiante.Total);

            this.Detalle = estudiante.CategoriaDetalle;
            CargarGrid();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Estudiantes> Metodos = new RepositorioBase<Estudiantes>();
            Estudiantes estudiante = Metodos.Buscar((int)IdNumericUpDown.Value);

            return (estudiante != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(EstudianteTextBox.Text))
            {
                MyErrorProvider.SetError(EstudianteTextBox, "El campo Estudiante no puede estar vacio");
                EstudianteTextBox.Focus();
                paso = false;
            }

            if (this.Detalle.Count==0)
            {
                MyErrorProvider.SetError(DetalleDataGridView, "Debe agregar al menos una categoria");
                DetalleDataGridView.Focus();
                paso = false;
            }

            return paso;
        }

        private void REstudiantes_Load(object sender, EventArgs e)
        {
            var Lista = new List<Categorias>();
            RepositorioBase<Categorias> Metodos = new RepositorioBase<Categorias>();

            Lista = Metodos.GetList(p => true);

            foreach (var item in Lista)
            {
                CategoriaComboBox.Items.Add(item.Descripcion);
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> Metodos = new RepositorioBase<Estudiantes>();
            Estudiantes estudiante;
            bool paso = false;

            if (!Validar())
                return;

            estudiante = LlenaClase();

            if (IdNumericUpDown.Value == 0)
                paso = Metodos.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Estudiante que no existe!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = EstudiantesBLL.Modificar(estudiante);
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
            RepositorioBase<Estudiantes> Metodos = new RepositorioBase<Estudiantes>();
            int id;
            int.TryParse(Convert.ToString(IdNumericUpDown.Value), out id);

            Limpiar();
            if (Metodos.Buscar(id) != null)
            {
                if (Metodos.Eliminar(id))
                    MessageBox.Show("Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se puede eliminar un estudiante que no existe!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> Metodos = new RepositorioBase<Estudiantes>();
            int id;
            Estudiantes estudiante = new Estudiantes();
            int.TryParse(Convert.ToString(IdNumericUpDown.Value), out id);

            Limpiar();

            estudiante = Metodos.Buscar(id);

            if (estudiante != null)
                LlenaCampo(estudiante);
            else
                MessageBox.Show("Estudiante no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidarDetalle()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(CategoriaComboBox.Text))
            {
                MyErrorProvider.SetError(CategoriaComboBox, "El campo Categoria no puede estar vacio");
                CategoriaComboBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CantidadTextBox.Text) || Convert.ToInt32(CantidadTextBox.Text) < 0)
            {
                MyErrorProvider.SetError(CantidadTextBox, "Campo Invalido");
                CantidadTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(PrecioTextBox.Text) || Convert.ToDecimal(PrecioTextBox.Text) < 0)
            {
                MyErrorProvider.SetError(PrecioTextBox, "Campo Invalido");
                PrecioTextBox.Focus();
                paso = false;
            }

            return paso;
        }
        private void AgregarDetalleButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.DataSource != null)
                this.Detalle = (List<CategoriasDetalle>)DetalleDataGridView.DataSource;

            if (!ValidarDetalle())
                return;

            this.Detalle.Add(
                new CategoriasDetalle(
                    categoriaID: (int)IdNumericUpDown.Value,
                    nombre: CategoriaComboBox.Text,
                    cantidad: Convert.ToInt32(CantidadTextBox.Text),
                    precio: Convert.ToDecimal(PrecioTextBox.Text),
                    importe: (Convert.ToInt32(CantidadTextBox.Text) * Convert.ToDecimal(PrecioTextBox.Text))
                    )
                );           
            CargarGrid();
            CategoriaComboBox.Focus();
            CategoriaComboBox.Text = string.Empty;
            TotalTextBox.Text = Convert.ToString(CategoriasDetalleBLL.CalcularTotal());

            CantidadTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }
    }
}
