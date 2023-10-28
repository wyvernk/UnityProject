using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateButton : MonoBehaviour
{
    [SerializeField]
    private Button[] childButtons;
    [SerializeField]
    float distance = 0.0f;
    [SerializeField]
    float speed = 1.0f;

    public enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }
    public Direction direction;

    private List<Vector2> targetPositions = new List<Vector2>();
    bool expand = false;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < childButtons.Length; i++)
        {
            childButtons[i].gameObject.SetActive(false);
            childButtons[i].gameObject.transform.localPosition = new Vector2(0, 0);
            switch(direction)
            {
                case Direction.UP:
                    targetPositions.Add(new Vector2(0, childButtons[i].gameObject.transform.localPosition.y + distance * (i + 1)));
                    break;

                case Direction.DOWN:
                    targetPositions.Add(new Vector2(0, childButtons[i].gameObject.transform.localPosition.y - distance * (i + 1)));
                    break;

                case Direction.LEFT:
                    targetPositions.Add(new Vector2(childButtons[i].gameObject.transform.localPosition.y - distance * (i + 1), 0));
                    break;

                case Direction.RIGHT:
                    targetPositions.Add(new Vector2(childButtons[i].gameObject.transform.localPosition.y + distance * (i + 1), 0));
                    break;
                default:
                    break;
            }
            
        }
    }

    public void ToggleExpandButtons()
    {
        expand = !expand;
    }

    public void SetExpandButtons(bool expandbutton)
    {
        expand = expandbutton;
    }

    // Update is called once per frame
    void Update()
    {
        if(expand && (childButtons[childButtons.Length-1].gameObject.transform.localPosition.x != targetPositions[targetPositions.Count-1].x || childButtons[childButtons.Length - 1].gameObject.transform.localPosition.y != targetPositions[targetPositions.Count - 1].y)) 
        {
            for (int i = 0; i < childButtons.Length; i++)
            {
                childButtons[i].gameObject.SetActive(true);
                childButtons[i].gameObject.transform.localPosition = Vector2.MoveTowards(childButtons[i].gameObject.transform.localPosition, targetPositions[i], speed * Time.deltaTime);
            }
        }
        else if(!expand && childButtons[0].gameObject.activeSelf)
        {
            for (int i = 0; i < childButtons.Length; i++)
            {
                childButtons[i].gameObject.transform.localPosition = new Vector2(0, 0);
                childButtons[i].gameObject.SetActive(false);
            }
        }
    }
}
