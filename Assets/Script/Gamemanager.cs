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
            case "‚â‚­‚»‚¤":
                if(_money >= _price[0])
                {
                    _money -= _price[0];
                    _item[0]++;
                }
                break;
            case "‚Ç‚­‚¯‚µ‚»‚¤":
                if (_money >= _price[1])
                {
                    _money -= _price[1];
                    _item[1]++;
                }
                break;
            case "‚¹‚¢‚·‚¢":
                if (_money >= _price[2])
                {
                    _money -= _price[2];
                    _item[2]++;
                }
                break;
            case "‚Â‚é‚¬":
                if (_money >= _price[3])
                {
                    _money -= _price[3];
                    _item[3]++;
                }
                break;
            case "‚æ‚ë‚¢":
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
            case "‚â‚­‚»‚¤":
                break;
            case "‚Ç‚­‚¯‚µ‚»‚¤":
                break;
            case "‚¹‚¢‚·‚¢":
                break;
            case "‚Â‚é‚¬":
                break;
            case "‚æ‚ë‚¢":
                break;
        }
    }
}
