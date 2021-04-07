namespace FactoryDesignPattern
{
    public class BenzFactory
    {
        public static Benz CreateBenz(string type) {
            return type switch {
                "E" => new ESeries(),
                "C" => new CSeries(),
                _ => null
            };
        }
    }
}