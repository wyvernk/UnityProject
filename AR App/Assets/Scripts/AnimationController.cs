using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    //0 for lie, 1 for sit, 2 for stand
    public void SetState(int state)
    {
        this.GetComponent<Animator>().SetInteger("State", state);
    }

}
