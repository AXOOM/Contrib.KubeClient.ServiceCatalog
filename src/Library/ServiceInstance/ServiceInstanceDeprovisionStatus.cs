using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace Contrib.KubeClient.ServiceCatalog
{
    /// <summary>
    /// ServiceInstanceDeprovisionStatus is the status of deprovisioning a
    /// ServiceInstance
    /// NotRequired indicates that a provision
    /// request has not been sent for the ServiceInstance, so no deprovision
    /// request needs to be made.
    /// Required indicates that a provision
    /// request has been sent for the ServiceInstance. A deprovision request
    /// must be made before deleting the ServiceInstance.
    /// Succeeded indicates that a deprovision
    /// request has been sent for the ServiceInstance, and the request was
    /// successful.
    /// Failed indicates that deprovision
    /// requests have been sent for the ServiceInstance but they failed. The
    /// controller has given up on sending more deprovision requests.
    /// </summary>
    [PublicAPI]
    public enum ServiceInstanceDeprovisionStatus
    {
        [EnumMember(Value = "")] None,
        [EnumMember(Value = "notRequired")] NotRequired,
        [EnumMember(Value = "required")] Required,
        [EnumMember(Value = "succeeded")] Succeeded,
        [EnumMember(Value = "failed")] Failed
    }
}
