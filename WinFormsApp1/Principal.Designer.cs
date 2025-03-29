namespace PIMVEscolaVencerSempre
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            groupBox1 = new GroupBox();
            btn_imprimir = new Button();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Equipamento = new DataGridViewTextBoxColumn();
            Turma = new DataGridViewTextBoxColumn();
            Sala = new DataGridViewTextBoxColumn();
            Professor = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btn_excluir = new Button();
            btn_voltar = new Button();
            btn_alterar = new Button();
            btn_gravar = new Button();
            btn_limpar = new Button();
            btn_todos = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_imprimir);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(8);
            groupBox1.Size = new Size(776, 212);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agendamentos";
            // 
            // btn_imprimir
            // 
            btn_imprimir.Cursor = Cursors.Hand;
            btn_imprimir.Image = Properties.Resources.icons8_imprimir_48;
            btn_imprimir.ImageAlign = ContentAlignment.TopCenter;
            btn_imprimir.Location = new Point(701, 16);
            btn_imprimir.Name = "btn_imprimir";
            btn_imprimir.Size = new Size(64, 67);
            btn_imprimir.TabIndex = 11;
            btn_imprimir.Text = "Imprimir";
            btn_imprimir.TextAlign = ContentAlignment.BottomCenter;
            btn_imprimir.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 24);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "Data";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(406, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(256, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 156);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Professor";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(256, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 112);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 4;
            label3.Text = "Sala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 68);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Turma";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Datashow", "Projetor", "Notebook", "Caixa de Som" });
            comboBox1.Location = new Point(256, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 24);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 2;
            label1.Text = "Equipamento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(17, 33);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Equipamento, Turma, Sala, Professor, Data });
            dataGridView1.Location = new Point(17, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(748, 115);
            dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Equipamento
            // 
            Equipamento.HeaderText = "Equipamento";
            Equipamento.Name = "Equipamento";
            // 
            // Turma
            // 
            Turma.HeaderText = "Turma";
            Turma.Name = "Turma";
            // 
            // Sala
            // 
            Sala.HeaderText = "Sala";
            Sala.Name = "Sala";
            // 
            // Professor
            // 
            Professor.HeaderText = "Professor";
            Professor.Name = "Professor";
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 285);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(8);
            groupBox2.Size = new Size(776, 153);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalhes";
            // 
            // btn_excluir
            // 
            btn_excluir.Cursor = Cursors.Hand;
            btn_excluir.Image = (Image)resources.GetObject("btn_excluir.Image");
            btn_excluir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_excluir.Location = new Point(399, 230);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(114, 49);
            btn_excluir.TabIndex = 9;
            btn_excluir.Text = "Excluir";
            btn_excluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_voltar
            // 
            btn_voltar.Cursor = Cursors.Hand;
            btn_voltar.Image = Properties.Resources.icons8_voltar_32;
            btn_voltar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_voltar.Location = new Point(39, 230);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(114, 49);
            btn_voltar.TabIndex = 12;
            btn_voltar.Text = "Voltar";
            btn_voltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += button7_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.Cursor = Cursors.Hand;
            btn_alterar.Image = Properties.Resources.icons8_editar_32;
            btn_alterar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_alterar.Location = new Point(524, 230);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(114, 49);
            btn_alterar.TabIndex = 13;
            btn_alterar.Text = "Alterar";
            btn_alterar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_gravar
            // 
            btn_gravar.Cursor = Cursors.Hand;
            btn_gravar.Image = Properties.Resources.icons8_salvar_32;
            btn_gravar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_gravar.Location = new Point(644, 230);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(114, 49);
            btn_gravar.TabIndex = 14;
            btn_gravar.Text = "Gravar";
            btn_gravar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_gravar.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            btn_limpar.Cursor = Cursors.Hand;
            btn_limpar.Image = Properties.Resources.icons8_vassoura_32;
            btn_limpar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpar.Location = new Point(279, 230);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(114, 49);
            btn_limpar.TabIndex = 15;
            btn_limpar.Text = "Limpar";
            btn_limpar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_todos
            // 
            btn_todos.Cursor = Cursors.Hand;
            btn_todos.Image = Properties.Resources.icons8_lista_32;
            btn_todos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_todos.Location = new Point(159, 230);
            btn_todos.Name = "btn_todos";
            btn_todos.Size = new Size(114, 49);
            btn_todos.TabIndex = 16;
            btn_todos.Text = "Todos";
            btn_todos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_todos.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_todos);
            Controls.Add(btn_limpar);
            Controls.Add(btn_gravar);
            Controls.Add(btn_alterar);
            Controls.Add(btn_voltar);
            Controls.Add(btn_excluir);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Equipamento;
        private DataGridViewTextBoxColumn Turma;
        private DataGridViewTextBoxColumn Sala;
        private DataGridViewTextBoxColumn Professor;
        private DataGridViewTextBoxColumn Data;
        private GroupBox groupBox2;
        private Button button2;
        private Button button3;
        private Button btn_excluir;
        private Button btn_imprimir;
        private DateTimePicker dateTimePicker1;
        private Button btn_voltar;
        private Button btn_alterar;
        private Button btn_gravar;
        private Button btn_limpar;
        private Button btn_todos;
    }
}