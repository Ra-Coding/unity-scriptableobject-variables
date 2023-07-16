using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class Vector2IntArrayMutableVariableReference : MutableVariableReference<Vector2Int[]>
    {
        [SerializeField] private Vector2IntArrayMutableVariable vector2IntArrayMutableVariable;

        protected override MutableVariable<Vector2Int[]> Reference => vector2IntArrayMutableVariable; 
    }
}
