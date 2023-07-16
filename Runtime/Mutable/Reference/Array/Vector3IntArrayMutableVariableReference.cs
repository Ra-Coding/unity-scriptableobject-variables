using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class Vector3IntArrayMutableVariableReference : MutableVariableReference<Vector3Int[]>
    {
        [SerializeField] private Vector3IntArrayMutableVariable vector3IntArrayMutableVariable;

        protected override MutableVariable<Vector3Int[]> Reference => vector3IntArrayMutableVariable; 
    }
}
