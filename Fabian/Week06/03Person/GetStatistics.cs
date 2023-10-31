namespace Fabian.Week06._03Person
{
    public class GetStatistics
    {
        public static Statistic CalcStatistics(List<Person2> persons)
        {
            if(persons == null || persons.Count == 0)
            {
                throw new ArgumentException("Can't take empty list");
            }

            int minAge = Int32.MaxValue;
            int maxAge = Int32.MinValue;
            double sumAge = 0;

            int minHeight = Int32.MaxValue;
            int maxHeight = Int32.MinValue;
            double sumHeight = 0;

            double minWeight = Int32.MaxValue;
            double maxWeight = Int32.MinValue;
            double sumWeight = 0;


            foreach (Person2 person in persons)
            {
                if(person.Age < minAge)
                {
                    minAge = person.Age;
                }
                if(person.Age > maxAge)
                {
                    maxAge = person.Age;
                }
                sumAge += person.Age;



                if(person.Height < minHeight)
                {
                    minHeight = person.Height;
                }
                if(person.Height > maxHeight)
                {
                    maxHeight = person.Height;
                }
                sumHeight += person.Height;



                if(person.Weight < minWeight)
                {
                    minWeight = person.Weight;
                }
                if(person.Weight > maxWeight)
                {
                    maxWeight = person.Weight;
                }
                sumWeight += person.Weight;                             
            }

            double avgAge = sumAge / persons.Count;
            double avgHeight = sumHeight / persons.Count;
            double avgWeight = sumWeight / persons.Count;

            return new Statistic(maxHeight, minHeight, avgHeight, maxAge, minAge, avgAge, minWeight, maxWeight, avgWeight);
        }
    }
}
