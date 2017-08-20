namespace State
{
    public class RiskContext
    {
        public RiskContext()
        {
            State = new GreenState(0, this);
        }

        public AbstractState State { get; set; }       

        public void IncreaseRisk(int risk) 
        {
            System.Console.WriteLine("Increasing current risk by " + risk);
            State.IncreaseRisk(risk);
        }
        public void DecreaseRisk(int risk) 
        {
            System.Console.WriteLine("Decreasing current risk by " + risk);
            State.DecreaseRisk(risk);
        }
    }
}