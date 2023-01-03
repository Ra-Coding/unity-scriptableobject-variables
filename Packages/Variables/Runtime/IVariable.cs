using UnityEngine;

namespace RaCoding.Variables
{
    public interface IVariable<T>
    {
        public T Value
        {
            get;
        }
    }
}
