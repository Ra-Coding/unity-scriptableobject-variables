namespace RaCoding.Variables
{
    public abstract class ArrayVariableEditor<T> : VariableEditor<T>
    {
        protected override void AssignResetValue()
        {
            resetValue.arraySize = value.arraySize;
            resetValue.ClearArray();
            for (int i = 0; i < value.arraySize; i++)
            {
                resetValue.InsertArrayElementAtIndex(i);
                AssignResetArrayElementValue(i);
            }
        }

        protected abstract void AssignResetArrayElementValue(int index);
    }
}