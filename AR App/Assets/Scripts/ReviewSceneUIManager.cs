using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ReviewSceneUIManager : MonoBehaviour
{
    public static ReviewSceneUIManager Instance { get; private set; }
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
    TMP_InputField questionOneAnswer;
    [SerializeField]
    TMP_InputField questionTwoAnswer;
    [SerializeField]
    TMP_InputField questionThreeAnswer;

    [SerializeField]
    TMP_InputField questionOneCorrectAnswer;
    [SerializeField]
    TMP_InputField questionTwoCorrectAnswer;
    [SerializeField]
    TMP_InputField questionThreeCorrectAnswer;

    private void Start()
    {
        questionOneAnswer.text = UserDataManager.Instance.GetQuestionOneAnswer();
        questionTwoAnswer.text = UserDataManager.Instance.GetQuestionTwoAnswer();
        questionThreeAnswer.text = UserDataManager.Instance.GetQuestionThreeAnswer();

        questionOneCorrectAnswer.text = UserDataManager.Instance.GetQuestionOneCorrectAnswer();
        questionTwoCorrectAnswer.text = UserDataManager.Instance.GetQuestionTwoCorrectAnswer();
        questionThreeCorrectAnswer.text = UserDataManager.Instance.GetQuestionThreeCorrectAnswer();
    }

    public void Return()
    {
        SceneManager.LoadScene("MainScene");
    }
}
