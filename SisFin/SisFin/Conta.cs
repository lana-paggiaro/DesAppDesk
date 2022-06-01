using System;
using System.Collections.Generic;
using System.Text;

namespace SisFin
{
    class Conta
    {
        public Conta(int id, string nome, string descricao, int categoria, int status)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Categoria = categoria;
            Status = status;
        }

        private int Id { get; set; }
        private string Nome { get; set; }
        private string Descricao { get; set; }
        private int Categoria { get; set; }
        private int Status { get; set; }
        private List<Conta> LstConta { get; set; }

        public Conta()
        {
        }

        public List<Conta> ToList()
        {
            return LstConta;
        }

        public void AddToList(int id, string nome, string descricao, int categoria, int status)
        {
            LstConta.Add(new Conta(id, nome, descricao, categoria, status));
        }

        public List<Conta> GeraContas()
        {
            Conta _cat1 = new Conta(1, "Salário", "Salário da UNICAMP", 1, 1);
            Conta _cat2 = new Conta(1, "Combustível", "Despesas com combustível", 2, 1);
            LstConta.Add(_cat1);
            LstConta.Add(_cat2);
            return LstConta;
        }

    }

}
