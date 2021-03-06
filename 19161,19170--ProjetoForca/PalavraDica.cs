﻿// Gabriel Alves de Arruda 19170    
// Angelo Gomes Pescarini 19161

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19161_19170__ProjetoForca
{
    class PalavraDica : IComparable<PalavraDica>, IRegistro // deve ter um método de comparação e deve seguir a interface IRegistro
    {
        private string palavraUsada;
        private string dicaUsada;


        const int tamanhoPalavra = 15;
        const int tamanhoDica = 100;

        const int inicioPalavra = 0;
        const int inicioDica = inicioPalavra + tamanhoPalavra;

        public PalavraDica(string palavra, string dica) // são lidos e divididos em strings a palavra e sua respectiva dica
        {
            palavraUsada = palavra;
            dicaUsada = dica;
        }

        public string PalavraUsada { get => palavraUsada; set => palavraUsada = value; } // acessam as palavras utilizadas
        public string DicaUsada { get => dicaUsada; set => dicaUsada = value; }  //sem os gets e os sets, as strings
                                                                                 //poderiam ser modificadas fora da classe
        public void LerRegistro(StreamReader arq) //le o registro de um arquivo passado como parâmetro
        {
            if (!arq.EndOfStream) // se o arquivo não acabou
            {
                String linha = arq.ReadLine(); // linha do arquivo
                palavraUsada = linha.Substring(inicioPalavra, tamanhoPalavra); //divide a linha em strings "palavraUsada" e "dicaUsada"
                dicaUsada = linha.Substring(inicioDica, tamanhoDica);
            }
        }

        public PalavraDica() // construtor vazio, pois a classe segue a interface IRegistro
        {

        }
        public int CompareTo(PalavraDica outra) //método CompareTo
        {
             return palavraUsada.Trim().CompareTo(outra.palavraUsada.Trim());
        }

        public String ParaArquivo()
        {
            return palavraUsada.PadRight(15, ' ') + dicaUsada.PadRight(100,' ');
        }
    }
}
