using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class Vector2MutableVariableReference : MutableVariableReference<Vector2>
    {
        [SerializeField] private Vector2MutableVariable vector2MutableVariable;

        protected override MutableVariable<Vector2> Reference => vector2MutableVariable;
    }
}
