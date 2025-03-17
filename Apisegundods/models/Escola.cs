namespace Apisegundods.models
{
    public class Escola
    {
       
        public string name { get; set; }

        public string CNPJ { get; set; }

        public string ID { get; set; }


        public int ProfessorID { get; set; }
        public int alunosID { get; set; }
    }
}