using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    [SerializeField]
    private Active_Anchor_Point anchorPointTrigger;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (anchorPointTrigger.isOnTP == true)
        {
            animator.SetTrigger("Activate");
        }
    }
}
