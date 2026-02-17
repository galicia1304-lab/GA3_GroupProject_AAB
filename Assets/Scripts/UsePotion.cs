using UnityEngine;

public class UsePotion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount > 0)
        {
            Transform potion = transform.GetChild(0);

            PotionInformation info = potion.GetComponent<PotionInformation>();

            Debug.Log("ingredients 1 = " + info.IngridentSelected1 + " and 2 = " + info.IngridentSelected2);

            if (info.IngridentSelected1 == 3 & info.IngridentSelected2 == 1)
            {
                return;
            }
        
        
        }
    }
}
