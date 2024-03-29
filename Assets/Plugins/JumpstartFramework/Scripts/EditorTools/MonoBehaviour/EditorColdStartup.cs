using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class EditorColdStartup : MonoBehaviour
{
#if UNITY_EDITOR
    [SerializeField] private GameSceneSO _thisSceneSO = default;
    [SerializeField] private GameSceneSO _persistentManagersSO = default;
    [SerializeField] private AssetReference _notifyColdStartupChannel = default;
    [SerializeField] private GameEventSO _onSceneReadyChannel = default;

    private bool isColdStart = false;
    private void Awake()
    {
        if (!SceneManager.GetSceneByName(_persistentManagersSO.sceneReference.editorAsset.name).isLoaded)
        {
            isColdStart = true;
        }
    }

    private void Start()
    {
        if (isColdStart)
        {
            _persistentManagersSO.sceneReference.LoadSceneAsync(LoadSceneMode.Additive, true).Completed += LoadEventChannel;

        }
    }
    private void LoadEventChannel(AsyncOperationHandle<SceneInstance> obj)
    {
        _notifyColdStartupChannel.LoadAssetAsync<LoadGameEventSO>().Completed += OnNotifyChannelLoaded;
    }

    private void OnNotifyChannelLoaded(AsyncOperationHandle<LoadGameEventSO> obj)
    {
        if (_thisSceneSO != null)
        {
            obj.Result.RaiseEvent(_thisSceneSO);
        }
        else
        {
            //Raise a fake scene ready event, so the player is spawned
            StartCoroutine(DelayedEvent());
            //When this happens, the player won't be able to move between scenes because the SceneLoader has no conception of which scene we are in
        }
    }

    private IEnumerator DelayedEvent()
    {
        yield return new WaitForSeconds(2f);

        _onSceneReadyChannel.RaiseEvent();
    }

#endif
}
