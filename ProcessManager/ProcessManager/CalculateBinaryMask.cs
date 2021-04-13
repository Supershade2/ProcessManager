using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessManager
{
    public class CalculateBinaryMask
    {
        public static long ProduceBitmask(List<string> processors) 
        {
            long bitmask = 0;
            //num is the number from which two to the power of the count of processors is stored
            long num = Convert.ToInt64(Math.Pow(2,processors.Count));
            for(int i=0; i<processors.Count; i++) 
            {
                if (processors[(processors.Count-1)-i] == "1") 
                {
                    num = Convert.ToInt64(Math.Pow(2, processors.Count - i));
                    bitmask += num;
                }
            }
            return 0;
        }
    }
}
