using UnityEngine;

namespace RaCoding.Variables
{
    [CreateAssetMenu(fileName = "TransformImmutableVariable", menuName = "RaCoding/Variables/Immutable/Create new immutable transform variable")]
    public class TransformImmutableVariable : ImmutableVariable<Transform> {}
}