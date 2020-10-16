namespace OdeToFood.Core
{
    // This class would represent the core of the 
    // application


    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}