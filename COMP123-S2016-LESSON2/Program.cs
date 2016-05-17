using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Abhinav
 * Date: May 17, 2016
 * Description: Adcanced demo lessons for lesson 2
 * version: 0.0.3 - created addXandY method and assiciated test
  */


namespace COMP123_S2016_LESSON2
{
    /**
     * Main Driver class For lesson 2
     * 
     * @class program
     */
    public class Program
    {
        /**
         *  Main method for our drive class
         *  
         * @constructor Main
         * @param{string[]} args
         */
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0;

            result = addXandY(x, y);
            Console.WriteLine(result);
        }
        /**
         * simple method to add two values
         * 
         * @method addXandY
         * @param {int} firstNumber
         * @param {int} secondNumber-
         */
       public static int addXandY(int firstNumber, int secondNumber)
        {
            int result = 0;
            result = firstNumber + secondNumber;
            return result;
        }
    }
}