using UnityEngine;

namespace RaCoding.Variables
{
    [CreateAssetMenu(fileName = "ColorImmutableVariable", menuName = "RaCoding/Variables/Immutable/Create new immutable color variable")]
    public class ColorImmutableVariable : ImmutableVariable<Color> {}
}