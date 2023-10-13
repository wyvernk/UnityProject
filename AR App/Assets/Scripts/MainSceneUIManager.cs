using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneUIManager : MonoBehaviour
{
    public static MainSceneUIManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    [SerializeField]
    private float feebackDisplayTime;
    [SerializeField]
    private string patientCondition;

    [SerializeField]
    TextMeshProUGUI equippedTool;
    [SerializeField]
    TextMeshProUGUI feedback;
    [SerializeField]
    TextMeshProUGUI notepadCondition;
    [SerializeField]
    TMP_InputField notepadNotes;
    [SerializeField]
    TextMeshProUGUI reviewNotepadNotes;
    [SerializeField]
    TMP_InputField questionOneAnswer;
    [SerializeField]
    TMP_InputField questionTwoAnswer;
    [SerializeField]
    TMP_InputField questionThreeAnswer;

    private float feebackDisplayTimer;


    // Start is called before the first frame update
    void Start()
    {
        notepadCondition.text = patientCondition;
    }

    public void ShowPatientCondition()
    {
        ShowFeedback(patientCondition);
    }

    public void UpdateReviewNotes()
    {
        reviewNotepadNotes.text = notepadNotes.text;
    }

    public void ShowFeedback(string text)
    {
        feedback.text = text;
        feebackDisplayTimer = feebackDisplayTime;
        feedback.gameObject.SetActive(true);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToReviewScreen()
    {
        UserDataManager.Instance.SetQuestionOneAnswer(questionOneAnswer.text);
        UserDataManager.Instance.SetQuestionTwoAnswer(questionTwoAnswer.text);
        UserDataManager.Instance.SetQuestionThreeAnswer(questionThreeAnswer.text);
        SceneManager.LoadScene("ReviewScene");
    }

    private void Update()
    {
        if(feedback.gameObject.activeSelf)
        {
            feebackDisplayTimer -= Time.deltaTime;

            if (feebackDisplayTimer <= 0)
            {
                feedback.gameObject.SetActive(false);
            }
        }

    }

    public string GetEquippedTool()
    {
        return equippedTool.text;
    }
}
