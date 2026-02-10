using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    //designate what object(prefab) is to be spawned
    public GameObject PotionBrewSpawn;


    public void SpawnBottle()
    {
        //prefab is spawned
        Instantiate(PotionBrewSpawn);
    }


}
