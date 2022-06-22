using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace OOP3
{
    public class Files //Encapsulation
    {
        //set string[] to private
        private string[] file1;
        private string[] file2;

        //use accessors File1 & File2 to retrieve and set values to file1 & file2
        public string[] File1
        {
            get
            {
                return file1;
            }
            set
            {
                file1 = value;
            }
        }
        public string[] File2
        {
            get
            {
                return file2;
            }
            set
            {
                file2 = value;
            }
        }
    }
}
