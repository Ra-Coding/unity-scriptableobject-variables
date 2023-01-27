using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class Vector2IntMutableVariableReference : MutableVariableReference<Vector2Int>
    {
        [SerializeField] private Vector2IntMutableVariable vector2intMutableVariable;

        protected override MutableVariable<Vector2Int> Reference => vector2intMutableVariable;
    }
}
