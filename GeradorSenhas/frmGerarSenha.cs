namespace GeradorSenhas
{
    public partial class frmGerarSenha : System.Windows.Forms.Form
    {
        public frmGerarSenha()
        {
            InitializeComponent();
        }

        void clickButton(System.Windows.Forms.Button btn)
        {
            System.Windows.Forms.Button[] btns = { btnNumeros2, btnMinusculas2, btnMaiusculas2, btnSimbolos2 };
            for (int i = 0; i < btns.Length; i++)
                if (btns[i] == btn && btn.BackColor != System.Drawing.Color.Teal)
                    btn.BackColor = System.Drawing.Color.Teal;
                else if (btns[i] != btn)
                    btns[i].BackColor = System.Drawing.Color.LightSeaGreen;
        }

        void clickButtons(System.Windows.Forms.Button btn)
        {
            if (btn.BackColor == System.Drawing.Color.LightSeaGreen) btn.BackColor = System.Drawing.Color.Teal;
            else btn.BackColor = System.Drawing.Color.LightSeaGreen;
        }

        void checkSecutiryPass(string str)
        {
            int totalPontos = 0;

            totalPontos += System.Math.Min(6, str.Length) * 10;
            totalPontos += System.Math.Min(2, str.Length - System.Text.RegularExpressions.Regex.Replace(str, "[A-Z]", "").Length) * 5;
            totalPontos += System.Math.Min(2, str.Length - System.Text.RegularExpressions.Regex.Replace(str, "[a-z]", "").Length) * 5;
            totalPontos += System.Math.Min(2, str.Length - System.Text.RegularExpressions.Regex.Replace(str, "[0-9]", "").Length) * 5;
            totalPontos += System.Math.Min(2, System.Text.RegularExpressions.Regex.Replace(str, "[a-zA-Z0-9]", "").Length) * 5;

            for (int i = 1; i < str.Length; i++)
                if (str[i] == str[i - 1])
                {
                    totalPontos -= 30; break;
                }

            if (totalPontos < 50)
            {
                nivelSenha.BackColor = System.Drawing.Color.Red;
                tip.SetToolTip(nivelSenha, "Senha INACEITÁVEL (" + totalPontos + " pontos)");
            }
            else if (totalPontos < 60)
            {
                nivelSenha.BackColor = System.Drawing.Color.DarkOrange;
                tip.SetToolTip(nivelSenha, "Senha PÉSSIMA (" + totalPontos + " pontos)");
            }
            else if (totalPontos < 80)
            {
                nivelSenha.BackColor = System.Drawing.Color.Yellow;
                tip.SetToolTip(nivelSenha, "Senha RUIM (" + totalPontos + " pontos)");
            }
            else if (totalPontos < 100)
            {
                nivelSenha.BackColor = System.Drawing.Color.Lime;
                tip.SetToolTip(nivelSenha, "Senha BOA (" + totalPontos + " pontos)");
            }
            else
            {
                nivelSenha.BackColor = System.Drawing.Color.DarkGreen;
                tip.SetToolTip(nivelSenha, "Senha EXCELENTE (" + totalPontos + " pontos)");
            }
        }

        private void frmPassGenerator_Load(object sender, System.EventArgs e)
        {
            if (!Properties.Settings.Default.Symbols)            
                clickButtons(btnSimbolos);
        
            if (!Properties.Settings.Default.Numbers)
                clickButtons(btnNumeros);

            if (!Properties.Settings.Default.Lower)
                clickButtons(btnMinusculas);

            if (!Properties.Settings.Default.Upper)
                clickButtons(btnMaiusculas);

            if (Properties.Settings.Default.Similar)
                cbSimilar.Checked = true;

            if (Properties.Settings.Default.Ambiguous)
                cbAmbiguous.Checked = true;

            if (Properties.Settings.Default.Equals)
                cbCaracteresIguais.Checked = true;

            if (!Properties.Settings.Default.LevelPass)
                cbNivelSenha.Checked = false;
        }

        private void btnNumeros2_Click(object sender, System.EventArgs e)
        {
            clickButton(btnNumeros2);
        }

        private void btnMinusculas2_Click(object sender, System.EventArgs e)
        {
            clickButton(btnMinusculas2);
        }

        private void btnMaiusculas2_Click(object sender, System.EventArgs e)
        {
            clickButton(btnMaiusculas2);
        }

        private void btnSimbolos2_Click(object sender, System.EventArgs e)
        {
            clickButton(btnSimbolos2);
        }

        private void btnGerarSenha_Click(object sender, System.EventArgs e)
        {
            txtSenha.Clear();

            System.Random random = new System.Random();
            string caracteres = string.Empty, senhaGerada = string.Empty, simbolos = "!@#$%&*-+=?_^", numeros = "0123456789",
                minusculas = "abcdefghijklmnopqrstuvxwyz", maiusculas = "ABCDEFGHIJKLMNOPQRSTUVXWYZ", simbolos2 = "{}[]()/\\'\"`~,;:.<>";
            int amountChar = (int)tamanhoSenha.Value;

            if (btnSimbolos.BackColor == System.Drawing.Color.Teal) caracteres += simbolos;
            if (btnNumeros.BackColor == System.Drawing.Color.Teal) caracteres += numeros;
            if (btnMinusculas.BackColor == System.Drawing.Color.Teal) caracteres += minusculas;
            if (btnMaiusculas.BackColor == System.Drawing.Color.Teal) caracteres += maiusculas;
            if (btnSimbolos.BackColor == System.Drawing.Color.Teal && !cbAmbiguous.Checked) caracteres += simbolos2;

            if (caracteres.Length < 6)
            {
                nivelSenha.BackColor = System.Drawing.SystemColors.Control;
                tip.SetToolTip(nivelSenha, null);
            }
            else
            {
                senhaGerada = string.Empty;

                if (btnNumeros2.BackColor == System.Drawing.Color.Teal)
                    senhaGerada += numeros[random.Next(0, numeros.Length)];
                else if (btnMinusculas2.BackColor == System.Drawing.Color.Teal)
                    senhaGerada += minusculas[random.Next(0, minusculas.Length)];
                else if (btnMaiusculas2.BackColor == System.Drawing.Color.Teal)
                    senhaGerada += maiusculas[random.Next(0, maiusculas.Length)];
                else if (btnSimbolos2.BackColor == System.Drawing.Color.Teal)
                    senhaGerada += (simbolos + (!cbAmbiguous.Checked ? simbolos2 : string.Empty))[random.Next(0, simbolos.Length + (!cbAmbiguous.Checked ? simbolos2.Length : 0))];

                for (int i = 1; i < amountChar; i++)
                {
                    char ch = caracteres[random.Next(0, caracteres.Length)];

                    if (cbCaracteresIguais.Checked)
                        while (senhaGerada[i - 1] == ch)
                            ch = caracteres[random.Next(0, caracteres.Length)];
                    else if (cbSimilar.Checked)
                    {   
                        char[] chL = { 'i', 'l', '1', 'o', '0', 'O' };
                        for (int j = 0; j < chL.Length; j++)
                            if (senhaGerada[i - 1] == chL[j])
                                while ((ch == 'i' || ch == 'l' || ch == '1' || ch == 'o' || ch == '0' || ch == 'O') && ch != chL[j])
                                    ch = caracteres[random.Next(0, caracteres.Length)];
                    }
                    senhaGerada += ch;
                }

                if (cbNivelSenha.Checked) checkSecutiryPass(senhaGerada);

                txtSenha.Text = senhaGerada;
            }
        }

        private void btnSalvarSenha_Click(object sender, System.EventArgs e)
        {
            if (txtSenha.Text.Trim().Length >= 6)
            {
                int i = 1;
                while (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Senha gerada" + i + ".txt"))
                    i++;

                System.IO.StreamWriter sw = new System.IO.StreamWriter(System.Windows.Forms.Application.StartupPath + "\\Senha gerada" + i + ".txt");
                sw.Write(txtSenha.Text);
                sw.Close();
                System.Windows.Forms.MessageBox.Show("Senha(s) salva(s) com sucesso! " + System.Windows.Forms.Application.StartupPath + "\\Senha gerada" + i + ".txt", "Sucesso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else System.Windows.Forms.MessageBox.Show("Primeiro gere uma senha para salvar!", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        private void btnCopiar_Click(object sender, System.EventArgs e)
        {
            if (txtSenha.Text.Trim() != string.Empty)
                System.Windows.Forms.Clipboard.SetText(txtSenha.Text.Trim());
            else System.Windows.Forms.Clipboard.Clear();
        }

        private void frmPassGen_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (btnSimbolos.BackColor == System.Drawing.Color.Teal)
                Properties.Settings.Default.Symbols = true;
            else Properties.Settings.Default.Symbols = false;

            if (btnNumeros.BackColor == System.Drawing.Color.Teal)
                Properties.Settings.Default.Numbers = true;
            else Properties.Settings.Default.Numbers = false;

            if (btnMinusculas.BackColor == System.Drawing.Color.Teal)
                Properties.Settings.Default.Lower = true;
            else Properties.Settings.Default.Lower = false;

            if (btnMaiusculas.BackColor == System.Drawing.Color.Teal)
                Properties.Settings.Default.Upper = true;
            else Properties.Settings.Default.Upper = false;

            if (cbSimilar.Checked)
                Properties.Settings.Default.Similar = true;
            else Properties.Settings.Default.Similar = false;

            if (cbAmbiguous.Checked)
                Properties.Settings.Default.Ambiguous = true;
            else Properties.Settings.Default.Ambiguous = false;

            if (cbCaracteresIguais.Checked)
                Properties.Settings.Default.Equals = true;
            else Properties.Settings.Default.Equals = false;

            if (cbNivelSenha.Checked)
                Properties.Settings.Default.LevelPass = true;
            else Properties.Settings.Default.LevelPass = false;

            Properties.Settings.Default.Save();
        }

        private void btnNumeros_Click(object sender, System.EventArgs e)
        {
            clickButtons(btnNumeros);
        }

        private void btnMinusculas_Click(object sender, System.EventArgs e)
        {
            clickButtons(btnMinusculas);
        }

        private void btnMaiusculas_Click(object sender, System.EventArgs e)
        {
            clickButtons(btnMaiusculas);
        }

        private void btnSimbolos_Click(object sender, System.EventArgs e)
        {
            clickButtons(btnSimbolos);
        }

        private void cbLevelPass_CheckedChanged(object sender, System.EventArgs e)
        {
            if (cbNivelSenha.Checked) { nivelSenha.Visible = true; nivelSenha.BackColor = System.Drawing.SystemColors.Control; }
            else nivelSenha.Visible = false;
        }

        private void nivelSenha_Click(object sender, System.EventArgs e)
        {
            checkSecutiryPass(txtSenha.Text);
        }
    }
}
