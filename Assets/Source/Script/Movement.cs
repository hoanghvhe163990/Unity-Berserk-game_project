using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float force;
    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.D))
        //{
        //    rigidbody2D.AddForce(Vector2.right * force);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    rigidbody2D.AddForce(Vector2.left * force);
        //}
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    rigidbody2D.velocity = Vector2.up * 10;
        //}
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        rigidbody2D.MovePosition(rigidbody2D.position + movement.normalized * 20 * Time.fixedDeltaTime);

    }
}
