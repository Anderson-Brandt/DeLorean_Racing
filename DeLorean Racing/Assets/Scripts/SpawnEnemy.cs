using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public List<GameObject> EnemyList = new List<GameObject>();

    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 1f)
        {
            object p = Instantiate(EnemyList[Random.Range(0, EnemyList.Count)], new Vector3(Random.Range(-2.89f, 2.89f), transform.position.y, transform.position.z), Quaternion.Euler(0, 0, -180f));
            timer = 0f;
        }
    }
}
