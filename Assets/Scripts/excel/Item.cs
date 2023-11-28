using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

    public class Item : MonoBehaviour
    {
        public int id;
        public string name;
        public string speed;
        public string boost;

    public Item (Item d)
    {
        id = d.id;
        name = d.name;
        speed = d.speed;
        boost = d.boost;

    }
    }

