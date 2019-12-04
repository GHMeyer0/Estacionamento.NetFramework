using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            panelIO.Enabled = true;
            

            for (int i = 1; i < estacionamento.cancelaEntrada.Length; i++)
            {
                estacionamento.cancelaEntrada[i].Start();
            }
            for (int i = 0; i < estacionamento.cancelaSaida.Length; i++)
            {
                estacionamento.cancelaSaida[i].Start();
            }
        }
        private void buttonEntraCarro_Click(object sender, EventArgs e)
        {
            int quantidadeCarros = Convert.ToInt32(textBoxQuantidadeCarroEntrar.Text);
            estacionamento.filaEntrada = new SemaphoreSlim(quantidadeCarros);
        }

        private void buttonSairCarro_Click(object sender, EventArgs e)
        {
            int quantidadeCarros = Convert.ToInt32(textBoxQuantidadeCarroSair.Text);
            estacionamento.filaSaida = new SemaphoreSlim(quantidadeCarros);
        }
    }
}
