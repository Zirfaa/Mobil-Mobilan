using UnityEngine;

public class SpawnManagers : MonoBehaviour
{
    [SerializeField]private GameObject bonusPrefab;
    private Transform[] spawnPoints;

    GameObject currentBonus;

    void Start()
    {
        spawnPoints = GetComponentsInChildren<Transform>();
        SpawnBonus();
    }

    private void SpawnBonus()
    {
        int index = Random.Range(1, spawnPoints.Length);

        currentBonus = Instantiate(bonusPrefab, spawnPoints[index].position, Quaternion.identity
        );
    }

    public void BonusTaken()
    {
        SpawnBonus();
    }
}
