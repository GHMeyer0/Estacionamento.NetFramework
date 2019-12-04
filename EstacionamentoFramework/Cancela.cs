using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EstacionamentoFramework
{
    public static class Cancela
    {
        public static SemaphoreSlim fila = new SemaphoreSlim(1, 1);
        public static void Entrada()
        {
            while (true)
            {
                if (FormEstacionamento.estacionamento.filaEntrada.CurrentCount > 0)
                {
                    if (FormEstacionamento.estacionamento.filaEntrada.CurrentCount < FormEstacionamento.estacionamento.vagasDisponiveis.CurrentCount)
                    {
                        FormEstacionamento.estacionamento.filaEntrada.Wait();
                        FormEstacionamento.estacionamento.vagasDisponiveis.Wait();
                        int numeroVaga = FormEstacionamento.estacionamento.vagasDisponiveis.CurrentCount;
                        Console.WriteLine("Dirija-se a vaga: " + (numeroVaga + 1));
                        Vaga.OcupaVaga(numeroVaga);
                    }
                    else
                    {
                        Console.WriteLine("Vagas Esgotas, Favor aguardar!");
                        FormEstacionamento.estacionamento.filaEntrada.Wait();
                    }
                }
            }
        }
        public static void Saida()
        {
            while (true)
            {
                if (FormEstacionamento.estacionamento.filaSaida.CurrentCount > 0)
                {
                    if (FormEstacionamento.estacionamento.vagasDisponiveis.CurrentCount < FormEstacionamento.estacionamento.quantidadeVagas)
                    {
                        FormEstacionamento.estacionamento.filaSaida.Wait();
                        _ = FormEstacionamento.estacionamento.vagasDisponiveis.CurrentCount;
                        int numeroVaga = FormEstacionamento.estacionamento.vagasDisponiveis.Release();
                        Console.WriteLine("Vaga numero " + (numeroVaga + 1) + " Liberada");
                        Vaga.LiberaVaga(numeroVaga);
                    }
                    else
                    {
                        FormEstacionamento.estacionamento.filaSaida.Wait();
                        Console.WriteLine("Todas as Vagas estão liberadas, Favor contatar o supote");
                    }
                }
            }

        }
    }
}
