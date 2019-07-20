using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    //生成的怪物
    public GameObject monster;
    //目标
    public Transform target;
    public int interval = 5;
    // Use this for initialization
    void Start () {

        StartCoroutine("createmonster");
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator createmonster() {
        while (true) {
        yield return new WaitForSeconds(interval);
         GameObject enemy = Instantiate(monster ,transform.position,
                            Quaternion.identity);
            
            enemy.GetComponent<Move>().target = target;
        }
        
    }
}
