using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaGameOver : MonoBehaviour {

    public float delay = 5f; 

    void Start()
    {
        Invoke("LoadMenuScene", delay);
    }

    void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
