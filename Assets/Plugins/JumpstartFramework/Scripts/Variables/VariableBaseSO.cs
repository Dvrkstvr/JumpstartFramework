using UnityEngine;

public abstract class VariableBaseSO<T> : ScriptableGameObject
{
    [SerializeField] protected T variableValue;
    public T Value => variableValue;

    public override string ToString()
    {
        return variableValue.ToString();
    }

    public void SetValue(T value)
    {
        variableValue = value;
    }

    public void SetValue(VariableBaseSO<T> value)
    {
        variableValue = value.Value;
    }

    public abstract void Add(T amount);

    public abstract void Add(VariableBaseSO<T> amount);
}
