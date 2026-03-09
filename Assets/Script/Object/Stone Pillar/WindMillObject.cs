using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindMillObject : MonoBehaviour, IArrowHit
{
    private StonePillarManager manager;
    private int stonePillarId;

    public void OnHit()
    {
        manager.PillarMove(stonePillarId);
    }

    public void Init(StonePillarManager manager, int stonePillarId)
    {
        this.manager = manager;
        this.stonePillarId = stonePillarId;
    }
}
