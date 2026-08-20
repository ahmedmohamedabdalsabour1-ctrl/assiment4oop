namespace assiment4oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region one 
            /*
             * a)  What is Abstraction in Object - Oriented Programming ?
             * اخفاء الاشياء الامهمه واظهار الاشياء التي يمكن للمستخدمه ان يراها 
             * b)  Why is abstraction considered one of the four pillars of OOP? 
             * 1-inheritance
             * 2-constractor
             * 3-polymarphism
             * 4-abstraction
             */
            #endregion
            #region Q2
            /*
             * a)  What is the difference between an Abstract Class and an Interface? 
             * abstract    A class can inherit from only one class      Can have constructors                       Can contain implemented methods
             * interface   A class can implement multiple interfaces    Cannot have normal instance constructors    Defines members that classes must implement
             * b)  When would you choose an Interface instead of an Abstract Class? 
             * We choose an interface when different classes need to follow the same contract, even if they are not closely related.
             * c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces? 
             * A C# class cannot inherit from multiple classes, whether abstract or not
             */
            #endregion

            DeliveryAddress egyptAddress =
           new DeliveryAddress(
               "Nasr City",
               "Cairo",
               "Egypt");

            DeliveryAddress germanyAddress =
                new DeliveryAddress(
                    "Berlin Street",
                    "Berlin",
                    "Germany");

            StandardShipment standard =
                new StandardShipment(
                    "SH001",
                    "Laptop",
                    10,
                    45,
                    egyptAddress);


            ExpressShipment express =
                new ExpressShipment(
                    "SH002",
                    "Phone",
                    8,
                    30,
                    30,
                    egyptAddress);


            InternationalShipment international =
                new InternationalShipment(
                    "SH003",
                    "Documents",
                    20,
                    60,
                    "Germany",
                    germanyAddress);
            DeliveryCenter center = new DeliveryCenter();

            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);
            Console.WriteLine("Delivery Center");
            center.PrintAllShipments();
            Console.WriteLine("Tracking Status");
            center.PrintTrackingStatuses();
            Console.WriteLine("Insurance");
            DeliveryReport report = new DeliveryReport();
            report.PrintInsurance(standard);
            report.PrintInsurance(express);
            report.PrintInsurance(international);
            Console.WriteLine("ITrackable Array");
            ITrackable[] trackableShipments =
            {
            standard,
            express,
            international
        };

            foreach (ITrackable shipment in trackableShipments)
            {
                report.PrintShipment(shipment);
            }
            Console.WriteLine("IInsurable Array");
            IInsurable[] insurableShipments =
            {
            standard,
            express,
            international
        };

            foreach (IInsurable shipment in insurableShipments)
            {
                report.PrintInsurance(shipment);
            }
            Console.WriteLine(
                "Interface Polymorphism Demonstrated Successfully.");
        }
    }
    }

