using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWeapons : MonoBehaviour
{
    public int throwspeed;

    // Start is called before the first frame update
    void Start()
    {
        Sword sword = new Sword();
        Dagger dagger = new Dagger();
        dagger.ThrowingRange = 20;
        sword.Equip();
        sword.Attack();
        sword.Unequip();


        dagger.Equip();
        dagger.Throw(throwspeed);
        dagger.Unequip();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
