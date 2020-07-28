// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Key Vault secret reference. </summary>
    public partial class AzureKeyVaultSecretReference : SecretBase
    {
        /// <summary> Initializes a new instance of AzureKeyVaultSecretReference. </summary>
        /// <param name="store"> The Azure Key Vault linked service reference. </param>
        /// <param name="secretName"> The name of the secret in Azure Key Vault. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="store"/> or <paramref name="secretName"/> is null. </exception>
        public AzureKeyVaultSecretReference(LinkedServiceReference store, object secretName)
        {
            if (store == null)
            {
                throw new ArgumentNullException(nameof(store));
            }
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }

            Store = store;
            SecretName = secretName;
            Type = "AzureKeyVaultSecret";
        }

        /// <summary> Initializes a new instance of AzureKeyVaultSecretReference. </summary>
        /// <param name="type"> Type of the secret. </param>
        /// <param name="store"> The Azure Key Vault linked service reference. </param>
        /// <param name="secretName"> The name of the secret in Azure Key Vault. Type: string (or Expression with resultType string). </param>
        /// <param name="secretVersion"> The version of the secret in Azure Key Vault. The default value is the latest version of the secret. Type: string (or Expression with resultType string). </param>
        internal AzureKeyVaultSecretReference(string type, LinkedServiceReference store, object secretName, object secretVersion) : base(type)
        {
            Store = store;
            SecretName = secretName;
            SecretVersion = secretVersion;
            Type = type ?? "AzureKeyVaultSecret";
        }

        /// <summary> The Azure Key Vault linked service reference. </summary>
        public LinkedServiceReference Store { get; set; }
        /// <summary> The name of the secret in Azure Key Vault. Type: string (or Expression with resultType string). </summary>
        public object SecretName { get; set; }
        /// <summary> The version of the secret in Azure Key Vault. The default value is the latest version of the secret. Type: string (or Expression with resultType string). </summary>
        public object SecretVersion { get; set; }
    }
}
