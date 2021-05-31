using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    [HideInInspector] public AudioSource source;
    [HideInInspector] public bool key;
    [HideInInspector] public Renderer rend;
    [HideInInspector] public Collider cld;
    [HideInInspector] public Light lights;
    public Text KeyT;
    // Start is called before the first frame update
    void Start()
    {
        key = false;
        lights = GetComponentInChildren<Light>();
        source = GetComponent<AudioSource>();
        rend = GetComponent<SkinnedMeshRenderer>();
        cld = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        key = true;
        KeyT.text = "Key Found";
        source.Play();
        lights.enabled = false;
        rend.enabled = false;
        cld.enabled = false;
        Destroy(gameObject, 1F);
        FindObjectOfType<GameManager>().CollectKey();
    }
}
