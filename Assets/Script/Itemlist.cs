using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemlist : MonoBehaviour
{
    Gamemanager _gm;
    [SerializeField] ItemText _itembutton;
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
        for (int i = 0; i > _gm._item.Length - 1; i++)
        {
            if (_gm._item[i] > 0)
            {
                var x = Instantiate(_itembutton);
                switch (i)
                {
                    case 0:
                        x.TextWrite("やくそう",_gm._item[i]);
                        break;
                    case 1:
                        x.TextWrite("どくけしそう", _gm._item[i]);
                        break;
                    case 2:
                        x.TextWrite("せいすい", _gm._item[i]);
                        break;
                    case 3:
                        x.TextWrite("つるぎ", _gm._item[i]);
                        break;
                    case 4:
                        x.TextWrite("よろい", _gm._item[i]);
                        break;
                }
            }
        }
    }
}
