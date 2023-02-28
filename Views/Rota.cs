namespace View
{
    public class Rota
    {
        public static void Show()
        {
            Console.WriteLine("Digite as informações da rota:");
            Console.WriteLine("ID da rota: ");
            Controller.Rota.placa(Console.ReadLine());
            Console.WriteLine("Nome do Motorista: ");
            Controller.Rota.placa(Console.ReadLine());
            Console.WriteLine("Cidade de partida: ");
            Controller.Rota.partida(Console.ReadLine());
            Console.WriteLine("Cidade de chegada: ");
            Controller.Rota.chegada(Console.ReadLine());
            Console.WriteLine("Data: ");
            Controller.Rota.data(Console.ReadLine());
        }
    }
}