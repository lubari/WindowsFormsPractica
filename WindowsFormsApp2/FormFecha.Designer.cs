namespace WindowsFormsApp2
{
    partial class FormFecha
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
            this.dtpPrueba1 = new System.Windows.Forms.DateTimePicker();
            this.mcPrueba2 = new System.Windows.Forms.MonthCalendar();
            this.btnPrueba1 = new System.Windows.Forms.Button();
            this.btnPrueba2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpPrueba1
            // 
            this.dtpPrueba1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpPrueba1.Location = new System.Drawing.Point(182, 125);
            this.dtpPrueba1.Name = "dtpPrueba1";
            this.dtpPrueba1.Size = new System.Drawing.Size(248, 20);
            this.dtpPrueba1.TabIndex = 0;
            this.dtpPrueba1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // mcPrueba2
            // 
            this.mcPrueba2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mcPrueba2.Location = new System.Drawing.Point(182, 188);
            this.mcPrueba2.Name = "mcPrueba2";
            this.mcPrueba2.TabIndex = 1;
            // 
            // btnPrueba1
            // 
            this.btnPrueba1.Location = new System.Drawing.Point(497, 122);
            this.btnPrueba1.Name = "btnPrueba1";
            this.btnPrueba1.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba1.TabIndex = 2;
            this.btnPrueba1.Text = "Prueba 1";
            this.btnPrueba1.UseVisualStyleBackColor = true;
            this.btnPrueba1.Click += new System.EventHandler(this.btnPrueba1_Click);
            // 
            // btnPrueba2
            // 
            this.btnPrueba2.Location = new System.Drawing.Point(502, 197);
            this.btnPrueba2.Name = "btnPrueba2";
            this.btnPrueba2.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba2.TabIndex = 3;
            this.btnPrueba2.Text = "Prueba 2";
            this.btnPrueba2.UseVisualStyleBackColor = true;
            // 
            // FormFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrueba2);
            this.Controls.Add(this.btnPrueba1);
            this.Controls.Add(this.mcPrueba2);
            this.Controls.Add(this.dtpPrueba1);
            this.Name = "FormFecha";
            this.Text = "FormFecha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPrueba1;
        private System.Windows.Forms.MonthCalendar mcPrueba2;
        private System.Windows.Forms.Button btnPrueba1;
        private System.Windows.Forms.Button btnPrueba2;
    }
}