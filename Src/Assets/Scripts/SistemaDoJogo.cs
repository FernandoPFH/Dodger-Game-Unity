using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SistemaDoJogo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void recomarJogo() {
        // Reinicia A Cena Do Jogo
        SceneManager.LoadScene("CenaDoJogo",LoadSceneMode.Single);

        // Recomeça O Jogo
        Time.timeScale = 1f;
    }
}