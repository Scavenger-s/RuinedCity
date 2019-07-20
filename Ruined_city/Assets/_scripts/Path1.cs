using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Path1 : MonoBehaviour {
    public Transform target;
    NavMeshAgent nav;
	// Use this for initialization
	void Start () {
        nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        nav.SetDestination(target.position);
	}
}
