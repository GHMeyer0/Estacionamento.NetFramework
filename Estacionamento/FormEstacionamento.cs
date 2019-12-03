using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstacionamentoSem
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
            int cancelaEntrada = Convert.ToInt32(textBoxCancelaEntrada.Text);
            int cancelaSaida = Convert.ToInt32(textBoxCancelaSaida.Text);
            textBoxQuantidadeVagas.Enabled = false;
            textBoxCancelaEntrada.Enabled = false;
            textBoxCancelaSaida.Enabled = false;
            estacionamento = new Estacionamento(quantidadeVagas,cancelaEntrada, cancelaSaida);
            estacionamento.cancelaEntrada[0].Start(this);
        }

        public static void UpdateOutput(FormEstacionamento form, string value)
        {
            form.labelOutput.Text += value;
        }

        private void buttonEntraCarro_Click(object sender, EventArgs e)
        {
            estacionamento.filaEntrada += Convert.ToInt32(textBoxQuantidadeCarroEntrar.Text);
        }
    }
}
