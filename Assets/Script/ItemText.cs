using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemText : MonoBehaviour
{
    [SerializeField] Text _itemTextUI;
    public string _itemname;
    public void TextWrite(string _name, int _volume)
    {
        _itemname = _name;
        _itemTextUI.text = _name + " Å~" + _volume;
    }
}
