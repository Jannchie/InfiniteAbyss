using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace InfiniteAbyss.Core.Utils
{
    public static class Logger
    {
        public static void Info(string Object, string Msg)
        {
            TestContext.Progress.WriteLine($"[ {DateTime.Now} ] {Object} : {Msg}");
        }
    }
}
