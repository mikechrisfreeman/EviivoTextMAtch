using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TextMatch.Helpers
{
    public class CaseConverter
    {
        private string text;
        private char[] LowerCharacters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private char[] UpperCharacters = new char[]{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

        public string ToLower 
        { 
            get
            {
                return convertToLower();
            }
            protected set{}
        }
        
        public CaseConverter(string s)
        {
            this.text = s;
        }

        private string convertToLower()
        {
            string result = "";
            foreach(char c in text)
            {
                if (charInArray(c, this.LowerCharacters))
                    result = result + c;
                else if (charInArray(c, this.UpperCharacters))
                    result = result + convertToLower(c);
                else
                    result = result + c;
            }
            return result;
        }

        //This assumes the character being passed in is a lowercase character
        private char convertToLower(char c)
        {
            int index = 0;
            foreach (char ca in this.UpperCharacters)
            {
                if (ca == c)
                    break;
                index = index + 1;
            }
            return this.LowerCharacters[index];
        }

        private bool charInArray(char c, char[] arr)
        {
            //assume failure
            bool result = false;
            foreach (char cA in arr)
            {
                if(c == cA)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

    }
}