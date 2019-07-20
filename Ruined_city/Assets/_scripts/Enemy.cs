using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

    Animation animations;
    //血的特效
    public GameObject effects;
    //
    //血量
    public int hp = 100;
	// Use this for initialization
	void Start () {

        animations = GetComponent<Animation>();
        animations.CrossFade("shamble");
        effects.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        if(hp <0)
        {
            animations.CrossFade("fallToFace");
            //删除NavMeshAgent组件
            Destroy(GetComponent<NavMeshAgent>());
            //死亡后删除物体
            Destroy(gameObject , 2f);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            animations.CrossFade("attack2");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animations.CrossFade("attack2");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animations.CrossFade("shamble");
        }
    }
}
