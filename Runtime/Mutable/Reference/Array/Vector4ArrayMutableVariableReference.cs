using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class Vector4ArrayMutableVariableReference : MutableVariableReference<Vector4[]>
    {
        [SerializeField] private Vector4ArrayMutableVariable vector4ArrayMutableVariable;

        protected override MutableVariable<Vector4[]> Reference => vector4ArrayMutableVariable; 
    }
}
