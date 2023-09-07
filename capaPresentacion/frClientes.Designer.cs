namespace capaPresentacion
{
    partial class frClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            picFoto = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 58);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 115);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 171);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(59, 232);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkFoto";
            // 
            // txtId
            // 
            txtId.Location = new Point(147, 55);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(147, 173);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(165, 23);
            txtApellido.TabIndex = 6;
            // 
            // picFoto
            // 
            picFoto.BackColor = SystemColors.ControlDarkDark;
            picFoto.Location = new Point(146, 228);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(166, 131);
            picFoto.TabIndex = 7;
            picFoto.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "ofDialog";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(63, 391);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(185, 391);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(318, 391);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 438);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(picFoto);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frClientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private PictureBox picFoto;
        private OpenFileDialog openFileDialog1;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnGuardar;
    }
}