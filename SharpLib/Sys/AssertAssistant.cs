using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLib.Sys
{
    public class AssertAssistant
    {
        public class AssertException : Exception { }

        public static void Assert(bool condition)
        {
            if (!condition)
            {
                throw new AssertException();
            }
        }

        public static bool Verify(bool condition)
        {
            if (!condition)
            {
                AssertFailed("Assertion Fails!");
                return false;
            }
            return false;
        }

        private static void AssertFailed(
            string message,
            [System.Runtime.CompilerServices.CallerMemberName] string callerName = "N/A",
            [System.Runtime.CompilerServices.CallerFilePath] string callerFilePath = "N/A",
            [System.Runtime.CompilerServices.CallerLineNumber] int callerLineNumber = -1)
        {
            
        }
    }
}
