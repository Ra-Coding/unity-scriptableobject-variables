using UnityEngine;

namespace RaCoding.Variables
{
    [CreateAssetMenu(fileName = "Vector3ImmutableVariable", menuName = "RaCoding/Variables/Immutable/Create new immutable vector3 variable")]
    public class Vector3ImmutableVariable : ImmutableVariable<Vector3> {}
}