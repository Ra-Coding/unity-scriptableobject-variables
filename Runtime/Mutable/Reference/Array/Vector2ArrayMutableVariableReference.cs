using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class Vector2ArrayMutableVariableReference : MutableVariableReference<Vector2[]>
    {
        [SerializeField] private Vector2ArrayMutableVariable vector2ArrayMutableVariable;

        protected override MutableVariable<Vector2[]> Reference => vector2ArrayMutableVariable; 
    }
}
