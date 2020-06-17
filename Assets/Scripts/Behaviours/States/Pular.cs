using Behaviours.StateMachine;
using UnityEngine;

namespace Behaviours.States
{
    [CreateAssetMenu(fileName = "Pular", menuName = "StateData/Pulo")]
    public class Pular : StateData
    {
        public override void OnEnter(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            jogadorStateMachine.GetController(animator).Pular();
        }

        public override void UpdateAbility(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
        }

        public override void OnExit(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
        }
    }
}