namespace AppAmalt.ModelsDatabase
{
    public class ValueCity : Base
    {
        public ValueCity(int value, int cityId)
        {
            Value = value;
            CityId = cityId;
        }

        public int Value { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }

    }
}
