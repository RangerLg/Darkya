using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;



public abstract class Magic : MonoBehaviour
{
    protected float Duration { set; get; }
    protected MagicType MType { set; get; }
    public GameObject EffectPrefab { get; set; }

    public abstract void LightUp(Vector3 pos);
    
}


public class PointMagic : Magic
{
    public PointMagic(GameObject effect)
    {
        EffectPrefab = effect;
        MType = MagicType.POINT;
    }
    
    public override void LightUp(Vector3 pos)
    {
        
        Instantiate(EffectPrefab, pos, Quaternion.identity);
    }
}

public class ConeMagic : Magic
 {
     public ConeMagic(GameObject effect)
     {
         EffectPrefab = effect;
         MType = MagicType.CONE;
     }
     public override void LightUp(Vector3 pos)
     {
         GameObject player = GameObject.FindWithTag("Player");
         Vector3 playerPos = player.transform.position;

         Vector3 vectorToTarget = pos - playerPos;
         float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - 90;
         Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
         ConeEffect.radius = Vector3.Distance(pos, playerPos);
         Instantiate(EffectPrefab, playerPos, q).transform.parent = player.transform;
         Debug.Log(MType);
     }
 }

public class RayMagic : Magic
{
    public RayMagic(GameObject effect)
    {
        EffectPrefab = effect;
        MType = MagicType.RAYS;
    }
    public override void LightUp(Vector3 pos)
    {
        Debug.Log(MType);
    }
}