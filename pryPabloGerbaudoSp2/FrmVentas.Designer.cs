namespace pryPabloGerbaudoSp2
{
    partial class FrmVentas
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
            dtpFechaTicket = new DateTimePicker();
            txtNroTicket = new TextBox();
            cmbTipo = new ComboBox();
            btnRegistrar = new Button();
            lstVentas = new ListBox();
            lblTitulo = new Label();
            lblFecha = new Label();
            lblNumeroTicket = new Label();
            llblTipoTicket = new Label();
            SuspendLayout();
            // 
            // dtpFechaTicket
            // 
            dtpFechaTicket.Format = DateTimePickerFormat.Short;
            dtpFechaTicket.Location = new Point(140, 68);
            dtpFechaTicket.Name = "dtpFechaTicket";
            dtpFechaTicket.Size = new Size(148, 23);
            dtpFechaTicket.TabIndex = 0;
            // 
            // txtNroTicket
            // 
            txtNroTicket.Location = new Point(140, 111);
            txtNroTicket.Name = "txtNroTicket";
            txtNroTicket.Size = new Size(148, 23);
            txtNroTicket.TabIndex = 1;
            txtNroTicket.TextChanged += txtNroTicket_TextChanged;
            txtNroTicket.KeyPress += txtNroTicket_KeyPress;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Enabled = false;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Básico", "Estándar", "Premium" });
            cmbTipo.Location = new Point(140, 151);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(148, 23);
            cmbTipo.TabIndex = 2;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(91, 195);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(142, 35);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lstVentas
            // 
            lstVentas.FormattingEnabled = true;
            lstVentas.Location = new Point(-2, 300);
            lstVentas.Name = "lstVentas";
            lstVentas.Size = new Size(533, 154);
            lstVentas.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(60, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(286, 37);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Generación de Ticket";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(12, 74);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(92, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha de Ticket:";
            // 
            // lblNumeroTicket
            // 
            lblNumeroTicket.AutoSize = true;
            lblNumeroTicket.Location = new Point(12, 114);
            lblNumeroTicket.Name = "lblNumeroTicket";
            lblNumeroTicket.Size = new Size(105, 15);
            lblNumeroTicket.TabIndex = 7;
            lblNumeroTicket.Text = "Número de Ticket:";
            // 
            // llblTipoTicket
            // 
            llblTipoTicket.AutoSize = true;
            llblTipoTicket.Location = new Point(12, 154);
            llblTipoTicket.Name = "llblTipoTicket";
            llblTipoTicket.Size = new Size(85, 15);
            llblTipoTicket.TabIndex = 8;
            llblTipoTicket.Text = "Tipo de Ticket:";
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 450);
            Controls.Add(llblTipoTicket);
            Controls.Add(lblNumeroTicket);
            Controls.Add(lblFecha);
            Controls.Add(lblTitulo);
            Controls.Add(lstVentas);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbTipo);
            Controls.Add(txtNroTicket);
            Controls.Add(dtpFechaTicket);
            Name = "FrmVentas";
            Text = "Frmventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaTicket;
        private TextBox txtNroTicket;
        private ComboBox cmbTipo;
        private Button btnRegistrar;
        private ListBox lstVentas;
        private Label lblTitulo;
        private Label lblFecha;
        private Label lblNumeroTicket;
        private Label llblTipoTicket;
    }
}
