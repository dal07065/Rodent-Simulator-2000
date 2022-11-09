using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSpawner : MonoBehaviour
{
    //Randomly generates Cheese blocks within the maze
    //https://generalistprogrammer.com/game-design-development/unity-spawn-prefab-at-position-tutorial/

    public CheeseInfo cheeseInfo;

    public GameObject cheese;
    public int numberOfCheese;

    public GameObject terrain;
    private MeshCollider col;

    // Start is called before the first frame update
    void Start()
    {
        col = terrain.GetComponent<MeshCollider>();
        GenerateObject(cheese, numberOfCheese);
    }

    void GenerateObject(GameObject go, int amount)
    {
        // This position is valid until proven invalid

        bool validPosition;
        float obstacleCheckRadius = 0.6f;
        Vector3 randomPoint;
        int spawnAttempts = 0;

        if (go == null) return;

        for (int i = 0; i < amount; i++)
        {
            /*
            do
            {
                GameObject tmp = Instantiate(go);
                Vector3 randomPoint = GetRandomPoint();
                tmp.gameObject.transform.position = new Vector3(randomPoint.x, tmp.transform.position.y, randomPoint.z);
            } while (cheeseInfo.getCurrentCollider() == "Terrain");
            */
            
            //Try to find a valid position where Cheese is not colliding with the Maze mesh
            do
            {
                validPosition = true;
                Debug.Log("Cheese # " + i);
                randomPoint = GetRandomPoint();

                // Collect all colliders within our Obstacle Check Radius
                Collider[] colliders = Physics.OverlapSphere(randomPoint, obstacleCheckRadius);

                // Go through each collider collected
                foreach (Collider col in colliders)
                {
                    Debug.Log("foreach");
                    // If this collider is tagged "Obstacle"
                    if (col.tag == "Terrain" || col.tag == "Cheese")
                    {
                        // Then this position is not a valid spawn position
                        validPosition = false;
                        Debug.Log("This Cheese is colliding with " + col.tag + " - Trying Again..");
                    }
                }
                spawnAttempts++;
            } while (!validPosition && spawnAttempts < 10);
            
            //Spawn Cheese ONLY IF the position is valid
            if (validPosition)
            {
                GameObject tmp = Instantiate(go);
                tmp.gameObject.transform.position = new Vector3(randomPoint.x, tmp.transform.position.y, randomPoint.z);
            }
            else
            {
                Debug.Log("****Cheese # " + i + " is getting deleted ******");
            }

            //Reset variables for next Cheese to spawn
            spawnAttempts = 0;
            validPosition = true;
        }

    }
    Vector3 GetRandomPoint()
    {
        int xRandom = 0;
        int zRandom = 0;
        xRandom = (int)Random.Range(col.bounds.min.x, col.bounds.max.x);
        zRandom = (int)Random.Range(col.bounds.min.z, col.bounds.max.z);

        return new Vector3(xRandom, -0.56f, zRandom);
    }
}