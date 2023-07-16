using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class ShortArrayMutableVariableReference : MutableVariableReference<short[]>
    {
        [SerializeField] private ShortArrayMutableVariable shortArrayMutableVariable;

        protected override MutableVariable<short[]> Reference => shortArrayMutableVariable; 
    }
}
