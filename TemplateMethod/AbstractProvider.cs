namespace TemplateMethod
{
    public abstract class AbstractProvider
    {
        public abstract void RegisterReferenceProviders();
        public abstract void RegisterAdditionalProviders();

        public void RegisterProviders() 
        {
            RegisterReferenceProviders();
            RegisterAdditionalProviders();
        }

    }
}