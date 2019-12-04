using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EstacionamentoFramework
{
    public class Vaga
    {
        private int Numero { get; set; }
        private bool Livre;
        public Vaga(int numeroVaga)
        {
            Numero = numeroVaga;
            Livre = true;
        }
        public static Vaga[] CriarVagas(int quantidade)
        {
            Vaga[] vagas = new Vaga[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                vagas[i] = new Vaga(i + 1);
            }
            return vagas;
        }
        public static void OcupaVaga(int numeroVaga)
        {
            FormEstacionamento.estacionamento.vagas[numeroVaga].Livre = false;
        }
        public static void LiberaVaga(int numeroVaga)
        {
            FormEstacionamento.estacionamento.vagas[numeroVaga].Livre = true;
        }
    }
}
