namespace State
{
    public class RedState : AbstractState
    {
        public RedState(AbstractState state)
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
            if (RiskLevel <= orangeLevelTreshold) 
            {
                System.Console.ForegroundColor = System.ConsoleColor.DarkYellow;                
                System.Console.WriteLine("Changing state to Orange");
                System.Console.ResetColor();
                Context.State = new OrangeState(this);
            }
        }
    }
}