using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text _text;
    [SerializeField] Block _block;
    // Start is called before the first frame update
    public void Start()
    {
        Block _blockscore = GetComponent<Block>();
        
    }

    // Update is called once per frame
    public void Update()
    {

        _text.text = _block._score.ToString("00");

    }

}
