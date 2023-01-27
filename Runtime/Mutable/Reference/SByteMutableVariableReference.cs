using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class SByteMutableVariableReference : MutableVariableReference<sbyte>
    {
        [SerializeField] private SByteMutableVariable sbyteMutableVariable;

        protected override MutableVariable<sbyte> Reference => sbyteMutableVariable;
    }
}
