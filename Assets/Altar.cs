using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altar : MonoBehaviour
{
    public GameObject caixaAberta;
    public GameObject caixaFechada;

    public AudioSource chestOpenSfx;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // print(other.name);

        if (other.CompareTag("Caixa")) {
            // Dentro deste bloco, detectamos que
            // a caixa está em cima do altar

            caixaFechada.SetActive(false);
            caixaAberta.SetActive(true);

            chestOpenSfx.Play();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // print(other.name);

        if (other.CompareTag("Caixa")) {
            // Dentro deste bloco, detectamos que
            // a caixa está acabou de sair do altar

            caixaFechada.SetActive(true);
            caixaAberta.SetActive(false);
        }
    }
}
