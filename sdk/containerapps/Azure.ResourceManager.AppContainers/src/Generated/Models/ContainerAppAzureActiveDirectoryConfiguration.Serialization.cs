// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppAzureActiveDirectoryConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(Registration))
            {
                writer.WritePropertyName("registration"u8);
                writer.WriteObjectValue(Registration);
            }
            if (Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login"u8);
                writer.WriteObjectValue(Login);
            }
            if (Optional.IsDefined(Validation))
            {
                writer.WritePropertyName("validation"u8);
                writer.WriteObjectValue(Validation);
            }
            if (Optional.IsDefined(IsAutoProvisioned))
            {
                writer.WritePropertyName("isAutoProvisioned"u8);
                writer.WriteBooleanValue(IsAutoProvisioned.Value);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppAzureActiveDirectoryConfiguration DeserializeContainerAppAzureActiveDirectoryConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<ContainerAppAzureActiveDirectoryRegistrationConfiguration> registration = default;
            Optional<ContainerAppAzureActiveDirectoryLoginConfiguration> login = default;
            Optional<ContainerAppAzureActiveDirectoryValidationConfiguration> validation = default;
            Optional<bool> isAutoProvisioned = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("registration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registration = ContainerAppAzureActiveDirectoryRegistrationConfiguration.DeserializeContainerAppAzureActiveDirectoryRegistrationConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("login"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    login = ContainerAppAzureActiveDirectoryLoginConfiguration.DeserializeContainerAppAzureActiveDirectoryLoginConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("validation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validation = ContainerAppAzureActiveDirectoryValidationConfiguration.DeserializeContainerAppAzureActiveDirectoryValidationConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("isAutoProvisioned"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProvisioned = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ContainerAppAzureActiveDirectoryConfiguration(Optional.ToNullable(enabled), registration.Value, login.Value, validation.Value, Optional.ToNullable(isAutoProvisioned));
        }
    }
}
