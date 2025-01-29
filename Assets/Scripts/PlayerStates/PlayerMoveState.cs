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

            this.Player.transform.Translate(new Vector3(this.InputManager.MoveInput.x, 0, this.InputManager.MoveInput.y) * (this.Player.MovementSpeed * Time.deltaTime));
            
            if(!this.InputManager.IsTryingToMove)
                this.StateMachine.ChangeState(this.Player.IdleState);
        }
    }
}