using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruitdestroy : MonoBehaviour {
    public float ydistance = -10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y <= ydistance)
            Destroy(this.gameObject);
	}
}
