using UnityEngine;

[CreateAssetMenu(fileName = "IntegerVariable", menuName = "Variables/IntegerVariable")]
public class IntegerVariableSO : VariableBaseSO<int>
{
    public override void Add(int amount) => variableValue += amount;

    public override void Add(VariableBaseSO<int> amount) => variableValue += amount.Value;
}
