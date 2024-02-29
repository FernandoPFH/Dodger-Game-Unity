using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlarMenu : MonoBehaviour
{
    public bool pode_se_pausar = true;

    [SerializeField] private GameObject _menuDePause;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Checa Se Pode Pausar
        if (!pode_se_pausar) 
            return;


        // Se O Botão "Escape" É Apertado, Se Sim, Pausa O Jogo E Abre O Menu
        if (Input.GetKeyDown(KeyCode.Escape)) {
            bool pausado = _menuDePause.activeSelf;

            _menuDePause.SetActive(!pausado);
            Time.timeScale = pausado?1:0;
        }
    }
}
