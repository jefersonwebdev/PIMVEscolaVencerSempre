namespace PIMVEscolaVencerSempre
{
    partial class Equipamentos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipamentos));
            dataGridViewEquipamentos = new DataGridView();
            bancoDadosHelperBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            tb_descricao = new TextBox();
            label4 = new Label();
            tb_tipo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cb_status = new ComboBox();
            label1 = new Label();
            tb_nome = new TextBox();
            btn_todos = new Button();
            btn_limpar = new Button();
            btn_gravar = new Button();
            btn_alterar = new Button();
            btn_voltar = new Button();
            btn_excluir = new Button();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bancoDadosHelperBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewEquipamentos
            // 
            dataGridViewEquipamentos.AllowUserToAddRows = false;
            dataGridViewEquipamentos.AllowUserToDeleteRows = false;
            dataGridViewEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEquipamentos.Location = new Point(11, 27);
            dataGridViewEquipamentos.Name = "dataGridViewEquipamentos";
            dataGridViewEquipamentos.ReadOnly = true;
            dataGridViewEquipamentos.Size = new Size(754, 197);
            dataGridViewEquipamentos.TabIndex = 0;
            // 
            // bancoDadosHelperBindingSource
            // 
            bancoDadosHelperBindingSource.DataSource = typeof(BancoDadosHelper);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_descricao);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tb_tipo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cb_status);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_nome);
            groupBox1.Location = new Point(14, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(8);
            groupBox1.Size = new Size(776, 130);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Equipamentos";
            // 
            // tb_descricao
            // 
            tb_descricao.Location = new Point(203, 42);
            tb_descricao.Name = "tb_descricao";
            tb_descricao.Size = new Size(354, 23);
            tb_descricao.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 68);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 14;
            label4.Text = "Status";
            // 
            // tb_tipo
            // 
            tb_tipo.Location = new Point(11, 89);
            tb_tipo.Name = "tb_tipo";
            tb_tipo.Size = new Size(186, 23);
            tb_tipo.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 24);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 12;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 68);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 11;
            label2.Text = "Tipo";
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Items.AddRange(new object[] { "Disponível", "Indisponível", "Manutenção" });
            cb_status.Location = new Point(203, 89);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(186, 23);
            cb_status.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 24);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Nome";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(11, 42);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(186, 23);
            tb_nome.TabIndex = 8;
            tb_nome.TextChanged += textBox1_TextChanged;
            // 
            // btn_todos
            // 
            btn_todos.Cursor = Cursors.Hand;
            btn_todos.Image = Properties.Resources.icons8_lista_32;
            btn_todos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_todos.Location = new Point(166, 151);
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
            btn_limpar.Location = new Point(286, 151);
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
            btn_gravar.Location = new Point(651, 151);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(114, 49);
            btn_gravar.TabIndex = 20;
            btn_gravar.Text = "Gravar";
            btn_gravar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_gravar.UseVisualStyleBackColor = true;
            btn_gravar.Click += btn_gravar_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.Cursor = Cursors.Hand;
            btn_alterar.Image = Properties.Resources.icons8_editar_32;
            btn_alterar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_alterar.Location = new Point(531, 151);
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
            btn_voltar.Location = new Point(46, 151);
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
            btn_excluir.Location = new Point(406, 151);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(114, 49);
            btn_excluir.TabIndex = 17;
            btn_excluir.Text = "Excluir";
            btn_excluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_excluir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewEquipamentos);
            groupBox2.Location = new Point(14, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(8);
            groupBox2.Size = new Size(776, 235);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de Equipamentos";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(btn_voltar);
            panel1.Controls.Add(btn_todos);
            panel1.Controls.Add(btn_alterar);
            panel1.Controls.Add(btn_excluir);
            panel1.Controls.Add(btn_limpar);
            panel1.Controls.Add(btn_gravar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 24;
            // 
            // Equipamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Equipamentos";
            Text = "Equipamentos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)bancoDadosHelperBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEquipamentos;
        private BindingSource bancoDadosHelperBindingSource;
        private GroupBox groupBox1;
        private TextBox tb_descricao;
        private Label label4;
        private TextBox tb_tipo;
        private Label label3;
        private Label label2;
        private ComboBox cb_status;
        private Label label1;
        private TextBox tb_nome;
        private Button btn_todos;
        private Button btn_limpar;
        private Button btn_gravar;
        private Button btn_alterar;
        private Button btn_voltar;
        private Button btn_excluir;
        private GroupBox groupBox2;
        private Panel panel1;
    }
}