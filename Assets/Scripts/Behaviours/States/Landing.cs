using Behaviours.StateMachine;
using Constantes;
using UnityEngine;

namespace Behaviours.States
{
    [CreateAssetMenu(fileName = "Landing", menuName = "StateData/Landing", order = 0)]
    public class Landing : StateData
    {
        public override void OnEnter(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            animator.SetBool(JogadorTransitionParameters.EstaPulando, false);
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