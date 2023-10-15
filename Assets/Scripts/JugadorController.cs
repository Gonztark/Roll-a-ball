using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class JugadorController : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    private int count;
    private float lvltime;

    private AudioSource audioSource;


    public Text TextoContador;
    public Text TextoGanar;
    public Text TextoTimer;


    public float delay = 3f; // delay de 3 segundos para cambiar la escena





    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        count = 0;
        lvltime = 60f;
        SetCountText();
        TextoGanar.text = "";


        
    }



    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        
    }

    void Update()
    {
        lvltime = lvltime - Time.deltaTime;
        TextoTimer.text = "Tiempo restante: " + Mathf.FloorToInt(lvltime).ToString();

        if (lvltime <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            audioSource.Play();
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        
    }

    void SetCountText()
    {
        TextoContador.text = "Contador: " + count.ToString();
        if (count >= 12)
        {
            


            if (SceneManager.GetActiveScene().name == "Nivel2")
            {
                SceneManager.LoadScene("Ganaste");
            }
            else
            {
                TextoGanar.text = "¡Ganaste!";
                Invoke("LoadNextLevel", delay);
            }
        }
    }


    void LoadNextLevel()
    {
        SceneManager.LoadScene("Nivel2");
    }
 
}
