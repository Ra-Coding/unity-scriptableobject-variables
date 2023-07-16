using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class Vector3ArrayMutableVariableReference : MutableVariableReference<Vector3[]>
    {
        [SerializeField] private Vector3ArrayMutableVariable vector3ArrayMutableVariable;

        protected override MutableVariable<Vector3[]> Reference => vector3ArrayMutableVariable; 
    }
}
