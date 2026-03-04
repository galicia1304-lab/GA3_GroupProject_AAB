using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SpawnerScript : MonoBehaviour
{

    //designate what object(prefab) is to be spawned
    public GameObject PotionBrewSpawn;

    public TMP_Dropdown dropone;
    public TMP_Dropdown droptwo;


    public void SpawnBottle()
    {
        //prefab is spawned
        GameObject newbrew = Instantiate(PotionBrewSpawn);
        newbrew.SetActive(true);

        Transform brewtrans = newbrew.transform;


        PotionInformation potioninfo = brewtrans.GetComponent<PotionInformation>();

        potioninfo.IngridentSelected1 = dropone.value;
        potioninfo.IngridentSelected2 = droptwo.value;

    }


}
