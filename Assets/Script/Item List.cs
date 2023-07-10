using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    Gamemanager _gm;
    [SerializeField] GameObject _itembutton;
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
                var x = Instantiate(_itembutton);
                switch (i)
                {
                    case 0:

                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
        }
    }
}
