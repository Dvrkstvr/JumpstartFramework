using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableGameObject : ScriptableObject
{
#if UNITY_EDITOR
    [TextArea]
    public string DeveloperDescription = "";
#endif
}
