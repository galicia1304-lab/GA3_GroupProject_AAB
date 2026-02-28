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

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BirdDelivery")
        {
            //set other collider box active

            //set what letter is to be shown
            //PageResponse = 3;

            Debug.Log("letter touched by bird");
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

    public void GoodSoldierFeedback()
    {
        //set pageresponse value
        PageResponse = 0;
    }

    public void BadSoldierFeedback()
    {
        //set pageresponse value
        PageResponse = 1;
    }

    public void GoodChurchFeedback()
    {
        //set pageresponse value
        PageResponse = 2;
    }

    public void BadChurchFeedback()
    {
        //set pageresponse value
        PageResponse = 3;
    }
}
