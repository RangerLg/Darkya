using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCampfireManager : MonoBehaviour
{
    [SerializeField] private  GameObject BigCampfire;
    public  GameObject CreateCampfire(Transform position)
    {
        return Instantiate(BigCampfire,position.position,Quaternion.identity);
    }
    // Start is called before the first frame update
}
