public class Calculator
{
    public decimal CalculateAverageCost(decimal totalCost, int totalShares)
    {
        if (totalShares <= 0)
        {
            throw new ArgumentException("Total shares must be greater than zero.");
        }

        return totalCost / totalShares;
    }
}