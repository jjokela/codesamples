namespace TemplateMethod
{
    public class DbProvider : AbstractProvider
    {
        public override void RegisterAdditionalProviders()
        {
            System.Console.WriteLine("Registering additional DB providers");
        }

        public override void RegisterReferenceProviders()
        {
            System.Console.WriteLine("Registering reference DB providers");
        }        
    }
}