using UnityEngine;

namespace RaCoding.Variables
{
    [System.Serializable]
    public class SpriteMutableVariableReference : MutableVariableReference<Sprite>
    {
        [SerializeField] private SpriteMutableVariable spriteMutableVariable;

        protected override MutableVariable<Sprite> Reference => spriteMutableVariable; 
    }
}
