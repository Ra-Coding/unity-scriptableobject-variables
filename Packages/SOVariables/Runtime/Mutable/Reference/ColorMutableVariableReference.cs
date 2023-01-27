using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class ColorMutableVariableReference : MutableVariableReference<Color>
    {
        [SerializeField] private ColorMutableVariable colorMutableVariable;

        protected override MutableVariable<Color> Reference => colorMutableVariable;
    }
}
