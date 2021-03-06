// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace SwaggerPetstore.Models
{
    /// <summary> The Error. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> . </param>
        /// <param name="message"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal Error(int code, string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
        }

        public int Code { get; }
        public string Message { get; }
    }
}
