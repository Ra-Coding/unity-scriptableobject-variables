using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class SpriteArrayMutableVariableReference : MutableVariableReference<Sprite[]>
    {
        [SerializeField] private SpriteArrayMutableVariable spriteArrayMutableVariable;

        protected override MutableVariable<Sprite[]> Reference => spriteArrayMutableVariable; 
    }
}
