using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour {
    //hp
    public int Hp = 100;
    //动画
    Animator animator;
    public GameObject effects;
	// Use this for initialization
	void Start () {
        //获取动画控制器
        animator = GetComponent<Animator>();
        animator.SetBool("Towalk", true);
        effects.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        //血量大于0
        
        if (Hp < 0) {
            animator.SetBool("Todeath", true);
            Destroy(GetComponent<NavMeshAgent>());
            Destroy(gameObject ,2f);
        }
            
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            animator.SetBool("Toattack", true);
            //启用携程
            StartCoroutine("attack");
           
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("Toattack", false);
            
        }
    }
    IEnumerator attack() {
        UImanage.instance.attackpaanel.SetActive(true);
        //等待时间
        yield return new WaitForSeconds(1f);
        UImanage.instance.attackpaanel.SetActive(false);
    }
}
