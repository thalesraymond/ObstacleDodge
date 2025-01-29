using UnityEngine;

namespace PlayerStates
{
    public class PlayerMoveState : PlayerState
    {
        public PlayerMoveState(Player player, PlayerStateMachine stateMachine) : base(player, stateMachine)
        {
        }
        
        public override void Enter()
        {
            base.Enter();
        }

        public override void Update()
        {
            base.Update();

            var velocityMultiplier = (this.Player.MovementSpeed * Time.deltaTime);
            
            var inputVectorDirection = new Vector3(this.InputManager.MoveInput.x * velocityMultiplier, 0, this.InputManager.MoveInput.y * velocityMultiplier);
            
            this.Player.Rigidbody.AddForce(inputVectorDirection);
            
            if(!this.InputManager.IsTryingToMove)
                this.StateMachine.ChangeState(this.Player.IdleState);
        }
    }
}