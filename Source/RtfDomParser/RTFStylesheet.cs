


using System;
using System.Collections ;
using System.Collections.Generic ;
using System.Text ;

namespace RtfDomParser
{
   [System.Diagnostics.DebuggerDisplay("Count={ Count }")]
    [System.Diagnostics.DebuggerTypeProxy(typeof(RTFInstanceDebugView))]
    public class RTFStylesheet : System.Collections.CollectionBase
    {

        /// <summary>
        /// initialize instance
        /// </summary>
        public RTFStylesheet()
        {
        }



        public string GetStyleName(string keyword,int styleIndex)
        {
            foreach (RTFStyle item in this) {
                if (item.Keyword == keyword && item.Index == styleIndex) return item.Name;
            }
            return null;
        }



        public void Add(RTFStyle f)
        {
            this.List.Add(f);
        }


        

    }








    public class RTFStyle
    {
        /// <summary>
        /// initialize instance
        /// </summary>
        /// <param name="index">font index</param>
        /// <param name="name">font name</param>
        public RTFStyle( string keyword, int index,string name)
        {
            Keyword = keyword;
            intIndex = index;
            strName = name;
            
        }

        private int intIndex = 0;
        /// <summary>
        /// font index
        /// </summary>
        public int Index
        {
            get
            {
                return intIndex;
            }
            set
            {
                intIndex = value;
            }
        }



        private string keyword = null;
        /// <summary>
        /// font name
        /// </summary>
        public string Keyword
        {
            get
            {
                return keyword;
            }
            set
            {
                keyword = value;
            }
        }

        private string strName = null;
        /// <summary>
        /// font name
        /// </summary>
        public string Name
        {
            get
            {
                return strName;
            }
            set
            {
                strName = value;
            }
        }

        public string StyleName
        {
            get
            {
                return keyword + intIndex;
            }
        }




        public override string ToString()
        {
            return StyleName + ": "  + strName;
        }
    }







}