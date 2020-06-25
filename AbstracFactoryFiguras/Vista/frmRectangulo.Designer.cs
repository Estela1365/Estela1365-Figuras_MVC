namespace AbstracFactoryFiguras.Vista
{
    partial class frmRectangulo
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
            this.labelAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPerR = new System.Windows.Forms.Label();
            this.labelAreaR = new System.Windows.Forms.Label();
            this.labelDecripcion = new System.Windows.Forms.Label();
            this.labelPerimetro = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.labelBase = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltura.Location = new System.Drawing.Point(110, 87);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(47, 15);
            this.labelAltura.TabIndex = 54;
            this.labelAltura.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(163, 85);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(143, 20);
            this.txtAltura.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Descripción ::";
            // 
            // labelPerR
            // 
            this.labelPerR.AutoSize = true;
            this.labelPerR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerR.Location = new System.Drawing.Point(112, 187);
            this.labelPerR.Name = "labelPerR";
            this.labelPerR.Size = new System.Drawing.Size(84, 15);
            this.labelPerR.TabIndex = 51;
            this.labelPerR.Text = "Perimetro ::";
            // 
            // labelAreaR
            // 
            this.labelAreaR.AutoSize = true;
            this.labelAreaR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAreaR.Location = new System.Drawing.Point(112, 158);
            this.labelAreaR.Name = "labelAreaR";
            this.labelAreaR.Size = new System.Drawing.Size(49, 15);
            this.labelAreaR.TabIndex = 50;
            this.labelAreaR.Text = "Area ::";
            // 
            // labelDecripcion
            // 
            this.labelDecripcion.AutoSize = true;
            this.labelDecripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecripcion.Location = new System.Drawing.Point(226, 223);
            this.labelDecripcion.Name = "labelDecripcion";
            this.labelDecripcion.Size = new System.Drawing.Size(43, 15);
            this.labelDecripcion.TabIndex = 49;
            this.labelDecripcion.Text = ".........";
            // 
            // labelPerimetro
            // 
            this.labelPerimetro.AutoSize = true;
            this.labelPerimetro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerimetro.Location = new System.Drawing.Point(226, 187);
            this.labelPerimetro.Name = "labelPerimetro";
            this.labelPerimetro.Size = new System.Drawing.Size(31, 15);
            this.labelPerimetro.TabIndex = 48;
            this.labelPerimetro.Text = "......";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(226, 158);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(35, 15);
            this.labelArea.TabIndex = 47;
            this.labelArea.Text = ".......";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(163, 111);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(143, 25);
            this.btnCalcular.TabIndex = 46;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBase.Location = new System.Drawing.Point(110, 52);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(39, 15);
            this.labelBase.TabIndex = 45;
            this.labelBase.Text = "Base";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(163, 50);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(143, 20);
            this.txtBase.TabIndex = 44;
            // 
            // frmRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 289);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPerR);
            this.Controls.Add(this.labelAreaR);
            this.Controls.Add(this.labelDecripcion);
            this.Controls.Add(this.labelPerimetro);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.txtBase);
            this.Name = "frmRectangulo";
            this.Text = "frmRectangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAltura;
        public System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPerR;
        private System.Windows.Forms.Label labelAreaR;
        public System.Windows.Forms.Label labelDecripcion;
        public System.Windows.Forms.Label labelPerimetro;
        public System.Windows.Forms.Label labelArea;
        public System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label labelBase;
        public System.Windows.Forms.TextBox txtBase;
    }
}