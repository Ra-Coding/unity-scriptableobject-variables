namespace RaCoding.Variables
{
    public abstract class MutableVariableReference<T> : IVariable<T>
    {
        protected abstract MutableVariable<T> Reference 
        { 
            get; 
        }
        
        public T Value
        {
            get 
            {
                return Reference.Value;
            }
        }
    }
}
