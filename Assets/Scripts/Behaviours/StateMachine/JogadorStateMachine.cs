using System.Collections.Generic;
using Behaviours.Controller;
using Behaviours.States;
using UnityEngine;

namespace Behaviours.StateMachine
{
    public class JogadorStateMachine : StateMachineBehaviour
    {
        public List<StateData> listAbilityData = new List<StateData>();
        private JogadorController _jogadorController;

        public void UpdateAll(JogadorStateMachine jogadorStateMachine, Animator animator, AnimatorStateInfo stateInfo)
        {
            foreach (var stateData in listAbilityData)
            {
                stateData.UpdateAbility(jogadorStateMachine, animator, stateInfo);
            }
        }

        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            foreach (var stateData in listAbilityData)
            {
                stateData.OnEnter(this, animator, stateInfo);
            }
        }

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            UpdateAll(this, animator, stateInfo);
            base.OnStateUpdate(animator, stateInfo, layerIndex);
        }

        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            foreach (var stateData in listAbilityData)
            {
                stateData.OnExit(this, animator, stateInfo);
            }
        }

        public JogadorController GetController(Animator animator)
        {
            if (_jogadorController == null)
            {
                _jogadorController = animator.GetComponentInParent<JogadorController>();
            }

            return _jogadorController;
        }
    }
}