using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Adição de Funcionalidades para comunicação MQTT
using MQTTnet;
using MQTTnet.Client;
using Newtonsoft.Json;

namespace Int_Supervisoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
