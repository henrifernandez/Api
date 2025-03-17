namespace Apisegundods.models
{
    public class Professor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string pai { get; set; }
        public string mae { get; set; }
        string nome = "ComponenteCurricular";
       

        public int RMA { get; set; }
        public int alunosID { get; set; }
        public int escolaID { get; set; }
    }
}