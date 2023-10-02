using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace calculaMediaPOO
{
    internal class Pessoa
    {
        private int matricula;
        private string nome;
        private double notaProva1;
        private double notaProva2;
        private double notaTrabalho;

        //Construtor que inicializa o nome e matricula do aluno
        public Pessoa()
        {
            this.matricula = matricula;
            this.nome = nome;
        }

        //Propriedades que vão armazenar os valores informado pelo usuário
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public double NotaProva1
        {
            get { return notaProva1; }
            set { notaProva1 = value; }
        }
        public double NotaProva2
        {
            get { return notaProva2; }
            set { notaProva2 = value; }
        }
        public double NotaTrabalho
        {
            get { return notaTrabalho; }
            set { notaTrabalho = value; }
        }
    }
}