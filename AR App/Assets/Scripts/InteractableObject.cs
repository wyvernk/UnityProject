using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractableObject : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI screenText;
    [SerializeField]
    private string customText;

    public void ReactToUser()
    {
        screenText.gameObject.SetActive(true);
        screenText.text = customText;
    }
}
