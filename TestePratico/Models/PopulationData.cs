namespace TestePratico.Models
{
    public class PopulationData
    {
        public string Entity { get; set; }
        public int Code { get; set; }
        public int Year { get; set; }
        public long Population { get; set; }

        public PopulationData(string entity, int code, int year, long population)
        {
            Entity = entity;
            Code = code;
            Year = year;
            Population = population;
        }

        public PopulationData()
        {
        }

     
    }

}
