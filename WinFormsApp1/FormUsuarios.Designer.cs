namespace PIMVEscolaVencerSempre
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            labelNome = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridViewUsuarios = new DataGridView();
            btn_todos = new Button();
            btn_limpar = new Button();
            btn_gravar = new Button();
            btn_alterar = new Button();
            btn_voltar = new Button();
            btn_excluir = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(labelNome);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(14, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(8);
            groupBox1.Size = new Size(774, 119);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuários";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(11, 42);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 23);
            textBox3.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 24);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 14;
            label4.Text = "Tipo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 86);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 68);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 12;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 68);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 11;
            label2.Text = "Usuário";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "professor", "admin" });
            comboBox1.Location = new Point(171, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 23);
            comboBox1.TabIndex = 9;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(11, 24);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 10;
            labelNome.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewUsuarios);
            groupBox2.Location = new Point(14, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(8);
            groupBox2.Size = new Size(774, 236);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de Usuários";
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(11, 27);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.Size = new Size(749, 198);
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // btn_todos
            // 
            btn_todos.Cursor = Cursors.Hand;
            btn_todos.Image = Properties.Resources.icons8_lista_32;
            btn_todos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_todos.Location = new Point(163, 147);
            btn_todos.Name = "btn_todos";
            btn_todos.Size = new Size(114, 49);
            btn_todos.TabIndex = 22;
            btn_todos.Text = "Todos";
            btn_todos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_todos.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            btn_limpar.Cursor = Cursors.Hand;
            btn_limpar.Image = Properties.Resources.icons8_vassoura_32;
            btn_limpar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpar.Location = new Point(283, 147);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(114, 49);
            btn_limpar.TabIndex = 21;
            btn_limpar.Text = "Limpar";
            btn_limpar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_gravar
            // 
            btn_gravar.Cursor = Cursors.Hand;
            btn_gravar.Image = Properties.Resources.icons8_salvar_32;
            btn_gravar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_gravar.Location = new Point(648, 147);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(114, 49);
            btn_gravar.TabIndex = 20;
            btn_gravar.Text = "Gravar";
            btn_gravar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_gravar.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            btn_alterar.Cursor = Cursors.Hand;
            btn_alterar.Image = Properties.Resources.icons8_editar_32;
            btn_alterar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_alterar.Location = new Point(528, 147);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(114, 49);
            btn_alterar.TabIndex = 19;
            btn_alterar.Text = "Alterar";
            btn_alterar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_voltar
            // 
            btn_voltar.Cursor = Cursors.Hand;
            btn_voltar.Image = Properties.Resources.icons8_voltar_32;
            btn_voltar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_voltar.Location = new Point(43, 147);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(114, 49);
            btn_voltar.TabIndex = 18;
            btn_voltar.Text = "Voltar";
            btn_voltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Cursor = Cursors.Hand;
            btn_excluir.Image = (Image)resources.GetObject("btn_excluir.Image");
            btn_excluir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_excluir.Location = new Point(403, 147);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(114, 49);
            btn_excluir.TabIndex = 17;
            btn_excluir.Text = "Excluir";
            btn_excluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_excluir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btn_todos);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(btn_limpar);
            panel1.Controls.Add(btn_excluir);
            panel1.Controls.Add(btn_gravar);
            panel1.Controls.Add(btn_voltar);
            panel1.Controls.Add(btn_alterar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 23;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Label labelNome;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewUsuarios;
        private Button btn_todos;
        private Button btn_limpar;
        private Button btn_gravar;
        private Button btn_alterar;
        private Button btn_voltar;
        private Button btn_excluir;
        private Panel panel1;
    }
}