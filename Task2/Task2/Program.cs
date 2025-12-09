namespace Task2
{
    using System;
    using System.Runtime.InteropServices;

    class Program
    {
        public static double OverAll = 0;
        public static double HighestBill = 0;

        public static int CommercialCount = 0;
        public static int DomesticCount = 0;

        public static void unitCalculation(int ConnectionType, int Units) 
        {
            int DomesticUnits = Units;
            double Base = 0;
            double Surcharges = 0;
            int Penalty = 0;
            double Discount = 0;
            double Total;
            double Final;
            

            if(Units > 500)
            {
                Penalty = 200;
            }

            if(ConnectionType == 1)
            {

                CommercialCount += 1;

                if (Units >= 0 && Units <= 100)
                    Base = (1.5 * Units);
                
                else if (Units >= 101 && Units <= 300)
                {
                    Base = (2.5 * Units);
                }
                else if(Units > 300)
                {
                    Base = (4 * Units);
                } else
                {
                    Console.WriteLine("Please enter a valid Unit");
                }
                


                Total = (Base + Surcharges + Penalty);

                if(Total > 2000)
                {
                    Discount = Total * (5.0 / 100.0);
                }

                Surcharges = Total * (3.0 / 100.0);

                Final = (Total - Discount) + Surcharges;

                if(HighestBill < Final)
                {
                    HighestBill = Final;
                }

                OverAll += Final;

                Console.WriteLine("\n+----------------------+");
                Console.WriteLine("Domestic Units: " + Units);
                Console.WriteLine("Base: " + Base);
                Console.WriteLine("Surcharges: " + Surcharges);
                Console.WriteLine("Penalty: " + Penalty);
                Console.WriteLine("Discount: " + Discount);
                Console.WriteLine("Final: " + Final);
                Console.WriteLine("+----------------------+\n");

            } else if(ConnectionType == 2)
            {
                DomesticCount += 1;

                if (Units >= 0 && Units <= 200)
                {
                    Base = (5.00 * Units);
                }
                else if (Units >= 201 && Units <= 500)
                {
                    Base = (6.50 * Units);
                }
                else if (Units > 500)
                {
                    Base = (8.00 * Units);
                }
                else
                {
                    Console.WriteLine("Please enter a valid Unit");
                }



                Total = (Base + Surcharges + Penalty);

                if (Total > 2000)
                {
                    Discount = Total * (5.0 / 100.0);
                }

                Surcharges = Total * (3.0 / 100.0);

                Final = (Total - Discount) + Surcharges;

                if (HighestBill < Final)
                {
                    HighestBill = Final;
                }

                OverAll += Final;
                
                Console.WriteLine("\n+----------------------+");
                Console.WriteLine("Domestic Units: " + Units);
                Console.WriteLine("Base: " + Base);
                Console.WriteLine("Surcharges: " + Surcharges);
                Console.WriteLine("Penalty: " + Penalty);
                Console.WriteLine("Discount: " + Discount);
                Console.WriteLine("Final: " + Final);
                Console.WriteLine("+----------------------+\n");
            }
        }

        static void Main(string[] args)
        {
            int N, i, unitsConsumed, connectionType;
            string consumerID;
            
            Console.Write("Enter the number of consumers: ");
            N = Convert.ToInt32(Console.ReadLine());
            
            if (N > 0)
            {
                for (i = 0; i < N; i++)
                {
                    Console.WriteLine("\n Consumer " + (i + 1) + "\n");

                    Console.WriteLine("Consumer ID: ");
                    consumerID = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Units Consumed: ");
                    unitsConsumed = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the connection type (Domestic - 1 | Commercial - 2): ");
                    connectionType = Convert.ToInt32(Console.ReadLine());

                    unitCalculation(connectionType, unitsConsumed);
                    
                }
            }
            else
            {
                Console.WriteLine("Please Enter a valid no. of consumers!");
            }

            Console.WriteLine("----SUMMARY----");
            Console.WriteLine("Total Consumer: " + N);
            Console.WriteLine("Total Revenue: " + OverAll);
            Console.WriteLine("Highest Bill: " + HighestBill);
            Console.WriteLine("Domestic: " + DomesticCount + " Commercial: " + CommercialCount);

                            


        }
    }
}




