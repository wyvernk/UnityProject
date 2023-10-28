using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour
{
    public int scenario;

    [SerializeField]
    private InteractableObject[] NumbHandsAffectedParts;
    [SerializeField]
    private string NumbHandsCondition;
    [SerializeField]
    private string NumbHandsCorrectAnswer1;
    [SerializeField]
    private string NumbHandsCorrectAnswer2;
    [SerializeField]
    private string NumbHandsCorrectAnswer3;

    [SerializeField]
    private InteractableObject[] NervePainAffectedParts;
    [SerializeField]
    private string NervePainCondition;
    [SerializeField]
    private string NervePainCorrectAnswer1;
    [SerializeField]
    private string NervePainCorrectAnswer2;
    [SerializeField]
    private string NervePainCorrectAnswer3;

    [SerializeField]
    private InteractableObject[] ArmWeaknessAffectedParts;
    [SerializeField]
    private string ArmWeaknessCondition;
    [SerializeField]
    private string ArmWeaknessCorrectAnswer1;
    [SerializeField]
    private string ArmWeaknessCorrectAnswer2;
    [SerializeField]
    private string ArmWeaknessCorrectAnswer3;


    private void Awake()
    {
        scenario = Random.Range(1, 4);
    }
    // Start is called before the first frame update
    void Start()
    {   
        switch (scenario)
        {
            case 1:
                for (int i = 0; i < NumbHandsAffectedParts.Length; i++)
                {
                    NumbHandsAffectedParts[i].SetInjured(true);
                }
                UserDataManager.Instance.SetQuestionOneCorrectAnswer(NumbHandsCorrectAnswer1);
                UserDataManager.Instance.SetQuestionTwoCorrectAnswer(NumbHandsCorrectAnswer2);
                UserDataManager.Instance.SetQuestionThreeCorrectAnswer(NumbHandsCorrectAnswer3);
                break;

            case 2:
                for (int i = 0; i < NervePainAffectedParts.Length; i++)
                {
                    NervePainAffectedParts[i].SetInjured(true);
                    UserDataManager.Instance.SetQuestionOneCorrectAnswer(NervePainCorrectAnswer1);
                    UserDataManager.Instance.SetQuestionTwoCorrectAnswer(NervePainCorrectAnswer2);
                    UserDataManager.Instance.SetQuestionThreeCorrectAnswer(NervePainCorrectAnswer3);
                }
                break;

            case 3:
                for (int i = 0; i < ArmWeaknessAffectedParts.Length; i++)
                {
                    ArmWeaknessAffectedParts[i].SetInjured(true);
                    UserDataManager.Instance.SetQuestionOneCorrectAnswer(ArmWeaknessCorrectAnswer1);
                    UserDataManager.Instance.SetQuestionTwoCorrectAnswer(ArmWeaknessCorrectAnswer2);
                    UserDataManager.Instance.SetQuestionThreeCorrectAnswer(ArmWeaknessCorrectAnswer3);
                }
                break;

            default:
                break;

        }

        
    }

    public string GetCondition()
    {
        switch(scenario)
        {
            case 1:
                return NumbHandsCondition;

            case 2:
                return NervePainCondition;
               
            case 3:
                return ArmWeaknessCondition;
              
            default:
                return "I guess I'm fine";
               
        }
           
    }
}
