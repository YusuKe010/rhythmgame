using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text _text;
    [SerializeField] Text _conbo;
    public int _score = 0;
    int conbo = 0;
    // Start is called before the first frame update
    public void Start()
    {
       
    }

    // Update is called once per frame
    public void Update()
    {
        
        _text.text = _score.ToString("00");
        _conbo.text = conbo.ToString("0");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("block") && Input.GetKey(KeyCode.A))
        {
           
            _score += 100;
            conbo += 1;

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        conbo = 0;
        Destroy(collision.gameObject);
    }
}
