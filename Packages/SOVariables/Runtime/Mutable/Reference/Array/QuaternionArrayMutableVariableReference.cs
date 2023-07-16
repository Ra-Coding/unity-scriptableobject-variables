using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class QuaternionArrayMutableVariableReference : MutableVariableReference<Quaternion[]>
    {
        [SerializeField] private QuaternionArrayMutableVariable quaternionArrayMutableVariable;

        protected override MutableVariable<Quaternion[]> Reference => quaternionArrayMutableVariable; 
    }
}
