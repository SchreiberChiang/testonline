using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rd;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.S))
            rd.AddForce(700 * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.W))
            rd.AddForce(-700 * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.A))
            rd.AddForce(0, 0, -700 * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            rd.AddForce(0, 0, 700 * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
            rd.AddForce(0, 1000 * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.name == "CubeWall")
            rd.AddForce(70000 * Time.deltaTime, 0, 0);
    }
}
