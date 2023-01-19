using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/Load Event Channel")]
public class LoadGameEventSO : ScriptableObject
{
	public UnityAction<GameSceneSO, bool, bool> OnLoadingRequested;

	public void RaiseEvent(GameSceneSO locationsToLoad, bool showLoadingScreen = false, bool fadeScreen = false)
	{
		if (OnLoadingRequested != null)
		{
			OnLoadingRequested.Invoke(locationsToLoad, showLoadingScreen, fadeScreen);
		}
		else
		{
			Debug.LogWarning("Requested loading Scene without SceneLoader");
		}
	}
}