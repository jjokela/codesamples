namespace State
{
    public class GreenState : AbstractState
    {
        public GreenState(AbstractState state) :
            this(state.RiskLevel, state.Context)
        {
        }

        public GreenState(int riskLevel, RiskContext context)
        {
            RiskLevel = riskLevel;
            Context = context;
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
            if (RiskLevel < 0)
            {
                RiskLevel = 0;
            }
            System.Console.WriteLine("Decreased risk level to " + RiskLevel);
            CalculateRiskLevel();
        }

        protected override void CalculateRiskLevel()
        {
            if (RiskLevel > greenLevelTreshold)
            {
                System.Console.ForegroundColor = System.ConsoleColor.DarkYellow;                
                System.Console.WriteLine("Changing state to Orange");
                System.Console.ResetColor();
                
                Context.State = new OrangeState(this);
            }
        }
    }
}