using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aiConttoller : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject[] goalLocations;

    // Start is called before the first frame update
    void Start()
    {
        goalLocations = GameObject.FindGameObjectsWithTag("Goal");
        agent = this.GetComponent<NavMeshAgent>();
        int rand = Random.Range(0, goalLocations.Length);
        agent.SetDestination(goalLocations[rand].transform.position);

    }
    private void Update()
    {
        if (agent.remainingDistance < 1)
        {
            int rand = Random.Range(0, goalLocations.Length);
            agent.SetDestination(goalLocations[rand].transform.position);
        }
    }

}
