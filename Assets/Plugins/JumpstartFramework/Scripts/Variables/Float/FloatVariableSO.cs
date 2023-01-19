using UnityEngine;

[CreateAssetMenu(fileName = "FloatVariable", menuName = "Variables/FloatVariable")]
public class FloatVariableSO : VariableBaseSO<float>
{
    public override void Add(float amount) => variableValue += amount;

    public override void Add(VariableBaseSO<float> amount) => variableValue += amount.Value;
}