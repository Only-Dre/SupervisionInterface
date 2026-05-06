using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Packages para comunicação
using MQTTnet;
using MQTTnet.Client;
using Newtonsoft.Json;

namespace Interface_Sup
{
    public partial class Form1 : Form
    {
        // Criação do 'clienteMqtt'
        private IMqttClient clienteMqtt;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            // Criação do Cliente
            var supervisorClient = new MqttFactory();
            clienteMqtt = supervisorClient.CreateMqttClient();

            // Registro do evento de recebimento de mensagens
            clienteMqtt.ApplicationMessageReceivedAsync += eMensagem =>
            {
                // Conversão de mensagem recebida para string
                string mensagem = Encoding.UTF8.GetString(eMensagem.ApplicationMessage.Payload);

                // Conversão JSON para object
                DadosMqtt dados = JsonConvert.DeserializeObject<DadosMqtt>(mensagem);

                // Atualização in-screen
                Invoke((MethodInvoker)delegate
                {                
                    // Barra de Temperatura
                    pBarTemp.Minimum = 0;
                    pBarTemp.Maximum = 100;
                    pBarTemp.Value = Math.Min(100, (int)dados.Temp);

                    lblUmi.Text = dados.Umi.ToString();
                    lblPres.Text = dados.Pres.ToString();
                    lblLevel.Text = dados.Level.ToString();
                    lblVib.Text = dados.Vib.ToString();

                    // Alarmes
                    if (dados.Temp >= 75)
                    {
                        string alerta = $"[{DateTime.Now:HH:mm:ss}] TEMPERATURA ALTA: {dados.Temp}°C";
                        richTextBoxAlertas.AppendText(alerta + Environment.NewLine);
                        pBarTemp.BarColor = Color.Red; // muda cor da barra no alarme
                    }
                    else
                    {
                        pBarTemp.BarColor = Color.LimeGreen; // cor normal
                    }

                    pBarTemp.Invalidate(); // força redesenho da barra

                    if (dados.Vib >= 18) // Vib >= 18mm/s
                    {
                        string alerta = $"[{DateTime.Now:HH:mm:ss}] VIBRAÇÃO ALTA: {dados.Vib} mm/s";
                        richTextBoxAlertas.AppendText(alerta + Environment.NewLine);
                        lblVib.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblVib.ForeColor = Color.Black;
                    }
                });

                return System.Threading.Tasks.Task.CompletedTask;
            };

            // Config de Conexão
            var opcoes = new MqttClientOptionsBuilder()
                .WithTcpServer(txtBroker.Text, int.Parse(txtIP.Text))
                .Build();

            // Try Catch para funcionalidade de conexão - altera o estado do texto e botão
            try
            {
                await clienteMqtt.ConnectAsync(opcoes);
                await clienteMqtt.SubscribeAsync("industria/sensores");
                lblConnection.Text = "Conectado";
                lblConnection.ForeColor = Color.DarkGreen;
            }
            catch
            {
                lblConnection.Text = "Desconectado";
                lblConnection.ForeColor = Color.Red;
            }
        }

        public class DadosMqtt
        {
            public double Temp { get; set; }
            public double Umi { get; set; }
            public double Pres { get; set; }
            public double Level { get; set; }
            public double Vib { get; set; }
        }

        // Funcionalidade de linkagem - website explicativo
        private void btnSaibaMais_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com");
        }

        private async void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (clienteMqtt != null && clienteMqtt.IsConnected)
            {
                await clienteMqtt.DisconnectAsync();
                lblConnection.Text = "Desconectado";
                lblConnection.ForeColor = Color.Red;
            }
        }
    }
}