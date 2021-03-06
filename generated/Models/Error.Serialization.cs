// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace SwaggerPetstore.Models
{
    internal partial class Error
    {
        internal static Error DeserializeError(JsonElement element)
        {
            int code = default;
            string message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new Error(code, message);
        }
    }
}
