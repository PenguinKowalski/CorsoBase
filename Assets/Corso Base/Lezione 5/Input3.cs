using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input3 : MonoBehaviour
{
    public InputActionAsset actions;

    // private field to store move action reference
    private InputAction logAction;

    void Awake()
    {
        // find the "move" action, and keep the reference to it, for use in Update
        logAction = actions.FindActionMap("Default").FindAction("AzioneLog");

        // for the "jump" action, we add a callback method for when it is performed
        logAction.performed += OnLog;
    }

    void Update()
    {
        // our update loop polls the "move" action value each frame
    }

    private void OnLog(InputAction.CallbackContext context)
    {
        // this is the "jump" action callback method
        Debug.Log("premuto spazio INPUT 3");
    }

    void OnEnable()
    {
        actions.FindActionMap("Default").Enable();
    }
    void OnDisable()
    {
        actions.FindActionMap("Default").Disable();
    }
}
