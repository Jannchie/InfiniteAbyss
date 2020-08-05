using System;
using System.Collections.Generic;
using System.Text;

namespace InfiniteAbyss.Core.Resources
{

    public class NameList {
        public IList<string> FirstName { get; set; }
        public IList<string> LastName { get; set; }
    }


    public class NameData
    {
        public NameList China { get; set; }
    }
}
