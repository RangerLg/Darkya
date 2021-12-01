using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicController : MonoBehaviour
{

    enum TypeMagic
    {
        Type1,
        Type2,
        Type3
    }

    private List<TypeMagic> _typeMagics = new List<TypeMagic>();
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_typeMagics.Count);
        _typeMagics.Add(TypeMagic.Type1);
        _typeMagics.Add(TypeMagic.Type1);
        Debug.Log(_typeMagics.Count);
    }

    public int GetCount()
    {
        return _typeMagics.Count;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
