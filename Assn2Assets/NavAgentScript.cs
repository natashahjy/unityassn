using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class NavAgentScript : MonoBehaviour {
	public Transform target;
	private NavMeshAgent agent;

	void Start () {
		
		agent = GetComponent<NavMeshAgent> ();
		agent.SetDestination(target.position); // if the target is static
	}
	

	void Update () {
		agent.SetDestination(target.position); // if the target can move
		
		//Debug.Log((target.position - agent.transform.position).magnitude); // for debugging
	}
}
