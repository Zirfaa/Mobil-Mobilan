using UnityEngine;

public class SpawnManagers : MonoBehaviour
{
    [SerializeField]public GameObject bonusPrefab;
    public Transform[] spawnPoints;

    GameObject currentBonus;

    void Start()
    {
        spawnPoints = GetComponentsInChildren<Transform>();
        SpawnBonus();
    }

    public void SpawnBonus()
    {
        int index = Random.Range(1, spawnPoints.Length);

        currentBonus = Instantiate(
            bonusPrefab, spawnPoints[index].position, Quaternion.identity
        );
    }

    public void BonusTaken()
    {
        SpawnBonus();
    }
}
