using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EstacionamentoFramework
{
    public class Estacionamento
    {
        public SemaphoreSlim vagasDisponiveis;
        public SemaphoreSlim filaEntrada, filaSaida;
        public int quantidadeVagas;
        public readonly Thread[] cancelaEntrada, cancelaSaida;
        public Estacionamento(int quantidadeVagas, int entradas, int saidas)
        {
            this.quantidadeVagas = quantidadeVagas;
            vagasDisponiveis = new SemaphoreSlim(quantidadeVagas, quantidadeVagas);
            filaEntrada = new SemaphoreSlim(0);
            filaSaida = new SemaphoreSlim(0);

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
