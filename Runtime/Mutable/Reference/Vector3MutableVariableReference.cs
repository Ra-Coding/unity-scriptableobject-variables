using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class Vector3MutableVariableReference : MutableVariableReference<Vector3>
    {
        [SerializeField] private Vector3MutableVariable vector3MutableVariable;

        protected override MutableVariable<Vector3> Reference => vector3MutableVariable;
    }
}
