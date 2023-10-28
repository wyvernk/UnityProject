using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractableObject : MonoBehaviour
{
    [SerializeField]
    private bool useCotton;
    [SerializeField]
    private bool useHammer;
    [SerializeField]
    private bool useHand;

    private bool isInjured = false;

    [SerializeField]
    private TextMeshProUGUI feedbackText;
    [SerializeField]
    private string successText;
    [SerializeField]
    private string injuredText;
    [SerializeField]
    private string failText;

    private bool animationPlaying = false;


    public void ReactToUser()
    {
        switch(MainSceneUIManager.Instance.GetEquippedTool())
        {
            case "Cotton":
                if(useCotton)
                {
                    gameObject.GetComponent<Animator>().Play("CottonRub");
                    animationPlaying = true;
                }
                else
                {
                    MainSceneUIManager.Instance.ShowFeedback(failText);
                }
                break;

            case "Hammer":
                if (useHammer)
                {
                    gameObject.GetComponent<Animator>().Play("HammerJoint");
                    animationPlaying = true;
                }
                else
                {
                    MainSceneUIManager.Instance.ShowFeedback(failText);
                }
                break;

            case "Hand":
                if (useHand)
                {
                    if (isInjured)
                    {
                        MainSceneUIManager.Instance.ShowFeedback(injuredText);
                       
                    }
                    else
                    {
                        MainSceneUIManager.Instance.ShowFeedback(successText);
                    }
                }
                else
                {
                    MainSceneUIManager.Instance.ShowFeedback(failText);
                }
                break;

            default:
                MainSceneUIManager.Instance.ShowFeedback(failText);
                break;

        }

    }

    private void Update()
    {
        if(animationPlaying)
        {
            if (gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                if(isInjured)
                {
                    MainSceneUIManager.Instance.ShowFeedback(injuredText);
                }
                else
                {
                    MainSceneUIManager.Instance.ShowFeedback(successText);
                }
                animationPlaying = false;
            }
        }
        

    }

    public void SetInjured(bool injured)
    {
        isInjured = injured;
    }
}
