using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageNavigation : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pages;

    [SerializeField]
    private Button backButton;

    [SerializeField]
    private Button nextButton;

    [SerializeField]
    private Button doneButton;

    private int index;

    void Start()
    {
        index = 0;
        backButton.gameObject.SetActive(false);
        nextButton.gameObject.SetActive(true);

        if(doneButton != null)
        {
            doneButton.gameObject.SetActive(false);
        }
        

        for (int i = 0; i < pages.Length; i++)
        {
            if(i == 0)
            {
                pages[i].gameObject.SetActive(true);
            }
            
            else
            {
                pages[i].gameObject.SetActive(false);
            }
        }
    }

    public void NextPage()
    {
        index++;
        for (int i = 0; i < pages.Length; i++)
        {
            if (i == index)
            {
                pages[i].gameObject.SetActive(true);
            }

            else
            {
                pages[i].gameObject.SetActive(false);
            }
        }

        backButton.gameObject.SetActive(true);

        if (index == pages.Length - 1)
        {
            if (doneButton != null)
            {
                doneButton.gameObject.SetActive(true);
            }
            nextButton.gameObject.SetActive(false);
        }
    }

    public void Previouspage()
    {
        index--;
        for (int i = 0; i < pages.Length; i++)
        {
            if (i == index)
            {
                pages[i].gameObject.SetActive(true);
            }

            else
            {
                pages[i].gameObject.SetActive(false);
            }
        }

        nextButton.gameObject.SetActive(true);

        if (doneButton != null)
        {
            doneButton.gameObject.SetActive(false);
        }

        if (index == 0)
        {
            backButton.gameObject.SetActive(false);
        }
    }

}
