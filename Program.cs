namespace ProgPOE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LooknFeel lnf = new LooknFeel();
            UserResponseSystem response = new UserResponseSystem();
            
            
            
            lnf.Audio();
            lnf.logo();
            
            
            
            response.ResponseSystem();
            
            Console.WriteLine("Thank you for using the program");

            Console.ReadLine();
        }
    }
}
