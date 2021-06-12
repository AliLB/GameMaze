using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetPowerUp : MonoBehaviour
{
    public PlayerAttraction attractionScript;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Magnet PowerUp Collected");
            attractionScript.enabled = true;
            Destroy(gameObject);

        }

    }
}
