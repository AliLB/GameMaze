using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector] public int score;
    [HideInInspector] public AudioSource source;
    [HideInInspector] public Renderer rend;
    [HideInInspector] public Light pointlight;
    [HideInInspector] public Collider cldr;
    public Text ScoreText;
    void Start()
    {
        score = 0;
        source = GetComponent<AudioSource>();
        cldr = GetComponent<Collider>();
        rend = GetComponent<MeshRenderer>();
        pointlight = GetComponentInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        source.Play();
        rend.enabled = false;
        cldr.enabled=false;
        Destroy(pointlight);
        Destroy(gameObject, 1F);
        int prevScore = Int32.Parse(ScoreText.text.Split(' ')[1]);
        score = prevScore + 1;
        ScoreText.text = "Score: " + score.ToString();
    }
}
