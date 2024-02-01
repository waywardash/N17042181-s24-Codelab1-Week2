using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    public float upSpeed; // fire up speed

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(0, upSpeed, 0); // moving fire upwards
    }

    private void OnMouseDown()
    {
        
        audioSource.Play();
    }

    private void Reset()
    {
        
    }
}
