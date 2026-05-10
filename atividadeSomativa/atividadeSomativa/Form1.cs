using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet.Client;
using MQTTnet;
using MQTTnet.Client;
using Newtonsoft.Json;

namespace atividadeSomativa
{
    public partial class Form1 : Form
    {
        private IMqttClient clienteMqtt;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnConectar_Click(object sender, EventArgs e)
        {
            var fabrica = new MqttFactory();
            clienteMqtt = fabrica.CreateMqttClient();

            lblConexao.Text = "Conectado";
            lblConexao.ForeColor = Color.Green;

            clienteMqtt.ApplicationMessageReceivedAsync += eMensagem =>
            {
                string mensagem = Encoding.UTF8.GetString(eMensagem.ApplicationMessage.Payload);
                DadosMqtt dados = JsonConvert.DeserializeObject<DadosMqtt>(mensagem);

                Invoke((MethodInvoker)delegate
               {
                   lblTemperatura.Text = $"{dados.Temperatura}°C";
                   lblUmidade.Text = $"{dados.Umidade}%";
                   lblPressao.Text = $"{dados.Pressao} hPa";
                   lblVibracao.Text = $"{dados.Vibracao} m/s²";
                   lblNivel.Text = $"{dados.Nivel} m";

                   alarmes();
               });

                return System.Threading.Tasks.Task.CompletedTask;
            };

            var opcoes = new MqttClientOptionsBuilder()
                    .WithTcpServer(txtBroker.Text, int.Parse(txtPorta.Text))
                    .Build();

            await clienteMqtt.ConnectAsync(opcoes);

            await clienteMqtt.SubscribeAsync(txtTopico.Text);
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            lblConexao.Text = "Conectado";
            lblConexao.ForeColor = Color.Green;

            try
            {
                if (clienteMqtt != null)
                {
                    await clienteMqtt.DisconnectAsync();
                    MessageBox.Show("Desconectado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao desconectar: {ex.Message}", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLigarAlarme_Click(object sender, EventArgs e)
        {
        }

        private void alarmes()
        {
            VerificarAlarme(lblTemperatura.Text, 90, "Temperatura alta detectada!");
            VerificarAlarme(lblUmidade.Text, 95, "Umidade alta detectada!");
            VerificarAlarme(lblPressao.Text, 10, "Pressão alta detectada!");
            VerificarAlarme(lblVibracao.Text, 25, "Vibração alta detectada!");
            VerificarAlarme(lblNivel.Text, 100, "Nível alto detectado!");
        }


        private void VerificarAlarme(string textoLabel, double limite, string mensagemAlarme)
        {
            string apenasNumeros = System.Text.RegularExpressions.Regex.Replace(textoLabel, @"[^\d,.]", "");

            if (double.TryParse(apenasNumeros, out double valor))
            {
                if (valor >= limite)
                {
                    txtAlarmes.AppendText($"[{DateTime.Now:HH:mm:ss}] {mensagemAlarme}{Environment.NewLine}");
                    txtAlarmes.ScrollToCaret();
                }
            }
        }

        private void btnDesligarAlarme_Click(object sender, EventArgs e)
        {
            txtAlarmes.Clear();
        }

    }
}
