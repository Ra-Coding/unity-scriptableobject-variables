using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class IntArrayMutableVariableReference : MutableVariableReference<int[]>
    {
        [SerializeField] private IntArrayMutableVariable intArrayMutableVariable;

        protected override MutableVariable<int[]> Reference => intArrayMutableVariable; 
    }
}
