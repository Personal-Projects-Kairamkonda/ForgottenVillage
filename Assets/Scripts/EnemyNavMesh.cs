using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavMesh : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Animator getAnimator;

    [SerializeField]
    private Transform target;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.speed /= 2.5f;

        /*
        getAnimator.applyRootMotion = true;
        navMeshAgent.updatePosition = false;
        navMeshAgent.updateRotation = true;
        */
    }

    private void OnAnimatorMove()
    {
        Vector3 rootPosition = getAnimator.rootPosition;
        rootPosition.y = navMeshAgent.nextPosition.y;
        transform.position = rootPosition;
        transform.rotation = getAnimator.rootRotation;
        navMeshAgent.nextPosition = rootPosition;
    }

    void Update()
    {
        MoveAgent();
    }

    void MoveAgent()
    {
        navMeshAgent.destination = target.position;
    }

    void PlayIdleAnimation()
    {
        getAnimator.Play("Mutant Idle");
    }

    void PlayWalkAnimation()
    {
        getAnimator.Play("Mutant Walking");
    }
}
