using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    private float verticalInput;
    private float horizontalInput;
    private List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();




    }

   
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.back * Time.deltaTime * horizontalInput * turnSpeed);

    }
}
