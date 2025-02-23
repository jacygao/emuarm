//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 612 // Disable "CS0612 '...' is obsolete"
#pragma warning disable 649 // Disable "CS0649 Field is never assigned to, and will always have its default value null"
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"
#pragma warning disable 8604 // Disable "CS8604 Possible null reference argument for parameter"
#pragma warning disable 8625 // Disable "CS8625 Cannot convert null literal to non-nullable reference type"
#pragma warning disable 8765 // Disable "CS8765 Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes)."

namespace ApplicationSecurityGroupController
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public interface IApplicationSecurityGroupsController
    {

        /// <remarks>
        /// Deletes the specified application security group.
        /// </remarks>

        /// <param name="resourceGroupName">The name of the resource group.</param>

        /// <param name="applicationSecurityGroupName">The name of the application security group.</param>

        /// <param name="api_version">Client API version.</param>

        /// <param name="subscriptionId">The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.</param>

        /// <returns>Delete successful.</returns>

        System.Threading.Tasks.Task DeleteAsync(string resourceGroupName, string applicationSecurityGroupName, string api_version, string subscriptionId);

        /// <remarks>
        /// Gets information about the specified application security group.
        /// </remarks>

        /// <param name="resourceGroupName">The name of the resource group.</param>

        /// <param name="applicationSecurityGroupName">The name of the application security group.</param>

        /// <param name="api_version">Client API version.</param>

        /// <param name="subscriptionId">The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.</param>

        /// <returns>Request successful. The operation returns the specified application security group resource.</returns>

        System.Threading.Tasks.Task<ApplicationSecurityGroup> GetAsync(string resourceGroupName, string applicationSecurityGroupName, string api_version, string subscriptionId);

        /// <remarks>
        /// Creates or updates an application security group.
        /// </remarks>

        /// <param name="resourceGroupName">The name of the resource group.</param>

        /// <param name="applicationSecurityGroupName">The name of the application security group.</param>

        /// <param name="parameters">Parameters supplied to the create or update ApplicationSecurityGroup operation.</param>

        /// <param name="api_version">Client API version.</param>

        /// <param name="subscriptionId">The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.</param>

        /// <returns>Update successful. The operation returns the resulting application security group resource.</returns>

        System.Threading.Tasks.Task<ApplicationSecurityGroup> CreateOrUpdateAsync(string resourceGroupName, string applicationSecurityGroupName, ApplicationSecurityGroup parameters, string api_version, string subscriptionId);

        /// <remarks>
        /// Updates an application security group's tags.
        /// </remarks>

        /// <param name="resourceGroupName">The name of the resource group.</param>

        /// <param name="applicationSecurityGroupName">The name of the application security group.</param>

        /// <param name="parameters">Parameters supplied to update application security group tags.</param>

        /// <param name="api_version">Client API version.</param>

        /// <param name="subscriptionId">The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.</param>

        /// <returns>Update successful. The operation returns the resulting ApplicationSecurityGroup resource.</returns>

        System.Threading.Tasks.Task<ApplicationSecurityGroup> UpdateTagsAsync(string resourceGroupName, string applicationSecurityGroupName, TagsObject parameters, string api_version, string subscriptionId);

        /// <remarks>
        /// Gets all application security groups in a subscription.
        /// </remarks>

        /// <param name="api_version">Client API version.</param>

        /// <param name="subscriptionId">The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.</param>

        /// <returns>Request successful. The operation returns a list of application security group resources.</returns>

        System.Threading.Tasks.Task<ApplicationSecurityGroupListResult> ListAllAsync(string api_version, string subscriptionId);

        /// <remarks>
        /// Gets all the application security groups in a resource group.
        /// </remarks>

        /// <param name="resourceGroupName">The name of the resource group.</param>

        /// <param name="api_version">Client API version.</param>

        /// <param name="subscriptionId">The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.</param>

        /// <returns>Request successful. The operation returns a list of application security group resources.</returns>

        System.Threading.Tasks.Task<ApplicationSecurityGroupListResult> ListAsync(string resourceGroupName, string api_version, string subscriptionId);

    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]

    public partial class ApplicationSecurityGroupsController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private IApplicationSecurityGroupsController _implementation;

        public ApplicationSecurityGroupsController(IApplicationSecurityGroupsController implementation)
        {
            _implementation = implementation;
        }

        /// <remarks>
        /// Deletes the specified application security group.
        /// </remarks>
        /// <param name="resourceGroupName">The name of the resource group.</param>
        /// <param name="applicationSecurityGroupName">The name of the application security group.</param>
        /// <param name="api_version">Client API version.</param>
        /// <param name="subscriptionId">The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.</param>
        /// <returns>Delete successful.</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups/{applicationSecurityGroupName}")]
        public System.Threading.Tasks.Task Delete(string resourceGroupName, string applicationSecurityGroupName, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "api-version")] string api_version, string subscriptionId)
        {

            return _implementation.DeleteAsync(resourceGroupName, applicationSecurityGroupName, api_version, subscriptionId);
        }

        /// <remarks>
        /// Gets information about the specified application security group.
        /// </remarks>
        /// <param name="resourceGroupName">The name of the resource group.</param>
        /// <param name="applicationSecurityGroupName">The name of the application security group.</param>
        /// <param name="api_version">Client API version.</param>
        /// <param name="subscriptionId">The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.</param>
        /// <returns>Request successful. The operation returns the specified application security group resource.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups/{applicationSecurityGroupName}")]
        public System.Threading.Tasks.Task<ApplicationSecurityGroup> Get(string resourceGroupName, string applicationSecurityGroupName, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "api-version")] string api_version, string subscriptionId)
        {

            return _implementation.GetAsync(resourceGroupName, applicationSecurityGroupName, api_version, subscriptionId);
        }

        /// <remarks>
        /// Creates or updates an application security group.
        /// </remarks>
        /// <param name="resourceGroupName">The name of the resource group.</param>
        /// <param name="applicationSecurityGroupName">The name of the application security group.</param>
        /// <param name="parameters">Parameters supplied to the create or update ApplicationSecurityGroup operation.</param>
        /// <param name="api_version">Client API version.</param>
        /// <param name="subscriptionId">The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.</param>
        /// <returns>Update successful. The operation returns the resulting application security group resource.</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups/{applicationSecurityGroupName}")]
        public System.Threading.Tasks.Task<ApplicationSecurityGroup> CreateOrUpdate(string resourceGroupName, string applicationSecurityGroupName, [Microsoft.AspNetCore.Mvc.FromBody] ApplicationSecurityGroup parameters, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "api-version")] string api_version, string subscriptionId)
        {

            return _implementation.CreateOrUpdateAsync(resourceGroupName, applicationSecurityGroupName, parameters, api_version, subscriptionId);
        }

        /// <remarks>
        /// Updates an application security group's tags.
        /// </remarks>
        /// <param name="resourceGroupName">The name of the resource group.</param>
        /// <param name="applicationSecurityGroupName">The name of the application security group.</param>
        /// <param name="parameters">Parameters supplied to update application security group tags.</param>
        /// <param name="api_version">Client API version.</param>
        /// <param name="subscriptionId">The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.</param>
        /// <returns>Update successful. The operation returns the resulting ApplicationSecurityGroup resource.</returns>
        [Microsoft.AspNetCore.Mvc.HttpPatch, Microsoft.AspNetCore.Mvc.Route("subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups/{applicationSecurityGroupName}")]
        public System.Threading.Tasks.Task<ApplicationSecurityGroup> UpdateTags(string resourceGroupName, string applicationSecurityGroupName, [Microsoft.AspNetCore.Mvc.FromBody] TagsObject parameters, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "api-version")] string api_version, string subscriptionId)
        {

            return _implementation.UpdateTagsAsync(resourceGroupName, applicationSecurityGroupName, parameters, api_version, subscriptionId);
        }

        /// <remarks>
        /// Gets all application security groups in a subscription.
        /// </remarks>
        /// <param name="api_version">Client API version.</param>
        /// <param name="subscriptionId">The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.</param>
        /// <returns>Request successful. The operation returns a list of application security group resources.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("subscriptions/{subscriptionId}/providers/Microsoft.Network/applicationSecurityGroups")]
        public System.Threading.Tasks.Task<ApplicationSecurityGroupListResult> ListAll([Microsoft.AspNetCore.Mvc.FromQuery(Name = "api-version")] string api_version, string subscriptionId)
        {

            return _implementation.ListAllAsync(api_version, subscriptionId);
        }

        /// <remarks>
        /// Gets all the application security groups in a resource group.
        /// </remarks>
        /// <param name="resourceGroupName">The name of the resource group.</param>
        /// <param name="api_version">Client API version.</param>
        /// <param name="subscriptionId">The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.</param>
        /// <returns>Request successful. The operation returns a list of application security group resources.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationSecurityGroups")]
        public System.Threading.Tasks.Task<ApplicationSecurityGroupListResult> List(string resourceGroupName, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "api-version")] string api_version, string subscriptionId)
        {

            return _implementation.ListAsync(resourceGroupName, api_version, subscriptionId);
        }

    }

    /// <summary>
    /// An application security group in a resource group.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ApplicationSecurityGroup : Resource
    {
        /// <summary>
        /// Properties of the application security group.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("properties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ApplicationSecurityGroupPropertiesFormat Properties { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("etag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Etag { get; set; }

    }

    /// <summary>
    /// Application security group properties.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ApplicationSecurityGroupPropertiesFormat
    {
        /// <summary>
        /// The resource GUID property of the application security group resource. It uniquely identifies a resource, even if the user changes its name or migrate the resource across subscriptions or resource groups.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resourceGuid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// The provisioning state of the application security group resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("provisioningState", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ProvisioningState? ProvisioningState { get; set; }

    }

    /// <summary>
    /// A list of application security groups.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ApplicationSecurityGroupListResult
    {
        /// <summary>
        /// A list of application security groups.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<ApplicationSecurityGroup> Value { get; set; }

        /// <summary>
        /// The URL to get the next set of results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nextLink", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NextLink { get; set; }

    }

    /// <summary>
    /// An error response from the service.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CloudError
    {
        /// <summary>
        /// Cloud error body.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Error Error { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Tags object for patch operations.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TagsObject
    {
        /// <summary>
        /// Resource tags.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Common resource representation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Resource
    {
        /// <summary>
        /// Resource ID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Resource name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Resource type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// The current provisioning state.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ProvisioningState
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Succeeded")]
        Succeeded = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Updating")]
        Updating = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Deleting")]
        Deleting = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Failed")]
        Failed = 3,

    }

    /// <summary>
    /// An error response from the service.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Error
    {
        /// <summary>
        /// An identifier for the error. Codes are invariant and are intended to be consumed programmatically.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// A message describing the error, intended to be suitable for display in a user interface.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// The target of the particular error. For example, the name of the property in error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// A list of additional details about the error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("details", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Error> Details { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }


}

#pragma warning restore  108
#pragma warning restore  114
#pragma warning restore  472
#pragma warning restore  612
#pragma warning restore 1573
#pragma warning restore 1591
#pragma warning restore 8073
#pragma warning restore 3016
#pragma warning restore 8603
#pragma warning restore 8604
#pragma warning restore 8625