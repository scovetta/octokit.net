using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Octokit
{
    /// <summary>
    /// Error payload from the API reposnse
    /// </summary>
#if !NETFX_CORE
    [Serializable]
#endif
    public class ApiError
    {
        public ApiError()
        {
        }

        public ApiError(string message)
        {
            Message = message;
        }

        /// <summary>
        /// The error message
        /// </summary>
        public string Message { get; protected set; }

        /// <summary>
        /// URL to the documentation for this error.
        /// </summary>
        public string DocumentationUrl { get; protected set; }

        // TODO: This ought to be an IReadOnlyList<ApiErrorDetail> but we need to add support to SimpleJson for that.
        /// <summary>
        /// Additional details about the error
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IList<ApiErrorDetail> Errors { get; protected set; }
    }
}