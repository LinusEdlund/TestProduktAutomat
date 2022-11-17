using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProduktAutomat.UI
{
    public static class Validator
    {
        //Den här kontrollerar så du skriver in rätt typ om jag vill ha en siffra ska 
        //jag använd den och sätta T:et som int. jag tror den kan vara använd bar på många ställen
        public static T Convert<T>(string prompt)
        {
            bool valid = false;
            string userInput;

            while (!valid)
            {
                userInput = Utility.GetUserInput(prompt);

                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    if (converter != null)
                    {
                        return (T)converter.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default;
                    }
                }
                catch 
                {
                    Utility.PrintMessage("Invalid input. Try again.", false);
                    
                }
            }

            return default;
        }
    }
}
