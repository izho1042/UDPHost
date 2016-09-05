using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UDPHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class FaqService : IService
    {
        public String SayFaq(String input)
        {
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("I need your name !");
                return "Fuck you.";
            }
            Console.WriteLine("Faq {0}", input);
            return "Fuck you " + input;
        }
    }
}
