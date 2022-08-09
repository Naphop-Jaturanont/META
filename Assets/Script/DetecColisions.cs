using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecColisions : MonoBehaviour
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
        if (other.tag == "Block")
        {
            ScoreManager.instance.AddPoint();
            Debug.Log("ADD Point");
            Destroy(gameObject);
        }

        if (other.tag == "Finish")
        {
            Destroy(gameObject);
            Debug.Log("Destroy object");
        }

    }
}
