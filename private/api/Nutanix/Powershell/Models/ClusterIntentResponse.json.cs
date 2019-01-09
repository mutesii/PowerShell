namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operations on a cluster</summary>
    public partial class ClusterIntentResponse
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Carbon.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Carbon.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Carbon.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Carbon.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Carbon.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="ClusterIntentResponse" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal ClusterIntentResponse(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _apiVersion = If( json?.PropertyT<Carbon.Json.JsonString>("api_version"), out var __jsonApiVersion) ? (string)__jsonApiVersion : (string)ApiVersion;
            _metadata = If( json?.PropertyT<Carbon.Json.JsonObject>("metadata"), out var __jsonMetadata) ? Nutanix.Powershell.Models.ClusterMetadata.FromJson(__jsonMetadata) : Metadata;
            _spec = If( json?.PropertyT<Carbon.Json.JsonObject>("spec"), out var __jsonSpec) ? Nutanix.Powershell.Models.Cluster.FromJson(__jsonSpec) : Spec;
            _status = If( json?.PropertyT<Carbon.Json.JsonObject>("status"), out var __jsonStatus) ? Nutanix.Powershell.Models.ClusterDefStatus.FromJson(__jsonStatus) : Status;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.IClusterIntentResponse.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.IClusterIntentResponse.</returns>
        public static Nutanix.Powershell.Models.IClusterIntentResponse FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new ClusterIntentResponse(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ClusterIntentResponse" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ClusterIntentResponse" /> as a <see cref="Carbon.Json.JsonNode" />.
        /// </returns>
        public Carbon.Json.JsonNode ToJson(Carbon.Json.JsonObject container, Microsoft.Rest.ClientRuntime.SerializationMode serializationMode)
        {
            container = container ?? new Carbon.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != ApiVersion ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ApiVersion) : null, "api_version" ,container.Add );
            AddIf( null != Metadata ? (Carbon.Json.JsonNode) Metadata.ToJson(null) : null, "metadata" ,container.Add );
            AddIf( null != Spec ? (Carbon.Json.JsonNode) Spec.ToJson(null) : null, "spec" ,container.Add );
            AddIf( null != Status ? (Carbon.Json.JsonNode) Status.ToJson(null) : null, "status" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}