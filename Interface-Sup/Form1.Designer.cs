namespace Interface_Sup
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBroker = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtBroker = new System.Windows.Forms.TextBox();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblConectionStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.Label();
            this.txtUmi = new System.Windows.Forms.Label();
            this.txtPress = new System.Windows.Forms.Label();
            this.txtVib = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblUmi = new System.Windows.Forms.Label();
            this.lblPres = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblVib = new System.Windows.Forms.Label();
            this.btnSaibaMais = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.richTextBoxAlertas = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pBarTemp = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBroker
            // 
            this.lblBroker.AutoSize = true;
            this.lblBroker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblBroker.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblBroker.Location = new System.Drawing.Point(14, 27);
            this.lblBroker.Name = "lblBroker";
            this.lblBroker.Size = new System.Drawing.Size(53, 18);
            this.lblBroker.TabIndex = 1;
            this.lblBroker.Text = "Broker";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblIP.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIP.Location = new System.Drawing.Point(249, 27);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(44, 18);
            this.lblIP.TabIndex = 2;
            this.lblIP.Text = "Porta";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTopic.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTopic.Location = new System.Drawing.Point(132, 27);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(54, 18);
            this.lblTopic.TabIndex = 3;
            this.lblTopic.Text = "Tópico";
            // 
            // txtBroker
            // 
            this.txtBroker.Location = new System.Drawing.Point(17, 56);
            this.txtBroker.Name = "txtBroker";
            this.txtBroker.Size = new System.Drawing.Size(100, 20);
            this.txtBroker.TabIndex = 4;
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(135, 56);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(100, 20);
            this.txtTopic.TabIndex = 5;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(252, 56);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 6;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblConnection.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblConnection.Location = new System.Drawing.Point(167, 86);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(78, 20);
            this.lblConnection.TabIndex = 7;
            this.lblConnection.Text = "Pendente";
            // 
            // lblConectionStatus
            // 
            this.lblConectionStatus.AutoSize = true;
            this.lblConectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblConectionStatus.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblConectionStatus.Location = new System.Drawing.Point(12, 86);
            this.lblConectionStatus.Name = "lblConectionStatus";
            this.lblConectionStatus.Size = new System.Drawing.Size(149, 20);
            this.lblConectionStatus.TabIndex = 8;
            this.lblConectionStatus.Text = "Status de Conexão:";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConnect.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnConnect.Location = new System.Drawing.Point(377, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDisconnect.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDisconnect.Location = new System.Drawing.Point(377, 56);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(114, 23);
            this.btnDisconnect.TabIndex = 10;
            this.btnDisconnect.Text = "Desconectar";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // txtTemp
            // 
            this.txtTemp.AutoSize = true;
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTemp.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtTemp.Location = new System.Drawing.Point(17, 270);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(90, 17);
            this.txtTemp.TabIndex = 11;
            this.txtTemp.Text = "Temperatura";
            // 
            // txtUmi
            // 
            this.txtUmi.AutoSize = true;
            this.txtUmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUmi.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtUmi.Location = new System.Drawing.Point(121, 270);
            this.txtUmi.Name = "txtUmi";
            this.txtUmi.Size = new System.Drawing.Size(64, 17);
            this.txtUmi.TabIndex = 13;
            this.txtUmi.Text = "Umidade";
            // 
            // txtPress
            // 
            this.txtPress.AutoSize = true;
            this.txtPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPress.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPress.Location = new System.Drawing.Point(198, 270);
            this.txtPress.Name = "txtPress";
            this.txtPress.Size = new System.Drawing.Size(60, 17);
            this.txtPress.TabIndex = 14;
            this.txtPress.Text = "Pressão";
            // 
            // txtVib
            // 
            this.txtVib.AutoSize = true;
            this.txtVib.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVib.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtVib.Location = new System.Drawing.Point(317, 270);
            this.txtVib.Name = "txtVib";
            this.txtVib.Size = new System.Drawing.Size(64, 17);
            this.txtVib.TabIndex = 15;
            this.txtVib.Text = "Vibração";
            // 
            // txtLevel
            // 
            this.txtLevel.AutoSize = true;
            this.txtLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLevel.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtLevel.Location = new System.Drawing.Point(267, 270);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(39, 17);
            this.txtLevel.TabIndex = 16;
            this.txtLevel.Text = "Nível";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTemp.ForeColor = System.Drawing.Color.Black;
            this.lblTemp.Location = new System.Drawing.Point(417, 238);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(16, 17);
            this.lblTemp.TabIndex = 17;
            this.lblTemp.Text = "0";
            // 
            // lblUmi
            // 
            this.lblUmi.AutoSize = true;
            this.lblUmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUmi.ForeColor = System.Drawing.Color.Black;
            this.lblUmi.Location = new System.Drawing.Point(138, 318);
            this.lblUmi.Name = "lblUmi";
            this.lblUmi.Size = new System.Drawing.Size(16, 17);
            this.lblUmi.TabIndex = 18;
            this.lblUmi.Text = "0";
            // 
            // lblPres
            // 
            this.lblPres.AutoSize = true;
            this.lblPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPres.ForeColor = System.Drawing.Color.Black;
            this.lblPres.Location = new System.Drawing.Point(225, 305);
            this.lblPres.Name = "lblPres";
            this.lblPres.Size = new System.Drawing.Size(16, 17);
            this.lblPres.TabIndex = 19;
            this.lblPres.Text = "0";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLevel.ForeColor = System.Drawing.Color.Black;
            this.lblLevel.Location = new System.Drawing.Point(279, 305);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(16, 17);
            this.lblLevel.TabIndex = 20;
            this.lblLevel.Text = "0";
            // 
            // lblVib
            // 
            this.lblVib.AutoSize = true;
            this.lblVib.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVib.ForeColor = System.Drawing.Color.Black;
            this.lblVib.Location = new System.Drawing.Point(339, 305);
            this.lblVib.Name = "lblVib";
            this.lblVib.Size = new System.Drawing.Size(16, 17);
            this.lblVib.TabIndex = 21;
            this.lblVib.Text = "0";
            // 
            // btnSaibaMais
            // 
            this.btnSaibaMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaibaMais.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSaibaMais.Location = new System.Drawing.Point(68, 73);
            this.btnSaibaMais.Name = "btnSaibaMais";
            this.btnSaibaMais.Size = new System.Drawing.Size(114, 23);
            this.btnSaibaMais.TabIndex = 22;
            this.btnSaibaMais.Text = "Saiba Mais";
            this.btnSaibaMais.UseVisualStyleBackColor = true;
            this.btnSaibaMais.Click += new System.EventHandler(this.btnSaibaMais_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 100);
            this.panel1.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(142, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(465, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sistema Supervisório";
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAuto.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAuto.Location = new System.Drawing.Point(3, 44);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(114, 23);
            this.btnAuto.TabIndex = 24;
            this.btnAuto.Text = "Automático";
            this.btnAuto.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(126, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Manual";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.AliceBlue;
            this.panelRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRegister.Controls.Add(this.richTextBoxAlertas);
            this.panelRegister.Location = new System.Drawing.Point(531, 238);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(257, 200);
            this.panelRegister.TabIndex = 26;
            // 
            // richTextBoxAlertas
            // 
            this.richTextBoxAlertas.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxAlertas.Name = "richTextBoxAlertas";
            this.richTextBoxAlertas.Size = new System.Drawing.Size(247, 190);
            this.richTextBoxAlertas.TabIndex = 0;
            this.richTextBoxAlertas.Text = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblBroker);
            this.panel2.Controls.Add(this.lblIP);
            this.panel2.Controls.Add(this.lblTopic);
            this.panel2.Controls.Add(this.txtBroker);
            this.panel2.Controls.Add(this.txtTopic);
            this.panel2.Controls.Add(this.txtIP);
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Controls.Add(this.btnDisconnect);
            this.panel2.Controls.Add(this.lblConectionStatus);
            this.panel2.Controls.Add(this.lblConnection);
            this.panel2.Location = new System.Drawing.Point(12, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 121);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnAuto);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnSaibaMais);
            this.panel3.Location = new System.Drawing.Point(536, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 121);
            this.panel3.TabIndex = 28;
            // 
            // pBarTemp
            // 
            this.pBarTemp.Location = new System.Drawing.Point(51, 305);
            this.pBarTemp.Name = "pBarTemp";
            this.pBarTemp.RightToLeftLayout = true;
            this.pBarTemp.Size = new System.Drawing.Size(30, 100);
            this.pBarTemp.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBarTemp);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVib);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblPres);
            this.Controls.Add(this.lblUmi);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtVib);
            this.Controls.Add(this.txtPress);
            this.Controls.Add(this.txtUmi);
            this.Controls.Add(this.txtTemp);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBroker;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox txtBroker;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblConectionStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label txtTemp;
        private System.Windows.Forms.Label txtUmi;
        private System.Windows.Forms.Label txtPress;
        private System.Windows.Forms.Label txtVib;
        private System.Windows.Forms.Label txtLevel;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblUmi;
        private System.Windows.Forms.Label lblPres;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblVib;
        private System.Windows.Forms.Button btnSaibaMais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.RichTextBox richTextBoxAlertas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar pBarTemp;
    }
}

