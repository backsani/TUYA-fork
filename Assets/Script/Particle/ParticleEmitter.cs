using System;
using UnityEngine;

public class ParticleEmitter
{
    private float timer;
    private float createCycle;
    private int createCount;

    private bool isParticle;

    private Action<ParticleEmitter> SpawnParticleAction;

    public void Init(ParticleScriptable scriptable, Action<ParticleEmitter> action)
    {
        SpawnParticleAction = action;

        timer = 0;
        createCycle = scriptable.createCycle;
        createCount = scriptable.createCount;

        Debug.Log(createCycle);
        Debug.Log(createCount);
    }

    // 매 틱을 계산하며, 파티클을 생성하는 함수를 호출하는 함수
    public void Tick(float deltaTime)
    {
        if (!isParticle)
        {
            return;
        }

        timer += deltaTime;

        // 파티클 생성 시간이 되면
        while(timer > createCycle)
        {
            timer -= createCycle;

            // 스폰 함수 실행
            SpawnParticleAction(this);
        }
    }

    // 파티클을 생성할지 생성하지 않을 지 설정하는 함수
    public void SetParticle(bool particleSetting)
    {
        timer = 0;
        isParticle = particleSetting;
    }
}
