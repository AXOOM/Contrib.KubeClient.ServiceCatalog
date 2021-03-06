using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace Contrib.KubeClient.ServiceCatalog
{
    /// <summary>
    /// ServiceBrokerConditionType represents a broker condition value.
    /// ServiceBrokerConditionReady represents the fact that a given broker condition
    /// is in ready state.
    /// ServiceBrokerConditionFailed represents information about a final failure
    /// that should not be retried.
    /// </summary>
    [PublicAPI]
    public enum ServiceBrokerConditionType
    {
        [EnumMember(Value = "")] None,
        [EnumMember(Value = "ready")] Ready,
        [EnumMember(Value = "failed")] Failed
    }
}
