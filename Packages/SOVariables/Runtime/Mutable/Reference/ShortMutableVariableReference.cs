using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class ShortMutableVariableReference : MutableVariableReference<short>
    {
        [SerializeField] private ShortMutableVariable shortMutableVariable;

        protected override MutableVariable<short> Reference => shortMutableVariable;
    }
}
