namespace Parcial2_AP1.UI.Registros
{
    partial class r
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
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(53, 18);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(165, 22);
            this.IdNumericUpDown.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 18);
            this.label8.TabIndex = 48;
            this.label8.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Fecha";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(371, 18);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.FechaDateTimePicker.TabIndex = 51;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 260);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(559, 221);
            this.DataGridView.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.EliminarButton);
            this.panel1.Controls.Add(this.NuevoButton);
            this.panel1.Controls.Add(this.GuardarButton);
            this.panel1.Location = new System.Drawing.Point(1, 615);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 50);
            this.panel1.TabIndex = 53;
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
            this.EliminarButton.Location = new System.Drawing.Point(374, 1);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(162, 46);
            this.EliminarButton.TabIndex = 7;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
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
            this.NuevoButton.Location = new System.Drawing.Point(44, 1);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(162, 46);
            this.NuevoButton.TabIndex = 5;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
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
            this.GuardarButton.Location = new System.Drawing.Point(209, 1);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(162, 46);
            this.GuardarButton.TabIndex = 6;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 497);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Total";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(442, 496);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(129, 22);
            this.TotalTextBox.TabIndex = 55;
            // 
            // RemoverButton
            // 
            this.RemoverButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.RemoverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoverButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RemoverButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RemoverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoverButton.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoverButton.Image = global::Parcial2_AP1.Properties.Resources.Eliminar1;
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(12, 487);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(151, 38);
            this.RemoverButton.TabIndex = 56;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = false;
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
            this.BuscarButton.Location = new System.Drawing.Point(234, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(57, 38);
            this.BuscarButton.TabIndex = 47;
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BuscarButton.UseVisualStyleBackColor = false;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // r
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 667);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label8);
            this.Name = "r";
            this.Text = "r";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}