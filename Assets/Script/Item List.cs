using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    Gamemanager _gm;
    // Start is called before the first frame update
    void Start()
    {
        _gm = FindObjectOfType<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void List()
    {
        for(int i = 0; i > _gm._item.Length-1; i++)
        {
            if(_gm._item[i] > 0)
            {

            }
        }
    }
}
