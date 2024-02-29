using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SistemaDoMenuPause : MonoBehaviour
{
    [SerializeField] private GameObject _musicaDeFundo;

    public void VoltarMenuInicial() {
        // Para Musica De Fundo
        Destroy(_musicaDeFundo);

        // Inicia A Cena Do Menu Inicial
        SceneManager.LoadScene("MenuInicial",LoadSceneMode.Single);
    }
}
