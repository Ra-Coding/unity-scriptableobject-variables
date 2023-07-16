using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class DoubleArrayMutableVariableReference : MutableVariableReference<double[]>
    {
        [SerializeField] private DoubleArrayMutableVariable doubleArrayMutableVariable;

        protected override MutableVariable<double[]> Reference => doubleArrayMutableVariable; 
    }
}
