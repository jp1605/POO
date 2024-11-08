using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7___Pilares
{
    internal class Pessoa
    {
        #region Atributos
        private int idade; //private   se inves do private tiver public ja se pode aceder

        private string nome; //private

        #endregion

        #region Construtores

        public Pessoa (int idadeParametro, string nomeParametro)
        {

            this.idade = idadeParametro;
            this.nome = nomeParametro;

        }

        #endregion
        // o til serve para apagar tudo no codigo 
        #region Destrutor 
        ~Pessoa ()
        {

        }

        #region Propriedades

        public int Idade
        {
            get
            {
                if(idade>0)
                    return idade;   
                else 
                    return 0;
            }
            set
            { 
                this.Idade = value; 
        }

            #region Metodos A_LA_JAVA

            public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade=idade;
        }

        }
    }
