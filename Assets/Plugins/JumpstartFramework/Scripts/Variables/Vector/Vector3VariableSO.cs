using UnityEngine;

[CreateAssetMenu(fileName = "Vector3Variable", menuName = "Variables/Vector3Variable")]
public class Vector3VariableSO : VariableBaseSO<Vector3>
{
    public override void Add(Vector3 amount) => variableValue += amount;

    public override void Add(VariableBaseSO<Vector3> amount) => variableValue += amount.Value;
}