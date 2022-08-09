using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    [SerializeField]
    private AudioSource audio;
    [SerializeField]
    private AudioSource audio2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Blue")
        {
            audio.Play();
        }

        if (other.tag == "Red")
        {
            audio2.Play();
        }

    }
}
