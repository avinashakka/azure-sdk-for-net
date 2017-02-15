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
    /// The integration account partner content.
    /// </summary>
    public partial class PartnerContent
    {
        /// <summary>
        /// Initializes a new instance of the PartnerContent class.
        /// </summary>
        public PartnerContent() { }

        /// <summary>
        /// Initializes a new instance of the PartnerContent class.
        /// </summary>
        public PartnerContent(B2BPartnerContent b2b = default(B2BPartnerContent))
        {
            B2b = b2b;
        }

        /// <summary>
        /// Gets or sets the B2B partner content.
        /// </summary>
        [JsonProperty(PropertyName = "b2b")]
        public B2BPartnerContent B2b { get; set; }

    }
}
