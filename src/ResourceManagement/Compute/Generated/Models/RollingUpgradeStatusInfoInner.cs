// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The status of the latest virtual machine scale set rolling upgrade.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RollingUpgradeStatusInfoInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the RollingUpgradeStatusInfoInner
        /// class.
        /// </summary>
        public RollingUpgradeStatusInfoInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RollingUpgradeStatusInfoInner
        /// class.
        /// </summary>
        /// <param name="policy">The rolling upgrade policies applied for this
        /// upgrade.</param>
        /// <param name="runningStatus">Information about the current running
        /// state of the overall upgrade.</param>
        /// <param name="progress">Information about the number of virtual
        /// machine instances in each upgrade state.</param>
        /// <param name="error">Error details for this upgrade, if there are
        /// any.</param>
        public RollingUpgradeStatusInfoInner(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), RollingUpgradePolicy policy = default(RollingUpgradePolicy), RollingUpgradeRunningStatus runningStatus = default(RollingUpgradeRunningStatus), RollingUpgradeProgressInfo progress = default(RollingUpgradeProgressInfo), ApiError error = default(ApiError))
            : base(location, id, name, type, tags)
        {
            Policy = policy;
            RunningStatus = runningStatus;
            Progress = progress;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the rolling upgrade policies applied for this upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policy")]
        public RollingUpgradePolicy Policy { get; private set; }

        /// <summary>
        /// Gets information about the current running state of the overall
        /// upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runningStatus")]
        public RollingUpgradeRunningStatus RunningStatus { get; private set; }

        /// <summary>
        /// Gets information about the number of virtual machine instances in
        /// each upgrade state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.progress")]
        public RollingUpgradeProgressInfo Progress { get; private set; }

        /// <summary>
        /// Gets error details for this upgrade, if there are any.
        /// </summary>
        [JsonProperty(PropertyName = "properties.error")]
        public ApiError Error { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Policy != null)
            {
                Policy.Validate();
            }
        }
    }
}
