using UnityEngine;

public class UsePotion : MonoBehaviour
{
    //these are set to true/false on the npc itself so they can recive the potions
    [SerializeField] bool SoldierMissingPotion = true;
    [SerializeField] bool ChruchMissingPotion = true;

    //ingridients can only be 0-2, making it 6 means invalid
    //these values will change based on dialouge player has with the soldier
    int SoldierWantingIngridient1 = 6;
    int SoldierWantingIngridient2 = 6;

    int ChurchWantingIngridient1 = 6;
    int ChurchWantingIngridient2 = 6;

    //this is for what letter the bird delivers based on waht potion the npc got
    public bool SoldierCorrectPotion = false;
    public bool ChurchCorrectPotion = false;

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount > 0)
        {
            Transform potion = transform.GetChild(0);

            PotionInformation info = potion.GetComponent<PotionInformation>();

            Debug.Log("ingredients 1 = " + info.IngridentSelected1 + " and 2 = " + info.IngridentSelected2);
            
            //this check will only work once
            if (SoldierMissingPotion == true)
            {
                SoldierMissingPotion = false;

                if (info.IngridentSelected1 == SoldierWantingIngridient1 & info.IngridentSelected2 == SoldierWantingIngridient2)
                {
                    //increase rep value of soldier in "reputationValues" scipt
                    Debug.Log("soldier rep +");
                    SoldierCorrectPotion = true;
                }

            }

            //this check will only work once
            if (ChruchMissingPotion == true)
            {
                ChruchMissingPotion = false;

                if (info.IngridentSelected1 == ChurchWantingIngridient1 & info.IngridentSelected2 == ChurchWantingIngridient2)
                {
                    //increase rep value of church in "reputationValues" scipt
                    Debug.Log("church rep +");
                    ChurchCorrectPotion = true;
                }

            }

            //regardless of above send the bird to deliver its letter
            Debug.Log("Bird will arrive after delay.");
        }
    }
}
