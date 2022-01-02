using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoJogador : MonoBehaviour
{
    // Variáveis Acessiveis De Fora Da Classe
    public bool podeSeMover = false;
    public float intensidadeDoImpulso = 6f;
    public float velocidadeMaxima = 5f;
    public Rigidbody rigidBody;

    // Variáveis Acessiveis De Dentro Da Classe 
    private bool deveIrParaFrente;
    private bool deveIrParaTras = false;
    private bool deveIrGirarSentidoAntiHorario = false;
    private bool deveIrGirarSentidoHorario = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Checa Se Os Botões "W" e "S" Foram Apertados
        if(Input.GetKey(KeyCode.W)) {
            this.deveIrParaFrente = true;
        } else if (Input.GetKey(KeyCode.S)) {
            this.deveIrParaTras = true;
        }

        //Checa Se Os Botões "A" e "D" Foram Apertados
        if(Input.GetKey(KeyCode.A)) {
            this.deveIrGirarSentidoAntiHorario = true;
        } else if (Input.GetKey(KeyCode.D)) {
            this.deveIrGirarSentidoHorario = true;
        }
    }

    void FixedUpdate()
    {
        // Se O Botão "W" Tiver Sido Apertado, É Adicionado Uma Força Para Cima
        if (this.deveIrParaFrente) {
            rigidBody.AddRelativeForce(transform.up * this.intensidadeDoImpulso);

            this.deveIrParaFrente = false;

        // Se O Botão "S" Tiver Sido Apertado, É Adicionado Uma Força Para Baixo
        } else if (this.deveIrParaTras) {
            rigidBody.AddRelativeForce((-transform.up) * this.intensidadeDoImpulso);

            this.deveIrParaTras = false;
        }

        // Se O Botão "A" Tiver Sido Apertado, É Adicionado Uma Força De Torque Para O Sentido AntiHorario
        if (this.deveIrGirarSentidoAntiHorario) {
            rigidBody.AddTorque(-transform.forward);

            this.deveIrGirarSentidoAntiHorario = false;

        // Se O Botão "D" Tiver Sido Apertado, É Adicionado Uma Força De Torque Para O Sentido Horario
        } else if (this.deveIrGirarSentidoHorario) {
            rigidBody.AddTorque(transform.forward);

            this.deveIrGirarSentidoHorario = false;
        }

        // Se A Velocidade Atual Do Objeto For Maior Que A Velocidade Máxima Desejada, Retorna o Valor Para Velocidade Máxima
        if (rigidBody.velocity.magnitude > this.velocidadeMaxima) {
            rigidBody.velocity = rigidBody.velocity.normalized * this.velocidadeMaxima;
        }
    }
}
