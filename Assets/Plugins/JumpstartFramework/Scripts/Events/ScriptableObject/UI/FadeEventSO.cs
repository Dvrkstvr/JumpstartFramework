using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/UI/Fade Event")]
public class FadeEventSO : ScriptableGameObject
{
	public UnityAction<bool, float, Color> OnEventRaised;

	public void FadeIn(float duration)
	{
		Fade(true, duration, Color.clear);
	}

	public void FadeOut(float duration)
	{
		Fade(false, duration, Color.black);
	}

	private void Fade(bool fadeIn, float duration, Color color)
	{
		if (OnEventRaised != null)
			OnEventRaised.Invoke(fadeIn, duration, color);
	}
}