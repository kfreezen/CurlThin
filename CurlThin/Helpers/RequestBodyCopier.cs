using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace CurlThin.Helpers
{
    /// <summary>
    /// Use this helper class for CURLoption.READFUNCTION
    /// 
    ///
    /// </summary>
    public class RequestBodyCopier : IDisposable
    {
        public RequestBodyCopier(Stream requestBody, long contentLength)
        {
            ContentLength = contentLength;

            DataHandler = (data, size, nmemb, userdata) =>
            {
                int length = (int)size * (int)nmemb;
                var buffer = new byte[length];
                RequestBodyStream.Read(buffer, 0, length);
                Marshal.Copy(buffer, 0, data, length);
                return (UIntPtr)length;
            };
        }

        public Stream RequestBodyStream { get; private set; }
        public long ContentLength { get; private set; }

        public CurlNative.Easy.DataHandler DataHandler { get; private set; }

        public void Dispose()
        {
            // Not much to dispose here. We don't want to dispose the stream because the caller might not be done with it.
        }
    }
}
