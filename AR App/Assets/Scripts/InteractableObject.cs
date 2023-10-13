using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractableObject : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI feedbackText;
    [SerializeField]
    private string customText;

    public void ReactToUser()
    {
        MainSceneUIManager.Instance.ShowFeedback(customText);
    }
}
