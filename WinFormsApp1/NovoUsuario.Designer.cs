namespace PIMVEscolaVencerSempre
{
    partial class NovoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoUsuario));
            panel1 = new Panel();
            btn_voltar = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxNome = new TextBox();
            textBoxLogin = new TextBox();
            textBoxSenha = new TextBox();
            label4 = new Label();
            comboBoxTipo = new ComboBox();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_voltar);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(8, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 55);
            panel1.TabIndex = 0;
            // 
            // btn_voltar
            // 
            btn_voltar.Cursor = Cursors.Hand;
            btn_voltar.Image = Properties.Resources.icons8_cancelar_32;
            btn_voltar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_voltar.Location = new Point(4, 3);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(114, 49);
            btn_voltar.TabIndex = 5;
            btn_voltar.Text = "Cancelar";
            btn_voltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Image = Properties.Resources.icons8_salvar_32;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(218, 3);
            button2.Name = "button2";
            button2.Size = new Size(114, 49);
            button2.TabIndex = 4;
            button2.Text = "Gravar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 63);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(6, 37);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(154, 23);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(6, 81);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(154, 23);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(164, 81);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(154, 23);
            textBoxSenha.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 19);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 7;
            label4.Text = "Tipo";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Professor", "Admin" });
            comboBoxTipo.Location = new Point(164, 37);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(154, 23);
            comboBoxTipo.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Controls.Add(textBoxSenha);
            groupBox1.Controls.Add(comboBoxTipo);
            groupBox1.Controls.Add(textBoxLogin);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 158);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // NovoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 231);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NovoUsuario";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterParent;
            Text = "NovoUsuario";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNome;
        private TextBox textBoxLogin;
        private TextBox textBoxSenha;
        private Label label4;
        private ComboBox comboBoxTipo;
        private Button button2;
        private GroupBox groupBox1;
        private Button btn_voltar;
    }
}