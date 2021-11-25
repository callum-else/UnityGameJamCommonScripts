using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public abstract class InputRecieverBase : MonoBehaviour
{
    public void OnGetInput(CallbackContext context)
    {
        // Input Pre-Processing Here.

        ProcessInput(context);
    }

    protected abstract void ProcessInput(CallbackContext context);
}
