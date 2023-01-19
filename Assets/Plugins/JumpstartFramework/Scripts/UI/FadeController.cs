using UnityEngine;
using UnityEngine.UI;

public class FadeController : MonoBehaviour
{
	[SerializeField] private FadeUIEventSO _fadeChannelSO;
	[SerializeField] private Image _imageComponent;

	private void OnEnable()
	{
		_fadeChannelSO.OnEventRaised += InitiateFade;
	}

	private void OnDisable()
	{
		_fadeChannelSO.OnEventRaised -= InitiateFade;
	}

	private void InitiateFade(bool fadeIn, float duration, Color desiredColor)
	{
		//_imageComponent.DOBlendableColor(desiredColor, duration); // FIND A WAY TO FADE
	}
}