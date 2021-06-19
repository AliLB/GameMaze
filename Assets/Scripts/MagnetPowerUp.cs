using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetPowerUp : MonoBehaviour
{
    public PlayerAttraction attractionScript;
    [HideInInspector]public AudioSource ad;
    [HideInInspector] public Collider cldr;
    [HideInInspector] public Renderer rend;

    void Start()
    {
        ad = GetComponent<AudioSource>();
        cldr = GetComponent<Collider>();
        rend = GetComponentInChildren<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ad.Play();
            rend.enabled = false;
            cldr.enabled = false;
            Debug.Log("Magnet PowerUp Collected");
            attractionScript.enabled = true;
            Destroy(gameObject,1.3F);

        }

    }
}
