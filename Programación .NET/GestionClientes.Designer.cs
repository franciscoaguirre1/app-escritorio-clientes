namespace Programación_.NET
{
    partial class GestionClientes
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
            listClientes = new ListBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtTarjetaDeCredito = new TextBox();
            Nombre = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(33, 24);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(234, 289);
            listClientes.TabIndex = 0;
            listClientes.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(603, 290);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(192, 342);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 111);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Apellido:";
            label2.Click += label2_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(450, 108);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(228, 23);
            txtApellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 162);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 8;
            label3.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(450, 159);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(228, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 228);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 10;
            label4.Text = "Tarjeta de Crédito:";
            // 
            // txtTarjetaDeCredito
            // 
            txtTarjetaDeCredito.Location = new Point(450, 225);
            txtTarjetaDeCredito.Name = "txtTarjetaDeCredito";
            txtTarjetaDeCredito.Size = new Size(228, 23);
            txtTarjetaDeCredito.TabIndex = 9;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(375, 57);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(54, 15);
            Nombre.TabIndex = 12;
            Nombre.Text = "Nombre:";
            Nombre.Click += label2_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(450, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 23);
            txtNombre.TabIndex = 11;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 450);
            Controls.Add(Nombre);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(txtTarjetaDeCredito);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(listClientes);
            Name = "GestionClientes";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listClientes;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtTarjetaDeCredito;
        private Label Nombre;
        private TextBox txtNombre;
    }
}