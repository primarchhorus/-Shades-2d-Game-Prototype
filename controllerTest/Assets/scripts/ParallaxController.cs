using UnityEngine;
using System.Collections;
public class ParallaxController : MonoBehaviour
{
	public GameObject[] clouds;
	public GameObject[] mountainBack;
	public GameObject[] mountainMed;
	public GameObject[] treeBack;
	public GameObject[] foreRock;
	public GameObject[] playerLevel;
	public GameObject[] treeFore;
	public GameObject[] playerRock;
	public float cloudLayerSpeedModifier;
	public float mountainBackLayerSpeedModifier;
	public float mountainMedLayerSpeedModifier;
	public float treeBackLayerSpeedModifier;
	public float foreRockLayerSpeedModifier;
	public float treeForeLayerSpeedModifier;
	public float playerLevelLayerSpeedModifier;
	public float playerRockLayerSpeedModifier;
	public Camera myCamera;
	private Vector3 lastCamPos;

	void Start()
	{
		lastCamPos = myCamera.transform.position;
	}
	void Update()
	{
		Vector3 currCamPos = myCamera.transform.position;
		float xPosDiff = lastCamPos.x - currCamPos.x;
		adjustParallaxPositionsForArray(clouds,
		                                cloudLayerSpeedModifier, xPosDiff);
		adjustParallaxPositionsForArray(mountainBack,
		                                mountainBackLayerSpeedModifier, xPosDiff);
		adjustParallaxPositionsForArray(mountainMed,
		                                mountainMedLayerSpeedModifier, xPosDiff);
		adjustParallaxPositionsForArray(treeBack,
		                                treeBackLayerSpeedModifier, xPosDiff);
		adjustParallaxPositionsForArray(foreRock,
		                                foreRockLayerSpeedModifier, xPosDiff);
		adjustParallaxPositionsForArray(treeFore,
		                                treeForeLayerSpeedModifier, xPosDiff);
		adjustParallaxPositionsForArray(playerLevel,
		                                playerLevelLayerSpeedModifier, xPosDiff);
		adjustParallaxPositionsForArray(playerRock,
		                                playerRockLayerSpeedModifier, xPosDiff);
		lastCamPos = myCamera.transform.position;
	}
	void adjustParallaxPositionsForArray(GameObject[]
	                                     layerArray, float layerSpeedModifier, float xPosDiff)
	{
		for(int i = 0; i < layerArray.Length; i++)
		{
			Vector3 objPos = 
				layerArray[i].transform.position;
			objPos.x += xPosDiff * layerSpeedModifier;
			layerArray[i].transform.position = objPos;
		}
	}
}
