using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AsteroidManager : MonoBehaviour
{

    public bool Ready = true;

    public GameObject RockParent;

    public GameObject GeneralRock;

    public int HP;

    private int RockType;

    public GameObject crack,crack0;

    public List<GameObject> ChildRocks;

    public int childCount, childCountOnStart;

    public TMP_Text score;


    private void Awake()
    {

        RockParent = gameObject.transform.parent.gameObject;
        score = GeneralRock.GetComponent<AsteroidManager>().score;

        if (ChildRocks.Count != 0)
        {
            foreach (GameObject childRock in ChildRocks)
            {
                childRock.SetActive(true);
            }
        }
    }

    private void Start()
    {
        childCountOnStart = ChildRocks.Count;

        if (gameObject.name.Contains("Large"))
        {
            HP = 3;
            RockType = 3;
        }
        else if (gameObject.name.Contains("Medium"))
        {
            HP = 2;
            RockType = 2;
        }
        else if (gameObject.name.Contains("Small"))
        {
            HP = 1;
            RockType = 1;
        }

        if (ChildRocks.Count != 0)
        {
            foreach (GameObject childRock in ChildRocks)
            {
                childRock.SetActive(false);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            transform.parent = RockParent.transform;
            transform.localPosition = new Vector3(0, 0, 0);
            transform.eulerAngles = RockParent.transform.eulerAngles;
            if (RockParent.name.Contains("Spown"))
            {
                RockParent.GetComponent<RocksSpown>().notFloatingRocks.Add(gameObject);
            }
            else if (gameObject.name.Contains("Medium"))
            {
                Ready = true;

                AsteroidManager generalMan = GeneralRock.GetComponent<AsteroidManager>();
                bool GeneralReady = true;
                foreach (GameObject rock in generalMan.ChildRocks)
                {
                    AsteroidManager rockMan = rock.GetComponent<AsteroidManager>();
                    if (rockMan.GetComponent<AsteroidManager>().Ready == false)
                    {
                        GeneralReady = false;
                    }
                }
                if (GeneralReady == true)
                {
                    generalMan.Ready = true;
                    GeneralRock.transform.parent.GetComponent<RocksSpown>().notFloatingRocks.Add(GeneralRock);
                }
            }
            else if(gameObject.name.Contains("Small"))
            {
                AsteroidManager parentMan = RockParent.GetComponent<AsteroidManager>();
                parentMan.childCount += 1;
                if (parentMan.childCount == parentMan.childCountOnStart)
                {
                    parentMan.Ready = true;

                    AsteroidManager generalMan = GeneralRock.GetComponent<AsteroidManager>();

                    if (GeneralRock.name.Contains("Large"))
                    {
                        generalMan.childCount += 1;
                    }

                    bool GeneralReady = true;
                    foreach(GameObject rock in generalMan.ChildRocks)
                    {
                        AsteroidManager rockMan = rock.GetComponent<AsteroidManager>();
                        if (rockMan.GetComponent<AsteroidManager>().Ready == false)
                        {
                            GeneralReady = false;
                        }
                    }
                    if (GeneralReady == true)
                    {
                        generalMan.Ready = true;
                        GeneralRock.transform.parent.GetComponent<RocksSpown>().notFloatingRocks.Add(GeneralRock);
                    }
                }
            }
            crack.SetActive(false);
            if (crack0 != null)
            {
                crack0.SetActive(false);
            }
            HP = RockType;
            GetComponent<CircleCollider2D>().enabled = true;
            gameObject.SetActive(false);
        }
    }

    public void Split()
    {
        if (ChildRocks.Count != 0)
        {
            childCount = 0;
            Ready = false;
            GetComponent<CircleCollider2D>().enabled = false;

            GameObject.Find("RocksSpownSpot1").GetComponent<RocksSpown>().SplitRocks.AddRange(ChildRocks.ToArray());
            GameObject.Find("RocksSpownSpot1").GetComponent<RocksSpown>().SplitTime = false;

            foreach (GameObject rock in ChildRocks)
            {
                rock.transform.eulerAngles = rock.GetComponent<AsteroidManager>().RockParent.transform.eulerAngles;
                rock.transform.parent = null;
                rock.SetActive(true);
                rock.GetComponent<AsteroidManager>().Ready = false;
                rock.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                int rockVelocity = Random.Range(5, 10);
                int rotationOffset = Random.Range(-360, 360);
                rock.transform.eulerAngles = new Vector3(0, 0, rotationOffset);
                rock.GetComponent<Rigidbody2D>().AddForce(rock.transform.up * rockVelocity);
            }
            Ready = false;
            transform.parent = RockParent.transform;
            transform.localPosition = new Vector3(0, 0, 0);
            transform.eulerAngles = RockParent.transform.eulerAngles;
            crack.SetActive(false);
            if (crack0 != null)
            {
                crack0.SetActive(false);
            }
            HP = RockType;
            GetComponent<CircleCollider2D>().enabled = true;

            ScoreAdd();

            gameObject.SetActive(false);
        }
        else
        {

            transform.parent = RockParent.transform;
            transform.localPosition = new Vector3(0, 0, 0);
            transform.eulerAngles = RockParent.transform.eulerAngles;
            if (RockParent.name.Contains("Spown"))
            {
                RockParent.GetComponent<RocksSpown>().notFloatingRocks.Add(gameObject);
            }
            else if(gameObject.name.Contains("Small"))
            {
                AsteroidManager parentMan = RockParent.GetComponent<AsteroidManager>();
                parentMan.childCount += 1;
                if(parentMan.childCount== parentMan.childCountOnStart)
                {
                    parentMan.Ready = true;
                    
                    AsteroidManager generalMan = GeneralRock.GetComponent<AsteroidManager>();

                    if (GeneralRock.name.Contains("Large"))
                    {
                        generalMan.childCount += 1;
                    }

                    bool GeneralReady = true;
                    foreach(GameObject rock in generalMan.ChildRocks)
                    {
                        AsteroidManager rockMan = rock.GetComponent<AsteroidManager>();
                        if (rockMan.GetComponent<AsteroidManager>().Ready == false)
                        {
                            GeneralReady = false;
                        }
                    }
                    if (GeneralReady == true)
                    {
                        generalMan.Ready = true;
                        GeneralRock.transform.parent.GetComponent<RocksSpown>().notFloatingRocks.Add(GeneralRock);
                    }

                }
            }
            crack.SetActive(false);
            if (crack0 != null)
            {
                crack0.SetActive(false);
            }
            HP = RockType;
            GetComponent<CircleCollider2D>().enabled = true;

            ScoreAdd();

            gameObject.SetActive(false);
        }
    }

    private void ScoreAdd()
    {
        if (gameObject.name.Contains("Small"))
        {
            int currentScore = int.Parse(score.text) + 5;
            int currentScoreSympolCount = currentScore.ToString().Length;
            score.text = "";
            for (int i = 0; i < 6 - currentScoreSympolCount; i++)
            {
                score.text = score.text + "0";
            }
            score.text = score.text + currentScore.ToString();
        }
        else if (gameObject.name.Contains("Medium"))
        {
            int currentScore = int.Parse(score.text) + 10;
            int currentScoreSympolCount = currentScore.ToString().Length;
            score.text = "";
            for (int i = 0; i < 6 - currentScoreSympolCount; i++)
            {
                score.text = score.text + "0";
            }
            score.text = score.text + currentScore.ToString();
        }
        else if (gameObject.name.Contains("Large"))
        {
            int currentScore = int.Parse(score.text) + 15;
            int currentScoreSympolCount = currentScore.ToString().Length;
            score.text = "";
            for (int i = 0; i < 6 - currentScoreSympolCount; i++)
            {
                score.text = score.text + "0";
            }
            score.text = score.text + currentScore.ToString();
        }
    }

}
