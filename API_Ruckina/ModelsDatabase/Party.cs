namespace AppAmalt.ModelsDatabase
{
    public class Party
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  Gender Gender { get; set; }
        public  LifeMain LifeMain { get; set; }
        public Age Age  { get; set; }
        public  Political Political { get; set; }
        public  Portrait Portrait { get; set; }
        public City City  { get; set; }

        public Party(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
