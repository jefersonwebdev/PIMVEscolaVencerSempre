namespace PIMVEscolaVencerSempre
{
    partial class NovoAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoAgendamento));
            groupBox1 = new GroupBox();
            maskedTextBoxHora = new MaskedTextBox();
            label5 = new Label();
            dateTimePickerData = new DateTimePicker();
            comboBoxUsuario = new ComboBox();
            textBoxSala = new TextBox();
            comboBoxEquipamento = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btn_voltar = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBoxHora);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePickerData);
            groupBox1.Controls.Add(comboBoxUsuario);
            groupBox1.Controls.Add(textBoxSala);
            groupBox1.Controls.Add(comboBoxEquipamento);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 158);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // maskedTextBoxHora
            // 
            maskedTextBoxHora.Location = new Point(6, 125);
            maskedTextBoxHora.Mask = "00:00";
            maskedTextBoxHora.Name = "maskedTextBoxHora";
            maskedTextBoxHora.Size = new Size(33, 23);
            maskedTextBoxHora.TabIndex = 4;
            maskedTextBoxHora.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 107);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 11;
            label5.Text = "Hora";
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Location = new Point(6, 81);
            dateTimePickerData.MaxDate = new DateTime(2025, 4, 28, 0, 0, 0, 0);
            dateTimePickerData.MinDate = new DateTime(2025, 3, 28, 0, 0, 0, 0);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(154, 23);
            dateTimePickerData.TabIndex = 2;
            // 
            // comboBoxUsuario
            // 
            comboBoxUsuario.FormattingEnabled = true;
            comboBoxUsuario.Location = new Point(164, 37);
            comboBoxUsuario.Name = "comboBoxUsuario";
            comboBoxUsuario.Size = new Size(154, 23);
            comboBoxUsuario.TabIndex = 1;
            // 
            // textBoxSala
            // 
            textBoxSala.Location = new Point(164, 81);
            textBoxSala.Name = "textBoxSala";
            textBoxSala.Size = new Size(154, 23);
            textBoxSala.TabIndex = 3;
            // 
            // comboBoxEquipamento
            // 
            comboBoxEquipamento.FormattingEnabled = true;
            comboBoxEquipamento.Location = new Point(6, 37);
            comboBoxEquipamento.Name = "comboBoxEquipamento";
            comboBoxEquipamento.Size = new Size(154, 23);
            comboBoxEquipamento.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Equipamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 63);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 3;
            label3.Text = "Sala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 19);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 7;
            label4.Text = "Usuário";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_voltar);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 55);
            panel1.TabIndex = 10;
            // 
            // btn_voltar
            // 
            btn_voltar.Cursor = Cursors.Hand;
            btn_voltar.Image = Properties.Resources.icons8_cancelar_32;
            btn_voltar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_voltar.Location = new Point(12, 3);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(114, 49);
            btn_voltar.TabIndex = 6;
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
            button2.Location = new Point(227, 3);
            button2.Name = "button2";
            button2.Size = new Size(114, 49);
            button2.TabIndex = 5;
            button2.Text = "Gravar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NovoAgendamento
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
            Name = "NovoAgendamento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NovoAgendamento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxSala;
        private ComboBox comboBoxEquipamento;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Panel panel1;
        private Button btn_voltar;
        private Button button2;
        private ComboBox comboBoxUsuario;
        private DateTimePicker dateTimePickerData;
        private MaskedTextBox maskedTextBoxHora;
        private Label label5;
    }
}