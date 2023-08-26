namespace DAL.Data
{
    public class Initializer
    {
        public static void Initialize(AppDbContex context)
        {
            context.Database.EnsureCreated();
        }
    }
}
