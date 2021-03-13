using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTomb : MonoBehaviour
{
    [SerializeField] private GameObject tombPrefab;
    private GameObject _tomb;
    private Vector3 place;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void spawnTomb()
    {
        _tomb = Instantiate(tombPrefab) as GameObject;
       // GameObject enemy = GameObject.Find("Enemy");
    // place = enemy.GetComponent<ReactiveTarget>().getDeathPos();
        _tomb.transform.position = new Vector3(1, 1, 1);
    }
}
