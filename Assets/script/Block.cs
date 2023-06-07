using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Block : MonoBehaviour
{
    
    public int _score = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < -15f)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("greet")&& Input.GetKey(KeyCode.A)) 
        {
            Debug.Log("greet");
            _score+=100;
            
            gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("parfect") && Input.GetKey(KeyCode.A))
        {
            Debug.Log("parfect");
            _score += 10000;
           
            gameObject.SetActive(false);
        }
    }
}
