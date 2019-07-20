using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanage : MonoBehaviour {
    public GameObject attackpaanel;
    public static UImanage instance;
	// Use this for initialization
	void Start () {
        instance = this;
        attackpaanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onClickButton() {
        SceneManager.LoadScene(1);
    }
}
