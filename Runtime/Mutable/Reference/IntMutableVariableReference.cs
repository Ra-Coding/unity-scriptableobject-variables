using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class IntMutableVariableReference : MutableVariableReference<int>
    {
        [SerializeField] private IntMutableVariable intMutableVariable;

        protected override MutableVariable<int> Reference => intMutableVariable;
    }
}
