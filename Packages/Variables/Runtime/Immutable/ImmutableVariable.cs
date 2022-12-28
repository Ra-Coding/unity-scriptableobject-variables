using UnityEngine;

namespace RaCoding.Variables
{
    public class ImmutableVariable<T> : ScriptableObject, IVariable<T>
    {
        [SerializeField] private T value;

        public T Value 
        {
            get { return this.value; }
        }
    }
}