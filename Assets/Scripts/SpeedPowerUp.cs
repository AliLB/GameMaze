using Invector.vCharacterController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public PlayerController mainCharacterPlayerController;
    [HideInInspector] public AudioSource ad;
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
            Debug.Log("Speed PowerUp Collected");
            mainCharacterPlayerController.freeSpeed.walkSpeed *= 2f;
            mainCharacterPlayerController.freeSpeed.sprintSpeed *= 2f;
            mainCharacterPlayerController.freeSpeed.runningSpeed *= 2f;
            Destroy(gameObject, 1.3F);

        }
        
    }

}
