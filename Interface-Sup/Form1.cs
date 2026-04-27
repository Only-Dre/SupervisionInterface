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
                    lblTemp.Text = dados.Temp.ToString();
                    pBarTemp.Minimum = 0;
                    pBarTemp.Maximum = 100;
                    pBarTemp.Value = dados.Temp;

                    lblUmi.Text = dados.Umi.ToString();
                    lblPres.Text = dados.Pres.ToString();
                    lblLevel.Text = dados.Level.ToString();
                    lblVib.Text = dados.Vib.ToString();

                    if (dados.Temp > 80)
                    {
                        //$  => Jeito moderno de concatenar
                        //[] => Visual para apresentar a data, aparentemente [20:31:22]
                        string alerta = $"[{DateTime.Now:HH:mm:ss}] Temperatura acima do limite: {dados.Temp}°";
                        richTextBoxAlertas.AppendText(alerta + Environment.NewLine );
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
