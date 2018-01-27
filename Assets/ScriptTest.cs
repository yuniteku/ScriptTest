using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour
{
    //課題1
   private int[] array = new int[5] { 10, 20, 30, 40, 50 };
   private Boss boss = new Boss();

    // Use this for initialization
    void Start()
    {
        

        //課題2
        Debug.Log(array[0]);
        Debug.Log(array[1]);
        Debug.Log(array[2]);
        Debug.Log(array[3]);
        Debug.Log(array[4]);

        Test();

        //発展課題
        boss.Magic(5);
 

    }


    void Test()
    {
        //課題3
        for (int j = array.Length - 1; 0 <= j; j--)
        {
            Debug.Log(array[j]);

        }
    }


public class  Boss
{
        private int mp = 53;


       public void Magic(int mAttack)
        {
           while(mp > 5)
            { 

                if (mp >= 4)
                {

                    this.mp -= mAttack;
                    Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
                }
                if (mp <= 4)
                {

                    this.mp = mAttack;
                    Debug.Log("MPが足りないため魔法が使えない。");
                }

            }

        }

}

    // Update is called once per frame
    void Update()
    {

    }

}