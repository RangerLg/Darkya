using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class ChangedMagicController : MonoBehaviour
{
    [SerializeField] private MagicController magicController;
    public void ChangeMagic()
    {
        var number = gameObject.name switch
        {
            "Magic 1" => 1,
            "Magic 2" => 2,
            "Magic 3" => 3,
            _=>1
        };
        magicController.ChangeMagic(number);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
