using System;
using System.Collections.Generic;
using System.Text;

namespace FoxmindedTestApp
{
    public class FileAnalizeResult
    {
        public double MaxSum { get; set; }
        public int MaxLineNumber { get; set; }
        public List<string> BrokenLines { get; set; }
    }
}
