using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class BoolMutableVariableReference : MutableVariableReference<bool>
    {
        [SerializeField] private BoolMutableVariable boolMutableVariable;

        protected override MutableVariable<bool> Reference => boolMutableVariable;
    }
}
