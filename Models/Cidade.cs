using System;

namespace Model
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static List<Cidade> Cidades { get; set; } = new List<Cidade>();

        public Cidade(string nome, int id)
        {
            Nome = nome;
            Id = id;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}";
        }

        public static void AlterarCidade(
            int id,
            string nome
        )
        {
            Cidade cidade = BuscarCidade(id);
            cidade.Nome = nome;
        }

        public static void ExcluirCidade(int id);
        {
            Cidade cidade
        }
    }
}