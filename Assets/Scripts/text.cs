using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{

    Text _text;
    public static int diceNumber;
    public static Color new_color;
    // Use this for initialization
    void Start()
    {
        _text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _text.text = "0";
            _text.color = new_color;
        }
        _text.text = diceNumber.ToString();
        _text.color = new_color;
    }
}
