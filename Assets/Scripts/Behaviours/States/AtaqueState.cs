using Behaviours.Singleton;
using Behaviours.StateMachine;
using Constantes;
using UnityEngine;

namespace Behaviours.States
{
    [CreateAssetMenu(fileName = "Ataque", menuName = "StateData/Ataque")]
    public class AtaqueState : StateData
    {
        [Header("Combo")] public float comboStartTime;
        public float comboEndTime;

        public override void OnEnter(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            animator.SetBool(JogadorTransitionParameters.EstaAtacando, false);
            jogadorStateMachine.GetController(animator).sword.enabled = true;
        }

        public override void UpdateAbility(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            if (VirtualInputManager.Instance.EstaPulando)
            {
                animator.SetBool(JogadorTransitionParameters.EstaPulando, true);
            }

            if (VirtualInputManager.Instance.EstaAtacando)
            {
                CheckCombo(jogadorStateMachine, animator, stateInfo);
            }
        }

        public override void OnExit(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            if (VirtualInputManager.Instance.EstaAtacando)
            {
                jogadorStateMachine.GetController(animator).sword.enabled = false;
            }
        }

        public void CheckCombo(JogadorStateMachine jogadorStateMachine, Animator animator, AnimatorStateInfo stateInfo)
        {
            if (stateInfo.normalizedTime >= comboStartTime)
            {
                if (stateInfo.normalizedTime <= stateInfo.length)
                {
                    animator.SetBool(JogadorTransitionParameters.EstaAtacando, true);
                }
            }
        }
    }
}