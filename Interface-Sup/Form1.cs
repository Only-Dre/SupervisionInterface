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

        // Definindo Tópico
        private const string TOPICO = "industria/sensores";
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
                    lblTemp.Text = $"{dados.Temp:F1} °C";
                    lblUmi.Text = $"{dados.Umi:F1} %";
                    lblPres.Text = $"{dados.Pres:F2} bar";
                    lblVib.Text = $"{dados.Vib:F1} Hz";
                    lblLevel.Text = $"{dados.Level:F1} %";

                    if (dados.Temp > 80)
                    {
                        string alerta = $"[{DateTime.Now:HH:mm:ss}] Temperatura acima do limite: {dados.Temp:F1}°C";
                        richTextBoxAlertas.AppendText(alerta + Environment.NewLine);
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
                await clienteMqtt.SubscribeAsync(txtIP.Text);

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
            public int Temp { get; set; }
            public string Umi { get; set; }
            public int Pres { get; set; }
            public int Level { get; set; }
            public string Vib { get; set; }

        }

        // Funcionalidade de linkagem - website explicativo
        private void btnSaibaMais_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com");
        }
    }
}
