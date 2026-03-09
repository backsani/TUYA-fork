using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StonePillarDirection
{
    None,
    Up,
    Down,
}

[System.Serializable]
public struct NodeStonePillar
{
    public int index;
}

[System.Serializable]
public struct StonePillar
{
    public Vector3 position;
    public Vector3 windMillPosition;
    public StonePillarDirection moveDirection;
    public int maxHight;

    public List<NodeStonePillar> connection;
}

public class StonePillarManager : BasicObject
{
    public Sprite stonePillarImage;
    public GameObject windMill;

    public List<StonePillar> pillars;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < pillars.Count; i++)
        {
            GameObject stonePillarOb = DrawImage(stonePillarImage, pillars[i].position, 1);

            GameObject windMillOb = Instantiate(windMill);

            windMillOb.transform.SetParent(stonePillarOb.transform, false);
            windMillOb.transform.localPosition = pillars[i].windMillPosition;


            WindMillObject windMillscript = windMillOb.GetComponent<WindMillObject>();

            windMillscript.Init(this, i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PillarMove(int stonePillarId)
    {

    }
}
