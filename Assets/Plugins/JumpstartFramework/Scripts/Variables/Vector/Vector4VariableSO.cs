using UnityEngine;

[CreateAssetMenu(fileName = "Vector4Variable", menuName = "Variables/Vector4Variable")]
public class Vector4VariableSO : VariableBaseSO<Vector4>
{
    public override void Add(Vector4 amount) => variableValue += amount;

    public override void Add(VariableBaseSO<Vector4> amount) => variableValue += amount.Value;
}