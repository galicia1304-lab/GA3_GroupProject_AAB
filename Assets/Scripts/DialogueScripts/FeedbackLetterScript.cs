using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackLetterScript : MonoBehaviour
{
    //the feedback letter
    public Image LetterImage;

    //sprites for the image
    public Sprite SoldierFeedbackGood;
    public Sprite SoldierFeedbackBad;


    //refrence to script
    [Header("script refrence")]
    public UsePotion SoldierPotionOutcome;


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


    //set sprite of letter based on the potion customer recived
    void Update()
    {
        //if soldier got correct potion change image to good outcome
        if (SoldierPotionOutcome.SoldierCorrectPotion == true)
        {
            LetterImage.sprite = SoldierFeedbackGood;
        }

        //otherwise display bad outcome
        else
        {
            LetterImage.sprite = SoldierFeedbackBad;
        }
    }



}
