using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    void spawnPotion(int angle){
        int radius = 3;
        Vector3 spawnPosition = transform.position;

        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
    void Start()
    {
        LootAngle myLootAngle = new LootAngle(45);
        
        //Potion 1
        spawnPotion(myLootAngle.nextAngle());

        //Potion 2
        spawnPotion(myLootAngle.nextAngle());

        //Potion 3
        spawnPotion(myLootAngle.nextAngle());

        //Potion 4
        spawnPotion(myLootAngle.nextAngle());
        
        
    }
}
public class LootAngle{
    int angle;
    int step;
    public LootAngle(int increment){

        step = increment;
        angle = 0;
    }
    public int nextAngle(){
        int currentAngle = angle;

        angle = Helpers.WrapAngle(angle + step);

        return currentAngle;
    }
}

