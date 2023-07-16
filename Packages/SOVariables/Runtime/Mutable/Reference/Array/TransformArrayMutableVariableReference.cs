using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class TransformArrayMutableVariableReference : MutableVariableReference<Transform[]>
    {
        [SerializeField] private TransformArrayMutableVariable transformArrayMutableVariable;

        protected override MutableVariable<Transform[]> Reference => transformArrayMutableVariable; 
    }
}
