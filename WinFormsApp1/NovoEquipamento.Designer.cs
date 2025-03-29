namespace PIMVEscolaVencerSempre
{
    partial class NovoEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoEquipamento));
            groupBox1 = new GroupBox();
            tb_descricao = new TextBox();
            label4 = new Label();
            tb_tipo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cb_status = new ComboBox();
            label1 = new Label();
            tb_nome = new TextBox();
            btn_gravar = new Button();
            btn_voltar = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_descricao);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tb_tipo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cb_status);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_nome);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(8);
            groupBox1.Size = new Size(329, 156);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // tb_descricao
            // 
            tb_descricao.Location = new Point(11, 78);
            tb_descricao.Name = "tb_descricao";
            tb_descricao.Size = new Size(308, 23);
            tb_descricao.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 104);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 14;
            label4.Text = "Status";
            // 
            // tb_tipo
            // 
            tb_tipo.Location = new Point(168, 34);
            tb_tipo.Name = "tb_tipo";
            tb_tipo.Size = new Size(151, 23);
            tb_tipo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 13);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 11;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 60);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 12;
            label3.Text = "Descrição";
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Items.AddRange(new object[] { "Disponível", "Indisponível", "Manutenção" });
            cb_status.Location = new Point(9, 122);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(154, 23);
            cb_status.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Nome";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(11, 34);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(154, 23);
            tb_nome.TabIndex = 0;
            // 
            // btn_gravar
            // 
            btn_gravar.Cursor = Cursors.Hand;
            btn_gravar.Image = Properties.Resources.icons8_salvar_32;
            btn_gravar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_gravar.Location = new Point(215, 3);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(114, 49);
            btn_gravar.TabIndex = 4;
            btn_gravar.Text = "Gravar";
            btn_gravar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_gravar.UseVisualStyleBackColor = true;
            btn_gravar.Click += btn_gravar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Cursor = Cursors.Hand;
            btn_voltar.Image = Properties.Resources.icons8_cancelar_32;
            btn_voltar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_voltar.Location = new Point(3, 3);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(114, 49);
            btn_voltar.TabIndex = 5;
            btn_voltar.Text = "Cancelar";
            btn_voltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_voltar);
            panel1.Controls.Add(btn_gravar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(8, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 54);
            panel1.TabIndex = 28;
            // 
            // NovoEquipamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 231);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NovoEquipamento";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterParent;
            Text = "NovoEquipamento";
            Load += NovoEquipamento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tb_descricao;
        private Label label4;
        private TextBox tb_tipo;
        private Label label3;
        private Label label2;
        private ComboBox cb_status;
        private Label label1;
        private TextBox tb_nome;
        private Button btn_gravar;
        private Button btn_voltar;
        private Panel panel1;
    }
}