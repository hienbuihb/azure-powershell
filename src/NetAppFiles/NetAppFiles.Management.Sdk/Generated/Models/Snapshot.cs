// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Snapshot of a Volume
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Snapshot : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Snapshot class.
        /// </summary>
        public Snapshot()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Snapshot class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="snapshotId">snapshotId</param>
        /// <param name="created">name</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        public Snapshot(string location, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string snapshotId = default(string), System.DateTime? created = default(System.DateTime?), string provisioningState = default(string))
            : base(id, name, type, systemData)
        {
            Location = location;
            SnapshotId = snapshotId;
            Created = created;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets snapshotId
        /// </summary>
        /// <remarks>
        /// UUID v4 used to identify the Snapshot
        /// </remarks>
        [JsonProperty(PropertyName = "properties.snapshotId")]
        public string SnapshotId { get; private set; }

        /// <summary>
        /// Gets name
        /// </summary>
        /// <remarks>
        /// The creation date of the snapshot
        /// </remarks>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime? Created { get; private set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (SnapshotId != null)
            {
                if (SnapshotId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "SnapshotId", 36);
                }
                if (SnapshotId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SnapshotId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(SnapshotId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "SnapshotId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                }
            }
        }
    }
}
