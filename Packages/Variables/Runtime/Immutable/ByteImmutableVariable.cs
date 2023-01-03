using UnityEngine;

namespace RaCoding.Variables
{
    [CreateAssetMenu(fileName = "ByteImmutableVariable", menuName = "RaCoding/Variables/Immutable/Create new immutable byte variable")]
    public class ByteImmutableVariable : ImmutableVariable<byte> {}
}