using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EstacionamentoFramework
{
    public static class Cancela
    {
        public static SemaphoreSlim fila = new SemaphoreSlim(1, 1);
        public static void Entrada(object form)
        {
            FormEstacionamento _form = (FormEstacionamento)form;
            while (true)
            {
                if (FormEstacionamento.estacionamento.filaEntrada.CurrentCount > 0)
                {
                    FormEstacionamento.estacionamento.filaEntrada.Wait();
                    FormEstacionamento.estacionamento.vagasDisponiveis.Wait();
                    int numeroVaga = FormEstacionamento.estacionamento.vagasDisponiveis.CurrentCount;
                    Console.WriteLine("Dirija-se a vaga: " + (numeroVaga + 1));
                    Vaga.OcupaVaga(numeroVaga);
                }
                else if (FormEstacionamento.estacionamento.filaEntrada.CurrentCount > 0)
                {
                    Console.WriteLine("Vagas Esgotas, Favor aguardar!");
                }
            }
        }
        public static void Saida(object form)
        {
            while (true)
            {
                if (FormEstacionamento.estacionamento.filaSaida.CurrentCount > 0 && FormEstacionamento.estacionamento.vagasDisponiveis.CurrentCount < FormEstacionamento.estacionamento.quantidadeVagas)
                {
                    FormEstacionamento.estacionamento.filaSaida.Wait();
                    int numeroVaga = FormEstacionamento.estacionamento.vagasDisponiveis.Release();
                    Console.WriteLine("Vaga numero " + (numeroVaga + 1) + " Liberada");
                    Vaga.LiberaVaga(numeroVaga);                    
                }
            }

        }
    }
}
