

using System.Diagnostics;

[System.Serializable]
public abstract class VariableReference<T, TV> where T : VariableBaseSO<TV>
{
    public bool UseConstant = true;
    public TV ConstantValue;
    public T Variable;

    public VariableReference() { }

    public VariableReference(TV value)
    {
        UseConstant = true;
        ConstantValue = value;
    }

    public TV Value
    {
        get => UseConstant ? ConstantValue : Variable.Value;
        set
        {
            if(UseConstant)
            {
                ConstantValue = value;
            }
            else
            {
                Debug.Assert(Variable != null, nameof(Variable) + " != null");
                Variable.SetValue(value);
            }
        }
    }

    public static implicit operator TV(VariableReference<T, TV> reference)
    {
        return reference.Value;
    }
}