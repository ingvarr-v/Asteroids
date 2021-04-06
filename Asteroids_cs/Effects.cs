using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public List<GameObject> EffectsList;

    [HideInInspector]
    public bool
        bool1 = false, bool2 = false, bool3 = false, bool4 = false, bool5 = false,
        bool6 = false, bool7 = false, bool8 = false, bool9 = false, bool10 = false;

    private void Start()
    {
        foreach(GameObject effect in EffectsList)
        {
            effect.SetActive(false);
        }
    }

    public IEnumerator ExplosionEffect1(GameObject effect, GameObject effectObj)
    {
        bool1 = true;
        effect.SetActive(true);
        effect.transform.localScale = effectObj.transform.localScale;
        effect.transform.eulerAngles = effectObj.transform.eulerAngles;
        if (effectObj.tag == "Alien")
        {
            effect.GetComponent<Animator>().Play("FireExplosionAnim");
            yield return new WaitForSeconds(0.5f);
        }
        else if (effectObj.tag == "Rock")
        {
            effect.GetComponent<Animator>().Play("RockExplosionAnim");
            yield return new WaitForSeconds(0.7f);
        }
        else if (effectObj.tag == "PlayerBullet")
        {
            effect.GetComponent<Animator>().Play("PlayerBulletExplosionAnim");
            yield return new WaitForSeconds(0.3f);

        }
        else if (effectObj.tag == "AlienBullet1")
        {
            effect.GetComponent<Animator>().Play("AlienBullet1Explosion");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet3")
        {
            effect.GetComponent<Animator>().Play("AlienBullet3Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        else if (effectObj.tag == "AlienBullet4")
        {
            effect.GetComponent<Animator>().Play("AlienBullet4Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        effect.SetActive(false);
        bool1 = false;
    }

    public IEnumerator ExplosionEffect2(GameObject effect, GameObject effectObj)
    {
        bool2 = true;
        effect.SetActive(true);
        effect.transform.localScale = effectObj.transform.localScale;
        if (effectObj.tag == "Alien")
        {
            effect.GetComponent<Animator>().Play("FireExplosionAnim");
            yield return new WaitForSeconds(0.5f);
        }
        else if (effectObj.tag == "Rock")
        {
            effect.GetComponent<Animator>().Play("RockExplosionAnim");
            yield return new WaitForSeconds(0.7f);
        }
        else if (effectObj.tag == "PlayerBullet")
        {
            effect.GetComponent<Animator>().Play("PlayerBulletExplosionAnim");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet1")
        {
            effect.GetComponent<Animator>().Play("AlienBullet1Explosion");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet3")
        {
            effect.GetComponent<Animator>().Play("AlienBullet3Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        else if (effectObj.tag == "AlienBullet4")
        {
            effect.GetComponent<Animator>().Play("AlienBullet4Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        effect.SetActive(false);
        bool2 = false;
    }

    public IEnumerator ExplosionEffect3(GameObject effect, GameObject effectObj)
    {
        bool3 = true;
        effect.SetActive(true);
        effect.transform.localScale = effectObj.transform.localScale;
        if (effectObj.tag == "Alien")
        {
            effect.GetComponent<Animator>().Play("FireExplosionAnim");
            yield return new WaitForSeconds(0.5f);
        }
        else if (effectObj.tag == "Rock")
        {
            effect.GetComponent<Animator>().Play("RockExplosionAnim");
            yield return new WaitForSeconds(0.7f);
        }
        else if (effectObj.tag == "PlayerBullet")
        {
            effect.GetComponent<Animator>().Play("PlayerBulletExplosionAnim");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet1")
        {
            effect.GetComponent<Animator>().Play("AlienBullet1Explosion");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet3")
        {
            effect.GetComponent<Animator>().Play("AlienBullet3Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        else if (effectObj.tag == "AlienBullet4")
        {
            effect.GetComponent<Animator>().Play("AlienBullet4Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        effect.SetActive(false);
        bool3 = false;
    }

    public IEnumerator ExplosionEffect4(GameObject effect, GameObject effectObj)
    {
        bool4 = true;
        effect.SetActive(true);
        effect.transform.localScale = effectObj.transform.localScale;
        if (effectObj.tag == "Alien")
        {
            effect.GetComponent<Animator>().Play("FireExplosionAnim");
            yield return new WaitForSeconds(0.5f);
        }
        else if (effectObj.tag == "Rock")
        {
            effect.GetComponent<Animator>().Play("RockExplosionAnim");
            yield return new WaitForSeconds(0.7f);
        }
        else if (effectObj.tag == "PlayerBullet")
        {
            effect.GetComponent<Animator>().Play("PlayerBulletExplosionAnim");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet1")
        {
            effect.GetComponent<Animator>().Play("AlienBullet1Explosion");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet3")
        {
            effect.GetComponent<Animator>().Play("AlienBullet3Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        else if (effectObj.tag == "AlienBullet4")
        {
            effect.GetComponent<Animator>().Play("AlienBullet4Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        effect.SetActive(false);
        bool4 = false;
    }

    public IEnumerator ExplosionEffect5(GameObject effect, GameObject effectObj)
    {
        bool5 = true;
        effect.SetActive(true);
        effect.transform.localScale = effectObj.transform.localScale;
        if (effectObj.tag == "Alien")
        {
            effect.GetComponent<Animator>().Play("FireExplosionAnim");
            yield return new WaitForSeconds(0.5f);
        }
        else if (effectObj.tag == "Rock")
        {
            effect.GetComponent<Animator>().Play("RockExplosionAnim");
            yield return new WaitForSeconds(0.7f);
        }
        else if (effectObj.tag == "PlayerBullet")
        {
            effect.GetComponent<Animator>().Play("PlayerBulletExplosionAnim");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet1")
        {
            effect.GetComponent<Animator>().Play("AlienBullet1Explosion");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet3")
        {
            effect.GetComponent<Animator>().Play("AlienBullet3Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        else if (effectObj.tag == "AlienBullet4")
        {
            effect.GetComponent<Animator>().Play("AlienBullet4Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        effect.SetActive(false);
        bool5 = false;
    }

    public IEnumerator ExplosionEffect6(GameObject effect, GameObject effectObj)
    {
        bool6 = true;
        effect.SetActive(true);
        effect.transform.localScale = effectObj.transform.localScale;
        if (effectObj.tag == "Alien")
        {
            effect.GetComponent<Animator>().Play("FireExplosionAnim");
            yield return new WaitForSeconds(0.5f);
        }
        else if (effectObj.tag == "Rock")
        {
            effect.GetComponent<Animator>().Play("RockExplosionAnim");
            yield return new WaitForSeconds(0.7f);
        }
        else if (effectObj.tag == "PlayerBullet")
        {
            effect.GetComponent<Animator>().Play("PlayerBulletExplosionAnim");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet1")
        {
            effect.GetComponent<Animator>().Play("AlienBullet1Explosion");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet3")
        {
            effect.GetComponent<Animator>().Play("AlienBullet3Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        else if (effectObj.tag == "AlienBullet4")
        {
            effect.GetComponent<Animator>().Play("AlienBullet4Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        effect.SetActive(false);
        bool6 = false;
    }

    public IEnumerator ExplosionEffect7(GameObject effect, GameObject effectObj)
    {
        bool7 = true;
        effect.SetActive(true);
        effect.transform.localScale = effectObj.transform.localScale;
        if (effectObj.tag == "Alien")
        {
            effect.GetComponent<Animator>().Play("FireExplosionAnim");
            yield return new WaitForSeconds(0.5f);
        }
        else if (effectObj.tag == "Rock")
        {
            effect.GetComponent<Animator>().Play("RockExplosionAnim");
            yield return new WaitForSeconds(0.7f);
        }
        else if (effectObj.tag == "PlayerBullet")
        {
            effect.GetComponent<Animator>().Play("PlayerBulletExplosionAnim");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet1")
        {
            effect.GetComponent<Animator>().Play("AlienBullet1Explosion");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet3")
        {
            effect.GetComponent<Animator>().Play("AlienBullet3Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        else if (effectObj.tag == "AlienBullet4")
        {
            effect.GetComponent<Animator>().Play("AlienBullet4Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        effect.SetActive(false);
        bool7 = false;
    }

    public IEnumerator ExplosionEffect8(GameObject effect, GameObject effectObj)
    {
        bool8 = true;
        effect.SetActive(true);
        effect.transform.localScale = effectObj.transform.localScale;
        if (effectObj.tag == "Alien")
        {
            effect.GetComponent<Animator>().Play("FireExplosionAnim");
            yield return new WaitForSeconds(0.5f);
        }
        else if (effectObj.tag == "Rock")
        {
            effect.GetComponent<Animator>().Play("RockExplosionAnim");
            yield return new WaitForSeconds(0.7f);
        }
        else if (effectObj.tag == "PlayerBullet")
        {
            effect.GetComponent<Animator>().Play("PlayerBulletExplosionAnim");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet1")
        {
            effect.GetComponent<Animator>().Play("AlienBullet1Explosion");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet3")
        {
            effect.GetComponent<Animator>().Play("AlienBullet3Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        else if (effectObj.tag == "AlienBullet4")
        {
            effect.GetComponent<Animator>().Play("AlienBullet4Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        effect.SetActive(false);
        bool8 = false;
    }

    public IEnumerator ExplosionEffect9(GameObject effect, GameObject effectObj)
    {
        bool9 = true;
        effect.SetActive(true);
        effect.transform.localScale = effectObj.transform.localScale;
        if (effectObj.tag == "Alien")
        {
            effect.GetComponent<Animator>().Play("FireExplosionAnim");
            yield return new WaitForSeconds(0.5f);
        }
        else if (effectObj.tag == "Rock")
        {
            effect.GetComponent<Animator>().Play("RockExplosionAnim");
            yield return new WaitForSeconds(0.7f);
        }
        else if (effectObj.tag == "PlayerBullet")
        {
            effect.GetComponent<Animator>().Play("PlayerBulletExplosionAnim");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet1")
        {
            effect.GetComponent<Animator>().Play("AlienBullet1Explosion");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet3")
        {
            effect.GetComponent<Animator>().Play("AlienBullet3Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        else if (effectObj.tag == "AlienBullet4")
        {
            effect.GetComponent<Animator>().Play("AlienBullet4Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        effect.SetActive(false);
        bool9 = false;
    }

    public IEnumerator ExplosionEffect10(GameObject effect, GameObject effectObj)
    {
        bool10 = true;
        effect.SetActive(true);
        effect.transform.localScale = effectObj.transform.localScale;
        if (effectObj.tag == "Alien")
        {
            effect.GetComponent<Animator>().Play("FireExplosionAnim");
            yield return new WaitForSeconds(0.5f);
        }
        else if (effectObj.tag == "Rock")
        {
            effect.GetComponent<Animator>().Play("RockExplosionAnim");
            yield return new WaitForSeconds(0.7f);
        }
        else if (effectObj.tag == "PlayerBullet")
        {
            effect.GetComponent<Animator>().Play("PlayerBulletExplosionAnim");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet1")
        {
            effect.GetComponent<Animator>().Play("AlienBullet1Explosion");
            yield return new WaitForSeconds(0.3f);
        }
        else if (effectObj.tag == "AlienBullet3")
        {
            effect.GetComponent<Animator>().Play("AlienBullet3Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        else if (effectObj.tag == "AlienBullet4")
        {
            effect.GetComponent<Animator>().Play("AlienBullet4Explosion");
            yield return new WaitForSeconds(0.4f);
        }
        effect.SetActive(false);
        bool10 = false;
    }

}
