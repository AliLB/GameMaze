using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool isKeyCollected;

    void Start()
    {
        isKeyCollected = false;
    }
    public void CollectKey()
    {
        isKeyCollected = true;
    }
    public bool IsKeyCollected()
    {
        return isKeyCollected;
    }
}
