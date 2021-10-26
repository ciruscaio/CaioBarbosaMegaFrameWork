using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Randomico
    {
        public decimal GerarComPrecisao(double pMinimo, double pMaximo, int pPrecisao)
        {
            Random lSorteado = new Random();

            double lSorteadoEMaxEMin = (lSorteado.NextDouble() * (pMaximo - pMinimo) + pMinimo);

            decimal lSorteadoEMaxEMinEAjustado = Convert.ToDecimal(Math.Round(lSorteadoEMaxEMin, pPrecisao));

            return lSorteadoEMaxEMinEAjustado;
        }

        public List<decimal> GeraListaDeNumerosComPrecisao(double pMinimo, double pMaximo, int pPrecisao, int pQuantidadeDeNumeros)
        {
            List<decimal> lLista = new List<decimal>();
            decimal lNumeroSorteado;

            for (int i = 0; i < pQuantidadeDeNumeros; i++)
            {
                do
                {
                    lNumeroSorteado = GerarComPrecisao(pMinimo, pMaximo, pPrecisao);
                } while (lLista.Contains(lNumeroSorteado) == true);
                lLista.Add(lNumeroSorteado);
            }

            return lLista;
        }
    }
}
