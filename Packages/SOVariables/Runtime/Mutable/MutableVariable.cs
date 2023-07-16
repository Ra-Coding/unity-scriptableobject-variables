using UnityEngine;

namespace RaCoding.Variables
{
    public abstract class MutableVariable<T> : ScriptableObject, IVariable<T>
    {
        [SerializeField] private T value;
        [SerializeField, ReadOnlyInInspector] private T resetValue;

        public T Value 
        {
            get { return value; }
            set { this.value = value; }
        }
        
        public void ResetValue() {
            Value = resetValue;
        }
    }
}