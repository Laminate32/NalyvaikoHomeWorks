using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowDestination : MonoBehaviour
{
    [SerializeField] private NavMeshAgent NavMeshAgentObject;
    public Transform Destination;
    void Awake()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgentObject.SetDestination(Destination.transform.position);
    }
}
