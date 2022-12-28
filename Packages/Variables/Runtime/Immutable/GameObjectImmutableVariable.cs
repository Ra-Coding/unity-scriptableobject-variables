using UnityEngine;

namespace RaCoding.Variables
{
    [CreateAssetMenu(fileName = "GameObjectImmutableVariable", menuName = "RaCoding/Variables/Immutable/Create new immutable gameobject variable")]
    public class GameObjectImmutableVariable : ImmutableVariable<GameObject> {}
}
