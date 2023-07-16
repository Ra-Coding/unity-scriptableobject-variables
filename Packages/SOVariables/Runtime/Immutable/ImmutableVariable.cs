using UnityEngine;

namespace RaCoding.Variables
{
    public abstract class ImmutableVariable<T> : ScriptableObject, IVariable<T>
    {
        [SerializeField] private T value;

        public T Value 
        {
            get { return value; }
        }
    }
}