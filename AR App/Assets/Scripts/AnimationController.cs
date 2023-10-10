using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public void SetLie(bool lie)
    {
        this.GetComponent<Animator>().SetBool("Lying", lie);
    }
}
