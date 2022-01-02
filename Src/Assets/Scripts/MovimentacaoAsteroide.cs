using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoAsteroide : MonoBehaviour
{
    // Variáveis Acessiveis De Fora Da Classe
    public float anguloMaximoDeVariacao = 30;

    // Start is called before the first frame update
    void Start()
    {
        var anguloDeDirecao = Random.Range(-anguloMaximoDeVariacao,anguloMaximoDeVariacao);

        Debug.Log(anguloDeDirecao);

        this.transform.rotation = Quaternion.Euler(new Vector3(0,0,-90 + anguloDeDirecao));

        this.GetComponent<Rigidbody>().AddForce(transform.right * 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
