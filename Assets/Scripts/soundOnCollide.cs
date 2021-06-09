using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollide : MonoBehaviour
{
    public AudioSource source;
    int beg = 0;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        beg = 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (beg==1 && collision.gameObject.tag.Equals("MainGround"))
        {
            source.Play();
        }
    }
}
