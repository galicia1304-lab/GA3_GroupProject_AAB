using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndingImageScript : MonoBehaviour
{

    public Image ImageEnding; //this is the image that holds the sprites

    public int EndingValueImg = 0;


    //this holds the diffrent images fo display
    public Sprite Ending1;
    public Sprite Ending2;
    public Sprite Ending3;

    //this could maybe be void start instead of update

    private void Start()
    {
        EndingValueImg = ReputationValues.EndingValue;
    }

    void Update()
    {
        if (EndingValueImg == 1)
        {
            ImageEnding.sprite = Ending1;
        }

        else if (EndingValueImg == 2)
        {
            ImageEnding.sprite = Ending2;
        }

        else if (EndingValueImg == 3)
        {
            ImageEnding.sprite = Ending3;
        }
    }

    public void SetEndingImg1()
    {
        EndingValueImg = 1;
    }
    public void SetEndingImg2()
    {
        EndingValueImg = 2;
    }
    public void SetEndingImg3()
    {
        EndingValueImg = 3;
    }
}
