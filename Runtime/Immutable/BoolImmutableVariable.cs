using UnityEngine;

namespace RaCoding.Variables
{
    [CreateAssetMenu(fileName = "BoolImmutableVariable", menuName = "RaCoding/Variables/Immutable/Create new immutable bool variable")]
    public class BoolImmutableVariable : ImmutableVariable<bool> {}
}