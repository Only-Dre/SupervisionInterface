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
            this.lblConection = new System.Windows.Forms.Label();
            this.lblConectionStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUmi = new System.Windows.Forms.Label();
            this.txtPress = new System.Windows.Forms.Label();
            this.txtVib = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblUmi = new System.Windows.Forms.Label();
            this.lblPres = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblVib = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBroker
            // 
            this.lblBroker.AutoSize = true;
            this.lblBroker.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 8.25F);
            this.lblBroker.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblBroker.Location = new System.Drawing.Point(17, 108);
            this.lblBroker.Name = "lblBroker";
            this.lblBroker.Size = new System.Drawing.Size(45, 15);
            this.lblBroker.TabIndex = 1;
            this.lblBroker.Text = "Broker";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 8.25F);
            this.lblIP.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIP.Location = new System.Drawing.Point(306, 108);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(38, 15);
            this.lblIP.TabIndex = 2;
            this.lblIP.Text = "Porta";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 8.25F);
            this.lblTopic.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTopic.Location = new System.Drawing.Point(162, 108);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(42, 15);
            this.lblTopic.TabIndex = 3;
            this.lblTopic.Text = "Tópico";
            // 
            // txtBroker
            // 
            this.txtBroker.Location = new System.Drawing.Point(20, 126);
            this.txtBroker.Name = "txtBroker";
            this.txtBroker.Size = new System.Drawing.Size(100, 20);
            this.txtBroker.TabIndex = 4;
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(165, 126);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(100, 20);
            this.txtTopic.TabIndex = 5;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(309, 126);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 6;
            // 
            // lblConection
            // 
            this.lblConection.AutoSize = true;
            this.lblConection.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 12F);
            this.lblConection.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblConection.Location = new System.Drawing.Point(185, 159);
            this.lblConection.Name = "lblConection";
            this.lblConection.Size = new System.Drawing.Size(87, 22);
            this.lblConection.TabIndex = 7;
            this.lblConection.Text = "Pendente";
            // 
            // lblConectionStatus
            // 
            this.lblConectionStatus.AutoSize = true;
            this.lblConectionStatus.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 12F);
            this.lblConectionStatus.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblConectionStatus.Location = new System.Drawing.Point(16, 159);
            this.lblConectionStatus.Name = "lblConectionStatus";
            this.lblConectionStatus.Size = new System.Drawing.Size(163, 22);
            this.lblConectionStatus.TabIndex = 8;
            this.lblConectionStatus.Text = "Status de Conexão:";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 10F);
            this.btnConnect.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnConnect.Location = new System.Drawing.Point(462, 104);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 10F);
            this.btnDisconnect.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDisconnect.Location = new System.Drawing.Point(462, 147);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(114, 23);
            this.btnDisconnect.TabIndex = 10;
            this.btnDisconnect.Text = "Desconectar";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // txtTemp
            // 
            this.txtTemp.AutoSize = true;
            this.txtTemp.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 10F);
            this.txtTemp.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtTemp.Location = new System.Drawing.Point(16, 234);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(98, 19);
            this.txtTemp.TabIndex = 11;
            this.txtTemp.Text = "Temperatura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // txtUmi
            // 
            this.txtUmi.AutoSize = true;
            this.txtUmi.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 10F);
            this.txtUmi.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtUmi.Location = new System.Drawing.Point(120, 234);
            this.txtUmi.Name = "txtUmi";
            this.txtUmi.Size = new System.Drawing.Size(71, 19);
            this.txtUmi.TabIndex = 13;
            this.txtUmi.Text = "Umidade";
            // 
            // txtPress
            // 
            this.txtPress.AutoSize = true;
            this.txtPress.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 10F);
            this.txtPress.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPress.Location = new System.Drawing.Point(197, 234);
            this.txtPress.Name = "txtPress";
            this.txtPress.Size = new System.Drawing.Size(63, 19);
            this.txtPress.TabIndex = 14;
            this.txtPress.Text = "Pressão";
            // 
            // txtVib
            // 
            this.txtVib.AutoSize = true;
            this.txtVib.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 10F);
            this.txtVib.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtVib.Location = new System.Drawing.Point(316, 234);
            this.txtVib.Name = "txtVib";
            this.txtVib.Size = new System.Drawing.Size(69, 19);
            this.txtVib.TabIndex = 15;
            this.txtVib.Text = "Vibração";
            // 
            // txtLevel
            // 
            this.txtLevel.AutoSize = true;
            this.txtLevel.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 10F);
            this.txtLevel.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtLevel.Location = new System.Drawing.Point(266, 234);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(44, 19);
            this.txtLevel.TabIndex = 16;
            this.txtLevel.Text = "Nível";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 10F);
            this.lblTemp.ForeColor = System.Drawing.Color.Black;
            this.lblTemp.Location = new System.Drawing.Point(26, 264);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(17, 19);
            this.lblTemp.TabIndex = 17;
            this.lblTemp.Text = "0";
            // 
            // lblUmi
            // 
            this.lblUmi.AutoSize = true;
            this.lblUmi.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 10F);
            this.lblUmi.ForeColor = System.Drawing.Color.Black;
            this.lblUmi.Location = new System.Drawing.Point(137, 282);
            this.lblUmi.Name = "lblUmi";
            this.lblUmi.Size = new System.Drawing.Size(17, 19);
            this.lblUmi.TabIndex = 18;
            this.lblUmi.Text = "0";
            // 
            // lblPres
            // 
            this.lblPres.AutoSize = true;
            this.lblPres.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 10F);
            this.lblPres.ForeColor = System.Drawing.Color.Black;
            this.lblPres.Location = new System.Drawing.Point(224, 269);
            this.lblPres.Name = "lblPres";
            this.lblPres.Size = new System.Drawing.Size(17, 19);
            this.lblPres.TabIndex = 19;
            this.lblPres.Text = "0";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 10F);
            this.lblLevel.ForeColor = System.Drawing.Color.Black;
            this.lblLevel.Location = new System.Drawing.Point(278, 269);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(17, 19);
            this.lblLevel.TabIndex = 20;
            this.lblLevel.Text = "0";
            // 
            // lblVib
            // 
            this.lblVib.AutoSize = true;
            this.lblVib.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 10F);
            this.lblVib.ForeColor = System.Drawing.Color.Black;
            this.lblVib.Location = new System.Drawing.Point(338, 269);
            this.lblVib.Name = "lblVib";
            this.lblVib.Size = new System.Drawing.Size(17, 19);
            this.lblVib.TabIndex = 21;
            this.lblVib.Text = "0";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 25F);
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(193, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(372, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sistema Supervisório";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVib);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblPres);
            this.Controls.Add(this.lblUmi);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtVib);
            this.Controls.Add(this.txtPress);
            this.Controls.Add(this.txtUmi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblConectionStatus);
            this.Controls.Add(this.lblConection);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.txtBroker);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblBroker);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label lblConection;
        private System.Windows.Forms.Label lblConectionStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label txtTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUmi;
        private System.Windows.Forms.Label txtPress;
        private System.Windows.Forms.Label txtVib;
        private System.Windows.Forms.Label txtLevel;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblUmi;
        private System.Windows.Forms.Label lblPres;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblVib;
        private System.Windows.Forms.Label lblTitle;
    }
}

