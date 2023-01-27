using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class Vector3IntMutableVariableReference : MutableVariableReference<Vector3Int>
    {
        [SerializeField] private Vector3IntMutableVariable vector3intMutableVariable;

        protected override MutableVariable<Vector3Int> Reference => vector3intMutableVariable;
    }
}
