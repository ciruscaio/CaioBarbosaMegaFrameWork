using System;
using System.Collections.Generic;
using System.Text;

namespace Excecao
{
    /// <summary>
    /// Classe responsável por encapsular as exceções da camada de Negócio
    /// </summary>
    public class InterfaceException : ApplicationException
    {
        /// <summary>
        /// Construtor herda base() (AplicationException)
        /// </summary>
        public InterfaceException() : base()
        {
        }

        /// <summary>
        /// Método que lança uma exceção para a camada superior
        /// </summary>
        /// <param name="mensagem">mensagem lançada</param>
        public InterfaceException(string mensagem) : base(mensagem)
        {
        }

        /// <summary>
        /// Método que lança uma exceção para a camada superior
        /// </summary>
        /// <param name="mensagem">mensagem lançada</param>
        /// <param name="erro">erro lançado</param>
        public InterfaceException(string mensagem, Exception erro)
            : base(mensagem, erro)
        {
        }
    }
}
