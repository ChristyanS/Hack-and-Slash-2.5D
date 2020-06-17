using Behaviours.StateMachine;
using UnityEngine;

namespace Behaviours.States
{
    [CreateAssetMenu(fileName = "Grounded", menuName = "StateData/Grounded")]
    public class DetectaChao : StateData
    {
        public override void OnEnter(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
        }

        public override void UpdateAbility(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
            if (Physics.Raycast(jogadorStateMachine.GetController(animator).chao.transform.position,
                Vector3.down * 0.7f,
                LayerMask.GetMask("Ground")))
                animator.SetBool("chao", true);
            else
                animator.SetBool("chao", false);
        }

        public override void OnExit(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo)
        {
        }
    }
}