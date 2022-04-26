
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemySpawnScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject temp = GameManager.instance.GetObjectsFromPool("Enemy");
        if (temp != null)
        {
            Debug.Log("true");
            if (Random.Range(0, 100) < 1f)
            {

                temp.transform.position = temp.transform.position + new Vector3(Random.Range(-48f, 27f), 1f, Random.Range(-14f, -4f));
                temp.SetActive(true);
            }
        }

    }
}

 
    
