// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Managed service identity.
    /// </summary>
    public partial class ManagedServiceIdentity
    {
        /// <summary>
        /// Initializes a new instance of the ManagedServiceIdentity class.
        /// </summary>
        public ManagedServiceIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedServiceIdentity class.
        /// </summary>
        /// <param name="type">Type of managed service identity. Possible
        /// values include: 'SystemAssigned', 'UserAssigned'</param>
        /// <param name="tenantId">Tenant of managed service identity.</param>
        /// <param name="principalId">Principal Id of managed service
        /// identity.</param>
        /// <param name="identityIds">Array of UserAssigned managed service
        /// identities.</param>
        public ManagedServiceIdentity(ManagedServiceIdentityType type = default(ManagedServiceIdentityType), string tenantId = default(string), string principalId = default(string), IList<string> identityIds = default(IList<string>))
        {
            Type = type;
            TenantId = tenantId;
            PrincipalId = principalId;
            IdentityIds = identityIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of managed service identity. Possible values
        /// include: 'SystemAssigned', 'UserAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ManagedServiceIdentityType Type { get; set; }

        /// <summary>
        /// Gets tenant of managed service identity.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets principal Id of managed service identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets or sets array of UserAssigned managed service identities.
        /// </summary>
        [JsonProperty(PropertyName = "identityIds")]
        public IList<string> IdentityIds { get; set; }

    }
}
