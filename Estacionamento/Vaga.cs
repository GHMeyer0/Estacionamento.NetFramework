using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EstacionamentoSem
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
                if (vaga.Livre == true)
                {
                    return vaga.Numero;
                }
            }
            return 0;
        }

        public static void OcuparVaga(int numeroVaga)
        {
            FormEstacionamento.estacionamento.vagas[numeroVaga - 1].Livre = false;
        }
    }
}
