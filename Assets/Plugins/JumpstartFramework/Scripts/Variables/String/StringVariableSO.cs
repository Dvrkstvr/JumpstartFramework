using UnityEngine;

[CreateAssetMenu(fileName = "StringVariable", menuName = "Variables/StringVariable")]
public class StringVariableSO : VariableBaseSO<string>
{
    public override void Add(string amount) => SetValue(amount);

    public override void Add(VariableBaseSO<string> amount) => SetValue(amount.Value);
}
