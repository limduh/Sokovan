using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float speed = 10f;
    public Rigidbody PlayerRigidbody;

    public void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
    }
    void Update ()
    {
        //-1 ~ +1
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        float fallSpeed = PlayerRigidbody.velocity.y;

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity = velocity * speed;

        velocity.y = fallSpeed;

        PlayerRigidbody.velocity = velocity;
    }
}
