using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ARInteraction : MonoBehaviour
{
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.GetComponent<InteractableObject>() != null)
                {
                    hit.collider.gameObject.GetComponent<InteractableObject>().ReactToUser();
                }
            }
        }
    }
}
