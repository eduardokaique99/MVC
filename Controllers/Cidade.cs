namespace Controller
{
    public class Cidade 
    {
        public static void CadastrarCidade(string id, string nome)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id invalido");
            }
            Model.Cidade cidade = new Model.Cidade(id, nome);
        }
    }
}