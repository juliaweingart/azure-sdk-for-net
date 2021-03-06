// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AppConfigurationKeyValueModifiedEventData
    {
        internal static AppConfigurationKeyValueModifiedEventData DeserializeAppConfigurationKeyValueModifiedEventData(JsonElement element)
        {
            Optional<string> key = default;
            Optional<string> label = default;
            Optional<string> etag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
            }
            return new AppConfigurationKeyValueModifiedEventData(key.Value, label.Value, etag.Value);
        }
    }
}
