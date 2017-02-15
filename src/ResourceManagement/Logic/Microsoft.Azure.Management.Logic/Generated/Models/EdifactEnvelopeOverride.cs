// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The Edifact enevlope override settings.
    /// </summary>
    public partial class EdifactEnvelopeOverride
    {
        /// <summary>
        /// Initializes a new instance of the EdifactEnvelopeOverride class.
        /// </summary>
        public EdifactEnvelopeOverride() { }

        /// <summary>
        /// Initializes a new instance of the EdifactEnvelopeOverride class.
        /// </summary>
        public EdifactEnvelopeOverride(string messageId = default(string), string messageVersion = default(string), string messageRelease = default(string), string messageAssociationAssignedCode = default(string), string targetNamespace = default(string), string functionalGroupId = default(string), string senderApplicationQualifier = default(string), string senderApplicationId = default(string), string receiverApplicationQualifier = default(string), string receiverApplicationId = default(string), string controllingAgencyCode = default(string), string groupHeaderMessageVersion = default(string), string groupHeaderMessageRelease = default(string), string associationAssignedCode = default(string), string applicationPassword = default(string))
        {
            MessageId = messageId;
            MessageVersion = messageVersion;
            MessageRelease = messageRelease;
            MessageAssociationAssignedCode = messageAssociationAssignedCode;
            TargetNamespace = targetNamespace;
            FunctionalGroupId = functionalGroupId;
            SenderApplicationQualifier = senderApplicationQualifier;
            SenderApplicationId = senderApplicationId;
            ReceiverApplicationQualifier = receiverApplicationQualifier;
            ReceiverApplicationId = receiverApplicationId;
            ControllingAgencyCode = controllingAgencyCode;
            GroupHeaderMessageVersion = groupHeaderMessageVersion;
            GroupHeaderMessageRelease = groupHeaderMessageRelease;
            AssociationAssignedCode = associationAssignedCode;
            ApplicationPassword = applicationPassword;
        }

        /// <summary>
        /// Gets or sets the message id on which this envelope settings has to
        /// be applied.
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the message version on which this envelope settings
        /// has to be applied.
        /// </summary>
        [JsonProperty(PropertyName = "messageVersion")]
        public string MessageVersion { get; set; }

        /// <summary>
        /// Gets or sets the message release version on which this envelope
        /// settings has to be applied.
        /// </summary>
        [JsonProperty(PropertyName = "messageRelease")]
        public string MessageRelease { get; set; }

        /// <summary>
        /// Gets or sets the message association assigned code.
        /// </summary>
        [JsonProperty(PropertyName = "messageAssociationAssignedCode")]
        public string MessageAssociationAssignedCode { get; set; }

        /// <summary>
        /// Gets or sets the target namespace on which this envelope settings
        /// has to be applied.
        /// </summary>
        [JsonProperty(PropertyName = "targetNamespace")]
        public string TargetNamespace { get; set; }

        /// <summary>
        /// Gets or sets the functional group id.
        /// </summary>
        [JsonProperty(PropertyName = "functionalGroupId")]
        public string FunctionalGroupId { get; set; }

        /// <summary>
        /// Gets or sets the sender application qualifier.
        /// </summary>
        [JsonProperty(PropertyName = "senderApplicationQualifier")]
        public string SenderApplicationQualifier { get; set; }

        /// <summary>
        /// Gets or sets the sender application id.
        /// </summary>
        [JsonProperty(PropertyName = "senderApplicationId")]
        public string SenderApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the receiver application qualifier.
        /// </summary>
        [JsonProperty(PropertyName = "receiverApplicationQualifier")]
        public string ReceiverApplicationQualifier { get; set; }

        /// <summary>
        /// Gets or sets the receiver application id.
        /// </summary>
        [JsonProperty(PropertyName = "receiverApplicationId")]
        public string ReceiverApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the controlling agency code.
        /// </summary>
        [JsonProperty(PropertyName = "controllingAgencyCode")]
        public string ControllingAgencyCode { get; set; }

        /// <summary>
        /// Gets or sets the group header message version.
        /// </summary>
        [JsonProperty(PropertyName = "groupHeaderMessageVersion")]
        public string GroupHeaderMessageVersion { get; set; }

        /// <summary>
        /// Gets or sets the group header message release.
        /// </summary>
        [JsonProperty(PropertyName = "groupHeaderMessageRelease")]
        public string GroupHeaderMessageRelease { get; set; }

        /// <summary>
        /// Gets or sets the association assigned code.
        /// </summary>
        [JsonProperty(PropertyName = "associationAssignedCode")]
        public string AssociationAssignedCode { get; set; }

        /// <summary>
        /// Gets or sets the application password.
        /// </summary>
        [JsonProperty(PropertyName = "applicationPassword")]
        public string ApplicationPassword { get; set; }

    }
}
