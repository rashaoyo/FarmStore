namespace FarmStore
{
    internal class FarmStoreConfiguration
    {
        public FarmStoreConfiguration()
        {
            public Database Database { get; set; }
        }

    public class Database
    {
        public string ConectionString { get; set; }
    }
}
}