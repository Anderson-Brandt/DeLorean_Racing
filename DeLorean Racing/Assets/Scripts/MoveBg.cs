using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBg : MonoBehaviour
{
    public Renderer rendererBg;

    public float speed;

    private Material materialBg;
    private Vector2 offsetMaterial;


    // Start is called before the first frame update
    void Start()
    {
        materialBg = rendererBg.material;
        offsetMaterial = materialBg.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        offsetMaterial.y += speed * Time.deltaTime;
        materialBg.SetTextureOffset("_MainTex", offsetMaterial);
    }
}
