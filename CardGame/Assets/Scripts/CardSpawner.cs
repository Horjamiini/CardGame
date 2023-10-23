using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;

public class CardSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    public SpawnManagerScriptableObject spawnerManagerValues;

    private int instanceNumber = 1;

    public CardInfo m_CardInfo;


    // Start is called before the first frame update
    void Start()
    {
        SpawnEntities();
    }

    private void SpawnEntities()
    {
        int currentSpawnPointIndex = 0;

        for (int i = 0; i < spawnerManagerValues.numberOfPrefabsToCreate; i++)
        {
            GameObject currentObject = Instantiate(objectToSpawn, spawnerManagerValues.spawnPoints[currentSpawnPointIndex], Quaternion.identity);

            currentObject.name = spawnerManagerValues.prefabName + instanceNumber;


            currentSpawnPointIndex = (currentSpawnPointIndex + 1) % spawnerManagerValues.spawnPoints.Length;

            instanceNumber++;
        }
    }

    private void GetScriptableObjects()
    {
        CardInfo attackCard = AssetDatabase.LoadAssetAtPath<CardInfo>("Assets/AttackCard.asset");
        
    }


}
