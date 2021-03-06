using System.Diagnostics.CodeAnalysis;
using Contrib.KubeClient.CustomResources;
using JetBrains.Annotations;

namespace Contrib.KubeClient.ServiceCatalog
{
    [ExcludeFromCodeCoverage]
    [PublicAPI]
    public class ClusterServiceClass : CustomResource<ClusterServiceClassSpec, ClusterServiceClassStatus>
    {
        public new static CustomResourceDefinition Definition { get; } = Crd.For(pluralName: "clusterserviceclasses", kind: "ClusterServiceClass");

        public ClusterServiceClass()
            : base(Definition)
        {}

        public ClusterServiceClass(string name, ClusterServiceClassSpec spec)
            : base(Definition, @namespace: null, name, spec)
        {}
    }
}
