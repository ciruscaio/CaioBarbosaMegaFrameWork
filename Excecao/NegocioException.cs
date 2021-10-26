using System;
using System.Collections.Generic;
using System.Text;

namespace Excecao
{
    /// <summary>
    /// Classe responsável por encapsular as exceções da camada de Negócio
    /// </summary>
    public class NegocioException : ApplicationException
    {
        /// <summary>
        /// Construtor herda base() (AplicationException)
        /// </summary>
        public NegocioException() : base()
        {
        }

        /// <summary>
        /// Método que lança uma exceção para a camada superior
        /// </summary>
        /// <param name="mensagem">mensagem lançada</param>
        public NegocioException(string mensagem) : base(mensagem)
        {
        }

        /// <summary>
        /// Método que lança uma exceção para a camada superior
        /// </summary>
        /// <param name="mensagem">mensagem lançada</param>
        /// <param name="erro">erro lançado</param>
        public NegocioException(string mensagem, Exception erro)
            : base(mensagem, erro)
        {
        }
    }
}
