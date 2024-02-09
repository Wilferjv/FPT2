namespace calculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnuno = new System.Windows.Forms.Button();
            this.btndos = new System.Windows.Forms.Button();
            this.btnseis = new System.Windows.Forms.Button();
            this.btncinco = new System.Windows.Forms.Button();
            this.btncuatro = new System.Windows.Forms.Button();
            this.btnquitar = new System.Windows.Forms.Button();
            this.brnborra = new System.Windows.Forms.Button();
            this.btnnueve = new System.Windows.Forms.Button();
            this.btnocho = new System.Windows.Forms.Button();
            this.btnsiete = new System.Windows.Forms.Button();
            this.btntres = new System.Windows.Forms.Button();
            this.btnraizcuadrada = new System.Windows.Forms.Button();
            this.btncuadrado = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btnsumar = new System.Windows.Forms.Button();
            this.btnrestar = new System.Windows.Forms.Button();
            this.btnresultado = new System.Windows.Forms.Button();
            this.btncero = new System.Windows.Forms.Button();
            this.btnsigno = new System.Windows.Forms.Button();
            this.btnborrartodo = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(15, 42);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtResultado.MaxLength = 21;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(317, 47);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnuno
            // 
            this.btnuno.Location = new System.Drawing.Point(20, 273);
            this.btnuno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnuno.Name = "btnuno";
            this.btnuno.Size = new System.Drawing.Size(57, 45);
            this.btnuno.TabIndex = 1;
            this.btnuno.Text = "1";
            this.btnuno.UseVisualStyleBackColor = true;
            this.btnuno.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btndos
            // 
            this.btndos.Location = new System.Drawing.Point(83, 273);
            this.btndos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndos.Name = "btndos";
            this.btndos.Size = new System.Drawing.Size(57, 45);
            this.btndos.TabIndex = 2;
            this.btndos.Text = "2";
            this.btndos.UseVisualStyleBackColor = true;
            this.btndos.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnseis
            // 
            this.btnseis.Location = new System.Drawing.Point(146, 227);
            this.btnseis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnseis.Name = "btnseis";
            this.btnseis.Size = new System.Drawing.Size(57, 45);
            this.btnseis.TabIndex = 6;
            this.btnseis.Text = "6";
            this.btnseis.UseVisualStyleBackColor = true;
            this.btnseis.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btncinco
            // 
            this.btncinco.Location = new System.Drawing.Point(83, 224);
            this.btncinco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncinco.Name = "btncinco";
            this.btncinco.Size = new System.Drawing.Size(57, 45);
            this.btncinco.TabIndex = 5;
            this.btncinco.Text = "5";
            this.btncinco.UseVisualStyleBackColor = true;
            this.btncinco.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btncuatro
            // 
            this.btncuatro.Location = new System.Drawing.Point(20, 224);
            this.btncuatro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncuatro.Name = "btncuatro";
            this.btncuatro.Size = new System.Drawing.Size(57, 45);
            this.btncuatro.TabIndex = 4;
            this.btncuatro.Text = "4";
            this.btncuatro.UseVisualStyleBackColor = true;
            this.btncuatro.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnquitar
            // 
            this.btnquitar.Location = new System.Drawing.Point(146, 129);
            this.btnquitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(57, 45);
            this.btnquitar.TabIndex = 11;
            this.btnquitar.Text = "<-";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // brnborra
            // 
            this.brnborra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnborra.Location = new System.Drawing.Point(20, 126);
            this.brnborra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brnborra.Name = "brnborra";
            this.brnborra.Size = new System.Drawing.Size(57, 45);
            this.brnborra.TabIndex = 10;
            this.brnborra.Text = "CE";
            this.brnborra.UseVisualStyleBackColor = true;
            this.brnborra.Click += new System.EventHandler(this.brnborra_Click);
            // 
            // btnnueve
            // 
            this.btnnueve.Location = new System.Drawing.Point(146, 178);
            this.btnnueve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnueve.Name = "btnnueve";
            this.btnnueve.Size = new System.Drawing.Size(57, 45);
            this.btnnueve.TabIndex = 9;
            this.btnnueve.Text = "9";
            this.btnnueve.UseVisualStyleBackColor = true;
            this.btnnueve.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnocho
            // 
            this.btnocho.Location = new System.Drawing.Point(83, 178);
            this.btnocho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnocho.Name = "btnocho";
            this.btnocho.Size = new System.Drawing.Size(57, 45);
            this.btnocho.TabIndex = 8;
            this.btnocho.Text = "8";
            this.btnocho.UseVisualStyleBackColor = true;
            this.btnocho.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnsiete
            // 
            this.btnsiete.Location = new System.Drawing.Point(20, 175);
            this.btnsiete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsiete.Name = "btnsiete";
            this.btnsiete.Size = new System.Drawing.Size(57, 45);
            this.btnsiete.TabIndex = 7;
            this.btnsiete.Text = "7";
            this.btnsiete.UseVisualStyleBackColor = true;
            this.btnsiete.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btntres
            // 
            this.btntres.Location = new System.Drawing.Point(146, 273);
            this.btntres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntres.Name = "btntres";
            this.btntres.Size = new System.Drawing.Size(57, 45);
            this.btntres.TabIndex = 3;
            this.btntres.Text = "3";
            this.btntres.UseVisualStyleBackColor = true;
            this.btntres.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnraizcuadrada
            // 
            this.btnraizcuadrada.Location = new System.Drawing.Point(209, 129);
            this.btnraizcuadrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnraizcuadrada.Name = "btnraizcuadrada";
            this.btnraizcuadrada.Size = new System.Drawing.Size(59, 48);
            this.btnraizcuadrada.TabIndex = 14;
            this.btnraizcuadrada.Tag = "√";
            this.btnraizcuadrada.Text = "√";
            this.btnraizcuadrada.UseVisualStyleBackColor = true;
            this.btnraizcuadrada.Click += new System.EventHandler(this.clickoperador);
            // 
            // btncuadrado
            // 
            this.btncuadrado.Location = new System.Drawing.Point(274, 129);
            this.btncuadrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncuadrado.Name = "btncuadrado";
            this.btncuadrado.Size = new System.Drawing.Size(58, 49);
            this.btncuadrado.TabIndex = 13;
            this.btncuadrado.Tag = "²";
            this.btncuadrado.Text = "x²";
            this.btncuadrado.UseVisualStyleBackColor = true;
            this.btncuadrado.Click += new System.EventHandler(this.clickoperador);
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(209, 181);
            this.btndividir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(59, 54);
            this.btndividir.TabIndex = 16;
            this.btndividir.Tag = "∕";
            this.btndividir.Text = "∕";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Location = new System.Drawing.Point(274, 182);
            this.btnmultiplicar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(58, 54);
            this.btnmultiplicar.TabIndex = 15;
            this.btnmultiplicar.Tag = "X";
            this.btnmultiplicar.Text = "X";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(209, 239);
            this.btnsumar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(59, 96);
            this.btnsumar.TabIndex = 18;
            this.btnsumar.Tag = "+";
            this.btnsumar.Text = "+";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnrestar
            // 
            this.btnrestar.Location = new System.Drawing.Point(274, 239);
            this.btnrestar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(58, 96);
            this.btnrestar.TabIndex = 17;
            this.btnrestar.Tag = "−";
            this.btnrestar.Text = "−";
            this.btnrestar.UseVisualStyleBackColor = true;
            this.btnrestar.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnresultado
            // 
            this.btnresultado.Location = new System.Drawing.Point(209, 339);
            this.btnresultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnresultado.Name = "btnresultado";
            this.btnresultado.Size = new System.Drawing.Size(123, 53);
            this.btnresultado.TabIndex = 19;
            this.btnresultado.Text = "=";
            this.btnresultado.UseVisualStyleBackColor = true;
            this.btnresultado.Click += new System.EventHandler(this.btnresultado_Click);
            // 
            // btncero
            // 
            this.btncero.Location = new System.Drawing.Point(83, 339);
            this.btncero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncero.Name = "btncero";
            this.btncero.Size = new System.Drawing.Size(57, 45);
            this.btncero.TabIndex = 21;
            this.btncero.Text = "0";
            this.btncero.UseVisualStyleBackColor = true;
            this.btncero.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnsigno
            // 
            this.btnsigno.Location = new System.Drawing.Point(20, 339);
            this.btnsigno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsigno.Name = "btnsigno";
            this.btnsigno.Size = new System.Drawing.Size(57, 45);
            this.btnsigno.TabIndex = 20;
            this.btnsigno.Text = "+/-";
            this.btnsigno.UseVisualStyleBackColor = true;
            this.btnsigno.Click += new System.EventHandler(this.btnsigno_Click);
            // 
            // btnborrartodo
            // 
            this.btnborrartodo.Location = new System.Drawing.Point(83, 129);
            this.btnborrartodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnborrartodo.Name = "btnborrartodo";
            this.btnborrartodo.Size = new System.Drawing.Size(57, 45);
            this.btnborrartodo.TabIndex = 23;
            this.btnborrartodo.Text = "C";
            this.btnborrartodo.UseVisualStyleBackColor = true;
            this.btnborrartodo.Click += new System.EventHandler(this.btnborrartodo_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.Location = new System.Drawing.Point(146, 339);
            this.btnpunto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(57, 45);
            this.btnpunto.TabIndex = 24;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(340, 408);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btnborrartodo);
            this.Controls.Add(this.btncero);
            this.Controls.Add(this.btnsigno);
            this.Controls.Add(this.btnresultado);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnraizcuadrada);
            this.Controls.Add(this.btncuadrado);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.brnborra);
            this.Controls.Add(this.btnnueve);
            this.Controls.Add(this.btnocho);
            this.Controls.Add(this.btnsiete);
            this.Controls.Add(this.btnseis);
            this.Controls.Add(this.btncinco);
            this.Controls.Add(this.btncuatro);
            this.Controls.Add(this.btntres);
            this.Controls.Add(this.btndos);
            this.Controls.Add(this.btnuno);
            this.Controls.Add(this.txtResultado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnuno;
        private System.Windows.Forms.Button btndos;
        private System.Windows.Forms.Button btnseis;
        private System.Windows.Forms.Button btncinco;
        private System.Windows.Forms.Button btncuatro;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Button brnborra;
        private System.Windows.Forms.Button btnnueve;
        private System.Windows.Forms.Button btnocho;
        private System.Windows.Forms.Button btnsiete;
        private System.Windows.Forms.Button btntres;
        private System.Windows.Forms.Button btnraizcuadrada;
        private System.Windows.Forms.Button btncuadrado;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Button btnrestar;
        private System.Windows.Forms.Button btnresultado;
        private System.Windows.Forms.Button btncero;
        private System.Windows.Forms.Button btnsigno;
        private System.Windows.Forms.Button btnborrartodo;
        private System.Windows.Forms.Button btnpunto;
    }
}

