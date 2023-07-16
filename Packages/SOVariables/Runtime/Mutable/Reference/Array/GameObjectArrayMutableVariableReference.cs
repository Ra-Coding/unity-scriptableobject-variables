using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class GameObjectArrayMutableVariableReference : MutableVariableReference<GameObject[]>
    {
        [SerializeField] private GameObjectArrayMutableVariable gameObjectArrayMutableVariable;

        protected override MutableVariable<GameObject[]> Reference => gameObjectArrayMutableVariable; 
    }
}
