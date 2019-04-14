using System;

namespace VacationCost
{
    public class VacationCostCalculator
    {
        public double DistanceToDestination { get; set; }

        public decimal CostOfVacation(string transportMethod, string distanceToDestination)
        {


            int choiceOfTransport = TransportMethod(transportMethod);
            decimal TotalCost = calculateCost(choiceOfTransport, distanceToDestination);

            return TotalCost;
        }

        public decimal calculateCost(int transportMethod, string distanceToDestionation)
        {
            double distanceToTravel = double.Parse(distanceToDestionation);
            decimal TotalCost = (decimal)(transportMethod * distanceToTravel);

            return TotalCost;
        }

        public int TransportMethod(string transportMethod)
        {

            switch(transportMethod)
            {
                case "Car":
                    return 1;
                case "Plane":
                    return 2;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        
    }
}