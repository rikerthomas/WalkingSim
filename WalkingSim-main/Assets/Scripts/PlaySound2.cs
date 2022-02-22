using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound2 : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("audio1"))
        {
            audioSource.Play();
        }

    }
}
