using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += new Vector3(0, -0.2f, 0);
        if(transform.position.y <= -6.46f)
        {
            Destroy(gameObject);
            GameController.instance.UpdateScoreText();
        }
        
    }
}
