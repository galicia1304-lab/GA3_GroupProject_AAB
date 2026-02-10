using UnityEngine;

public class PotionInformation : MonoBehaviour
{
    //this script is only to hold information for the potion
    public int IngridentSelected1 = 1;
    public int IngridentSelected2 = 1;


    void Start()
    {
        //when object is spawned in say in logs what its numbers are
        Debug.Log("Ingridient numbers are: " + IngridentSelected1 + IngridentSelected2);   
    }

}
