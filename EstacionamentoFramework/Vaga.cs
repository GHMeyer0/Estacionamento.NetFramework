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

        public static int BuscarVagaLivre(Vaga[] vagas)
        {
            foreach (var vaga in vagas)
            {
                if (vaga.Livre)
                {
                    return vaga.Numero;
                }
            }
            return 0;
        }

        public static int BuscarVagaOcupada(Vaga[] vagas)
        {
            var random = new Random();
            List<int> vagas_ocupadas = new List<int>();
            for (int i = 0; i < vagas.Length; i++)
            {
                if (!vagas[i].Livre)
                {
                    int x = vagas[i].Numero;
                    vagas_ocupadas.Add(x);
                }
            }
            
            int index = random.Next(vagas_ocupadas.Count);
            return vagas_ocupadas[index];
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
