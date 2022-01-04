using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SpawnDeAsteroides : MonoBehaviour
{
    // Variáveis Acessiveis De Fora Da Classe
    public float porcentagemDeEspacoUsado = 70;
    public int tempoEntreSpawns = 2000;
    public GameObject asteroidePequeno;
    public GameObject asteroideMedio;
    public GameObject asteroideGrande;
    public Material lavaVermelha;
    public Material lavaAzul;

    // Variáveis Acessiveis De Dentro Da Classe 
    private float extremidade;

    // Start is called before the first frame update
    void Start()
    {
        // Calcula As Extremidades No Eixo X
        this.extremidade = this.gameObject.GetComponentInChildren<MeshRenderer>().bounds.center.x + this.gameObject.GetComponentInChildren<MeshRenderer>().bounds.extents.x;
    
        // Começa A Spawner Asteroides
        this.spawnarAsteroides();
    }

    private async void spawnarAsteroides() {

        // Spawna Asteroides Com Um Delay Entre Eles
        while(this != null) {
            var posicaoMax = this.extremidade * this.porcentagemDeEspacoUsado / 100;

            // Checa Se O Jogo Não Está Parado
            if (Time.timeScale > 0f) {
                // Escolhe Um Número Aleatório Entre 0 - 9
                var escolhaDeTamanho = Random.Range(0, 10);

                GameObject prefabEscolhido;

                // Escolhe Qual Asteróide Usar Baseado No Número Escolhido
                if (escolhaDeTamanho <= 4) {
                    prefabEscolhido = asteroidePequeno;
                } else if (escolhaDeTamanho <= 6) {
                    prefabEscolhido = asteroideMedio;
                } else {
                    prefabEscolhido = asteroideGrande;
                }

                // Escolhe Um Número Aleatório Entre 0 - 9
                var escolhaDeCor = Random.Range(0, 10);

                Material materialEscolhido;

                // Escolhe Qual Material Do Asteróide Usar Baseado No Número Escolhido
                if (escolhaDeCor <= 4) {
                    materialEscolhido = lavaVermelha;
                } else {
                    materialEscolhido = lavaAzul;
                }

                // Instanciar O Asteroide
                var asteroide = Instantiate(prefabEscolhido,new Vector3(Random.Range(-posicaoMax,posicaoMax),this.transform.position.y,this.transform.position.z),Quaternion.identity);

                // Colocar O Material No Asteroide
                foreach (MeshRenderer meshRenderer in asteroide.GetComponentsInChildren<MeshRenderer>()){
                    meshRenderer.material = materialEscolhido;
                }
            }
        
            await Task.Delay(this.tempoEntreSpawns);
        }
    }
}
