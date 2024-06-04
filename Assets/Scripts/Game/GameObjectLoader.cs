using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroid
{
    [CreateAssetMenu(fileName = "GameObjectLoader", menuName = "ScriptableObjects/GameObjectLoader", order = 1)]
    public class GameObjectLoader : ScriptableObject
    {
        [SerializeField] public List<GameObject> gameObjects = new List<GameObject>();

        public GameObject Load(string name)
        {
            GameObject goPrefab = gameObjects.Find(go => go.name == name);

            if (goPrefab == null)
            {
                Debug.LogError("GameObjectLoader can't Load " + name);
                return null; 
            }

            //Debug.Log("GameObjectLoader Load " + name);

            return GameObject.Instantiate(goPrefab);
        }
    }
}