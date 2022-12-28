using UnityEngine;

namespace RaCoding.Variables
{
    public class MutableVariable<T> : ScriptableObject, IVariable<T>
    {
        [SerializeField] private T value;
        [SerializeField] private T resetValue;

        public T Value 
        {
            get { return this.value; }
            set { this.value = value; }
        }
        
        public void ResetValue() {
            Value = resetValue;
        }
    }
}