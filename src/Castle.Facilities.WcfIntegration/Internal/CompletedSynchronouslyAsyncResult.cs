using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Castle.Facilities.WcfIntegration.Internal
{
    using System.Threading;

    public class CompletedSynchronouslyAsyncResult : IAsyncResult
    {
        public object AsyncState
        {
            get { return null; }
        }

        public System.Threading.WaitHandle AsyncWaitHandle
        {
            get { return new ManualResetEvent(true); }
        }

        public bool CompletedSynchronously
        {
            get { return true; }
        }

        public bool IsCompleted
        {
            get { return true; }
        }
    }
}
