using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager: MonoBehaviour
{ 
    public static InputManager Instance { get; private set; }
    
    public InputAction PlayerMovementAction { get; private set; }
    
    public Vector2 MoveInput { get; private set; }
    
    public bool IsTryingToMove { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance.gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        this.PlayerMovementAction = InputSystem.actions.FindAction("Move");
    }

    private void Update()
    {
        this.MoveInput = this.PlayerMovementAction.ReadValue<Vector2>();
        
        this.IsTryingToMove = this.MoveInput.x != 0 || this.MoveInput.y != 0;
    }
}