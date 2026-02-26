using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackLetterScript : MonoBehaviour
{
    public Image LetterImage;

    public Sprite SoldierFeedbackGood;
    public Sprite SoldierFeedbackBad;
    public Sprite ChurchFeedbackGood;
    public Sprite ChurchFeedbackBad;

    //what feedback letter is to be showed
    [SerializeField] public int PageResponse = 0;

    void OnTriggerStay(Collider PLayerInside)
    {
        if (PLayerInside.tag == "BirdDelivery")
        {
            //become active?

            //set what letter is to be shown
            PageResponse = 0;
        }
    }


    //set sprite of leter based on the potion customer recived
    void Update()
    {
        if (PageResponse == 0)
        {
            LetterImage.sprite = SoldierFeedbackGood;
        }

        else if (PageResponse == 1)
        {
            LetterImage.sprite = SoldierFeedbackBad;
        }

        else if (PageResponse == 2)
        {
            LetterImage.sprite = ChurchFeedbackGood;
        }

        else if (PageResponse == 3)
        {
            LetterImage.sprite = ChurchFeedbackBad;
        }
    }
}
