using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject batteryAmmoPrefab;
    public GameObject medPrefab;
    public Terrain terrain;

    [SerializeField] Transform itemsContainer;

    TerrainData terrainData;
    
    // Start is called before the first frame update
    void Start()
    {
        terrainData = terrain.terrainData;
        InvokeRepeating("CreateBattery", 1, 1);
        InvokeRepeating("CreateMedKit", 1, 1);
    }

    void CreateBattery()
    {
        int x = (int)Random.Range(0, terrainData.size.x);
        int z = (int)Random.Range(0, terrainData.size.z);

        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 0.15f;
        GameObject batteryKit = Instantiate(batteryAmmoPrefab, pos, Quaternion.identity);
        batteryKit.transform.SetParent(itemsContainer);
    }

    void CreateMedKit()
    {
        int x = (int)Random.Range(0, terrainData.size.x);
        int z = (int)Random.Range(0, terrainData.size.z);

        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 0.5f;
        GameObject medKit = Instantiate(medPrefab, pos, Quaternion.identity);
        medKit.transform.SetParent(itemsContainer);
    }
}
