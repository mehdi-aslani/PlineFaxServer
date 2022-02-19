using System;
using System.Net.Http;
using PlineFaxServer.Data;

namespace PlineFaxServer.Tools
{
    public static class Globals
    {
        public static string ToastWarning = "___Warning";
        public static string ToastError = "___Error";
        public static string ToastInfo = "___Info";
        public static string ToastSuccess = "___Success";

        public static string GenerateId()
        {
            return Guid.NewGuid().ToString("N");
        }

        public enum FaxStatus
        {
            InQueue = 0,
            Send = 1,
            Cancel = 2,
            Archive = 3,
            Delete = 4,
            Fail = 5,
            Recycle = 7,
            Received = 6,
            NewFaxReceive = 8,
            Unknown = 99
        }
    }
}