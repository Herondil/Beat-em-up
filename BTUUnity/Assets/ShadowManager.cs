using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowManager : MonoBehaviour
{
    public FixedJoint2D j;
    public Rigidbody2D rgbd;
    public Animator _anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //si on jump !
        if (_anim.GetCurrentAnimatorStateInfo(0).IsName("Jump"))
        {
            //couper le Fixed joint  à cause de la collision ?
            j.enabled = false;
            rgbd.constraints = RigidbodyConstraints2D.FreezePositionY;
        }

        
    }
}
