using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EstacionamentoSem
{
    public class Estacionamento
    {
        public Vaga[] vagas;
        public Semaphore vagasDisponiveis;
        public int filaEntrada, filaSaida;
        public readonly Thread[] cancelaEntrada, cancelaSaida;
        public Estacionamento(int quantidadeVagas, int entradas, int saidas)
        {
            vagas = Vaga.CriarVagas(quantidadeVagas);
            vagasDisponiveis = new Semaphore(quantidadeVagas, quantidadeVagas);

            cancelaEntrada = new Thread[entradas];
            for (int i = 0; i < entradas; i++)
            {
                cancelaEntrada[i] = new Thread(Cancela.Entrada);
            }

            cancelaSaida = new Thread[saidas];
            for (int i = 0; i < saidas; i++)
            {
                cancelaSaida[i] = new Thread(Cancela.Saida);
            }
        }
    }
}
