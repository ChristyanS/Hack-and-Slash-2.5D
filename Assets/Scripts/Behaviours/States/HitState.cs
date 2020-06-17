using Behaviours.StateMachine;
using UnityEngine;

namespace Behaviours.States
{
    [CreateAssetMenu(fileName = "Hit", menuName = "StateData/Hit")]
    public class HitState : StateData
    {
        public override void OnEnter(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            jogadorStateMachine.GetController(animator).estaMachucado = false;
            animator.SetBool("estaMachucado", false);

        }

        public override void UpdateAbility(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
        }

        public override void OnExit(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}