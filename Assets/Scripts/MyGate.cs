using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGate : MonoBehaviour
{
    public GameObject door;
    [HideInInspector]public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && FindObjectOfType<GameManager>().IsKeyCollected()==true)
            openGate();

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && FindObjectOfType<GameManager>().IsKeyCollected() == true)
            closeGate();
    }

    private void openGate()
    {
        anim = door.GetComponent<Animator>();
        anim.SetBool("Open", true);
        anim.SetBool("Close", false);
    }

    private void closeGate()
    {
        anim = door.GetComponent<Animator>();
        anim.SetBool("Close", true);
        anim.SetBool("Open", false);
    }
}