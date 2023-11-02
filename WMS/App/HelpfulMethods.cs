using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scanner.App
{
    public static class HelpfulMethods
    {
        private static int count=0;


        /// <summary>
        ///  A method to prevent duplicate click on the button.
        /// </summary>
        /// <returns></returns>
        public static bool preventDupUse()
        {
                var check = count;
                count += 1;

                if (count > 1)
                {
                
                    count = 0;
                    return false;

                } else

                {
                
                return true;
                }
        }
        
        
        /// <summary>
        ///  Releases the lock on the button after the use.
        /// </summary>
        public static void releaseLock()
        {
            count = 0;
        }


        /// <summary>
        ///  Returns the last 5 characters of the reversed string.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns></returns>
        public static string lastReturn(string input, int noCharacters)
        {
            string lastReturn;

            lastReturn = input.Substring(input.Length - noCharacters);

            return lastReturn;
        }


        public static void clearTheStack(Activity activity)
        {
            activity.Finish();
        }

    }
}