using UnityEngine;

namespace RaCoding.Variables
{
    [CreateAssetMenu(fileName = "QuaternionImmutableVariable", menuName = "RaCoding/Variables/Immutable/Create new immutable quaternion variable")]
    public class QuaternionImmutableVariable : ImmutableVariable<Quaternion> { }
}