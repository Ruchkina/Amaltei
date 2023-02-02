namespace AppAmalt.Dto
{
    public class CityDto
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public CityDto(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}