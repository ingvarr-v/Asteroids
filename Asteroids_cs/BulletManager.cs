using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{

    public GameObject player;
    public GameObject effects;
    private Effects effectsGet;


    void Start()
    {       
        player = GameObject.Find("Player");
        effects = GameObject.Find("Effects");
        effectsGet = effects.GetComponent<Effects>();
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {        

        if(collision.gameObject.layer == 10 || collision.gameObject.layer == 13)        
        {
            Rocks(collision);
        }

        if (collision.gameObject.layer == 11)       
        {
            Aliens(collision);         
        }

        if (collision.gameObject.layer == 9 || collision.gameObject.layer == 10 || collision.gameObject.layer == 11 
            || collision.gameObject.layer == 12 || collision.gameObject.layer == 15)
        {
            BulletDie(collision);
        }
    }

    private void Rocks(Collider2D collision)
    {

        AsteroidManager rockMan = collision.gameObject.GetComponent<AsteroidManager>();
        if (rockMan.HP == 3)
        {
            rockMan.HP = rockMan.HP - 1;
            rockMan.crack0.SetActive(true);
        }
        else if (rockMan.HP == 2)
        {
            rockMan.HP = rockMan.HP - 1;
            if (rockMan.crack0 != null)
            {
                rockMan.crack0.SetActive(false);
            }
            rockMan.crack.SetActive(true);
        }
        else if (rockMan.HP == 1)
        {
            Vector3 boomPoint = collision.gameObject.transform.position;
            boomPoint = new Vector3(boomPoint.x, boomPoint.y, -3f);
            EffectsCheck(boomPoint,collision.gameObject);

            rockMan.Split();
        }
        
    }
    private void Aliens(Collider2D collision)
    {
        GameObject alien = collision.gameObject;
        EnemyManager enemyMan = alien.GetComponent<EnemyManager>();

        if (enemyMan.HP > 1)
        {
            enemyMan.HP = enemyMan.HP - 1;
            Vector3 HPLoss = new Vector3(0f, enemyMan.hpBar.transform.localScale.y - enemyMan.HP / enemyMan.primeHP * enemyMan.HPbarScale, 0f);
            enemyMan.hpBar.transform.localScale = enemyMan.hpBar.transform.localScale - HPLoss;
        }
        else
        {
            Vector3 boomPoint = collision.gameObject.transform.position;
            boomPoint = new Vector3(boomPoint.x, boomPoint.y, -4f);
            EffectsCheck(boomPoint,collision.gameObject);

            enemyMan.Die();
        }
    }
    private void BulletDie(Collider2D collision)
    {
        Vector3 hitPos = gameObject.transform.position;
        hitPos = new Vector3(hitPos.x, hitPos.y, -3.1f);
        EffectsCheck(hitPos,gameObject);

        transform.parent = player.transform;
        transform.localPosition = new Vector3(0, 0, 0);
        transform.eulerAngles = player.transform.eulerAngles;
        gameObject.SetActive(false);
    }

    private void EffectsCheck(Vector3 Pos, GameObject effectObj)
    {
        foreach (GameObject effect in effectsGet.EffectsList)
        {
            if (effect.activeSelf == false)
            {
                effect.transform.position = Pos;
                if (effectsGet.bool1 == false)
                {
                    effectsGet.StartCoroutine(effectsGet.ExplosionEffect1(effect, effectObj));
                }
                else if (effectsGet.bool2 == false)
                {
                    effectsGet.StartCoroutine(effectsGet.ExplosionEffect2(effect, effectObj));
                }
                else if (effectsGet.bool3 == false)
                {
                    effectsGet.StartCoroutine(effectsGet.ExplosionEffect3(effect, effectObj));
                }
                else if (effectsGet.bool4 == false)
                {
                    effectsGet.StartCoroutine(effectsGet.ExplosionEffect4(effect, effectObj));
                }
                else if (effectsGet.bool5 == false)
                {
                    effectsGet.StartCoroutine(effectsGet.ExplosionEffect5(effect, effectObj));
                }
                else if (effectsGet.bool6 == false)
                {
                    effectsGet.StartCoroutine(effectsGet.ExplosionEffect6(effect, effectObj));
                }
                else if (effectsGet.bool7 == false)
                {
                    effectsGet.StartCoroutine(effectsGet.ExplosionEffect7(effect, effectObj));
                }
                else if (effectsGet.bool8 == false)
                {
                    effectsGet.StartCoroutine(effectsGet.ExplosionEffect8(effect, effectObj));
                }
                else if (effectsGet.bool7 == false)
                {
                    effectsGet.StartCoroutine(effectsGet.ExplosionEffect7(effect, effectObj));
                }
                else if (effectsGet.bool8 == false)
                {
                    effectsGet.StartCoroutine(effectsGet.ExplosionEffect8(effect, effectObj));
                }
                else if (effectsGet.bool9 == false)
                {
                    effectsGet.StartCoroutine(effectsGet.ExplosionEffect9(effect, effectObj));
                }
                else if (effectsGet.bool10 == false)
                {
                    effectsGet.StartCoroutine(effectsGet.ExplosionEffect10(effect, effectObj));
                }
                break;
            }
        }
    }
}
