using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {
    public Material cut;
    GameObject tempeffects;
    public int damage = 20;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        /*
        GameObject victim = collision.gameObject;
        Debug.Log(collision.gameObject.name);
        GameObject[] gameObjects = BLINDED_AM_ME.MeshCut.Cut(victim,
                                                             transform.position,
                                                             transform.right,
                                                             cut
                                                             );
        gameObjects[0].AddComponent<Rigidbody>();
        gameObjects[1].AddComponent<BoxCollider>();
        Destroy(gameObjects[1], 5f);
        */
        if (collision.gameObject.tag == "zombie") {
            
            //GetComponent<BoxCollider>().isTrigger = true;
            Zombie z = collision.gameObject.GetComponent<Zombie>();
            z.Hp -= damage;
            tempeffects = z.effects;
            StartCoroutine("starteffects");
        }
        if (collision.gameObject.tag == "Enemy")
        {

            //GetComponent<BoxCollider>().isTrigger = true;
            Enemy z = collision.gameObject.GetComponent<Enemy>();
            z.hp -= damage;
            tempeffects = z.effects;
            StartCoroutine("starteffects");
        }
    }
    /*
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zombie")
        {
            
            GetComponent<BoxCollider>().isTrigger = false;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "zombie")
        {

            GetComponent<BoxCollider>().isTrigger = false;

        }
    }*/
    IEnumerator starteffects() {
        tempeffects.SetActive(true);
        
        yield return new WaitForSeconds(1f);
        
        tempeffects.SetActive(false);

    }
}
