using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public NavMeshAgent agent;

    void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(transform.position);
	}
	
	
	void Update ()
    {
        if (Vector3.Distance(transform.position, agent.destination) < 1)
        {
            Vector3 targetposition = transform.position + new Vector3(Random.Range(-20, 20), 0, Random.Range(-20, 20));
            agent.SetDestination(targetposition);
        }
	}

    
 
}
