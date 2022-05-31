namespace JuliaGonzalez34
{
    partial class Form1
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
            this.CompradorLbl = new System.Windows.Forms.Label();
            this.ListaProductosLbl = new System.Windows.Forms.Label();
            this.Comprador1TxtBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.EurosLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CompradorLbl
            // 
            this.CompradorLbl.AutoSize = true;
            this.CompradorLbl.Location = new System.Drawing.Point(468, 49);
            this.CompradorLbl.Name = "CompradorLbl";
            this.CompradorLbl.Size = new System.Drawing.Size(83, 20);
            this.CompradorLbl.TabIndex = 0;
            this.CompradorLbl.Text = "comprador";
            // 
            // ListaProductosLbl
            // 
            this.ListaProductosLbl.AutoSize = true;
            this.ListaProductosLbl.Location = new System.Drawing.Point(468, 90);
            this.ListaProductosLbl.Name = "ListaProductosLbl";
            this.ListaProductosLbl.Size = new System.Drawing.Size(151, 20);
            this.ListaProductosLbl.TabIndex = 1;
            this.ListaProductosLbl.Text = "lista de los productos";
            // 
            // Comprador1TxtBox
            // 
            this.Comprador1TxtBox.Location = new System.Drawing.Point(625, 42);
            this.Comprador1TxtBox.Name = "Comprador1TxtBox";
            this.Comprador1TxtBox.Size = new System.Drawing.Size(151, 27);
            this.Comprador1TxtBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JuliaGonzalez34.Properties.Resources.Consum_Cooperativa;
            this.pictureBox1.Location = new System.Drawing.Point(59, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Añadir producto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Añadir a la lista de la compra";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Location = new System.Drawing.Point(384, 263);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(50, 20);
            this.TotalLbl.TabIndex = 7;
            this.TotalLbl.Text = "TOTAL";
            // 
            // EurosLbl
            // 
            this.EurosLbl.AutoSize = true;
            this.EurosLbl.Location = new System.Drawing.Point(561, 263);
            this.EurosLbl.Name = "EurosLbl";
            this.EurosLbl.Size = new System.Drawing.Size(25, 20);
            this.EurosLbl.TabIndex = 8;
            this.EurosLbl.Text = "0€";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(625, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 104);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.EurosLbl);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Comprador1TxtBox);
            this.Controls.Add(this.ListaProductosLbl);
            this.Controls.Add(this.CompradorLbl);
            this.Name = "Form1";
            this.Text = "Hola soy el TPV rey";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CompradorLbl;
        private Label ListaProductosLbl;
        private TextBox Comprador1TxtBox;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label TotalLbl;
        private Label EurosLbl;
        private ListBox listBox1;
    }
}