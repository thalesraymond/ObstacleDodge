using UnityEngine;

namespace PlayerStates
{
    public class PlayerIdleState : PlayerState
    {
        public PlayerIdleState(Player player, PlayerStateMachine stateMachine) : base(player, stateMachine)
        {
        }
        
        public override void Enter()
        {
            base.Enter();

            this.Player.Rigidbody.AddForce(Vector3.zero);
        }

        public override void Update()
        {
            base.Update();

            if (this.InputManager.IsTryingToMove)
                this.StateMachine.ChangeState(this.Player.MoveState);
        }
    }
}