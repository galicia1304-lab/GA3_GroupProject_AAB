using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackLetterScript : MonoBehaviour
{
    public Image LetterImage;

    public Sprite SoldierFeedbackGood;
    public Sprite SoldierFeedbackNeutral;
    public Sprite SoldierFeedbackBad;
    public Sprite ChurchFeedbackGood;
    public Sprite ChurchFeedbackNeutral;
    public Sprite ChurchFeedbackBad;

    public int PageResponse = 0;

    // Update is called once per frame
    void Update()
    {
        if (PageResponse == 0)
        {
            LetterImage.sprite = SoldierFeedbackGood;
        }

        else if (PageResponse == 1)
        {
            LetterImage.sprite = SoldierFeedbackNeutral;
        }

        else if (PageResponse == 2)
        {
            LetterImage.sprite = SoldierFeedbackBad;
        }

        else if (PageResponse == 3)
        {
            LetterImage.sprite = ChurchFeedbackGood;
        }

        else if (PageResponse == 4)
        {
            LetterImage.sprite = ChurchFeedbackNeutral;
        }

        else if (PageResponse == 5)
        {
            LetterImage.sprite = ChurchFeedbackBad;
        }
    }
}
