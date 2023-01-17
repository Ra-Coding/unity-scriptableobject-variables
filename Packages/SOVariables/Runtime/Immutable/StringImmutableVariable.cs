using UnityEngine;

namespace RaCoding.Variables
{
    [CreateAssetMenu(fileName = "StringImmutableVariable", menuName = "RaCoding/Variables/Immutable/Create new immutable string variable")]
    public class StringImmutableVariable : ImmutableVariable<string> {}
}
