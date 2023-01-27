using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class TransformMutableVariableReference : MutableVariableReference<Transform>
    {
        [SerializeField] private TransformMutableVariable transformMutableVariable;

        protected override MutableVariable<Transform> Reference => transformMutableVariable;
    }
}
