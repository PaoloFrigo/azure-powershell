// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>Properties of the Partner Topic update.</summary>
    public partial class PartnerTopicUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerTopicUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerTopicUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfo _identity;

        /// <summary>Identity information for the Partner Topic resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfo Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IdentityInfo()); set => this._identity = value; }

        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfoInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfoInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfoInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfoInternal)Identity).TenantId = value ?? null; }

        /// <summary>
        /// The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity
        /// and a set of user-assigned identities. The type 'None' will remove any identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfoInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfoInternal)Identity).Type = value ?? null; }

        /// <summary>
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
        /// ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// This property is currently not used and reserved for future usage.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfoUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfoInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfoInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfo Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerTopicUpdateParametersInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IdentityInfo()); set { {_identity = value;} } }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerTopicUpdateParametersTags _tag;

        /// <summary>Tags of the Partner Topic resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerTopicUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.PartnerTopicUpdateParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="PartnerTopicUpdateParameters" /> instance.</summary>
        public PartnerTopicUpdateParameters()
        {

        }
    }
    /// Properties of the Partner Topic update.
    public partial interface IPartnerTopicUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The principal ID of resource identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get; set; }
        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The tenant ID of resource.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get; set; }
        /// <summary>
        /// The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity
        /// and a set of user-assigned identities. The type 'None' will remove any identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user-assigned identities. The type 'None' will remove any identity.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned, UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
        /// ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// This property is currently not used and reserved for future usage.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource ids in the form:
        '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        This property is currently not used and reserved for future usage.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfoUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfoUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Tags of the Partner Topic resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tags of the Partner Topic resource.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerTopicUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerTopicUpdateParametersTags Tag { get; set; }

    }
    /// Properties of the Partner Topic update.
    internal partial interface IPartnerTopicUpdateParametersInternal

    {
        /// <summary>Identity information for the Partner Topic resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfo Identity { get; set; }
        /// <summary>The principal ID of resource identity.</summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>The tenant ID of resource.</summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity
        /// and a set of user-assigned identities. The type 'None' will remove any identity.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned, UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
        /// ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// This property is currently not used and reserved for future usage.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IIdentityInfoUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Tags of the Partner Topic resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerTopicUpdateParametersTags Tag { get; set; }

    }
}