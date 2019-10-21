namespace Parcial2_AP1.UI.Registros
{
    partial class rCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.EliminarButton);
            this.panel1.Controls.Add(this.NuevoButton);
            this.panel1.Controls.Add(this.GuardarButton);
            this.panel1.Location = new System.Drawing.Point(3, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 50);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "ID Categoria";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(133, 79);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(362, 24);
            this.DescripcionTextBox.TabIndex = 33;
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(133, 35);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(165, 22);
            this.IdNumericUpDown.TabIndex = 46;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BuscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BuscarButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BuscarButton.Image = global::Parcial2_AP1.Properties.Resources.ConsultaBlanco;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(321, 29);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(177, 33);
            this.BuscarButton.TabIndex = 8;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BuscarButton.UseVisualStyleBackColor = false;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EliminarButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarButton.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EliminarButton.Image = global::Parcial2_AP1.Properties.Resources.Eliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(331, 1);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(162, 46);
            this.EliminarButton.TabIndex = 7;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NuevoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NuevoButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NuevoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoButton.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NuevoButton.Image = global::Parcial2_AP1.Properties.Resources.Nuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(2, 1);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(162, 46);
            this.NuevoButton.TabIndex = 5;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GuardarButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.GuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarButton.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GuardarButton.Image = global::Parcial2_AP1.Properties.Resources.Guardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(167, 1);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(162, 46);
            this.GuardarButton.TabIndex = 6;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // rCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 186);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "rCategorias";
            this.Text = "Registro de Categorias";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}