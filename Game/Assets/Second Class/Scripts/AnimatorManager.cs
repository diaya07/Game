using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator theAnimator;
    
    public void Run()
    {
        //SetTrigger: 트리거를 발동시킴.
        theAnimator.SetTrigger("Run");
    }
}
