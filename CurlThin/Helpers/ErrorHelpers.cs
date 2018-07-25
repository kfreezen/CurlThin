using CurlThin.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurlThin.Helpers
{
    /// <summary>
    /// A little helper class to simplify certain types of error checking on CURL codes.
    /// </summary>
    public static class ErrorHelpers
    {
        /// <summary>
        /// Returns whether the given CURLcode is an SSL error code.
        /// </summary>
        /// <param name="curlCode"></param>
        /// <returns></returns>
        public static bool IsSslError(CURLcode curlCode)
        {
            switch(curlCode)
            {
                case CURLcode.PEER_FAILED_VERIFICATION:
                case CURLcode.SSL_CIPHER:
                case CURLcode.SSL_ENGINE_INITFAILED:
                case CURLcode.SSL_CONNECT_ERROR:
                case CURLcode.SSL_INVALIDCERTSTATUS:
                case CURLcode.SSL_ISSUER_ERROR:
                case CURLcode.SSL_SHUTDOWN_FAILED:
                    return true;

                default:
                    return false;
            }
        }
    }
}
