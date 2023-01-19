using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu]
public class InputReader : ScriptableObject, GameInput.IPlayerActions
{
    //Gameplay
    public event UnityAction<Vector2> moveEvent;
    public event UnityAction<Vector2> lookEvent;
    public event UnityAction fireEvent;
    
    private GameInput gameInput;

    private void OnEnable()
    {
        if(gameInput == null)
        {
            gameInput = new GameInput();
            gameInput.Player.SetCallbacks(this);
        }

        EnableGameplayInput();
    }

    private void OnDisable()
    {
        DisableAllInput();
    }

    public void EnableGameplayInput()
    {
        gameInput.Player.Enable();
    }

    public void DisableAllInput()
    {
        gameInput.Player.Disable();
    }


    public void OnFire(InputAction.CallbackContext context)
    {
        if (fireEvent != null && context.phase == InputActionPhase.Performed)
        {
            fireEvent.Invoke();
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (moveEvent != null)
        {
            moveEvent.Invoke(context.ReadValue<Vector2>());
        }
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        if (lookEvent != null)
        {
            lookEvent.Invoke(context.ReadValue<Vector2>());
        }
    }
}
