using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    int[] _price;
    public int[] _item;
    int _money;
    // Start is called before the first frame update
    void Start()
    {
        _price = new int[]{100,50,200,500,700};
        _item = new int[] { 0, 0, 0, 0, 0 };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buy(string _name)
    {
        switch(_name)
        {
            case "�₭����":
                if(_money >= _price[0])
                {
                    _money -= _price[0];
                    _item[0]++;
                }
                break;
            case "�ǂ���������":
                if (_money >= _price[1])
                {
                    _money -= _price[1];
                    _item[1]++;
                }
                break;
            case "��������":
                if (_money >= _price[2])
                {
                    _money -= _price[2];
                    _item[2]++;
                }
                break;
            case "�邬":
                if (_money >= _price[3])
                {
                    _money -= _price[3];
                    _item[3]++;
                }
                break;
            case "��낢":
                if (_money >= _price[4])
                {
                    _money -= _price[4];
                    _item[4]++;
                }
                break;
        }
    }

    public void use(string _name)
    {
        switch (_name)
        {
            case "�₭����":
                break;
            case "�ǂ���������":
                break;
            case "��������":
                break;
            case "�邬":
                break;
            case "��낢":
                break;
        }
    }
}
