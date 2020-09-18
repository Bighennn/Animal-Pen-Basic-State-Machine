﻿using UnityEngine;

namespace State_Machine
{
    public class ChaseState : State
    {
        private Transform _destination;
        public ChaseState(StateController stateController): base(stateController)
        {

        }
        public override void CheckTransitions()
        {
            if (!StateController.CheckIfInRange())
            {
                StateController.SetState(new PatrolState(StateController));
            }
        }
        public override void Act()
        {
            if (StateController.enemyToChase == null) return;
        
            _destination = StateController.enemyToChase.transform;
            StateController.ai.SetTarget(_destination);
        }
        public override void OnStateEnter()
        {
            StateController.ChangeColor(Color.red);
            StateController.ai.agent.speed = .5f;
        }
    }
}