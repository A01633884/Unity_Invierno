using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generador_esfera : MonoBehaviour
{
    public GameObject prefab_esfera;
    public int cantidad;
    public int rangoX;
    public int rangoZ;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(prefabSpawn());
        //Instantiate(prefab_esfera, new Vector3(0, 1, 0), Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator prefabSpawn() {
        for (int i = 0; i < cantidad; i++) {

            float posX = Random.Range(-rangoX / 2, rangoX / 2);
            float posZ = Random.Range(-rangoZ / 2, rangoZ / 2);
            Instantiate(prefab_esfera, new Vector3(posX, 2, posZ), Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }
}
