namespace AppAmalt.ModelsGraph
{
    public class CityModal
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public CityModal(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}