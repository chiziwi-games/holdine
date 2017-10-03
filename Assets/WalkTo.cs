using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class WalkTo : MonoBehaviour {

    public Transform target;
    private NavMeshAgent agent;
    private Animator m_animator;
    

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        m_animator = GetComponent<Animator>();
        agent.destination = target.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
