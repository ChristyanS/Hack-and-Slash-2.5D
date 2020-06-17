using Behaviours.Singleton;
using Behaviours.StateMachine;
using Constantes;
using UnityEngine;

namespace Behaviours.States
{
    [CreateAssetMenu(fileName = "Correr", menuName = "StateData/Correr")]
    public class CorrerState : StateData
    {
        public override void OnEnter(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
        }

        public override void UpdateAbility(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            if (!VirtualInputManager.Instance.EstaMovimentando)
                animator.SetBool(JogadorTransitionParameters.EstaCorrendo, false);
            if (VirtualInputManager.Instance.EstaPulando)
                animator.SetBool(JogadorTransitionParameters.EstaPulando, true);

            if (VirtualInputManager.Instance.EstaAtacando)
                animator.SetBool(JogadorTransitionParameters.EstaAtacando, true);
        }

        public override void OnExit(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            animator.SetBool(JogadorTransitionParameters.EstaCorrendo, false);
        }
    }
}