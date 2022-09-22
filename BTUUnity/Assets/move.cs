using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public Vector2  direction;
    public float speed;
    public Rigidbody2D _rgbd;
    private bool Jumping;

    // Start is called before the first frame update
    void Start()
    {
        Jumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Jumping)
        {
            //la direction ne change pas ?
            direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        else
        {
            direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }


        
    }

    private void FixedUpdate()
    {
        if (Jumping)
        {
            //on a l"influence du saut
           // _rgbd.transform.Translate(new Vector2(direction.x*speed, transform.position.y));
        }
        else
        {
            _rgbd.velocity = direction * speed;
        }
        
    }
}
