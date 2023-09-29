
public class WalkMethods
{
    public static double CalculateMilesWalked(int numberOfSteps, int lengthOfStep)
    {
        return (numberOfSteps * lengthOfStep) / 63360.0;
    }

    public static WalkFields Walk(string nameofwalker, int steplength, int stepscount)
    {
        var fields = new WalkFields
        {
            WalkerName = nameofwalker,
            LengthOfStep = steplength,
            NumberOfSteps = stepscount
        };
        return fields;
    }
}
