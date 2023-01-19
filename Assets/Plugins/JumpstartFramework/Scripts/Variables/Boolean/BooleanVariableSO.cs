using UnityEngine;

[CreateAssetMenu(fileName = "BooleanVariable", menuName = "Variables/BooleanVariable")]
public class BooleanVariableSO : VariableBaseSO<bool>
{
    public override void Add(bool amount) => SetValue(amount);

    public override void Add(VariableBaseSO<bool> amount) => SetValue(amount.Value);
}