using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input2 : MonoBehaviour
{
    public InputAction axeAction;
    public InputAction logAction;

    public Vector2 axeValue;
    public void Awake()
    {
        // assign a callback for the "jump" action.
        logAction.performed += ctx => { OnLog(ctx); };
    }

    public void Update()
    {
        axeValue = axeAction.ReadValue<Vector2>();
    }

    public void OnLog(InputAction.CallbackContext context)
    {
        Debug.Log("premuto spazio INPUT 2");
    }

    // the actions must be enabled and disabled
    // when the GameObject is enabled or disabled

    public void OnEnable()
    {
        axeAction.Enable();
        logAction.Enable();
    }

    public void OnDisable()
    {
        axeAction.Disable();
        logAction.Disable();
    }
}
