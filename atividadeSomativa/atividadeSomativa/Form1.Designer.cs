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
            lblConexao = new Label();
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
            panelTitle.Location = new Point(0, 3);
            panelTitle.Margin = new Padding(3, 4, 3, 4);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1127, 77);
            panelTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 22F, FontStyle.Bold);
            lblTitle.Location = new Point(381, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(381, 44);
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
            panelAutomatico.Location = new Point(14, 88);
            panelAutomatico.Margin = new Padding(3, 4, 3, 4);
            panelAutomatico.Name = "panelAutomatico";
            panelAutomatico.Size = new Size(527, 598);
            panelAutomatico.TabIndex = 1;
            // 
            // panelNivel
            // 
            panelNivel.BackColor = SystemColors.Control;
            panelNivel.BorderStyle = BorderStyle.FixedSingle;
            panelNivel.Controls.Add(lblNivel);
            panelNivel.Controls.Add(label8);
            panelNivel.Location = new Point(75, 471);
            panelNivel.Margin = new Padding(3, 4, 3, 4);
            panelNivel.Name = "panelNivel";
            panelNivel.Size = new Size(360, 103);
            panelNivel.TabIndex = 4;
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            lblNivel.Location = new Point(79, 21);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(0, 58);
            lblNivel.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 39);
            label8.Name = "label8";
            label8.Size = new Size(65, 23);
            label8.TabIndex = 3;
            label8.Text = "Nível: ";
            // 
            // panelVibracao
            // 
            panelVibracao.BackColor = SystemColors.Control;
            panelVibracao.BorderStyle = BorderStyle.FixedSingle;
            panelVibracao.Controls.Add(lblVibracao);
            panelVibracao.Controls.Add(label7);
            panelVibracao.Location = new Point(286, 264);
            panelVibracao.Margin = new Padding(3, 4, 3, 4);
            panelVibracao.Name = "panelVibracao";
            panelVibracao.Size = new Size(222, 186);
            panelVibracao.TabIndex = 3;
            // 
            // lblVibracao
            // 
            lblVibracao.AutoSize = true;
            lblVibracao.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            lblVibracao.Location = new Point(14, 81);
            lblVibracao.Name = "lblVibracao";
            lblVibracao.Size = new Size(0, 58);
            lblVibracao.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(63, 19);
            label7.Name = "label7";
            label7.Size = new Size(94, 23);
            label7.TabIndex = 3;
            label7.Text = "Vibração:";
            // 
            // panelPressao
            // 
            panelPressao.BackColor = SystemColors.Control;
            panelPressao.BorderStyle = BorderStyle.FixedSingle;
            panelPressao.Controls.Add(lblPressao);
            panelPressao.Controls.Add(label6);
            panelPressao.Location = new Point(22, 264);
            panelPressao.Margin = new Padding(3, 4, 3, 4);
            panelPressao.Name = "panelPressao";
            panelPressao.Size = new Size(227, 186);
            panelPressao.TabIndex = 2;
            // 
            // lblPressao
            // 
            lblPressao.AutoSize = true;
            lblPressao.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            lblPressao.Location = new Point(16, 81);
            lblPressao.Name = "lblPressao";
            lblPressao.Size = new Size(0, 58);
            lblPressao.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(69, 19);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 2;
            label6.Text = "Pressão:";
            // 
            // panelUmidade
            // 
            panelUmidade.BackColor = SystemColors.Control;
            panelUmidade.BorderStyle = BorderStyle.FixedSingle;
            panelUmidade.Controls.Add(lblUmidade);
            panelUmidade.Controls.Add(label4);
            panelUmidade.Location = new Point(286, 59);
            panelUmidade.Margin = new Padding(3, 4, 3, 4);
            panelUmidade.Name = "panelUmidade";
            panelUmidade.Size = new Size(222, 186);
            panelUmidade.TabIndex = 1;
            // 
            // lblUmidade
            // 
            lblUmidade.AutoSize = true;
            lblUmidade.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            lblUmidade.Location = new Point(14, 67);
            lblUmidade.Name = "lblUmidade";
            lblUmidade.Size = new Size(0, 58);
            lblUmidade.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 13);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 0;
            label4.Text = "Umidade:";
            // 
            // panelTemperatura
            // 
            panelTemperatura.BackColor = SystemColors.Control;
            panelTemperatura.BorderStyle = BorderStyle.FixedSingle;
            panelTemperatura.Controls.Add(lblTemperatura);
            panelTemperatura.Controls.Add(label5);
            panelTemperatura.Location = new Point(22, 59);
            panelTemperatura.Margin = new Padding(3, 4, 3, 4);
            panelTemperatura.Name = "panelTemperatura";
            panelTemperatura.Size = new Size(227, 186);
            panelTemperatura.TabIndex = 0;
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            lblTemperatura.Location = new Point(16, 67);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(0, 58);
            lblTemperatura.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(52, 13);
            label5.Name = "label5";
            label5.Size = new Size(127, 23);
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
            panelManual.Location = new Point(583, 88);
            panelManual.Margin = new Padding(3, 4, 3, 4);
            panelManual.Name = "panelManual";
            panelManual.Size = new Size(529, 598);
            panelManual.TabIndex = 2;
            // 
            // txtAlarmes
            // 
            txtAlarmes.Location = new Point(3, 471);
            txtAlarmes.Margin = new Padding(3, 4, 3, 4);
            txtAlarmes.Multiline = true;
            txtAlarmes.Name = "txtAlarmes";
            txtAlarmes.Size = new Size(519, 120);
            txtAlarmes.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDesligarAlarme);
            panel2.Controls.Add(btnLigarAlarme);
            panel2.Location = new Point(280, 316);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 134);
            panel2.TabIndex = 7;
            // 
            // btnDesligarAlarme
            // 
            btnDesligarAlarme.BackColor = Color.Red;
            btnDesligarAlarme.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDesligarAlarme.Location = new Point(46, 61);
            btnDesligarAlarme.Margin = new Padding(3, 4, 3, 4);
            btnDesligarAlarme.Name = "btnDesligarAlarme";
            btnDesligarAlarme.Size = new Size(142, 69);
            btnDesligarAlarme.TabIndex = 1;
            btnDesligarAlarme.Text = "Desligar Alarmes";
            btnDesligarAlarme.UseVisualStyleBackColor = false;
            btnDesligarAlarme.Click += btnDesligarAlarme_Click;
            // 
            // btnLigarAlarme
            // 
            btnLigarAlarme.BackColor = Color.YellowGreen;
            btnLigarAlarme.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLigarAlarme.Location = new Point(46, 4);
            btnLigarAlarme.Margin = new Padding(3, 4, 3, 4);
            btnLigarAlarme.Name = "btnLigarAlarme";
            btnLigarAlarme.Size = new Size(142, 63);
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
            panelTitulo.Margin = new Padding(3, 4, 3, 4);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(529, 51);
            panelTitulo.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(158, 12);
            label2.Name = "label2";
            label2.Size = new Size(240, 24);
            label2.TabIndex = 9;
            label2.Text = "Painel de Configurações";
            // 
            // panelStatus
            // 
            panelStatus.BackColor = SystemColors.Control;
            panelStatus.BorderStyle = BorderStyle.FixedSingle;
            panelStatus.Controls.Add(lblConexao);
            panelStatus.Controls.Add(lblTitleStatus);
            panelStatus.Location = new Point(280, 59);
            panelStatus.Margin = new Padding(3, 4, 3, 4);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(228, 59);
            panelStatus.TabIndex = 7;
            // 
            // lblConexao
            // 
            lblConexao.AutoSize = true;
            lblConexao.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConexao.ForeColor = Color.Red;
            lblConexao.Location = new Point(87, 14);
            lblConexao.Name = "lblConexao";
            lblConexao.Size = new Size(136, 23);
            lblConexao.TabIndex = 9;
            lblConexao.Text = "Desconectado";
            // 
            // lblTitleStatus
            // 
            lblTitleStatus.AutoSize = true;
            lblTitleStatus.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTitleStatus.Location = new Point(16, 13);
            lblTitleStatus.Name = "lblTitleStatus";
            lblTitleStatus.Size = new Size(78, 24);
            lblTitleStatus.TabIndex = 8;
            lblTitleStatus.Text = "Status:";
            // 
            // panelBotoes
            // 
            panelBotoes.BackColor = SystemColors.Control;
            panelBotoes.BorderStyle = BorderStyle.FixedSingle;
            panelBotoes.Controls.Add(btnDesconectar);
            panelBotoes.Controls.Add(btnConectar);
            panelBotoes.Location = new Point(280, 141);
            panelBotoes.Margin = new Padding(3, 4, 3, 4);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(228, 166);
            panelBotoes.TabIndex = 6;
            // 
            // btnDesconectar
            // 
            btnDesconectar.BackColor = Color.Red;
            btnDesconectar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDesconectar.Location = new Point(46, 87);
            btnDesconectar.Margin = new Padding(3, 4, 3, 4);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(142, 64);
            btnDesconectar.TabIndex = 1;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = false;
            btnDesconectar.Click += button1_Click;
            // 
            // btnConectar
            // 
            btnConectar.BackColor = Color.YellowGreen;
            btnConectar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConectar.Location = new Point(46, 15);
            btnConectar.Margin = new Padding(3, 4, 3, 4);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(142, 64);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtTopico
            // 
            txtTopico.Location = new Point(39, 377);
            txtTopico.Margin = new Padding(3, 4, 3, 4);
            txtTopico.Name = "txtTopico";
            txtTopico.Size = new Size(207, 27);
            txtTopico.TabIndex = 5;
            // 
            // lblTopico
            // 
            lblTopico.AutoSize = true;
            lblTopico.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTopico.Location = new Point(39, 348);
            lblTopico.Name = "lblTopico";
            lblTopico.Size = new Size(75, 24);
            lblTopico.TabIndex = 4;
            lblTopico.Text = "Tópico";
            // 
            // txtPorta
            // 
            txtPorta.Location = new Point(39, 249);
            txtPorta.Margin = new Padding(3, 4, 3, 4);
            txtPorta.Name = "txtPorta";
            txtPorta.Size = new Size(207, 27);
            txtPorta.TabIndex = 3;
            // 
            // lblPorta
            // 
            lblPorta.AutoSize = true;
            lblPorta.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblPorta.Location = new Point(39, 220);
            lblPorta.Name = "lblPorta";
            lblPorta.Size = new Size(61, 24);
            lblPorta.TabIndex = 2;
            lblPorta.Text = "Porta";
            // 
            // txtBroker
            // 
            txtBroker.Location = new Point(39, 127);
            txtBroker.Margin = new Padding(3, 4, 3, 4);
            txtBroker.Name = "txtBroker";
            txtBroker.Size = new Size(207, 27);
            txtBroker.TabIndex = 1;
            // 
            // lblBroker
            // 
            lblBroker.AutoSize = true;
            lblBroker.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblBroker.Location = new Point(39, 93);
            lblBroker.Name = "lblBroker";
            lblBroker.Size = new Size(74, 24);
            lblBroker.TabIndex = 0;
            lblBroker.Text = "Broker";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(14, 88);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 51);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(113, 12);
            label3.Name = "label3";
            label3.Size = new Size(314, 24);
            label3.TabIndex = 9;
            label3.Text = "Painel de Visualização de Dados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 703);
            Controls.Add(panel1);
            Controls.Add(panelManual);
            Controls.Add(panelAutomatico);
            Controls.Add(panelTitle);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblConexao;
    }
}
