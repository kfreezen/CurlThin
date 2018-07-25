using System;
using System.Collections.Generic;
using System.Text;

namespace CurlThin.Enums
{
    public enum CURLhttpversion
    {
        /// <summary>
        /// setting this means we don't care, and that we'd
        /// like the library to choose the best possible for us!
        /// </summary>
        NONE,

        /// <summary>
        /// Please use HTTP 1.0 in the request.
        /// </summary>
        VERSION_1_0,

        /// <summary>
        /// Please use HTTP 1.1 in the request.
        /// </summary>
        VERSION_1_1,

        /// <summary>
        /// Please use HTTP 2 in the request.
        /// </summary>
        VERSION_2_0,

        /// <summary>
        /// Use version 2 for HTTPS, version 1.1 for HTTP
        /// </summary>
        VERSION_2TLS,

        /// <summary>
        /// Please use HTTP 2 without HTTP/1.1 Upgrade
        /// </summary>
        VERSION_2_PRIOR_KNOWLEDGE,

        /// <summary>
        /// *ILLEGAL* HTTP version
        /// </summary>
        VERSION_LAST
    }
}
