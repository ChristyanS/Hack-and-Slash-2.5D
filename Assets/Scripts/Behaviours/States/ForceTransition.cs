using System;
using Behaviours.StateMachine;
using UnityEngine;

namespace Behaviours.States
{
    [CreateAssetMenu(fileName = "ForceTransition", menuName = "StateData/ForceTransition")]
    public class ForceTransition : StateData
    {
        [Range(0.01f, 1f)] public float transitionTime;

        public override void OnEnter(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
        }

        public override void UpdateAbility(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            if (stateInfo.normalizedTime >= transitionTime)
            {
                animator.SetBool("forceTransition", true);
            }
        }

        public override void OnExit(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            animator.SetBool("forceTransition", false);
        }
    }
}