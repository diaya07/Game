using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator theAnimator;
    
    public void Run()
    {
        //SetTrigger: Ʈ���Ÿ� �ߵ���Ŵ.
        theAnimator.SetTrigger("Run");
    }
}
