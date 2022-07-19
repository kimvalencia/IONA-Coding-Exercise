namespace IONACodingExercise.ExternalDomains.BreedAgg
{
    public class DogBreedDTO
    {
        public BreedWeight weight { get; set; }
        public BreedHeight height { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string country_code { get; set; }
        public string bred_for { get; set; }
        public string breed_group { get; set; }
        public string life_span { get; set; }
        public string temperament { get; set; }
        public string origin { get; set; }
        public string reference_image_id { get; set; }
        public BreedImage image { get; set; }
    }
}
