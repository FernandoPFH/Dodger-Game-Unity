using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SpawnDeAsteroides : MonoBehaviour
{
    // Variáveis Acessiveis De Fora Da Classe
    public float porcentagemDeEspacoUsado = 70;
    public int tempoEntreSpawns = 2000;
    public GameObject asteroide;

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
        while(true) {
            var posicaoMax = this.extremidade * this.porcentagemDeEspacoUsado / 100;
            
            Instantiate(asteroide,new Vector3(Random.Range(-posicaoMax,posicaoMax),this.transform.position.y,this.transform.position.z),Quaternion.identity);
        
            await Task.Delay(this.tempoEntreSpawns);
        }
    }
}
