using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject DrawImage(Sprite image, Vector3 position, int order)
    {
        GameObject ob = new GameObject();

        SpriteRenderer sprite = ob.AddComponent<SpriteRenderer>();
        sprite.sprite = image;
        sprite.sortingOrder = order;

        ob.transform.position = position;
        return ob;
    }
}
