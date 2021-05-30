using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateAutoOpen : MonoBehaviour
{
    public GameObject metalGate;
    public float raiseDistance;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
            openGate();

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
            closeGate();
    }

    private void openGate()
    {
        metalGate.transform.position = metalGate.transform.position + new Vector3(0, raiseDistance, 0);
    }
    private void closeGate()
    {
        metalGate.transform.position = metalGate.transform.position + new Vector3(0, -raiseDistance, 0);
    }
}