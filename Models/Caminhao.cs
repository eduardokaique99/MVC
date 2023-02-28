using System;

namespace Model
{
    public class Caminhao
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Motorista { get; set; }
        public static List<Caminhao>
        

        public Caminhao(string placa, string motorista, int id)
        {
            Placa = placa;
            Motorista = motorista;
            Id = id;
        }
    }
}