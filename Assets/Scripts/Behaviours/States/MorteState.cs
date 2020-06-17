using Behaviours.StateMachine;
using UnityEngine;

namespace Behaviours.States
{
    [CreateAssetMenu(fileName = "Morte", menuName = "StateData/Morte")]
    public class MorteState : StateData
    {
        public override void OnEnter(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
        }

        public override void UpdateAbility(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            if (jogadorStateMachine.GetController(animator).estaMachucado)
            {
                animator.SetBool("estaMachucado", true);
            }
        }

        public override void OnExit(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}