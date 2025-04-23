namespace ProgPOE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LooknFeel lnf = new LooknFeel();
            UserResponseSystem response = new UserResponseSystem();


            lnf.logo();
            lnf.Audio();
                        
            response.ResponseSystem();
            
            Console.WriteLine("Thank you for using the program");

            Console.ReadLine();
        }
    }
}
