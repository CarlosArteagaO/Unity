using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public static int coinCount = 0;

    private void Start()
    {
        coin.coinCount = coin.coinCount +1;
        Debug.Log("Empieza el juego" + coin.coinCount + "monedas");
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player") == true)
        {

        }

        coin.coinCount--;
        Debug.Log("recogida de moneda" + coin.coinCount + "monedas");

        if(coin.coinCount ==0)
        {
            Debug.Log("Se han acabado las monedas");
        }

        Destroy (gameObject);
    }
}
