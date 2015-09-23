using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TextMatch.Helpers
{
    public class StringCompare
    {
        
        private string Subtext;
        private string Text;
        private int TextHigh;
        private int SubtextHigh;
        private List<int> FoundOccurances = new List<int>();

        public string Indexes
        {
            get
            {
                scanText();
                string result = "";
                foreach (int i in FoundOccurances)
                {
                    if (result == "")
                        result = i.ToString();
                    else
                        result = result + "," + i.ToString();
                }

                return result;
            }
            protected set{}
        }
        
        public StringCompare(string subtext, string text)
        {
            this.Subtext = convertToLower(subtext);
            this.Text = convertToLower(text);
            TextHigh = GetLength(Text);
            SubtextHigh = GetLength(Subtext);           
        }

        private void scanText()
        {
            int TextIndex = 0;

            
            foreach(char c in Text)
            {
                int TempTextIndex = TextIndex;
                int subTextIndex = 0;
                bool match = true;
                foreach(char sc in Subtext)
                {
                    //we dont have a match and reached the end of our text.
                    if (TempTextIndex >= TextHigh)
                    {
                        match = false;
                        break;
                    }                    
                    
                    if(Text[TempTextIndex] != sc){
                        match = false;
                        break;
                    }

                    TempTextIndex = TempTextIndex+ 1;
                    subTextIndex = subTextIndex + 1;
                }
                if(match)
                    FoundOccurances.Add(TextIndex);
                TextIndex = TextIndex + 1;
            }
        }

        private string convertToLower(string s)
        {
            CaseConverter cc = new CaseConverter(s);
            return cc.ToLower;
        }

        private int GetLength(string t)
        {
            int index = 0;
            foreach (char c in t)
            {
                index = ++index;
            }
            return index;
        }
    }
}