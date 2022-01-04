using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SistemaDoMenuInicial : MonoBehaviour
{
    // Chamada Para Começar O Jogo
    public void comecarJogo() {

        // Inicia A Melhor Pontuação
        ControleMelhorPontuacao.melhorPontuacao = 0;

        // Inicia A Cena Do Jogo
        SceneManager.LoadScene("CenaDoJogo",LoadSceneMode.Single);
    }
}
