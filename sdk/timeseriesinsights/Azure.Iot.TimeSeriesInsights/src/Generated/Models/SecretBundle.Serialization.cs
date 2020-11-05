// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.TimeSeriesInsights.Models
{
    public partial class SecretBundle
    {
        internal static SecretBundle DeserializeSecretBundle(JsonElement element)
        {
            Optional<string> value = default;
            Optional<string> id = default;
            Optional<string> contentType = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Optional<string> kid = default;
            Optional<bool> managed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"))
                {
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("kid"))
                {
                    kid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    managed = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SecretBundle(value.Value, id.Value, contentType.Value, Optional.ToDictionary(tags), kid.Value, Optional.ToNullable(managed));
        }
    }
}
