using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanfeSharp;
using DanfeSharp.Modelo;

namespace TesteDanfe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicando o caminho da imagem para a logo
            var logoPath = @"C:\Temp\Danfe\Logo\logo.jpg";
            //Cria o modelo a partir do arquivo Xml da NF-e.
            var modelo = DanfeViewModelCreator.CriarDeArquivoXml(@"C:\Temp\Danfe\XML\26190935523703000189550010000012611000025220-nfe.xml");
            //Inicia o Danfe com o modelo criado
            using (var danfe = new Danfe(modelo))
            {
                danfe.AdicionarLogoImagem(logoPath);
                danfe.Gerar();
                danfe.Salvar("TestedanfeLogo.pdf");
            }
            
        }
    }
}
