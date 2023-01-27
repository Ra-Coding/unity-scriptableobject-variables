using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class Vector4MutableVariableReference : MutableVariableReference<Vector4>
    {
        [SerializeField] private Vector4MutableVariable vector4MutableVariable;

        protected override MutableVariable<Vector4> Reference => vector4MutableVariable;
    }
}
