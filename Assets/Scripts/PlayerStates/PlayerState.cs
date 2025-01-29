using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerStates
{
    public abstract class PlayerState
    {
        public Player Player { get; set; }
        public PlayerStateMachine StateMachine { get; set; }
        
        protected InputManager InputManager => InputManager.Instance;

        protected PlayerState(Player player, PlayerStateMachine stateMachine)
        {
            this.Player = player;

            this.StateMachine = stateMachine;
        }
        
        public virtual void Enter()
        {
        }

        public virtual void Exit()
        {
        }

        public virtual void Update()
        {
        }
    }
}