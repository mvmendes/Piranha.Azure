/*
 * Copyright (c) 2014 Håkan Edling
 *
 * See the file LICENSE for copying permission.
 */

using System;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Piranha.Log;

namespace Piranha.Azure.Log
{
    /// <summary>
    /// Log provider for storing logs on Windows Azure.
    /// </summary>
    public class TraceLogProvider : ILogProvider
    {
        /// <summary>
        /// Logs an error to the log file.
        /// </summary>
        /// <param name="origin">The origin of the error</param>
        /// <param name="message">The message</param>
        /// <param name="details">Optional error details</param>
        public void Error(string origin, string message, Exception details = null)
        {
            System.Diagnostics.Trace.WriteLine(string.Format("ERROR [{0}] Origin [{1}] Message [{2}]", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), origin, message));
            if (details != null)
            {
                System.Diagnostics.Trace.WriteLine(details);
            }
        }
    }
}
