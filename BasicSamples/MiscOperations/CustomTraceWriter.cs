﻿using System;
using System.Diagnostics;
using Microsoft.Azure.WebJobs.Host;

namespace MiscOperations
{
    /// <summary>
    /// Custom <see cref="TraceWriter"/> demonstrating how JobHost logs/traces can
    /// be intercepted by user code.
    /// </summary>
    public class CustomTraceWriter : TraceWriter
    {
        public CustomTraceWriter(TraceLevel level)
            : base(level)
        {
        }

        public override void Trace(TraceLevel level, string source, string message, Exception ex)
        {
            // handle trace messages here
        }
    }
}
