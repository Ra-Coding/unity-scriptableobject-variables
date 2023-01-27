using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class GameObjectMutableVariableReference : MutableVariableReference<GameObject>
    {
        [SerializeField] private GameObjectMutableVariable gameObjectMutableVariable;

        protected override MutableVariable<GameObject> Reference => gameObjectMutableVariable;
    }
}
