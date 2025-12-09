using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject playerPrefab;
    
    void Start()
    {
        Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }
}
