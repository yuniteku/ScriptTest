using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Boss lastboss = new Boss();

    Boss midboss = new Boss();


    // Use this for initialization
    void Start()
    {
    

        lastboss.Attack();

        midboss.Attack();

        lastboss.Defence(3);

        midboss.Defence(1);


    }

    // Update is called once per frame
    void Update()
    {

    }



}

public class Boss
{
    private int hp = 100;
    private int power = 25;

    private string[] name = { "ボス","中ボス"};

    public void Attack()
    {
        Debug.Log(name[0] + "に"+ this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(name[1] + "から" + damage + "のダメージを受けた");
        //残りHPを減らす
        this.hp -= damage;

    }

}

