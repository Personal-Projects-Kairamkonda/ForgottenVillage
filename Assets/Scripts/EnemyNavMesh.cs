using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavMesh : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    [SerializeField]
    private Transform target;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        Debug.Log(navMeshAgent.speed);
        navMeshAgent.speed /= 2.5f;
    }

    
    void Update()
    {
        navMeshAgent.destination = target.position;
    }


}
