using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDataManager : MonoBehaviour
{
    public static UserDataManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private string questionOneAnswer;
    private string questionTwoAnswer;
    private string questionThreeAnswer;

    private string questionOneCorrectAnswer;
    private string questionTwoCorrectAnswer;
    private string questionThreeCorrectAnswer;

    public void SetQuestionOneAnswer(string answer)
    {
        questionOneAnswer = answer;
    }

    public void SetQuestionTwoAnswer(string answer)
    {
        questionTwoAnswer = answer;
    }

    public void SetQuestionThreeAnswer(string answer)
    {
        questionThreeAnswer = answer;
    }

    public void SetQuestionOneCorrectAnswer(string answer)
    {
        questionOneCorrectAnswer = answer;
    }

    public void SetQuestionTwoCorrectAnswer(string answer)
    {
        questionTwoCorrectAnswer = answer;
    }

    public void SetQuestionThreeCorrectAnswer(string answer)
    {
        questionThreeCorrectAnswer = answer;
    }

    public string GetQuestionOneAnswer()
    {
        return questionOneAnswer;
    }

    public string GetQuestionTwoAnswer()
    {
        return questionTwoAnswer;
    }

    public string GetQuestionThreeAnswer()
    {
        return questionThreeAnswer;
    }

    public string GetQuestionOneCorrectAnswer()
    {
        return questionOneCorrectAnswer;
    }

    public string GetQuestionTwoCorrectAnswer()
    {
        return questionTwoCorrectAnswer;
    }

    public string GetQuestionThreeCorrectAnswer()
    {
        return questionThreeCorrectAnswer;
    }
}
