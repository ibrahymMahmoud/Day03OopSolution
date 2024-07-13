using System.Collections;

namespace Assignmet
{
    #region Part2 Q1
    //Part1 Q1 
    public interface IShape
    {
        public double Area { get; set; }
        void DisplayShapeInfo();
    }

    public interface ICircle : IShape
    {
        double Radius { get; set; }
    }

    public interface IRectangle : IShape
    {
        double Length { get; set; }
        double Width { get; set; }
    }

    public class Circle : ICircle
    {
        public double Radius { get; set; }

        public double Area
        {
            get { return Math.PI * Radius * Radius; }
            set { Radius = value; }
        }


        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This is a circle with a radius of {Radius} and an area of {Area}.");
        }
    }

    public class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area
        {
            get { return Length * Width; }
            set { Length = value; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This is a rectangle with a length of {Length} and a width of {Width}, and an area of {Area}.");
        }
    }
    //// end Part Q1  
    #endregion

    #region Part2 Q2

    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }

    public class BasicAuthenticationService : IAuthenticationService
    {
        private string[] storedUsernames = { "admin", "user" };
        private string[] storedPasswords = { "password123", "abc123" };
        private string[][] storedRoles = { new[] { "admin", "user" }, new[] { "user" } };

        public bool AuthenticateUser(string username, string password)
        {
            int index = Array.IndexOf(storedUsernames, username);
            if (index >= 0 && storedPasswords[index] == password)
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            int index = Array.IndexOf(storedUsernames, username);
            if (index >= 0)
            {
                string[] roles = storedRoles[index];
                if (Array.IndexOf(roles, role) >= 0)
                {
                    return true;
                }
            }
            return false;
        }
    }


    #endregion

    #region part2 Q3

    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }

    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"from EmailNotificationService ==> {recipient}: {message}");
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"from SmsNotificationService ==> {recipient}: {message}");
        }
    }

    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"from PushNotificationService ==> {recipient}: {message}");
        }
    }


    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            /*
             * Question 1:
                  What is the primary purpose of an interface in C#?
                       a) To provide a way to implement multiple inheritance
                       b) To define a blueprint for a class
                       c) To declare abstract methods and properties
                       d) To create instances of objects
             */

            //Answer
            //a) To provide a way to implement multiple inheritance
            #endregion

            #region Q2
            /*
             * Question 2:
                   Which of the following is NOT a valid access modifier for interface members in C#?
                        a) private
                        b) protected
                        c) internal
                        d) public
             */

            //Answer
            //a) private
            #endregion

            #region Q3
            /*
             * Question 3:
                   Can an interface contain fields in C#?
                         a) Yes
                         b) No
                         c) Only if they are static
                         d) Only if they are read only
             */

            //Answer
            //b) No




            #endregion

            #region Q4
            /*
             * Question 4:
                   In C#, can an interface inherit from another interface?
                               a) No, interfaces cannot inherit from each other
                               b) Yes, interfaces can inherit from multiple interfaces
                               c) Yes, but only if they have the same methods
                               d) Only if the interfaces are in the same namespace
             */

            //Answer
            //b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q5
            /*
             * Question 5:
                   Which keyword is used to implement an interface in a class in C#?
                       a) inherit
                       b) use
                       c) extends
                       d) implements
             */

            //Answer
            //d) implements
            #endregion

            #region Q6
            /*
             * Question 6:
                   Can an interface contain static methods in C#?
                         a) Yes
                         b) No
                         c) Only if the interface is sealed
                         d) Only if the methods are private
            */

            //Answer
            //a) Yes
            #endregion

            #region Q7
            /*
             * Question 7:
                   In C#, can an interface have explicit access modifiers for its members?
                         a) Yes, for all members
                         b) No, all members are implicitly public
                         c) Yes, but only for abstract members
                         d) Only if the interface is sealed
             */

            //Answer
            //a) Yes, for all members
            #endregion

            #region Q8
            /*
             * Question 8:
                   What is the purpose of an explicit interface implementation in C#?
                          a) To hide the interface members from outside access
                          b) To provide a clear separation between interface and class members
                          c) To allow multiple classes to implement the same interface
                          d) To speed up method resolution
             */

            //Answer
            //a) To hide the interface members from outside access
            #endregion

            #region Q9
            /*
             * Question 9:
                   In C#, can an interface have a constructor?
                          a) Yes, but it must be private
                          b) No, interfaces cannot have constructors
                          c) Yes, but only if the interface is sealed
                          d) Only if the constructor is static
             */

            //Answer
            //b) No, interfaces cannot have constructors
            #endregion

            #region Q10
            /*
             * Question 10:
                  How can a C# class implement multiple interfaces?
                       a) By using the "implements" keyword
                       b) By using the "extends" keyword
                       c) By separating interface names with commas
                       d) A class cannot implement multiple interfaces
             */

            //Answer
            //c) By separating interface names with commas


            #endregion

            #region Part02 Q1
            /*
             * Question 01:
                  Define an interface named IShape with a property Area and a method DisplayShapeInfo.
                  Create two interfaces, ICircle and IRectangle, that inherit from IShape. 
                  Implement these interfaces in classes Circle and Rectangle. 
                  Test your implementation by creating instances of both classes and displaying their shape information.
             */

            /// ICircle circle = new Circle { Radius = 5 };
            /// circle.DisplayShapeInfo();
            ///
            /// IRectangle rectangle = new Rectangle { Length = 10, Width = 5 };
            /// rectangle.DisplayShapeInfo();


            #endregion

            #region Part02 Q2

            ///   IAuthenticationService authService = new BasicAuthenticationService();
            /// 
            ///   bool isAuthenticated = authService.AuthenticateUser("admin", "password123");
            ///   Console.WriteLine($"is admin authenticated? {isAuthenticated}");
            /// 
            ///   bool isAuthorized = authService.AuthorizeUser("admin", "admin");
            ///   Console.WriteLine($"is admin authorized? {isAuthorized}");

            #endregion

            #region part02 Q3
          ///  INotificationService emailService = new EmailNotificationService();
          ///  emailService.SendNotification("Hema@gmail.com", "message from hema");
          ///
          ///  INotificationService smsService = new SmsNotificationService();
          ///  smsService.SendNotification("ibrahym", "hema notification");
          ///
          ///  INotificationService pushService = new PushNotificationService();
          ///  pushService.SendNotification("hoda", "push notification");
            #endregion
        }
    }
}
