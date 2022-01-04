using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class DestruicaoDosAsteroides : MonoBehaviour
{
    // Variáveis Acessiveis De Fora Da Classe
    public int tempoDeVida = 15;

    // Start is called before the first frame update
    void Start()
    {
        // Chama A Função Para Destruir O Asteroide
        this.destruirAsteroide();
    }

    // Destroi O Asteroide Depois De Um Tempo
    private async void destruirAsteroide() {
        // Espera Um Tempo
        await Task.Delay(this.tempoDeVida * 1000);
        // Destroi O Asteroide
        Object.Destroy(this.gameObject);
    }
}