using System;
using System.Collections.Generic;
using System.Text;
namespace EstacionamentoSem
{
    public static class Cancela
    {
        public static void Entrada(object form)
        {
            FormEstacionamento _form = (FormEstacionamento)form;
            while (true)
            {
                if (FormEstacionamento.estacionamento.filaEntrada > 0)
                {
                    FormEstacionamento.estacionamento.vagasDisponiveis.WaitOne();
                    int numeroVaga = Vaga.BuscarVagaLivre(FormEstacionamento.estacionamento.vagas);
                    Vaga.OcuparVaga(numeroVaga);
                    FormEstacionamento.estacionamento.filaEntrada--;
                    FormEstacionamento.UpdateOutput(_form, "Ir para Vaga: " + numeroVaga + "\n");
                }
            }
        }
        public static void Saida()
        {

        }
    }
}
