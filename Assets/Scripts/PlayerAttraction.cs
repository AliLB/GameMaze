using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttraction : MonoBehaviour
{
    public GameObject MainCharacter;
    public float attractionspeed=2f;
    void Start()
    {
        
    }

    private void Update()
    {
        this.transform.position = MainCharacter.transform.position+(new Vector3(0,2,0));
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Collectable")
        {
            RaycastHit hit;
            if (Physics.Linecast(MainCharacter.transform.position + (new Vector3(0, 1, 0)), other.transform.position , out hit))
            {
                Debug.Log("Hit :"+hit.transform.tag);
                if(hit.transform.tag=="Collectable")
                    other.gameObject.transform.position = Vector3.MoveTowards(other.gameObject.transform.position, MainCharacter.transform.position + (new Vector3(0, 1, 0)), attractionspeed * Time.deltaTime);
            }
        }

    }

}
