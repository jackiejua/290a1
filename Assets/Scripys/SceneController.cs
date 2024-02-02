using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    public float minScale = 1.0f; // The minimum scale
    public float maxScale = 5.0f;
    private GameObject enemy;
    // Start is called before the first frame update

    //     public Renderer rend;
    void Start()
    {
        //rend = GetComponent<Renderer> ();
    }

    // Update is called once per frame 
    void Update()
    {
        if (enemy == null)
        {
            enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0);
            float scale = Random.Range(minScale, maxScale);
            enemy.transform.localScale = new Vector3(1, scale, 1);
            enemy.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }

    

}
