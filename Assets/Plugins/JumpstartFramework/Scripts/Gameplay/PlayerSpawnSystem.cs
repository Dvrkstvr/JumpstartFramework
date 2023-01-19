using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnSystem : MonoBehaviour
{
	[Header("Asset References")]
	[SerializeField] private InputReader _inputReader = default;
	[SerializeField] private GameObject _playerPrefab = default;
	//[SerializeField] private TransformEventChannelSO _playerInstantiatedChannel = default;

	[Header("Scene Ready Event")]
	[SerializeField] private GameEventSO _onSceneReady = default; //Raised by SceneLoader when the scene is set to active

	private Transform _defaultSpawnPoint;
	private bool isSpawned = false;

	private void Awake()
	{
		_defaultSpawnPoint = transform.GetChild(0);
	}

    private void Update()
    {
        if(_onSceneReady != null && isSpawned == false)
        {
			isSpawned = true;	
			SpawnPlayer();
        }
    }

    private void SpawnPlayer()
	{
		Transform spawnLocation = _defaultSpawnPoint;
		GameObject playerInstance = Instantiate(_playerPrefab, spawnLocation.position, spawnLocation.rotation);

		//_playerInstantiatedChannel.RaiseEvent(playerInstance.transform);

		//TODO: Probably move this to the GameManager once it's up and running
		_inputReader.EnableGameplayInput();
	}
}
