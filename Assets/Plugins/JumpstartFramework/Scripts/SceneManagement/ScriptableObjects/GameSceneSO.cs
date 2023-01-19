using UnityEngine.AddressableAssets;

public class GameSceneSO : ScriptableGameObject
{
    public GameSceneType sceneType;
    public AssetReference sceneReference;

    public enum GameSceneType
    {
        // Playable Scenes
        Menu,
        Location,

        // Special Scenes
        Intialisation,
        PersistentManagers,
        Gameplay,

        // Unplayable Scenes
        DEV,
        Art
    }
}