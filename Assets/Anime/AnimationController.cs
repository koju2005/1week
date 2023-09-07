using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;
   public static AnimationController instance;

    void Awake()
    {
       
        if (null == instance)
        {
            instance=this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (instance != this) 
                Destroy(this.gameObject);
        }
        animator = GetComponent<Animator>();
        ChangeChar();
    }

   public void ChangeChar()
    {
        int Char = PlayerPrefs.GetInt("Char");
        if (Char == 0)
        {
            RuntimeAnimatorController newController = Resources.Load<RuntimeAnimatorController>("Idle_0");
        animator.runtimeAnimatorController = newController;
        }
       else if (Char == 1)
        {
            RuntimeAnimatorController newController = Resources.Load<RuntimeAnimatorController>("Idle_1");
            animator.runtimeAnimatorController = newController;
        }
    }
}
