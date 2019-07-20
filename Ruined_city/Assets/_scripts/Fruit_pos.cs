using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit_pos : MonoBehaviour {
    //水果
    public GameObject[] Fruits;
    public Transform fruitpos;
	// Use this for initialization
	void Start () {
        while (true) {
            StartCoroutine("crateFruit");
        }
	}
  
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator crateFruit() {
        //随机生成一种水果
        GameObject fruit = Instantiate(Fruits[Random.Range(0 , Fruits.Length - 1)],fruitpos) as GameObject;
        Vector3 pos = fruit.transform.position;
        pos.x += Random.Range(-1 ,1);
        fruit.transform.position = pos;
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(0 ,Random.Range(8,10) , 0);
        rigidbody.angularVelocity = new Vector3(0, 1,0);
        yield return new WaitForSeconds(1f);
    }
}
