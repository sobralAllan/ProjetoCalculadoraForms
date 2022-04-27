
namespace ProjetoCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.subtrair = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.soma = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subtrair
            // 
            this.subtrair.BackColor = System.Drawing.Color.Transparent;
            this.subtrair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subtrair.BackgroundImage")));
            this.subtrair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.subtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtrair.ForeColor = System.Drawing.Color.Transparent;
            this.subtrair.Location = new System.Drawing.Point(188, 95);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(123, 76);
            this.subtrair.TabIndex = 1;
            this.subtrair.UseVisualStyleBackColor = false;
            this.subtrair.Click += new System.EventHandler(this.subtrair_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.BackColor = System.Drawing.Color.Transparent;
            this.multiplicar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("multiplicar.BackgroundImage")));
            this.multiplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.multiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplicar.ForeColor = System.Drawing.Color.Transparent;
            this.multiplicar.Location = new System.Drawing.Point(317, 95);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(123, 76);
            this.multiplicar.TabIndex = 2;
            this.multiplicar.UseVisualStyleBackColor = false;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // dividir
            // 
            this.dividir.BackColor = System.Drawing.Color.Transparent;
            this.dividir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dividir.BackgroundImage")));
            this.dividir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dividir.ForeColor = System.Drawing.Color.Transparent;
            this.dividir.Location = new System.Drawing.Point(59, 177);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(123, 76);
            this.dividir.TabIndex = 3;
            this.dividir.UseVisualStyleBackColor = false;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // raiz
            // 
            this.raiz.BackColor = System.Drawing.Color.Transparent;
            this.raiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("raiz.BackgroundImage")));
            this.raiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.raiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raiz.ForeColor = System.Drawing.Color.Transparent;
            this.raiz.Location = new System.Drawing.Point(317, 179);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(123, 74);
            this.raiz.TabIndex = 4;
            this.raiz.UseVisualStyleBackColor = false;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // potencia
            // 
            this.potencia.BackColor = System.Drawing.Color.Transparent;
            this.potencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("potencia.BackgroundImage")));
            this.potencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.potencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.potencia.ForeColor = System.Drawing.Color.Transparent;
            this.potencia.Location = new System.Drawing.Point(188, 179);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(123, 74);
            this.potencia.TabIndex = 5;
            this.potencia.UseVisualStyleBackColor = false;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // soma
            // 
            this.soma.BackColor = System.Drawing.Color.Transparent;
            this.soma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soma.BackgroundImage")));
            this.soma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.soma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soma.ForeColor = System.Drawing.Color.Transparent;
            this.soma.Location = new System.Drawing.Point(59, 95);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(123, 76);
            this.soma.TabIndex = 6;
            this.soma.UseVisualStyleBackColor = false;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(59, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 33);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(256, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 33);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Primeiro Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(252, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Segundo Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 11;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 369);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.subtrair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button subtrair;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

