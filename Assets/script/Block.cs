using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Block : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("greet") ||collision.gameObject.CompareTag("parfect") && Input.GetKey(KeyCode.A))
        {
            gameObject.SetActive(false);
        }
       
    }

}
