using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice : MonoBehaviour
{
    public static bool buton_týklama = false;
    Color white = new Color(1f, 1f, 1f, 1f);
    static Rigidbody rb;
    public static Vector3 diceVelocity;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        diceVelocity = rb.velocity;

        if (Input.GetKeyDown(KeyCode.Space) || buton_týklama==true) {
            fýrlat();
            buton_týklama=false;
        }
    }
    void fýrlat()
    {

        text.new_color = white;
        text.diceNumber = 0;
        float dirX = random_dondurme();
        float dirY = random_dondurme();
        float dirZ = random_dondurme();
        transform.rotation = Quaternion.identity;
        rb.AddForce(transform.up * 350);
        rb.AddTorque(dirX , dirY , dirZ);
    }
    float random_dondurme()
    {
        int x=Random.Range(500, 800);
        int y= Random.Range(0,2);
        if (y == 0) return x;
        else  return -x;
    }
}
