using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour {
    //导航
    NavMeshAgent agent;
    //目标
    public Transform target;
    public Transform player;
    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(player.position);

	}
}
