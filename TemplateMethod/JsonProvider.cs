namespace TemplateMethod
{
    public class JsonProvider : AbstractProvider
    {
        public override void RegisterAdditionalProviders()
        {
            System.Console.WriteLine("Registering additional JSON providers");
        }

        public override void RegisterReferenceProviders()
        {
            System.Console.WriteLine("Registering reference JSON providers");
        }
    }
}