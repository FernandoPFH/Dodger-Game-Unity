using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorteDoJogador : MonoBehaviour
{
    // Variáveis Acessiveis De Fora Da Classe
    public GameObject menuMorteDoJogador;
    public ControlarMenu controlarMenu;
    public GameObject fogoDeExplosao;
    public ParticleSystem fogoEsquerdo;
    public ParticleSystem fogoCentral;
    public ParticleSystem fogoDireito;

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

            // Para Animação Do Fogo Do Jogador
            fogoEsquerdo.Stop(true,ParticleSystemStopBehavior.StopEmittingAndClear);
            fogoCentral.Stop(true,ParticleSystemStopBehavior.StopEmittingAndClear);
            fogoDireito.Stop(true,ParticleSystemStopBehavior.StopEmittingAndClear);

            fogoDeExplosao.GetComponent<AudioSource>().Play();

            // Desaparece Com A Nave 
            foreach (MeshRenderer meshRenderer in this.GetComponentsInChildren<MeshRenderer>())
            {
                meshRenderer.enabled = false;
            }

            // Começa Efeito De Explosão
            foreach (ParticleSystem particleSystem in fogoDeExplosao.GetComponentsInChildren<ParticleSystem>())
            {
                particleSystem.Play();
            }

            // Ativa O Menu De Morte
            menuMorteDoJogador.SetActive(true);

            // Desativa O Menu De Pause
            controlarMenu.pode_se_pausar = false;

            // Para o Jogo
            Time.timeScale = 0f;
        }
    }
}
