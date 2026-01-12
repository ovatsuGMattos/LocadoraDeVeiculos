using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LocadoraDeVeiculos.Dominio.FotoModule
{
    public class Foto : EntidadeBase
    {
        public Image Imagem { get; set; }

        public Foto()
        {
        }

        public Foto(Image imagem)
        {
            Imagem = imagem;
        }

        public override string Validar()
        {
            return "Esta_Valido";
        }

    }
}
