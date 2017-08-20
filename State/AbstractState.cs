namespace State
{
    public abstract class AbstractState
    {        
        protected const int greenLevelTreshold = 10;
        protected const int orangeLevelTreshold = 50;
        protected const int redLevelTreshold = 80;

        protected abstract void CalculateRiskLevel();

        public RiskContext Context { get; set; }
        public int RiskLevel { get; set; }

        public abstract void IncreaseRisk(int risk);
        public abstract void DecreaseRisk(int risk);
    }
}