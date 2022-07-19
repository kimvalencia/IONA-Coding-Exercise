namespace IONACodingExercise.Domain.BreedAgg
{
    public class Breed
    {
        public string id { get; set; }
        public string name { get; set; }
        public string temperament { get; set; }
        public string origin { get; set; }
        public string country_code { get; set; }
        public string description { get; set; }
        public BreedImage image { get; set; }
    }
}
