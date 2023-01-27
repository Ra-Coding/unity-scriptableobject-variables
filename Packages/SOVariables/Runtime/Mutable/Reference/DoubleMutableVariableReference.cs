using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class DoubleMutableVariableReference : MutableVariableReference<double>
    {
        [SerializeField] private DoubleMutableVariable doubleMutableVariable;

        protected override MutableVariable<double> Reference => doubleMutableVariable;
    }
}
