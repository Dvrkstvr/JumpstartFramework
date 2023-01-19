using UnityEngine;

[CreateAssetMenu(fileName = "Vector2Variable", menuName = "Variables/Vector2Variable")]
public class Vector2VariableSO : VariableBaseSO<Vector2>
{
    public override void Add(Vector2 amount) => variableValue += amount;

    public override void Add(VariableBaseSO<Vector2> amount) => variableValue += amount.Value;
}