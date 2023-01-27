using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class LongMutableVariableReference : MutableVariableReference<long>
    {
        [SerializeField] private LongMutableVariable longMutableVariable;

        protected override MutableVariable<long> Reference => longMutableVariable;
    }
}
