using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chests : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector] public int score;
    [HideInInspector] public AudioSource source;
    [HideInInspector] public Renderer CHrend;
    [HideInInspector] public Renderer COrend;
    [HideInInspector] public Light pointlight;
    [HideInInspector] public Collider CHcldr;
    [HideInInspector] public Collider COcldr;
    public Text ScoreText;
    void Start()
    {
        score = 0;
        source = GetComponent<AudioSource>();
        pointlight = GetComponentInChildren<Light>();
        CHcldr = gameObject.transform.Find("chest_open").GetComponent<MeshCollider>(); 
        COcldr = gameObject.transform.Find("coins").GetComponent<MeshCollider>();
        CHrend = gameObject.transform.Find("chest_open").GetComponent<MeshRenderer>();
        COrend = gameObject.transform.Find("coins").GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        source.Play();
        CHrend.enabled = false;
        CHcldr.enabled = false;
        COrend.enabled = false;
        COcldr.enabled = false;
        Destroy(pointlight);
        Destroy(gameObject, 1F);
        int prevScore = Int32.Parse(ScoreText.text.Split(' ')[1]);
        if (gameObject.name.Equals("Chest (4)"))
            score = prevScore + 10;
        else score = prevScore + 5;
        ScoreText.text = "Score: " + score.ToString();
    }
}
