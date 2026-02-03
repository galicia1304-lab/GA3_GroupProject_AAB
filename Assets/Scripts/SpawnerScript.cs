using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    //designate what object is to be spawned
    public GameObject PotionBrewSpawn;


    public void SpawnBottle()
    {
        Instantiate(PotionBrewSpawn);
    }


}
