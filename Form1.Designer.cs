
namespace FormsMultidimensional_2023_II
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
            this.rdbRad = new System.Windows.Forms.RadioButton();
            this.rdbDeg = new System.Windows.Forms.RadioButton();
            this.txtbDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMatriz1 = new System.Windows.Forms.Label();
            this.lbMatriz2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnTrans = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIntro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbRad
            // 
            this.rdbRad.AutoSize = true;
            this.rdbRad.Location = new System.Drawing.Point(69, 34);
            this.rdbRad.Name = "rdbRad";
            this.rdbRad.Size = new System.Drawing.Size(40, 17);
            this.rdbRad.TabIndex = 0;
            this.rdbRad.TabStop = true;
            this.rdbRad.Text = "rad";
            this.rdbRad.UseVisualStyleBackColor = true;
            // 
            // rdbDeg
            // 
            this.rdbDeg.AutoSize = true;
            this.rdbDeg.Location = new System.Drawing.Point(197, 34);
            this.rdbDeg.Name = "rdbDeg";
            this.rdbDeg.Size = new System.Drawing.Size(43, 17);
            this.rdbDeg.TabIndex = 0;
            this.rdbDeg.TabStop = true;
            this.rdbDeg.Text = "deg";
            this.rdbDeg.UseVisualStyleBackColor = true;
            // 
            // txtbDisplay
            // 
            this.txtbDisplay.Location = new System.Drawing.Point(69, 78);
            this.txtbDisplay.Name = "txtbDisplay";
            this.txtbDisplay.Size = new System.Drawing.Size(333, 20);
            this.txtbDisplay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matriz 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matriz 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // lbMatriz1
            // 
            this.lbMatriz1.Location = new System.Drawing.Point(66, 149);
            this.lbMatriz1.Name = "lbMatriz1";
            this.lbMatriz1.Size = new System.Drawing.Size(92, 70);
            this.lbMatriz1.TabIndex = 2;
            this.lbMatriz1.Text = "1 2";
            // 
            // lbMatriz2
            // 
            this.lbMatriz2.Location = new System.Drawing.Point(198, 149);
            this.lbMatriz2.Name = "lbMatriz2";
            this.lbMatriz2.Size = new System.Drawing.Size(87, 70);
            this.lbMatriz2.TabIndex = 2;
            this.lbMatriz2.Text = "label1";
            // 
            // lbResultado
            // 
            this.lbResultado.Location = new System.Drawing.Point(349, 149);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(88, 70);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "label1";
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(69, 268);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 44);
            this.btnSuma.TabIndex = 3;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(168, 268);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 44);
            this.btnResta.TabIndex = 3;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(277, 268);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 44);
            this.btnMult.TabIndex = 3;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            // 
            // btnSeno
            // 
            this.btnSeno.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeno.Location = new System.Drawing.Point(69, 335);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(75, 44);
            this.btnSeno.TabIndex = 3;
            this.btnSeno.Text = "Sen";
            this.btnSeno.UseVisualStyleBackColor = true;
            // 
            // btnTrans
            // 
            this.btnTrans.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrans.Location = new System.Drawing.Point(168, 335);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(75, 44);
            this.btnTrans.TabIndex = 3;
            this.btnTrans.Text = "T";
            this.btnTrans.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClear.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(277, 335);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 44);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnIntro
            // 
            this.btnIntro.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIntro.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntro.Location = new System.Drawing.Point(378, 268);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(75, 111);
            this.btnIntro.TabIndex = 3;
            this.btnIntro.Text = "In";
            this.btnIntro.UseVisualStyleBackColor = false;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 392);
            this.Controls.Add(this.btnIntro);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMatriz2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMatriz1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbDisplay);
            this.Controls.Add(this.rdbDeg);
            this.Controls.Add(this.rdbRad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbRad;
        private System.Windows.Forms.RadioButton rdbDeg;
        private System.Windows.Forms.TextBox txtbDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMatriz1;
        private System.Windows.Forms.Label lbMatriz2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnIntro;
    }
}

