using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    // Use this for initialization
    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }

}
