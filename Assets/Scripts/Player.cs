using PlayerStates;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float movementSpeed  = 5f;
    
    public float MovementSpeed => this.movementSpeed;
    
    public PlayerStateMachine StateMachine { get; private set; }

    public PlayerIdleState IdleState { get; private set; }
    
    public PlayerMoveState MoveState { get; private set; }
    
    private void Awake()
    {
        this.StateMachine = new PlayerStateMachine();

        this.IdleState = new PlayerIdleState(this, this.StateMachine);

        this.MoveState = new PlayerMoveState(this, this.StateMachine);
    }
    
    private void Start()
    {
        this.StateMachine.Initialize(this.IdleState);
    }

    // Update is called once per frame
    private void Update()
    {
        this.StateMachine.CurrentState.Update();
    }
}
