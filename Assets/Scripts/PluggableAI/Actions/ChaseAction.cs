using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Chase")]
public class ChaseAction : Action
{

    public override void Act(StateController controller)
    {
		Chase(controller);
    }

	private bool Chase(StateController controller)
	{
		controller.navMeshAgent.destination = controller.chaseTarget.position;
		controller.navMeshAgent.isStopped = false;
		return controller.CheckIfCountDownElapsed(controller.enemyStats.chaseTime);
	}

}