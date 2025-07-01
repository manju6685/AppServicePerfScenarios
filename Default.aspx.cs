using System;
using System.Collections.Generic;



namespace manjuvs
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // This will cause a StackOverflowException
            CauseStackOverflow();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // This will cause high CPU usage
            CauseHighCPU();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // This will cause high memory usage
            CauseHighMemory();
        }
       
        private void CauseStackOverflow()
        {
            CauseStackOverflow(); // Recursive call without a termination condition
        }

        private void CauseHighCPU()
        {
            while (true)
            {
                // Busy-wait loop to cause high CPU usage
            }
        }

        private void CauseHighMemory()
        {
            List<byte[]> memoryHog = new List<byte[]>();
            while (true)
            {
                // Allocate large chunks of memory in a loop
                memoryHog.Add(new byte[1024 * 1024]); // Allocate 1 MB
            }
        }
    }
}