using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class QuaternionMutableVariableReference : MutableVariableReference<Quaternion>
    {
        [SerializeField] private QuaternionMutableVariable quaternionMutableVariable;

        protected override MutableVariable<Quaternion> Reference => quaternionMutableVariable;
    }
}
