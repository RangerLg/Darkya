
using UnityEngine;

public class MagicFactory : MonoBehaviour
{
    [SerializeField] private GameObject pointEffect;
    [SerializeField] private GameObject coneEffect;
    [SerializeField] private GameObject raysEffect;
    public  Magic GetMagic(MagicType magicType)
    {
        Magic obj = magicType switch
        {
            MagicType.POINT => new PointMagic(pointEffect),
            MagicType.CONE =>new ConeMagic(coneEffect),
            MagicType.RAYS=>new RayMagic(raysEffect),
            _=>new PointMagic(pointEffect)
        };
        return obj;
    }
}