using Invector.vCharacterController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public PlayerController mainCharacterPlayerController;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Speed PowerUp Collected");
            mainCharacterPlayerController.freeSpeed.walkSpeed *= 2f;
            mainCharacterPlayerController.freeSpeed.sprintSpeed *= 2f;
            mainCharacterPlayerController.freeSpeed.runningSpeed *= 2f;
            Destroy(gameObject);

        }
        
    }

}
