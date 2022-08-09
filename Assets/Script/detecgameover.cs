using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detecgameover : MonoBehaviour
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
        if (other.tag == "Finish")
        {
            Destroy(gameObject);
            Debug.Log("Destroy object");
        }

        if (other.tag == "Block")
        {
            Destroy(gameObject);
            GameManager.instance.EndGameNodelay();
        }

    }
}
