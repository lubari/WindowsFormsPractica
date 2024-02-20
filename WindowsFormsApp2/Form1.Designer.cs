namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.elementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.lblPerfilPersona = new System.Windows.Forms.Label();
            this.rbtWizard = new System.Windows.Forms.RadioButton();
            this.rbtMuggle = new System.Windows.Forms.RadioButton();
            this.rbtSquibs = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.lblColorFavorito = new System.Windows.Forms.Label();
            this.lblNumeroFavorito = new System.Windows.Forms.Label();
            this.nudNumeroFavorito = new System.Windows.Forms.NumericUpDown();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(147, 68);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(76, 20);
            this.textNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(271, 523);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 19);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // elementos
            // 
            this.elementos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.elementos.HideSelection = false;
            this.elementos.Location = new System.Drawing.Point(54, 434);
            this.elementos.Margin = new System.Windows.Forms.Padding(2);
            this.elementos.Name = "elementos";
            this.elementos.OwnerDraw = true;
            this.elementos.Size = new System.Drawing.Size(182, 80);
            this.elementos.TabIndex = 7;
            this.elementos.UseCompatibleStateImageBehavior = false;
            this.elementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(98, 72);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(51, 113);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(99, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha Nacimiento: ";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(147, 108);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(213, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(147, 150);
            this.ckbChocolate.Margin = new System.Windows.Forms.Padding(2);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(135, 17);
            this.ckbChocolate.TabIndex = 2;
            this.ckbChocolate.Text = "Te gusta el chocolate?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblPerfilPersona
            // 
            this.lblPerfilPersona.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPerfilPersona.AutoSize = true;
            this.lblPerfilPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilPersona.Location = new System.Drawing.Point(48, 9);
            this.lblPerfilPersona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerfilPersona.Name = "lblPerfilPersona";
            this.lblPerfilPersona.Size = new System.Drawing.Size(202, 36);
            this.lblPerfilPersona.TabIndex = 7;
            this.lblPerfilPersona.Text = "Perfil Persona";
            // 
            // rbtWizard
            // 
            this.rbtWizard.AutoSize = true;
            this.rbtWizard.Checked = true;
            this.rbtWizard.Location = new System.Drawing.Point(9, 26);
            this.rbtWizard.Margin = new System.Windows.Forms.Padding(2);
            this.rbtWizard.Name = "rbtWizard";
            this.rbtWizard.Size = new System.Drawing.Size(58, 17);
            this.rbtWizard.TabIndex = 8;
            this.rbtWizard.TabStop = true;
            this.rbtWizard.Text = "Wizard";
            this.rbtWizard.UseVisualStyleBackColor = true;
            // 
            // rbtMuggle
            // 
            this.rbtMuggle.AutoSize = true;
            this.rbtMuggle.Location = new System.Drawing.Point(115, 26);
            this.rbtMuggle.Margin = new System.Windows.Forms.Padding(2);
            this.rbtMuggle.Name = "rbtMuggle";
            this.rbtMuggle.Size = new System.Drawing.Size(60, 17);
            this.rbtMuggle.TabIndex = 9;
            this.rbtMuggle.Text = "Muggle";
            this.rbtMuggle.UseVisualStyleBackColor = true;
            // 
            // rbtSquibs
            // 
            this.rbtSquibs.AutoSize = true;
            this.rbtSquibs.Location = new System.Drawing.Point(218, 26);
            this.rbtSquibs.Margin = new System.Windows.Forms.Padding(2);
            this.rbtSquibs.Name = "rbtSquibs";
            this.rbtSquibs.Size = new System.Drawing.Size(57, 17);
            this.rbtSquibs.TabIndex = 10;
            this.rbtSquibs.Text = "Squibs";
            this.rbtSquibs.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTipo.Controls.Add(this.rbtSquibs);
            this.gbxTipo.Controls.Add(this.rbtMuggle);
            this.gbxTipo.Controls.Add(this.rbtWizard);
            this.gbxTipo.Location = new System.Drawing.Point(137, 194);
            this.gbxTipo.Margin = new System.Windows.Forms.Padding(2);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Padding = new System.Windows.Forms.Padding(2);
            this.gbxTipo.Size = new System.Drawing.Size(313, 58);
            this.gbxTipo.TabIndex = 3;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Location = new System.Drawing.Point(146, 286);
            this.cboColorFavorito.Margin = new System.Windows.Forms.Padding(2);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(92, 21);
            this.cboColorFavorito.TabIndex = 4;
            // 
            // lblColorFavorito
            // 
            this.lblColorFavorito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblColorFavorito.AutoSize = true;
            this.lblColorFavorito.Location = new System.Drawing.Point(71, 289);
            this.lblColorFavorito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColorFavorito.Name = "lblColorFavorito";
            this.lblColorFavorito.Size = new System.Drawing.Size(75, 13);
            this.lblColorFavorito.TabIndex = 13;
            this.lblColorFavorito.Text = "Color Favorito:";
            // 
            // lblNumeroFavorito
            // 
            this.lblNumeroFavorito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumeroFavorito.AutoSize = true;
            this.lblNumeroFavorito.Location = new System.Drawing.Point(56, 341);
            this.lblNumeroFavorito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroFavorito.Name = "lblNumeroFavorito";
            this.lblNumeroFavorito.Size = new System.Drawing.Size(91, 13);
            this.lblNumeroFavorito.TabIndex = 14;
            this.lblNumeroFavorito.Text = "Numero Favorito: ";
            // 
            // nudNumeroFavorito
            // 
            this.nudNumeroFavorito.Location = new System.Drawing.Point(147, 339);
            this.nudNumeroFavorito.Margin = new System.Windows.Forms.Padding(2);
            this.nudNumeroFavorito.Name = "nudNumeroFavorito";
            this.nudNumeroFavorito.Size = new System.Drawing.Size(58, 20);
            this.nudNumeroFavorito.TabIndex = 5;
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnVerPerfil.FlatAppearance.BorderSize = 2;
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.Location = new System.Drawing.Point(374, 377);
            this.btnVerPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(86, 35);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(485, 553);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.nudNumeroFavorito);
            this.Controls.Add(this.lblNumeroFavorito);
            this.Controls.Add(this.lblColorFavorito);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.lblPerfilPersona);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.elementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textNombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(501, 557);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView elementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.Label lblPerfilPersona;
        private System.Windows.Forms.RadioButton rbtWizard;
        private System.Windows.Forms.RadioButton rbtMuggle;
        private System.Windows.Forms.RadioButton rbtSquibs;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.Label lblColorFavorito;
        private System.Windows.Forms.Label lblNumeroFavorito;
        private System.Windows.Forms.NumericUpDown nudNumeroFavorito;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

