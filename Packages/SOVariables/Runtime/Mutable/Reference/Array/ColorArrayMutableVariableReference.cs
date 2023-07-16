using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class ColorArrayMutableVariableReference : MutableVariableReference<Color[]>
    {
        [SerializeField] private ColorArrayMutableVariable colorArrayMutableVariable;

        protected override MutableVariable<Color[]> Reference => colorArrayMutableVariable; 
    }
}
