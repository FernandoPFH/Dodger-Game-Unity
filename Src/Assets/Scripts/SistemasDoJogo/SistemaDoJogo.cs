using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class SistemaDoJogo : MonoBehaviour
{
    // Variáveis Acessiveis De Fora Da Classe
    public TMP_Text menuDePontuacao;
    public TMP_Text menuDeMelhorPontuacao;

    // Variáveis Acessiveis De Dentro Da Classe 
    private int pontuacao = 0; 
    private int melhorPontuacao = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Pega A Melhor Pontuação Do Jogador
        this.melhorPontuacao = ControleMelhorPontuacao.melhorPontuacao;
    }

    // Update is called once per frame
    void Update()
    {
        // Calcula A Pontuação Atual Do Jogador
        this.pontuacao = (int) Time.timeSinceLevelLoad;
        // Mostra A Pontuação Na Tela
        this.menuDePontuacao.text = this.pontuacao.ToString();

        // Checa Para Mostrar Melhor Pontuação
        if (this.pontuacao < this.melhorPontuacao) {
            this.menuDeMelhorPontuacao.text = this.melhorPontuacao.ToString();
        } else {
            this.menuDeMelhorPontuacao.text = this.pontuacao.ToString();
        }

    }

    // Chamada Para Recomeçar O Jogo
    public void recomarJogo() {
        // Se Pontuação Atual For Maior Que Melhor Pontuação, Atualiza Pontuação
        if (this.pontuacao > this.melhorPontuacao) {
            ControleMelhorPontuacao.melhorPontuacao = this.pontuacao;
        }

        // Reinicia A Cena Do Jogo
        SceneManager.LoadScene("CenaDoJogo",LoadSceneMode.Single);

        // Recomeça O Jogo
        Time.timeScale = 1f;
    }
}