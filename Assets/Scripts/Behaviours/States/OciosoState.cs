using Behaviours.Singleton;
using Behaviours.StateMachine;
using Constantes;
using UnityEngine;

namespace Behaviours.States
{
    [CreateAssetMenu(fileName = "Ocioso", menuName = "StateData/Ocioso")]
    public class OciosoState : StateData
    {
        public override void OnEnter(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
        }

        public override void UpdateAbility(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            if (VirtualInputManager.Instance.EstaPulando)
            {
                animator.SetBool(JogadorTransitionParameters.EstaPulando, true);
            }

            if (VirtualInputManager.Instance.EstaMovimentando)
            {
                animator.SetBool(JogadorTransitionParameters.EstaCorrendo, true);
            }

            if (VirtualInputManager.Instance.EstaAtacando)
            {
                animator.SetBool(JogadorTransitionParameters.EstaAtacando, true);
            }
        }

        public override void OnExit(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
        }
    }
}