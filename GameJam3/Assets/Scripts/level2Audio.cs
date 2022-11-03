using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2Audio : MonoBehaviour
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
        audioSource.PlayOneShot(clip);
    }
}
