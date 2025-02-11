// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Extensions;

    public partial class NginxFrontendIPConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxFrontendIPConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxFrontendIPConfigurationInternal
    {

        /// <summary>Backing field for <see cref="PrivateIPAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxPrivateIPAddress[] _privateIPAddress;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxPrivateIPAddress[] PrivateIPAddress { get => this._privateIPAddress; set => this._privateIPAddress = value; }

        /// <summary>Backing field for <see cref="PublicIPAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxPublicIPAddress[] _publicIPAddress;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxPublicIPAddress[] PublicIPAddress { get => this._publicIPAddress; set => this._publicIPAddress = value; }

        /// <summary>Creates an new <see cref="NginxFrontendIPConfiguration" /> instance.</summary>
        public NginxFrontendIPConfiguration()
        {

        }
    }
    public partial interface INginxFrontendIPConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"privateIPAddresses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxPrivateIPAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxPrivateIPAddress[] PrivateIPAddress { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"publicIPAddresses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxPublicIPAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxPublicIPAddress[] PublicIPAddress { get; set; }

    }
    internal partial interface INginxFrontendIPConfigurationInternal

    {
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxPrivateIPAddress[] PrivateIPAddress { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxPublicIPAddress[] PublicIPAddress { get; set; }

    }
}