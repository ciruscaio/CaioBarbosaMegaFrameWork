using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Util
{
    /// <summary>
    /// sdfgsdfg asd.
    /// </summary>
    public class ManipulaImagem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDiretorio"></param>
        /// <param name="pImagemEmRessources"></param>
        /// <param name="pAltura"></param>
        /// <param name="pLargura"></param>
        /// <returns></returns>
        public Bitmap ModificarImagem_PorPercentual(string pDiretorio, string pImagemEmRessources, int pAltura, int pLargura)
        {
            // Carrega imagem original
            Bitmap original = (Bitmap)Image.FromFile(pDiretorio + "\\" + pImagemEmRessources + "\\");
            // Bitmap para nova imagem com 50% do tamanho original
            Bitmap modificada = new Bitmap((int)(((float)pLargura / 100) * original.Width), (int)(((float)pLargura / 100) * original.Height));
            // Redimensiona imagem
            modificada = (Bitmap)original.GetThumbnailImage(modificada.Width, modificada.Height, null, IntPtr.Zero);

            return modificada;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDiretorio"></param>
        /// <param name="pImagemEmRessources"></param>
        /// <param name="pRatio"></param>
        /// <returns></returns>
        public Bitmap ModificarImagem_PorRatio(string pDiretorio, string pImagemEmRessources, int pRatio)
        {
            // Carrega imagem original
            Bitmap original = (Bitmap)Image.FromFile(pDiretorio + "\\" + pImagemEmRessources + "\\");
            // Bitmap para nova imagem com 50% do tamanho original
            Bitmap modificada = new Bitmap((int)(((float)pRatio / 100) * original.Width), (int)(((float)pRatio / 100) * original.Height));
            // Redimensiona imagem
            modificada = (Bitmap)original.GetThumbnailImage(modificada.Width, modificada.Height, null, IntPtr.Zero);

            return modificada;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDiretorio"></param>
        /// <param name="pImagemEmRessources"></param>
        /// <param name="pAltura"></param>
        /// <param name="pLargura"></param>
        /// <returns></returns>
        public Bitmap ModificarImagem_PorLarguraEAltura(string pDiretorio, string pImagemEmRessources, int pAltura, int pLargura)
        {
            // Carrega imagem original
            Bitmap original = (Bitmap)Image.FromFile(pDiretorio + "\\" + pImagemEmRessources + "\\");

            Bitmap modificada = new Bitmap(pAltura, pLargura);
            // Redimensiona imagem
            modificada = (Bitmap)original.GetThumbnailImage(modificada.Width, modificada.Height, null, IntPtr.Zero);

            return modificada;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDiretorio"></param>
        /// <param name="pImagem"></param>
        /// <param name="pAltura"></param>
        /// <param name="pLargura"></param>
        /// <returns></returns>
        public Bitmap ModificarImagemEmBitman_PorLarguraEAltura(string pDiretorio, Image pImagem, int pAltura, int pLargura)
        {
            // Carrega imagem original
            Bitmap original = (Bitmap)pImagem;

            Bitmap modificada = new Bitmap(pAltura, pLargura);
            // Redimensiona imagem
            modificada = (Bitmap)original.GetThumbnailImage(modificada.Width, modificada.Height, null, IntPtr.Zero);

            return modificada;
        }
    }
}