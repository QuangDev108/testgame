using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    public GameObject pipePrefabs;
    [SerializeField] protected float countDown;
    [SerializeField] protected float timeDuration = 2f;
    public bool enableGenratePipe = false;

    // Start is called before the first frame update
    void Awake()
    {
        this.pipePrefabs = GameObject.Find("Pipe");

        Time.timeScale = 0;
    }

    void Start()
    {
        this.countDown = timeDuration;

    }

    // Update is called once per frame
    void Update()
    {
        this.PipeSpawn();
    }

    protected virtual void PipeSpawn()
    {
        if(this.enableGenratePipe == true)
        {
            this.countDown -= Time.deltaTime;
            if (this.countDown <= 0)
            {
                Instantiate(this.pipePrefabs, new Vector3(7, Random.Range(-1.2f, 2f), 0), Quaternion.identity);
                this.countDown = this.timeDuration;
            }
        }    
    }    
}
