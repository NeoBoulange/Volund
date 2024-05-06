using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Magnéto : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    public void ChangeAnimation(bool changing)
    {
        animator.SetBool("playing", changing);
    }
}
