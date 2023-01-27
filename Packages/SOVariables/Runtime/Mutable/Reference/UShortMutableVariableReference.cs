using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class UShortMutableVariableReference : MutableVariableReference<ushort>
    {
        [SerializeField] private UShortMutableVariable ushortMutableVariable;

        protected override MutableVariable<ushort> Reference => ushortMutableVariable;
    }
}
