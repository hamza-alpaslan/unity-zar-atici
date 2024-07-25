using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control : MonoBehaviour {

    Vector3 diceVelocity;
    Color green= new Color(0f,0.9f,0f,1f);
    Color white = new Color(1f, 1f, 1f, 1f);
    // Update is called once per frame
    void FixedUpdate () {
		diceVelocity = dice.diceVelocity;
	}

	void OnTriggerStay(Collider col)
	{
            if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
            {
            text.new_color = green; ;

            }
            
     

            switch (col.gameObject.name)
            {
                case "yuz 1":
                    text.diceNumber = 1;
                    break;
                case "yuz 2":
                    text.diceNumber = 2;
                    break;
                case "yuz 3":
                    text.diceNumber = 3;
                    break;
                case "yuz 4":
                    text.diceNumber = 4;
                    break;
                case "yuz 5":
                    text.diceNumber = 5;
                    break;
                case "yuz 6":
                    text.diceNumber = 6;
                    break;
            }
        
	}
    void OnTriggerExit(Collider col)
    {
        text.diceNumber = 0;
        text.new_color = white;
    }
}
