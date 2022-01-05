using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedimensionarArea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Acha A Largura Vista Pela Camera
        var largura = Camera.main.orthographicSize * 2.0 * Screen.width / Screen.height;

        // Muda O Tamanho Do Spawner
        this.transform.localScale = new Vector3((float) largura ,this.transform.localScale.y ,this.transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        var largura = Camera.main.orthographicSize * 2.0 * Screen.width / Screen.height;

        // Muda O Tamanho Do Spawner
        this.transform.localScale = new Vector3((float) largura ,this.transform.localScale.y ,this.transform.localScale.z);
    }
}
