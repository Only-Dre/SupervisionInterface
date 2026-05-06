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
            this.btnSaibaMais = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.richTextBoxAlertas = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.pBarTemp = new Interface_Sup.VerticalProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUmi = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPres = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblVib = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.lblConnection.Location = new System.Drawing.Point(168, 91);
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
            this.lblConectionStatus.Location = new System.Drawing.Point(13, 91);
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
            this.btnDisconnect.Location = new System.Drawing.Point(377, 91);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(114, 23);
            this.btnDisconnect.TabIndex = 10;
            this.btnDisconnect.Text = "Desconectar";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnSaibaMais
            // 
            this.btnSaibaMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaibaMais.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSaibaMais.Location = new System.Drawing.Point(48, 108);
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
            this.lblTitle.Location = new System.Drawing.Point(155, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(465, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sistema Supervisório";
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAuto.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAuto.Location = new System.Drawing.Point(48, 42);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(114, 23);
            this.btnAuto.TabIndex = 24;
            this.btnAuto.Text = "Automático";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnManual
            // 
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnManual.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnManual.Location = new System.Drawing.Point(48, 71);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(114, 23);
            this.btnManual.TabIndex = 25;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.AliceBlue;
            this.panelRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRegister.Controls.Add(this.richTextBoxAlertas);
            this.panelRegister.Location = new System.Drawing.Point(572, 256);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(216, 182);
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
            this.panel2.Size = new System.Drawing.Size(554, 138);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnAuto);
            this.panel3.Controls.Add(this.btnManual);
            this.panel3.Controls.Add(this.btnSaibaMais);
            this.panel3.Location = new System.Drawing.Point(572, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 138);
            this.panel3.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTemp);
            this.groupBox1.Controls.Add(this.pBarTemp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 163);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperatura";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTemp.ForeColor = System.Drawing.Color.Black;
            this.lblTemp.Location = new System.Drawing.Point(71, 65);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(29, 31);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "0";
            // 
            // pBarTemp
            // 
            this.pBarTemp.BarColor = System.Drawing.Color.LimeGreen;
            this.pBarTemp.Location = new System.Drawing.Point(6, 22);
            this.pBarTemp.Name = "pBarTemp";
            this.pBarTemp.Size = new System.Drawing.Size(48, 135);
            this.pBarTemp.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUmi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(124, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 163);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Umidade";
            // 
            // lblUmi
            // 
            this.lblUmi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUmi.AutoSize = true;
            this.lblUmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblUmi.ForeColor = System.Drawing.Color.Black;
            this.lblUmi.Location = new System.Drawing.Point(38, 66);
            this.lblUmi.Name = "lblUmi";
            this.lblUmi.Size = new System.Drawing.Size(29, 31);
            this.lblUmi.TabIndex = 0;
            this.lblUmi.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPres);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(236, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 163);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pressão";
            // 
            // lblPres
            // 
            this.lblPres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPres.AutoSize = true;
            this.lblPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPres.ForeColor = System.Drawing.Color.Black;
            this.lblPres.Location = new System.Drawing.Point(38, 66);
            this.lblPres.Name = "lblPres";
            this.lblPres.Size = new System.Drawing.Size(29, 31);
            this.lblPres.TabIndex = 0;
            this.lblPres.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblLevel);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox4.Location = new System.Drawing.Point(348, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(106, 163);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nível";
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblLevel.ForeColor = System.Drawing.Color.Black;
            this.lblLevel.Location = new System.Drawing.Point(38, 66);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(29, 31);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblVib);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox5.Location = new System.Drawing.Point(460, 270);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(106, 163);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vibração";
            // 
            // lblVib
            // 
            this.lblVib.AutoSize = true;
            this.lblVib.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblVib.ForeColor = System.Drawing.Color.Black;
            this.lblVib.Location = new System.Drawing.Point(38, 66);
            this.lblVib.Name = "lblVib";
            this.lblVib.Size = new System.Drawing.Size(29, 31);
            this.lblVib.TabIndex = 0;
            this.lblVib.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Painel de modos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnSaibaMais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.RichTextBox richTextBoxAlertas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTemp;
        private VerticalProgressBar pBarTemp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUmi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPres;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblVib;
        private System.Windows.Forms.Label label1;
    }
}

