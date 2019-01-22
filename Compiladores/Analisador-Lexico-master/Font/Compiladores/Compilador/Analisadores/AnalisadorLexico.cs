using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Compilador
{
 
    public class AnalisadorLexico
    {
        #region Variaveis Privadas

        Hashtable palavra;
        Hashtable simboloDuplo;
        Hashtable simboloSimples;
        Hashtable operador;

        /// <summary>
        ///Variavel Privada Token que aponta para o Inicio
        /// </summary>
        private Token inicio;

        /// <summary>
        ///Variavel Privada Token Aux
        /// </summary>
        private Token aux;

        /// <summary>
        ///Variavel Privada strCodigo Usada para apontar o Erro
        /// </summary>
        private string strcodigo;

        /// <summary>
        ///Variavel Privada Apntando para linha que deu o erro
        /// </summary>
        private int Linha;

        /// <summary>
        ///Variavel Privada que aponta para coluna que deu o erro
        /// </summary>
        private int Coluna;

        /// <summary>
        ///Variavel para auxiliar
        /// </summary>
        private int pos;

        #endregion

        #region Variaveis Publicas

        /// <summary>
        /// The Variavel Token
        /// </summary>
        public Token tk = new Token();

        /// <summary>
        /// Lista de token que vai conter os tokens encontrados
        /// </summary>
        public List<Token> lstToken = new List<Token>();
        public List<string> lstErros = new List<string>();

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor Analisador Lexico
        /// </summary>
        /// <param name="strCod">The string cod.</param>
        public AnalisadorLexico(String strCod)
        {
            strcodigo = strCod;
            pos = 0;
            cargaPalavra();
            cargasimboloDuplo();
            cargaSimboloSimples();
            cargaOperador();
        }

        #endregion

        #region Metodos Publicos

        /// <summary>
        /// Metodo que vai realixar analise Lexica
        /// </summary>
        /// <param name="codigo">The codigo.</param>
        /// <returns></returns>
        public bool realizaAnaliseLexica(StreamReader codigo)
        {

            char caracter = (char)codigo.Read();
            string valorToken = "";
            inicio = new Token();

            bool erroLexico = false;
            bool final = false; 
            int estado = 0;
            while (!erroLexico && !final)
            {
                switch (estado)
                {
                    case 0:
                        if (char.IsLetter(caracter))
                        {
                            estado = 1; 
                            valorToken += caracter;
                            caracter = (char)codigo.Read();
                            pos += 1;
                            break;
                        }
                        if (char.IsNumber(caracter))
                        {
                            estado = 2; 
                            valorToken += caracter;
                            caracter = (char)codigo.Read();
                            pos += 1;
                            break;
                        }
                        if (verificaEspacamento(caracter))
                        {
                            caracter = (char)codigo.Read();
                            pos += 1;
                            estado = 0; 
                            break;
                        }
                        if (verificaSimboloSimples(caracter) || verificaOperador(caracter))
                        {
                            if (caracter == '/')
                            {
                                valorToken += caracter;
                                estado = 5;                                
                                caracter = (char)codigo.Read();
                                pos += 1;
                                break;
                            }
                            if (caracter == '{')
                            {
                                estado = 6; // Comentário '{'
                                valorToken = "";
                                caracter = (char)codigo.Read();
                                pos += 1;
                                break;
                            }
                            if (caracter == '>' || caracter == '<' || caracter == ':')
                            {
                                valorToken += caracter;
                                estado = 7;
                                caracter = (char)codigo.Read();
                                pos += 1;
                                break;
                            }
                            adicionaListaToken(caracter.ToString(), "Símbolo simples");
                            caracter = (char)codigo.Read();
                            pos += 1;
                            valorToken = "";
                            estado = 0;
                            break;
                        }
                        if (codigo.EndOfStream)
                        {
                            final = true;
                            break;
                        }
                        erroLexico = true;
                        lstErros.Add("Erro Léxico 1 / " + RetorLinhaColuna(pos));                        
                        break; 

                    case 1: /* Palavra reservada ou identificador */
                        if (char.IsLetter(caracter) || char.IsNumber(caracter))
                        {
                            valorToken += caracter;
                            caracter = (char)codigo.Read();
                            pos += 1;
                            break;
                        }
                        if (verificaSimboloSimples(caracter) || verificaEspacamento(caracter) || verificaOperador(caracter) || codigo.EndOfStream)
                        {
                            estado = 0;
                            adicionaListaToken(valorToken, verificaPalavraReservada(valorToken) ? "Palavra Reservada" : "ident");
                            valorToken = "";
                            if (codigo.EndOfStream)
                            {                                
                                if (caracter == '.')
                                {
                                    valorToken += caracter;
                                    adicionaListaToken(valorToken, "Símbolo simples");
                                }
                                final = true;
                                setaInicioToken();
                            }
                            break;
                        }
                        erroLexico = true;
                        lstErros.Add("Erro Léxico! Caracter não permitido!" + RetorLinhaColuna(pos));

                        break;

                    case 2: /* Número inteiro */
                        if (char.IsNumber(caracter))
                        {
                            valorToken += caracter;
                            caracter = (char)codigo.Read();
                            pos += 1;
                            break;
                        }
                        if (caracter == '.')
                        {
                            valorToken += caracter;
                            caracter = (char)codigo.Read();
                            pos += 1;
                            estado = 3;
                            break;
                        }
                        if (verificaEspacamento(caracter) || verificaSimboloSimples(caracter))
                        {
                            adicionaListaToken(valorToken, "numero_int");
                            estado = 0;
                            valorToken = "";
                            break;
                        }
                        erroLexico = true;
                        lstErros.Add("Erro Léxico Num / " + RetorLinhaColuna(pos));
                        break;

                    case 3: /* Aux Número real */
                        if (char.IsNumber(caracter))
                        {
                            valorToken += caracter;
                            estado = 4;
                            caracter = (char)codigo.Read();
                            pos += 1;
                            break;
                        }
                        erroLexico = true;
                        lstErros.Add("Erro Léxico 2 / " + RetorLinhaColuna(pos));
                        break;

                    case 4: 
                        if (char.IsNumber(caracter))
                        {
                            valorToken += caracter;
                            caracter = (char)codigo.Read();
                            pos += 1;
                            break;
                        }
                        if (verificaEspacamento(caracter) || verificaOperador(caracter) || caracter == ';')
                        {
                            adicionaListaToken(valorToken, "numero_real");
                            valorToken = "";
                            estado = 0;
                            break;
                        }
                        erroLexico = true;
                        lstErros.Add("Erro Léxico 3 / " + RetorLinhaColuna(pos));
                        break;


                    case 5: /* Comentário "/*" ou Simbolo Simples */
                        if (caracter == '*')
                        {
                            caracter = (char)codigo.Read();
                            pos += 1;
                            var caracter2 = (char)codigo.Read();
                            pos += 1;
                            valorToken = "";
                            while (caracter != '*' && caracter2 != '/') 
                            {
                                caracter = (char)codigo.Read();
                                pos += 1;
                                caracter2 = (char)codigo.Read();
                                pos += 1;
                            }
                            break;
                        }
                        if (char.IsLetterOrDigit(caracter) || verificaEspacamento(caracter) || codigo.EndOfStream)
                        {
                            adicionaListaToken(valorToken, "Símbolo simples");
                            valorToken = "";
                            estado = 0;
                            break;
                        }
                        erroLexico = true;
                        lstErros.Add("Erro Léxico 4 / " + RetorLinhaColuna(pos));
                        break;
                    case 6: 
                        while (caracter != '}' || verificaEspacamento(caracter))
                        {
                            if (codigo.EndOfStream)
                            {
                                lstErros.Add("Erro Léxico, Não fechou o comentario!");
                                final = true;
                                break;
                            }

                            caracter = (char)codigo.Read();
                            pos += 1;
                        }
                        estado = 0;
                        caracter = (char)codigo.Read();
                        pos += 1;
                        break;
                    case 7: /* Simbolo duplo */
                        if (caracter == '>' || caracter == '=')
                        {
                            valorToken += caracter;
                            if (verificaSimboloDuplo(valorToken))
                            {
                                adicionaListaToken(valorToken, "Símbolo Duplo");
                                valorToken = "";
                                estado = 0;
                                caracter = (char)codigo.Read();
                                pos += 1;
                                break;
                            }
                            erroLexico = true;
                            lstErros.Add("Erro Léxico, simbolo duplo não existe!" + RetorLinhaColuna(pos));
                            break;
                        }
                        if (verificaEspacamento(caracter) || char.IsLetterOrDigit(caracter))
                        {
                            adicionaListaToken(valorToken, "Símbolo simples");
                            valorToken = "";
                            estado = 0;
                            caracter = (char)codigo.Read();
                            pos += 1;
                            break;
                        }
                        erroLexico = true;
                        lstErros.Add("Erro Léxico 5 / " + RetorLinhaColuna(pos));
                        break;
                }//fim switch
            }//fim while
            return final;
        }//fim geraToken


        /// <summary>
        /// Setas the inicio token.
        /// </summary>
        public void setaInicioToken()
        {
            aux = inicio;
        }

        /// <summary>
        /// Retors the linha coluna.
        /// </summary>
        /// <param name="posicao">The posicao.</param>
        /// <returns></returns>
        public string RetorLinhaColuna(int posicao)
        {
            Linha = 0;
            int contador = 0;

            string GetlineStringReplace = strcodigo.Replace("\r\n\n", "\n");
            string[] VetGetLine = Regex.Split(GetlineStringReplace, "\n");
           
            for (int i = 0; i < VetGetLine.Length; i++)
            {
                Linha += 1;
                Coluna = 0;
                
                string[] LineChar = VetGetLine[i].Select(c => c.ToString()).ToArray();

                for (int x = 0; x < LineChar.Length; x++)
                {

                    if (contador == posicao)
                    {
                        return " Linha : " + i + "   Coluna : " + x;
                    }

                    if (!(LineChar[x] ==  " ")) {
                        contador += 1;
                    }

                    

                }
            }
            return "";
        }

        #endregion

        #region Metodos Privados

        /// <summary>
        /// Adicionas the lista token.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="tipo">The tipo.</param>
        private void adicionaListaToken(string id, string tipo)
        {
            Token novo = new Token(id, tipo);
            if (inicio.proximoToken == null)
            {
                inicio.proximoToken = novo;
            }
            else
            {
                var auxAdd = inicio.proximoToken;
                while (auxAdd.proximoToken != null)
                {
                    auxAdd = auxAdd.proximoToken;
                }
                auxAdd.proximoToken = novo;
                lstToken.Add(auxAdd);
            }

        }

        /// <summary>
        /// Verificas the palavra reservada.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        private bool verificaPalavraReservada(string token)
        {                        
            return palavra.ContainsValue(token);
        }

        /// <summary>
        /// Verificas the espacamento.
        /// </summary>
        /// <param name="caracter">The caracter.</param>
        /// <returns></returns>
        private bool verificaEspacamento(char caracter)
        {
            return (caracter == 9 || caracter == 10 || caracter == 11 || caracter == 13 || caracter == 32 || caracter == 160);
        }

        /// <summary>
        /// Verificas the operador.
        /// </summary>
        /// <param name="caracter">The caracter.</param>
        /// <returns></returns>
        private bool verificaOperador(char caracter)
        {
            return operador.ContainsValue(caracter);
        }

        /// <summary>
        /// Verificas the simbolo simples.
        /// </summary>
        /// <param name="caracter">The caracter.</param>
        /// <returns></returns>
        private bool verificaSimboloSimples(char caracter)
        {
            return simboloSimples.ContainsValue(caracter);
        }

        /// <summary>
        /// Verificas the simbolo duplo.
        /// </summary>
        /// <param name="caracter">The caracter.</param>
        /// <returns></returns>
        private bool verificaSimboloDuplo(string caracter)
        {
            
            return simboloDuplo.ContainsValue(caracter);

        }//fim simboloDuplo

        /// <summary>
        /// Cargas the palavra.
        /// </summary>
        private void cargaPalavra()
        {

            palavra = new Hashtable();
            palavra[0] = "real";
            palavra[1] = "integer";
            palavra[2] = "if";
            palavra[3] = "then";
            palavra[4] = "while";
            palavra[5] = "do";
            palavra[6] = "write";
            palavra[7] = "read";
            palavra[8] = "else";
            palavra[9] = "begin";
            palavra[10] = "end";
            palavra[11] = "program";
            palavra[12] = "var";

        }

        /// <summary>
        /// Cargasimboloes the duplo.
        /// </summary>
        private void cargasimboloDuplo()
        {
            simboloDuplo = new Hashtable(); 
            simboloDuplo[0] = ">=";
            simboloDuplo[1] = "<=";
            simboloDuplo[2] = "<>";
            simboloDuplo[3] = ":=";
        }

        /// <summary>
        /// Cargas the simbolo simples.
        /// </summary>
        private void cargaSimboloSimples()
        {
            simboloSimples  = new Hashtable();
            simboloSimples[0] = '(';
            simboloSimples[1] = ')';
            simboloSimples[6] = ':';
            simboloSimples[7] = ';';
            simboloSimples[8] = ',';
            simboloSimples[9] = '=';
            simboloSimples[10] = '>';
            simboloSimples[11] = '<';
            simboloSimples[12] = '$';
            simboloSimples[13] = '.';
            simboloSimples[14] = '{';
            simboloSimples[15] = '}';
        }

        /// <summary>
        /// Cargas the operador.
        /// </summary>
        private void cargaOperador()
        {
            operador = new Hashtable();
            operador[0] = '+';
            operador[1] = '-';
            operador[2] = '/';
            operador[3] = '*';
        }



        #endregion

    }
}