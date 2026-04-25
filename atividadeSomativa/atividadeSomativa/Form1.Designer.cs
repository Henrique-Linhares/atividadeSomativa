namespace atividadeSomativa
{
    partial class Form1
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
            panelTitle = new Panel();
            lblTitle = new Label();
            panelAutomatico = new Panel();
            panelNivel = new Panel();
            lblNivel = new Label();
            label8 = new Label();
            panelVibracao = new Panel();
            lblVibracao = new Label();
            label7 = new Label();
            panelPressao = new Panel();
            lblPressao = new Label();
            label6 = new Label();
            panelUmidade = new Panel();
            lblUmidade = new Label();
            label4 = new Label();
            panelTemperatura = new Panel();
            lblTemperatura = new Label();
            label5 = new Label();
            panelManual = new Panel();
            txtAlarmes = new TextBox();
            panel2 = new Panel();
            btnDesligarAlarme = new Button();
            btnLigarAlarme = new Button();
            panelTitulo = new Panel();
            label2 = new Label();
            panelStatus = new Panel();
            label1 = new Label();
            lblTitleStatus = new Label();
            panelBotoes = new Panel();
            btnDesconectar = new Button();
            btnConectar = new Button();
            txtTopico = new TextBox();
            lblTopico = new Label();
            txtPorta = new TextBox();
            lblPorta = new Label();
            txtBroker = new TextBox();
            lblBroker = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panelTitle.SuspendLayout();
            panelAutomatico.SuspendLayout();
            panelNivel.SuspendLayout();
            panelVibracao.SuspendLayout();
            panelPressao.SuspendLayout();
            panelUmidade.SuspendLayout();
            panelTemperatura.SuspendLayout();
            panelManual.SuspendLayout();
            panel2.SuspendLayout();
            panelTitulo.SuspendLayout();
            panelStatus.SuspendLayout();
            panelBotoes.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackColor = SystemColors.GradientInactiveCaption;
            panelTitle.BorderStyle = BorderStyle.FixedSingle;
            panelTitle.Controls.Add(lblTitle);
            panelTitle.Location = new Point(0, 2);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(986, 58);
            panelTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 22F, FontStyle.Bold);
            lblTitle.Location = new Point(333, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(303, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Comunicação MQTT";
            // 
            // panelAutomatico
            // 
            panelAutomatico.BackColor = SystemColors.ControlLight;
            panelAutomatico.BorderStyle = BorderStyle.FixedSingle;
            panelAutomatico.Controls.Add(panelNivel);
            panelAutomatico.Controls.Add(panelVibracao);
            panelAutomatico.Controls.Add(panelPressao);
            panelAutomatico.Controls.Add(panelUmidade);
            panelAutomatico.Controls.Add(panelTemperatura);
            panelAutomatico.Location = new Point(12, 66);
            panelAutomatico.Name = "panelAutomatico";
            panelAutomatico.Size = new Size(461, 449);
            panelAutomatico.TabIndex = 1;
            // 
            // panelNivel
            // 
            panelNivel.BackColor = SystemColors.Control;
            panelNivel.BorderStyle = BorderStyle.FixedSingle;
            panelNivel.Controls.Add(lblNivel);
            panelNivel.Controls.Add(label8);
            panelNivel.Location = new Point(66, 353);
            panelNivel.Name = "panelNivel";
            panelNivel.Size = new Size(315, 78);
            panelNivel.TabIndex = 4;
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Arial Narrow", 30F, FontStyle.Bold);
            lblNivel.Location = new Point(69, 16);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(0, 46);
            lblNivel.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 29);
            label8.Name = "label8";
            label8.Size = new Size(49, 18);
            label8.TabIndex = 3;
            label8.Text = "Nível: ";
            // 
            // panelVibracao
            // 
            panelVibracao.BackColor = SystemColors.Control;
            panelVibracao.BorderStyle = BorderStyle.FixedSingle;
            panelVibracao.Controls.Add(lblVibracao);
            panelVibracao.Controls.Add(label7);
            panelVibracao.Location = new Point(250, 198);
            panelVibracao.Name = "panelVibracao";
            panelVibracao.Size = new Size(184, 140);
            panelVibracao.TabIndex = 3;
            // 
            // lblVibracao
            // 
            lblVibracao.AutoSize = true;
            lblVibracao.Font = new Font("Arial Narrow", 30F, FontStyle.Bold);
            lblVibracao.Location = new Point(12, 61);
            lblVibracao.Name = "lblVibracao";
            lblVibracao.Size = new Size(0, 46);
            lblVibracao.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(55, 15);
            label7.Name = "label7";
            label7.Size = new Size(76, 18);
            label7.TabIndex = 3;
            label7.Text = "Vibração:";
            // 
            // panelPressao
            // 
            panelPressao.BackColor = SystemColors.Control;
            panelPressao.BorderStyle = BorderStyle.FixedSingle;
            panelPressao.Controls.Add(lblPressao);
            panelPressao.Controls.Add(label6);
            panelPressao.Location = new Point(19, 198);
            panelPressao.Name = "panelPressao";
            panelPressao.Size = new Size(184, 140);
            panelPressao.TabIndex = 2;
            // 
            // lblPressao
            // 
            lblPressao.AutoSize = true;
            lblPressao.Font = new Font("Arial Narrow", 30F, FontStyle.Bold);
            lblPressao.Location = new Point(14, 61);
            lblPressao.Name = "lblPressao";
            lblPressao.Size = new Size(0, 46);
            lblPressao.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 15);
            label6.Name = "label6";
            label6.Size = new Size(71, 18);
            label6.TabIndex = 2;
            label6.Text = "Pressão:";
            // 
            // panelUmidade
            // 
            panelUmidade.BackColor = SystemColors.Control;
            panelUmidade.BorderStyle = BorderStyle.FixedSingle;
            panelUmidade.Controls.Add(lblUmidade);
            panelUmidade.Controls.Add(label4);
            panelUmidade.Location = new Point(250, 44);
            panelUmidade.Name = "panelUmidade";
            panelUmidade.Size = new Size(184, 140);
            panelUmidade.TabIndex = 1;
            // 
            // lblUmidade
            // 
            lblUmidade.AutoSize = true;
            lblUmidade.Font = new Font("Arial Narrow", 30F, FontStyle.Bold);
            lblUmidade.Location = new Point(12, 50);
            lblUmidade.Name = "lblUmidade";
            lblUmidade.Size = new Size(0, 46);
            lblUmidade.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 10);
            label4.Name = "label4";
            label4.Size = new Size(76, 18);
            label4.TabIndex = 0;
            label4.Text = "Umidade:";
            // 
            // panelTemperatura
            // 
            panelTemperatura.BackColor = SystemColors.Control;
            panelTemperatura.BorderStyle = BorderStyle.FixedSingle;
            panelTemperatura.Controls.Add(lblTemperatura);
            panelTemperatura.Controls.Add(label5);
            panelTemperatura.Location = new Point(19, 44);
            panelTemperatura.Name = "panelTemperatura";
            panelTemperatura.Size = new Size(184, 140);
            panelTemperatura.TabIndex = 0;
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Font = new Font("Arial Narrow", 30F, FontStyle.Bold);
            lblTemperatura.Location = new Point(14, 50);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(0, 46);
            lblTemperatura.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 10);
            label5.Name = "label5";
            label5.Size = new Size(99, 18);
            label5.TabIndex = 1;
            label5.Text = "Temperatura:";
            // 
            // panelManual
            // 
            panelManual.BackColor = SystemColors.ControlLight;
            panelManual.BorderStyle = BorderStyle.FixedSingle;
            panelManual.Controls.Add(txtAlarmes);
            panelManual.Controls.Add(panel2);
            panelManual.Controls.Add(panelTitulo);
            panelManual.Controls.Add(panelStatus);
            panelManual.Controls.Add(panelBotoes);
            panelManual.Controls.Add(txtTopico);
            panelManual.Controls.Add(lblTopico);
            panelManual.Controls.Add(txtPorta);
            panelManual.Controls.Add(lblPorta);
            panelManual.Controls.Add(txtBroker);
            panelManual.Controls.Add(lblBroker);
            panelManual.Location = new Point(510, 66);
            panelManual.Name = "panelManual";
            panelManual.Size = new Size(463, 449);
            panelManual.TabIndex = 2;
            // 
            // txtAlarmes
            // 
            txtAlarmes.Location = new Point(3, 353);
            txtAlarmes.Multiline = true;
            txtAlarmes.Name = "txtAlarmes";
            txtAlarmes.Size = new Size(455, 91);
            txtAlarmes.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDesligarAlarme);
            panel2.Controls.Add(btnLigarAlarme);
            panel2.Location = new Point(245, 237);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 101);
            panel2.TabIndex = 7;
            // 
            // btnDesligarAlarme
            // 
            btnDesligarAlarme.BackColor = Color.Red;
            btnDesligarAlarme.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDesligarAlarme.Location = new Point(40, 46);
            btnDesligarAlarme.Name = "btnDesligarAlarme";
            btnDesligarAlarme.Size = new Size(124, 52);
            btnDesligarAlarme.TabIndex = 1;
            btnDesligarAlarme.Text = "Desligar Alarmes";
            btnDesligarAlarme.UseVisualStyleBackColor = false;
            btnDesligarAlarme.Click += btnDesligarAlarme_Click;
            // 
            // btnLigarAlarme
            // 
            btnLigarAlarme.BackColor = Color.YellowGreen;
            btnLigarAlarme.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLigarAlarme.Location = new Point(40, 3);
            btnLigarAlarme.Name = "btnLigarAlarme";
            btnLigarAlarme.Size = new Size(124, 47);
            btnLigarAlarme.TabIndex = 0;
            btnLigarAlarme.Text = "Ligar Alarmes";
            btnLigarAlarme.UseVisualStyleBackColor = false;
            btnLigarAlarme.Click += btnLigarAlarme_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.AliceBlue;
            panelTitulo.Controls.Add(label2);
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(463, 38);
            panelTitulo.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(138, 9);
            label2.Name = "label2";
            label2.Size = new Size(196, 19);
            label2.TabIndex = 9;
            label2.Text = "Painel de Configurações";
            // 
            // panelStatus
            // 
            panelStatus.BackColor = SystemColors.Control;
            panelStatus.BorderStyle = BorderStyle.FixedSingle;
            panelStatus.Controls.Add(label1);
            panelStatus.Controls.Add(lblTitleStatus);
            panelStatus.Location = new Point(245, 44);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(200, 45);
            panelStatus.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(84, 11);
            label1.Name = "label1";
            label1.Size = new Size(110, 18);
            label1.TabIndex = 9;
            label1.Text = "Desconectado";
            // 
            // lblTitleStatus
            // 
            lblTitleStatus.AutoSize = true;
            lblTitleStatus.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTitleStatus.Location = new Point(14, 10);
            lblTitleStatus.Name = "lblTitleStatus";
            lblTitleStatus.Size = new Size(64, 19);
            lblTitleStatus.TabIndex = 8;
            lblTitleStatus.Text = "Status:";
            // 
            // panelBotoes
            // 
            panelBotoes.BackColor = SystemColors.Control;
            panelBotoes.BorderStyle = BorderStyle.FixedSingle;
            panelBotoes.Controls.Add(btnDesconectar);
            panelBotoes.Controls.Add(btnConectar);
            panelBotoes.Location = new Point(245, 106);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(200, 125);
            panelBotoes.TabIndex = 6;
            // 
            // btnDesconectar
            // 
            btnDesconectar.BackColor = Color.Red;
            btnDesconectar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDesconectar.Location = new Point(40, 65);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(124, 48);
            btnDesconectar.TabIndex = 1;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = false;
            btnDesconectar.Click += button1_Click;
            // 
            // btnConectar
            // 
            btnConectar.BackColor = Color.YellowGreen;
            btnConectar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConectar.Location = new Point(40, 11);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(124, 48);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtTopico
            // 
            txtTopico.Location = new Point(34, 283);
            txtTopico.Name = "txtTopico";
            txtTopico.Size = new Size(182, 23);
            txtTopico.TabIndex = 5;
            // 
            // lblTopico
            // 
            lblTopico.AutoSize = true;
            lblTopico.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTopico.Location = new Point(34, 261);
            lblTopico.Name = "lblTopico";
            lblTopico.Size = new Size(62, 19);
            lblTopico.TabIndex = 4;
            lblTopico.Text = "Tópico";
            // 
            // txtPorta
            // 
            txtPorta.Location = new Point(34, 187);
            txtPorta.Name = "txtPorta";
            txtPorta.Size = new Size(182, 23);
            txtPorta.TabIndex = 3;
            // 
            // lblPorta
            // 
            lblPorta.AutoSize = true;
            lblPorta.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblPorta.Location = new Point(34, 165);
            lblPorta.Name = "lblPorta";
            lblPorta.Size = new Size(50, 19);
            lblPorta.TabIndex = 2;
            lblPorta.Text = "Porta";
            // 
            // txtBroker
            // 
            txtBroker.Location = new Point(34, 95);
            txtBroker.Name = "txtBroker";
            txtBroker.Size = new Size(182, 23);
            txtBroker.TabIndex = 1;
            // 
            // lblBroker
            // 
            lblBroker.AutoSize = true;
            lblBroker.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblBroker.Location = new Point(34, 70);
            lblBroker.Name = "lblBroker";
            lblBroker.Size = new Size(61, 19);
            lblBroker.TabIndex = 0;
            lblBroker.Text = "Broker";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 38);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(99, 9);
            label3.Name = "label3";
            label3.Size = new Size(257, 19);
            label3.TabIndex = 9;
            label3.Text = "Painel de Visualização de Dados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 527);
            Controls.Add(panel1);
            Controls.Add(panelManual);
            Controls.Add(panelAutomatico);
            Controls.Add(panelTitle);
            Name = "Form1";
            Text = "Form1";
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panelAutomatico.ResumeLayout(false);
            panelNivel.ResumeLayout(false);
            panelNivel.PerformLayout();
            panelVibracao.ResumeLayout(false);
            panelVibracao.PerformLayout();
            panelPressao.ResumeLayout(false);
            panelPressao.PerformLayout();
            panelUmidade.ResumeLayout(false);
            panelUmidade.PerformLayout();
            panelTemperatura.ResumeLayout(false);
            panelTemperatura.PerformLayout();
            panelManual.ResumeLayout(false);
            panelManual.PerformLayout();
            panel2.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            panelBotoes.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label lblTitle;
        private Panel panelAutomatico;
        private Panel panelManual;
        private Label lblBroker;
        private Panel panelBotoes;
        private Button btnDesconectar;
        private Button btnConectar;
        private TextBox txtTopico;
        private Label lblTopico;
        private TextBox txtPorta;
        private Label lblPorta;
        private TextBox txtBroker;
        private Panel panelTitulo;
        private Label label2;
        private Panel panelStatus;
        private Label label1;
        private Label lblTitleStatus;
        private Panel panel1;
        private Label label3;
        private Panel panelNivel;
        private Panel panelVibracao;
        private Panel panelPressao;
        private Panel panelUmidade;
        private Label label4;
        private Panel panelTemperatura;
        private Label label5;
        private Label lblNivel;
        private Label label8;
        private Label lblVibracao;
        private Label label7;
        private Label lblPressao;
        private Label label6;
        private Label lblUmidade;
        private Label lblTemperatura;
        private Panel panel2;
        private Button btnDesligarAlarme;
        private Button btnLigarAlarme;
        private TextBox txtAlarmes;
    }
}
