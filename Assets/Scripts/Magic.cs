using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;



public abstract class Magic
{
    protected float Duration { set; get; }
    protected MagicType MType { set; get; }
    protected GameObject EffectPrefab;

    public abstract void LightUp(Transform pos);
    
}


public class PointMagic : Magic
{
    public PointMagic(GameObject effect)
    {
        EffectPrefab = effect;
        MType = MagicType.POINT;
    }
    
    public override void LightUp(Transform pos)
    {
        
        Debug.Log(MType);
    }
}

public class ConeMagic : Magic
 {
     public ConeMagic(GameObject effect)
     {
         EffectPrefab = effect;
         MType = MagicType.CONE;
     }
     public override void LightUp(Transform pos)
     {
         
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
    public override void LightUp(Transform pos)
    {
        Debug.Log(MType);
    }
}