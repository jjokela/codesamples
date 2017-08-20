namespace State
{
    public class OrangeState : AbstractState
    {
        public OrangeState(AbstractState state)
        {
            RiskLevel = state.RiskLevel;
            Context = state.Context;            
        }

        public override void IncreaseRisk(int risk)
        {
            RiskLevel = RiskLevel + risk;
            System.Console.WriteLine("Increased risk level to " + RiskLevel);
            CalculateRiskLevel();
        }
        public override void DecreaseRisk(int risk)
        {
            RiskLevel = RiskLevel - risk;
            System.Console.WriteLine("Decreased risk level to " + RiskLevel);
            CalculateRiskLevel();
        }

        protected override void CalculateRiskLevel()
        {
            if (RiskLevel > redLevelTreshold)
            {
                System.Console.WriteLine("Changing state to Red");

                System.Console.ForegroundColor = System.ConsoleColor.Red;                
                System.Console.WriteLine("Changing state to Red");
                System.Console.ResetColor();

                Context.State = new RedState(this);
            } else if (RiskLevel <= greenLevelTreshold) 
            {
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine("Changing state to Green");
                System.Console.ResetColor();
                Context.State = new GreenState(this);
            }
        }
    }
}