namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btn_entrar = new Button();
            tb_senha = new TextBox();
            label1 = new Label();
            tb_usuario = new TextBox();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            label3 = new Label();
            colorDialog1 = new ColorDialog();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.DodgerBlue;
            btn_entrar.Cursor = Cursors.Hand;
            btn_entrar.FlatStyle = FlatStyle.Popup;
            btn_entrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_entrar.ForeColor = Color.White;
            btn_entrar.Location = new Point(23, 430);
            btn_entrar.Margin = new Padding(8);
            btn_entrar.MinimumSize = new Size(250, 44);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Padding = new Padding(4);
            btn_entrar.Size = new Size(368, 44);
            btn_entrar.TabIndex = 2;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += button1_Click;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(23, 344);
            tb_senha.MinimumSize = new Size(250, 44);
            tb_senha.Name = "tb_senha";
            tb_senha.PasswordChar = '*';
            tb_senha.PlaceholderText = "Insira sua senha";
            tb_senha.Size = new Size(368, 44);
            tb_senha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 326);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Senha";
            // 
            // tb_usuario
            // 
            tb_usuario.AcceptsTab = true;
            tb_usuario.Location = new Point(23, 279);
            tb_usuario.MinimumSize = new Size(250, 44);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.PlaceholderText = "Insira seu nome de usuário";
            tb_usuario.Size = new Size(367, 44);
            tb_usuario.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(23, 399);
            linkLabel1.Margin = new Padding(8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(118, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueci minha senha";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(23, 481);
            checkBox1.Margin = new Padding(8);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Lembrar-me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label3.Location = new Point(149, 210);
            label3.Margin = new Padding(20);
            label3.Name = "label3";
            label3.Size = new Size(110, 46);
            label3.TabIndex = 7;
            label3.Text = "Login";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(132, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tb_usuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tb_senha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_entrar);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(413, 505);
            panel1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 191);
            label4.Name = "label4";
            label4.Size = new Size(210, 15);
            label4.TabIndex = 13;
            label4.Text = "Reserva de equipamentos audiovisuais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 261);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Usuário";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(437, 529);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escola Vencer Sempre";
            FormClosed += Login_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_entrar;
        private TextBox tb_senha;
        private Label label1;
        private TextBox tb_usuario;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private Label label3;
        private ColorDialog colorDialog1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Label label4;
    }
}
