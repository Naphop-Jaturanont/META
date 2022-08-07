using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Red")
        {
            ScoreManager.instance.AddPoint();
            Destroy(gameObject);
        }

        if (other.tag == "Finish")
        {
            GameManager.instance.EndGame();
        }

    }
}
