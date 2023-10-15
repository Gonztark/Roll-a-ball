using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EscenaJuego()
    {
        SceneManager.LoadScene("MiniGame");
    }

    public void EscenaControles()
    {
        SceneManager.LoadScene("Controles");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
