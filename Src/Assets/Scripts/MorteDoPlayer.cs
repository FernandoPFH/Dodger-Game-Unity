using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorteDoPlayer : MonoBehaviour
{
    // Variáveis Acessiveis De Fora Da Classe
    public GameObject menuMorteDoJogador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision objeto) {
        // Checa Se A Tag Do Objeto é "Asteroide"
        if (objeto.gameObject.tag == "Asteroide") {
            // Ativa O Menu De Morte
            menuMorteDoJogador.SetActive(true);

            // Para o Jogo
            Time.timeScale = 0f;
        }
    }
}
