namespace Apisegundods.models
{
    public class alunos
    {
        public int id {  get; set; }  
        public string name { get; set; }
        public string RMA { get; set; }
        public string pai { get; set; }
        public string mae { get; set; }
        public Escola Escola { get; set; }
        public Professor Professor { get; set; }


    }
}
