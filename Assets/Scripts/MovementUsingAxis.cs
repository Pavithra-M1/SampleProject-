using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUsingAxis : MonoBehaviour
{
    public float speed = 5f;
    public GameObject cube;
    public GameObject sphere;

    private Rigidbody rb;
  

    // Start is called before the first frame update
    void Start()
    {
        rb = sphere.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementUsingKeyInputs();
        //using Input functions 
      /**  float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontalMovement, 0, verticalMovement);

        transform.Translate(move * speed * Time.deltaTime);

        Debug.Log("x: " + horizontalMovement + "z: " + verticalMovement);

        //Move forward without inputs
        transform.Translate(Vector3.forward * speed * Time.deltaTime);**/
    }

    void MovementUsingKeyInputs()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
