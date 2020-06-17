using Behaviours.StateMachine;
using UnityEngine;

namespace Behaviours.States
{
    public abstract class StateData : ScriptableObject
    {

        public abstract void OnEnter(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo);

        public abstract void UpdateAbility(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo);

        public abstract void OnExit(JogadorStateMachine jogadorStateMachine, Animator animator,
            AnimatorStateInfo stateInfo);
    }
}