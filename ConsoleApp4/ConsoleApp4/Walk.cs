
namespace WalkApp
{
    public class Walk
    {
        private int lengthOfStep;
        private int numberOfSteps;
        private string walkerName;

        // Constructor
        public Walk(string walkerName, int lengthOfStep, int numberOfSteps)
        {
            this.walkerName = walkerName;
            this.lengthOfStep = lengthOfStep;
            this.numberOfSteps = numberOfSteps;
        }

        public double CalculateMilesWalked()
        {
            return (numberOfSteps * lengthOfStep) / 63360.0;
        }
    }
}
