namespace WinFormsApp1
{
    partial class Reserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserva));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            reservaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            novoUsuárioToolStripMenuItem = new ToolStripMenuItem();
            gestaoDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            equipamentosToolStripMenuItem = new ToolStripMenuItem();
            novoEquipamentoToolStripMenuItem = new ToolStripMenuItem();
            gestãoDeEquipamentosToolStripMenuItem = new ToolStripMenuItem();
            novoAgendamentoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, usuáriosToolStripMenuItem, equipamentosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(832, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoAgendamentoToolStripMenuItem, reservaToolStripMenuItem, sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // reservaToolStripMenuItem
            // 
            reservaToolStripMenuItem.Image = PIMVEscolaVencerSempre.Properties.Resources.icons8_calendário_32;
            reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            reservaToolStripMenuItem.Size = new Size(182, 22);
            reservaToolStripMenuItem.Text = "Agendamentos";
            reservaToolStripMenuItem.Click += reservaToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = PIMVEscolaVencerSempre.Properties.Resources.icons8_sair_32;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(182, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoUsuárioToolStripMenuItem, gestaoDeUsuariosToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(64, 20);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            novoUsuárioToolStripMenuItem.Image = PIMVEscolaVencerSempre.Properties.Resources.icons8_adicionar_usuário_masculino_32;
            novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            novoUsuárioToolStripMenuItem.Size = new Size(174, 22);
            novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            novoUsuárioToolStripMenuItem.Click += novoUsuárioToolStripMenuItem_Click;
            // 
            // gestaoDeUsuariosToolStripMenuItem
            // 
            gestaoDeUsuariosToolStripMenuItem.Image = PIMVEscolaVencerSempre.Properties.Resources.icons8_grupo_de_usuários_32;
            gestaoDeUsuariosToolStripMenuItem.Name = "gestaoDeUsuariosToolStripMenuItem";
            gestaoDeUsuariosToolStripMenuItem.Size = new Size(174, 22);
            gestaoDeUsuariosToolStripMenuItem.Text = "Gestao de Usuarios";
            gestaoDeUsuariosToolStripMenuItem.Click += gestaoDeUsuariosToolStripMenuItem_Click;
            // 
            // equipamentosToolStripMenuItem
            // 
            equipamentosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoEquipamentoToolStripMenuItem, gestãoDeEquipamentosToolStripMenuItem });
            equipamentosToolStripMenuItem.Name = "equipamentosToolStripMenuItem";
            equipamentosToolStripMenuItem.Size = new Size(95, 20);
            equipamentosToolStripMenuItem.Text = "Equipamentos";
            // 
            // novoEquipamentoToolStripMenuItem
            // 
            novoEquipamentoToolStripMenuItem.Image = PIMVEscolaVencerSempre.Properties.Resources.icons8_monitor_32;
            novoEquipamentoToolStripMenuItem.Name = "novoEquipamentoToolStripMenuItem";
            novoEquipamentoToolStripMenuItem.Size = new Size(205, 22);
            novoEquipamentoToolStripMenuItem.Text = "Novo Equipamento";
            novoEquipamentoToolStripMenuItem.Click += novoEquipamentoToolStripMenuItem_Click;
            // 
            // gestãoDeEquipamentosToolStripMenuItem
            // 
            gestãoDeEquipamentosToolStripMenuItem.Image = PIMVEscolaVencerSempre.Properties.Resources.icons8_gestor_de_networking_32;
            gestãoDeEquipamentosToolStripMenuItem.Name = "gestãoDeEquipamentosToolStripMenuItem";
            gestãoDeEquipamentosToolStripMenuItem.Size = new Size(205, 22);
            gestãoDeEquipamentosToolStripMenuItem.Text = "Gestão de Equipamentos";
            gestãoDeEquipamentosToolStripMenuItem.Click += gestãoDeEquipamentosToolStripMenuItem_Click;
            // 
            // novoAgendamentoToolStripMenuItem
            // 
            novoAgendamentoToolStripMenuItem.Image = PIMVEscolaVencerSempre.Properties.Resources.icons8_mais_calendário_321;
            novoAgendamentoToolStripMenuItem.Name = "novoAgendamentoToolStripMenuItem";
            novoAgendamentoToolStripMenuItem.Size = new Size(182, 22);
            novoAgendamentoToolStripMenuItem.Text = "Novo Agendamento";
            novoAgendamentoToolStripMenuItem.Click += novoAgendamentoToolStripMenuItem_Click;
            // 
            // Reserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 490);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Reserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escola Vencer Sempre - Reserva de Equipamentos Audiovisuais";
            FormClosed += Reserva_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem reservaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private ToolStripMenuItem equipamentosToolStripMenuItem;
        private ToolStripMenuItem novoEquipamentoToolStripMenuItem;
        private ToolStripMenuItem gestãoDeEquipamentosToolStripMenuItem;
        private ToolStripMenuItem gestaoDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem novoAgendamentoToolStripMenuItem;
    }
}