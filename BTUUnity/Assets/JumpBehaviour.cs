using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBehaviour : StateMachineBehaviour
{

    public  float JumpDuration = 5f;
    private float JumpStartClock;
    private Animator _animations;
    //private Rigidbody2D _shadowBody;
    //public FixedJoint2D j;


    private void Awake()
    {
        _animations  = GameObject.Find("Graphics").GetComponent<Animator>();
        //_shadowBody  = GameObject.Find("Shadow").GetComponent<Rigidbody2D>();
        //j = _shadowBody.GetComponent<FixedJoint2D>(); 
    }

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        JumpStartClock = Time.time;
        //démarrer l'animation 
        _animations.SetTrigger("Jump");
        
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(Time.time > (JumpStartClock + JumpDuration))
        {
            animator.SetTrigger("EndJump");
            //fin de l'animation
            //_shadowBody.constraints = RigidbodyConstraints2D.None;
            //j.enabled = true;
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
