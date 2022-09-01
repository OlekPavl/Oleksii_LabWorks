using System;

namespace LabWork_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observation titmouse flight");
            Bird My_Bird = new Bird("Titmouse", 20);

            //1. Create the skeleton code with the  basic exception handling for the menu in the main method 
            //try - catch
            // 1. begin
            char rdk;
            try
            {
                do
                {
                    //2. Create code for the nested special exception handling in the main method
                    //try - catch - catch - finally
                    // 2. begin
                    try
                    {
                        //do something


                        //3. Create the menu for three options in the inner try block  
                        //In the second option throw the System.Exception
                        // 3. begin
                        Console.WriteLine("Monitoring in Try block ");
                        Console.WriteLine(@"Please, type the number
                            1. array overflow
                            2. throw exception
                            3. user exception
                        ");
                        uint i = uint.Parse(Console.ReadLine());
                                        
                        switch (i)
                        {
                            //4. in case 1 code array overflow exception 
                            case 1:
                                throw new OverflowException();
                                break;
                            //in case 2 code throw (new System.Exception("Oh! My system exception..."));
                            case 2:
                                throw new Exception("Oh! My system exception...");
                                break;
                            //in case 3  code the sequentially incrementing of Bird speed until to the exception 
                            case 3:
                                for (;;)
                                {
                                    My_Bird.FlyAway(1);
                                }
                                break;
                            default:
                                break;
                        }
                        // 3. end
                    }
                    catch (BirdFlewAwayException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.When);
                        Console.WriteLine(e.Why);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("CLS exception: Message -" + e.Message + " Source -" + e.Source); ;
                    }
                    finally
                    {
                        Console.WriteLine("For the next step ...");
                    }

                    rdk = Console.ReadKey().KeyChar;
                } while (rdk != ' ');
                // 2. end
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // 1. end

            Console.ReadKey();
        }
    }
}
