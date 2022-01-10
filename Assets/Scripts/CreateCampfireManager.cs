using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCampfireManager : MonoBehaviour
{
    [SerializeField] private  GameObject BigCampfire;
    public  void CreateCampfire(Transform position)
    {
        Instantiate(BigCampfire,position.position,Quaternion.identity);
    }
    // Start is called before the first frame update
}
