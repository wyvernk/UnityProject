using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private float Speed;
    private bool rotateRight;
    private bool rotateLeft;

    public void RotateRight()
    {
        rotateRight = true;
        rotateLeft = false;
    }

    public void RotateLeft()
    {
        rotateRight = false;
        rotateLeft = true;
    }

    public void StopRotate()
    {
        rotateRight = false;
        rotateLeft = false;
    }


    private void Update()
    {
        if (rotateRight)
        {
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, this.transform.eulerAngles.y - (Speed * Time.deltaTime), this.transform.eulerAngles.z);
        }

        else if (rotateLeft)
        {
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, this.transform.eulerAngles.y + (Speed * Time.deltaTime), this.transform.eulerAngles.z);
        }
    }
}
