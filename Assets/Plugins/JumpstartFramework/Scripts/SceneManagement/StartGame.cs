using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private bool _showLoadScreen = default;

    [SerializeField] private LoadGameEventSO _loadLocation = default;

    public void StartNewGame(GameSceneSO gameScene)
    {
        _loadLocation.RaiseEvent(gameScene, _showLoadScreen);
    }
}