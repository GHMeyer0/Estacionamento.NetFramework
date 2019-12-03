using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoFramework
{
    public partial class FormEstacionamento : Form
    {
        public static Estacionamento estacionamento;
        public FormEstacionamento()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            int quantidadeVagas = Convert.ToInt32(textBoxQuantidadeVagas.Text);
            int quantidadeCancelaEntrada = Convert.ToInt32(textBoxCancelaEntrada.Text);
            int quantidadeCancelaSaida = Convert.ToInt32(textBoxCancelaSaida.Text);
            panelConfig.Enabled = false;
            estacionamento = new Estacionamento(quantidadeVagas, quantidadeCancelaEntrada, quantidadeCancelaSaida);

            for (int i = 0; i < estacionamento.cancelaEntrada.Length; i++)
            {
                estacionamento.cancelaEntrada[i].Start(this);
            }
            for (int i = 0; i < estacionamento.cancelaSaida.Length; i++)
            {
                estacionamento.cancelaSaida[i].Start(this);
            }
        }

        public static void UpdateOutput(FormEstacionamento form, string value)
        {
            form.labelOutput.Text += value;
        }

        public static void UpdateGrid(FormEstacionamento form)
        {

        }

        private void buttonEntraCarro_Click(object sender, EventArgs e)
        {
            int quantidadeCarros = Convert.ToInt32(textBoxQuantidadeCarroEntrar.Text);
            for (int i = 0; i < quantidadeCarros; i++)
            {
                estacionamento.filaEntrada.Release();
            }
        }

        private void buttonSairCarro_Click(object sender, EventArgs e)
        {
            int quantidadeCarros = Convert.ToInt32(textBoxQuantidadeCarroSair.Text);
            for (int i = 0; i < quantidadeCarros; i++)
            {
                estacionamento.filaSaida.Release();
            }
        }
    }
}
