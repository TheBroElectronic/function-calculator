namespace graficador_de_funciones
{
    partial class Form1
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
            this.funcion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grafica = new System.Windows.Forms.PictureBox();
            this.escalaTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.funcionTomada = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // funcion
            // 
            this.funcion.Location = new System.Drawing.Point(65, 13);
            this.funcion.Name = "funcion";
            this.funcion.Size = new System.Drawing.Size(140, 20);
            this.funcion.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "graficar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grafica
            // 
            this.grafica.InitialImage = null;
            this.grafica.Location = new System.Drawing.Point(235, 13);
            this.grafica.Name = "grafica";
            this.grafica.Size = new System.Drawing.Size(530, 530);
            this.grafica.TabIndex = 0;
            this.grafica.TabStop = false;
            // 
            // escalaTXT
            // 
            this.escalaTXT.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.escalaTXT.Location = new System.Drawing.Point(65, 73);
            this.escalaTXT.Name = "escalaTXT";
            this.escalaTXT.Size = new System.Drawing.Size(140, 20);
            this.escalaTXT.TabIndex = 4;
            this.escalaTXT.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "escala:";
            // 
            // funcionTomada
            // 
            this.funcionTomada.AutoSize = true;
            this.funcionTomada.Location = new System.Drawing.Point(62, 152);
            this.funcionTomada.Name = "funcionTomada";
            this.funcionTomada.Size = new System.Drawing.Size(0, 13);
            this.funcionTomada.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "funcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "funcion graficada:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.funcionTomada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.escalaTXT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.funcion);
            this.Controls.Add(this.grafica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox grafica;
        private System.Windows.Forms.TextBox funcion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox escalaTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label funcionTomada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

