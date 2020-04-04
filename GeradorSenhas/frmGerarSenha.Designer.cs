namespace GeradorSenhas
{
    partial class frmGerarSenha
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbSimilar = new System.Windows.Forms.CheckBox();
            this.cbAmbiguous = new System.Windows.Forms.CheckBox();
            this.lblAmountPass = new System.Windows.Forms.Label();
            this.tamanhoSenha = new System.Windows.Forms.NumericUpDown();
            this.btnNumeros2 = new System.Windows.Forms.Button();
            this.btnMaiusculas2 = new System.Windows.Forms.Button();
            this.btnMinusculas2 = new System.Windows.Forms.Button();
            this.btnSimbolos2 = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnSalvarSenha = new System.Windows.Forms.Button();
            this.nivelSenha = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnGerarSenha = new System.Windows.Forms.Button();
            this.cbNivelSenha = new System.Windows.Forms.CheckBox();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.btnSimbolos = new System.Windows.Forms.Button();
            this.btnMinusculas = new System.Windows.Forms.Button();
            this.btnMaiusculas = new System.Windows.Forms.Button();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.cbCaracteresIguais = new System.Windows.Forms.CheckBox();
            this.lblFirstChar = new System.Windows.Forms.Label();
            this.lblOthers = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tamanhoSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSimilar
            // 
            this.cbSimilar.AutoSize = true;
            this.cbSimilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSimilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSimilar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSimilar.Location = new System.Drawing.Point(9, 100);
            this.cbSimilar.Name = "cbSimilar";
            this.cbSimilar.Size = new System.Drawing.Size(307, 20);
            this.cbSimilar.TabIndex = 3;
            this.cbSimilar.Text = "Excluir caracteres similares (i, l, 1, L, o, 0, O)";
            this.cbSimilar.UseVisualStyleBackColor = true;
            // 
            // cbAmbiguous
            // 
            this.cbAmbiguous.AutoSize = true;
            this.cbAmbiguous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAmbiguous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAmbiguous.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAmbiguous.Location = new System.Drawing.Point(9, 132);
            this.cbAmbiguous.Name = "cbAmbiguous";
            this.cbAmbiguous.Size = new System.Drawing.Size(371, 20);
            this.cbAmbiguous.TabIndex = 4;
            this.cbAmbiguous.Text = "Excluir caracteres ambíguos ({ } [ ] ( ) / \\ \' \" ` ~ , ; : . < >)";
            this.cbAmbiguous.UseVisualStyleBackColor = true;
            // 
            // lblAmountPass
            // 
            this.lblAmountPass.AutoSize = true;
            this.lblAmountPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPass.Location = new System.Drawing.Point(222, 335);
            this.lblAmountPass.Name = "lblAmountPass";
            this.lblAmountPass.Size = new System.Drawing.Size(133, 16);
            this.lblAmountPass.TabIndex = 6;
            this.lblAmountPass.Text = "Tamanho da senha:";
            // 
            // tamanhoSenha
            // 
            this.tamanhoSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tamanhoSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanhoSenha.Location = new System.Drawing.Point(360, 333);
            this.tamanhoSenha.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.tamanhoSenha.Name = "tamanhoSenha";
            this.tamanhoSenha.Size = new System.Drawing.Size(49, 22);
            this.tamanhoSenha.TabIndex = 7;
            this.tamanhoSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tamanhoSenha.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btnNumeros2
            // 
            this.btnNumeros2.BackColor = System.Drawing.Color.Teal;
            this.btnNumeros2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNumeros2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumeros2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeros2.Location = new System.Drawing.Point(48, 238);
            this.btnNumeros2.Name = "btnNumeros2";
            this.btnNumeros2.Size = new System.Drawing.Size(75, 26);
            this.btnNumeros2.TabIndex = 8;
            this.btnNumeros2.Text = "Número";
            this.tip.SetToolTip(this.btnNumeros2, "Caractere inicial: Número");
            this.btnNumeros2.UseVisualStyleBackColor = false;
            this.btnNumeros2.Click += new System.EventHandler(this.btnNumeros2_Click);
            // 
            // btnMaiusculas2
            // 
            this.btnMaiusculas2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMaiusculas2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaiusculas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaiusculas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaiusculas2.Location = new System.Drawing.Point(199, 238);
            this.btnMaiusculas2.Name = "btnMaiusculas2";
            this.btnMaiusculas2.Size = new System.Drawing.Size(79, 26);
            this.btnMaiusculas2.TabIndex = 9;
            this.btnMaiusculas2.Text = "Maiúsculo";
            this.tip.SetToolTip(this.btnMaiusculas2, "Caractere inicial: Maiúsculo");
            this.btnMaiusculas2.UseVisualStyleBackColor = false;
            this.btnMaiusculas2.Click += new System.EventHandler(this.btnMaiusculas2_Click);
            // 
            // btnMinusculas2
            // 
            this.btnMinusculas2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMinusculas2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinusculas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusculas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusculas2.Location = new System.Drawing.Point(122, 238);
            this.btnMinusculas2.Name = "btnMinusculas2";
            this.btnMinusculas2.Size = new System.Drawing.Size(78, 26);
            this.btnMinusculas2.TabIndex = 10;
            this.btnMinusculas2.Text = "Minúsculo";
            this.tip.SetToolTip(this.btnMinusculas2, "Caractere inicial: Minúsculo");
            this.btnMinusculas2.UseVisualStyleBackColor = false;
            this.btnMinusculas2.Click += new System.EventHandler(this.btnMinusculas2_Click);
            // 
            // btnSimbolos2
            // 
            this.btnSimbolos2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSimbolos2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimbolos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimbolos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimbolos2.Location = new System.Drawing.Point(277, 238);
            this.btnSimbolos2.Name = "btnSimbolos2";
            this.btnSimbolos2.Size = new System.Drawing.Size(75, 26);
            this.btnSimbolos2.TabIndex = 11;
            this.btnSimbolos2.Text = "Símbolo";
            this.tip.SetToolTip(this.btnSimbolos2, "Caractere inicial: Símbolo");
            this.btnSimbolos2.UseVisualStyleBackColor = false;
            this.btnSimbolos2.Click += new System.EventHandler(this.btnSimbolos2_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.Location = new System.Drawing.Point(524, 330);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(103, 26);
            this.btnCopiar.TabIndex = 13;
            this.btnCopiar.Text = "Copiar senha";
            this.tip.SetToolTip(this.btnCopiar, "Copiar campo de senha");
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnSalvarSenha
            // 
            this.btnSalvarSenha.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSalvarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarSenha.Location = new System.Drawing.Point(415, 330);
            this.btnSalvarSenha.Name = "btnSalvarSenha";
            this.btnSalvarSenha.Size = new System.Drawing.Size(103, 26);
            this.btnSalvarSenha.TabIndex = 15;
            this.btnSalvarSenha.Text = "Salvar senha";
            this.tip.SetToolTip(this.btnSalvarSenha, "Salvar campo de senha");
            this.btnSalvarSenha.UseVisualStyleBackColor = false;
            this.btnSalvarSenha.Click += new System.EventHandler(this.btnSalvarSenha_Click);
            // 
            // nivelSenha
            // 
            this.nivelSenha.BackColor = System.Drawing.SystemColors.Control;
            this.nivelSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nivelSenha.Location = new System.Drawing.Point(183, 331);
            this.nivelSenha.Name = "nivelSenha";
            this.nivelSenha.Size = new System.Drawing.Size(24, 24);
            this.nivelSenha.TabIndex = 11;
            this.nivelSenha.TabStop = false;
            this.nivelSenha.Click += new System.EventHandler(this.nivelSenha_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(14, 281);
            this.txtSenha.MaxLength = 3000;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(722, 29);
            this.txtSenha.TabIndex = 10;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGerarSenha
            // 
            this.btnGerarSenha.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGerarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnGerarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarSenha.Location = new System.Drawing.Point(633, 330);
            this.btnGerarSenha.Name = "btnGerarSenha";
            this.btnGerarSenha.Size = new System.Drawing.Size(103, 26);
            this.btnGerarSenha.TabIndex = 9;
            this.btnGerarSenha.Text = "Gerar senha";
            this.tip.SetToolTip(this.btnGerarSenha, "Gerar senha aleatória");
            this.btnGerarSenha.UseVisualStyleBackColor = false;
            this.btnGerarSenha.Click += new System.EventHandler(this.btnGerarSenha_Click);
            // 
            // cbNivelSenha
            // 
            this.cbNivelSenha.AutoSize = true;
            this.cbNivelSenha.Checked = true;
            this.cbNivelSenha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNivelSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNivelSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNivelSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelSenha.Location = new System.Drawing.Point(14, 333);
            this.cbNivelSenha.Name = "cbNivelSenha";
            this.cbNivelSenha.Size = new System.Drawing.Size(168, 20);
            this.cbNivelSenha.TabIndex = 15;
            this.cbNivelSenha.Text = "Mostrar nível de senha";
            this.cbNivelSenha.UseVisualStyleBackColor = true;
            this.cbNivelSenha.CheckedChanged += new System.EventHandler(this.cbLevelPass_CheckedChanged);
            // 
            // btnSimbolos
            // 
            this.btnSimbolos.BackColor = System.Drawing.Color.Teal;
            this.btnSimbolos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimbolos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimbolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimbolos.Location = new System.Drawing.Point(613, 238);
            this.btnSimbolos.Name = "btnSimbolos";
            this.btnSimbolos.Size = new System.Drawing.Size(75, 26);
            this.btnSimbolos.TabIndex = 21;
            this.btnSimbolos.Text = "Símbolos";
            this.tip.SetToolTip(this.btnSimbolos, "Outros caracteres: Símbolos");
            this.btnSimbolos.UseVisualStyleBackColor = false;
            this.btnSimbolos.Click += new System.EventHandler(this.btnSimbolos_Click);
            // 
            // btnMinusculas
            // 
            this.btnMinusculas.BackColor = System.Drawing.Color.Teal;
            this.btnMinusculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinusculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusculas.Location = new System.Drawing.Point(456, 238);
            this.btnMinusculas.Name = "btnMinusculas";
            this.btnMinusculas.Size = new System.Drawing.Size(80, 26);
            this.btnMinusculas.TabIndex = 20;
            this.btnMinusculas.Text = "Minúsculos";
            this.tip.SetToolTip(this.btnMinusculas, "Outros caracteres: Minúsculos");
            this.btnMinusculas.UseVisualStyleBackColor = false;
            this.btnMinusculas.Click += new System.EventHandler(this.btnMinusculas_Click);
            // 
            // btnMaiusculas
            // 
            this.btnMaiusculas.BackColor = System.Drawing.Color.Teal;
            this.btnMaiusculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaiusculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaiusculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaiusculas.Location = new System.Drawing.Point(534, 238);
            this.btnMaiusculas.Name = "btnMaiusculas";
            this.btnMaiusculas.Size = new System.Drawing.Size(80, 26);
            this.btnMaiusculas.TabIndex = 19;
            this.btnMaiusculas.Text = "Maiúsculos";
            this.tip.SetToolTip(this.btnMaiusculas, "Outros caracteres: Maiúsculos");
            this.btnMaiusculas.UseVisualStyleBackColor = false;
            this.btnMaiusculas.Click += new System.EventHandler(this.btnMaiusculas_Click);
            // 
            // btnNumeros
            // 
            this.btnNumeros.BackColor = System.Drawing.Color.Teal;
            this.btnNumeros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeros.Location = new System.Drawing.Point(382, 238);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(75, 26);
            this.btnNumeros.TabIndex = 18;
            this.btnNumeros.Text = "Números";
            this.tip.SetToolTip(this.btnNumeros, "Outros caracteres: Números");
            this.btnNumeros.UseVisualStyleBackColor = false;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // cbCaracteresIguais
            // 
            this.cbCaracteresIguais.AutoSize = true;
            this.cbCaracteresIguais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCaracteresIguais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCaracteresIguais.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCaracteresIguais.Location = new System.Drawing.Point(9, 163);
            this.cbCaracteresIguais.Name = "cbCaracteresIguais";
            this.cbCaracteresIguais.Size = new System.Drawing.Size(294, 20);
            this.cbCaracteresIguais.TabIndex = 16;
            this.cbCaracteresIguais.Text = "Excluir caracteres iguais (aa, ZZ, oo, PP, ii)";
            this.cbCaracteresIguais.UseVisualStyleBackColor = true;
            // 
            // lblFirstChar
            // 
            this.lblFirstChar.AutoSize = true;
            this.lblFirstChar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstChar.Location = new System.Drawing.Point(138, 219);
            this.lblFirstChar.Name = "lblFirstChar";
            this.lblFirstChar.Size = new System.Drawing.Size(127, 16);
            this.lblFirstChar.TabIndex = 17;
            this.lblFirstChar.Text = "Primeiro caractere";
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthers.Location = new System.Drawing.Point(476, 219);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(119, 16);
            this.lblOthers.TabIndex = 22;
            this.lblOthers.Text = "Outros caracteres";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescription.Location = new System.Drawing.Point(44, 32);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(358, 24);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "GERADOR DE SENHAS ALEATÓRIAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::GeradorSenhas.Properties.Resources.cadeado;
            this.pictureBox1.Location = new System.Drawing.Point(524, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // frmGerarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(749, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnSimbolos);
            this.Controls.Add(this.btnMaiusculas);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnMinusculas);
            this.Controls.Add(this.btnSalvarSenha);
            this.Controls.Add(this.lblOthers);
            this.Controls.Add(this.nivelSenha);
            this.Controls.Add(this.btnGerarSenha);
            this.Controls.Add(this.lblFirstChar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.cbCaracteresIguais);
            this.Controls.Add(this.cbNivelSenha);
            this.Controls.Add(this.btnSimbolos2);
            this.Controls.Add(this.btnMinusculas2);
            this.Controls.Add(this.btnMaiusculas2);
            this.Controls.Add(this.btnNumeros2);
            this.Controls.Add(this.tamanhoSenha);
            this.Controls.Add(this.lblAmountPass);
            this.Controls.Add(this.cbAmbiguous);
            this.Controls.Add(this.cbSimilar);
            this.Controls.Add(this.btnNumeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGerarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Senha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPassGen_FormClosing);
            this.Load += new System.EventHandler(this.frmPassGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tamanhoSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckBox cbSimilar;
        private System.Windows.Forms.CheckBox cbAmbiguous;
        private System.Windows.Forms.Label lblAmountPass;
        private System.Windows.Forms.NumericUpDown tamanhoSenha;
        private System.Windows.Forms.Button btnNumeros2;
        private System.Windows.Forms.Button btnMaiusculas2;
        private System.Windows.Forms.Button btnMinusculas2;
        private System.Windows.Forms.Button btnSimbolos2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnGerarSenha;
        private System.Windows.Forms.CheckBox cbNivelSenha;
        private System.Windows.Forms.PictureBox nivelSenha;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.CheckBox cbCaracteresIguais;
        private System.Windows.Forms.Label lblFirstChar;
        private System.Windows.Forms.Button btnSalvarSenha;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label lblOthers;
        private System.Windows.Forms.Button btnSimbolos;
        private System.Windows.Forms.Button btnMinusculas;
        private System.Windows.Forms.Button btnMaiusculas;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

