using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

using LinkCommunicationColoredNamespace;
using CommunicationCamaraShakeNamespace;
using CommunicationCorrectAnswerNamespace;
using CommunicationBezierCharToWordsNamespace;
using CommunicationCollisionCharToWordsNamespace;


public class WordHandler_CharToWords : MonoBehaviour
{



	public GameObject TextOne_0;
	public GameObject TextOne_1;

	public GameObject BoxOne_0;
	public GameObject BoxOne_1;

	public GameObject backgroundShader_0;
	public GameObject backgroundShader_1;

	Vector3 vector3_PositionStartBackground_0;
	Vector3 vector3_PositionStartBackground_1;

	public GameObject Container_0;
	public GameObject Container_1;


	List<GameObject> list_GameObjectInstanciated_0;
	List<GameObject> list_GameObjectInstanciated_1;
		
    List<int> list_IntPositionMark_0;
    List<int> list_IntPositionMark_1;

    List<string> list_OneTranslationOperational;
    List<string> list_TwoTranslationOperational;


	// List<GameObject> list_OfGameObjectBackgroundShader;
	// List<Transform> listOfTransformBackgroundShader;

	// List<GameObject> listOfBoxGameObject_One;

	// List<Transform> listOfTransform_One;
	// List<Vector3> listOfPosition_One;
	// List<Quaternion> listOfRotation_One;
	// List<Collider> listOfCollider_One;
	// List<TextMeshPro> list_OfTextMeshPro;


 	List<string> list_OfStringEnglish;
 	List<string> list_OfStringFrench;

 	float float_CurrentTime;

    string string_OneTranslation = "Goal";
    string string_TwoTranslation = "Goalition";
    string string_OneTranslationOperational = "Goal";
    string string_TwoTranslationOperational = "Goalition";


	List<int> list_IntCharToColorOne;
	List<int> list_IntCharToColorTwo;
    

	List<int> list_PositionCheck;


    // int int_PositionSelected = 0;
    // int int_PositionList = 0;


	// List<string> list_OfWordsAfterSuffle; 
	// List<int> list_OfIntOrderPair;


    // Vector3 updatedPositionOne = new Vector3(0.0f, 0.0f, 0.0f);
    // Vector3 coordinateBase = new Vector3(-7f, -1.75f, 0.0f);


    void Start()	
    {	

 		list_OfStringEnglish = new List<string>();
 		list_OfStringFrench = new List<string>();


		LoadStringList();

		
		// transformFocus = BoxFocus.GetComponent<Transform>();
		// scaleFocus = BoxFocus.GetComponent<Transform>().localScale;
		// positionFocus = BoxFocus.GetComponent<Transform>().position;
		// rotationFocus = BoxFocus.GetComponent<Transform>().rotation;
		// colliderFocus = BoxFocus.GetComponent<Collider>();
		// textMeshProFocus = TextFocus.GetComponent<TextMeshPro>();

		// list_OfGameObjectBackgroundShader = new List<GameObject>();

		// list_OfGameObjectBackgroundShader.Add(backgroundShader_0);
		// list_OfGameObjectBackgroundShader.Add(backgroundShader_1);
		// list_OfGameObjectBackgroundShader.Add(backgroundShader_2);
		// list_OfGameObjectBackgroundShader.Add(backgroundShader_3);
		// list_OfGameObjectBackgroundShader.Add(backgroundShader_4);
		// list_OfGameObjectBackgroundShader.Add(backgroundShader_5);



		// listOfTransformBackgroundShader = new List<Transform>();

		// Transform transforBackgroundShader_0 = backgroundShader_0.GetComponent<Transform>();
		// Transform transforBackgroundShader_1 = backgroundShader_1.GetComponent<Transform>();
		// Transform transforBackgroundShader_2 = backgroundShader_2.GetComponent<Transform>();
		// Transform transforBackgroundShader_3 = backgroundShader_3.GetComponent<Transform>();
		// Transform transforBackgroundShader_4 = backgroundShader_4.GetComponent<Transform>();
		// Transform transforBackgroundShader_5 = backgroundShader_5.GetComponent<Transform>();

		// listOfTransformBackgroundShader.Add(transforBackgroundShader_0);
		// listOfTransformBackgroundShader.Add(transforBackgroundShader_1);
		// listOfTransformBackgroundShader.Add(transforBackgroundShader_2);
		// listOfTransformBackgroundShader.Add(transforBackgroundShader_3);
		// listOfTransformBackgroundShader.Add(transforBackgroundShader_4);
		// listOfTransformBackgroundShader.Add(transforBackgroundShader_5);




	 	// 	listOfBoxGameObject_One = new List<GameObject>();
	
	 	// 	listOfBoxGameObject_One.Add(BoxOne_0);
	 	// 	listOfBoxGameObject_One.Add(BoxOne_1);
	 	// 	listOfBoxGameObject_One.Add(BoxOne_2);
	 	// 	listOfBoxGameObject_One.Add(BoxOne_3);
	 	// 	listOfBoxGameObject_One.Add(BoxOne_4);
	 	// 	listOfBoxGameObject_One.Add(BoxOne_5);




		// listOfTransform_One = new List<Transform>();

		// Transform transformOne_0 = BoxOne_0.GetComponent<Transform>();
		// Transform transformOne_1 = BoxOne_1.GetComponent<Transform>();
		// Transform transformOne_2 = BoxOne_2.GetComponent<Transform>();
		// Transform transformOne_3 = BoxOne_3.GetComponent<Transform>();
		// Transform transformOne_4 = BoxOne_4.GetComponent<Transform>();
		// Transform transformOne_5 = BoxOne_5.GetComponent<Transform>();

		// listOfTransform_One.Add(transformOne_0);
		// listOfTransform_One.Add(transformOne_1);
		// listOfTransform_One.Add(transformOne_2);
		// listOfTransform_One.Add(transformOne_3);
		// listOfTransform_One.Add(transformOne_4);
		// listOfTransform_One.Add(transformOne_5);



		
		// listOfPosition_One = new List<Vector3>();

		// Vector3 positionOne_0 = BoxOne_0.GetComponent<Transform>().position;
		// Vector3 positionOne_1 = BoxOne_1.GetComponent<Transform>().position;
		// Vector3 positionOne_2 = BoxOne_2.GetComponent<Transform>().position;
		// Vector3 positionOne_3 = BoxOne_3.GetComponent<Transform>().position;
		// Vector3 positionOne_4 = BoxOne_4.GetComponent<Transform>().position;
		// Vector3 positionOne_5 = BoxOne_5.GetComponent<Transform>().position;

		// listOfPosition_One.Add(positionOne_0);
		// listOfPosition_One.Add(positionOne_1);
		// listOfPosition_One.Add(positionOne_2);
		// listOfPosition_One.Add(positionOne_3);
		// listOfPosition_One.Add(positionOne_4);
		// listOfPosition_One.Add(positionOne_5);




		// listOfRotation_One = new List<Quaternion>();

		// Quaternion rotationOne_0 = BoxOne_0.GetComponent<Transform>().rotation;
		// Quaternion rotationOne_1 = BoxOne_1.GetComponent<Transform>().rotation;
		// Quaternion rotationOne_2 = BoxOne_2.GetComponent<Transform>().rotation;
		// Quaternion rotationOne_3 = BoxOne_3.GetComponent<Transform>().rotation;
		// Quaternion rotationOne_4 = BoxOne_4.GetComponent<Transform>().rotation;
		// Quaternion rotationOne_5 = BoxOne_5.GetComponent<Transform>().rotation;

		// listOfRotation_One.Add(rotationOne_0);
		// listOfRotation_One.Add(rotationOne_1);
		// listOfRotation_One.Add(rotationOne_2);
		// listOfRotation_One.Add(rotationOne_3);
		// listOfRotation_One.Add(rotationOne_4);
		// listOfRotation_One.Add(rotationOne_5);




		// listOfCollider_One = new List<Collider>();

        //    Collider colliderOne_0 = BoxOne_0.GetComponent<Collider>();
        //    Collider colliderOne_1 = BoxOne_1.GetComponent<Collider>();
        //    Collider colliderOne_2 = BoxOne_2.GetComponent<Collider>();
        //    Collider colliderOne_3 = BoxOne_3.GetComponent<Collider>();
        //    Collider colliderOne_4 = BoxOne_4.GetComponent<Collider>();
        //    Collider colliderOne_5 = BoxOne_5.GetComponent<Collider>();
        //    listOfCollider_One.Add(colliderOne_0);
        //    listOfCollider_One.Add(colliderOne_1);
        //    listOfCollider_One.Add(colliderOne_2);
        //    listOfCollider_One.Add(colliderOne_3);
        //    listOfCollider_One.Add(colliderOne_4);
        //    listOfCollider_One.Add(colliderOne_5);


  		//   list_OfTextMeshPro = new List<TextMeshPro>();


		TextMeshPro valuesOne_0 = TextOne_0.GetComponent<TextMeshPro>();
		TextMeshPro valuesOne_1 = TextOne_1.GetComponent<TextMeshPro>();


		// TextMeshPro valuesOne_2 = TextOne_2.GetComponent<TextMeshPro>();
		// TextMeshPro valuesOne_3 = TextOne_3.GetComponent<TextMeshPro>();
		// TextMeshPro valuesOne_4 = TextOne_4.GetComponent<TextMeshPro>();
		// TextMeshPro valuesOne_5 = TextOne_5.GetComponent<TextMeshPro>();


 
		var src = DateTime.Now;
		var hm = new DateTime(src.Year, src.Month, src.Day, src.Hour, src.Minute, src.Second);
		int hashRandom = (hm.Hour + hm.Year + hm.Month + hm.Day + hm.Minute + hm.Second);

		System.Random randomGeneratorNumber = new System.Random(hashRandom);
		int int_randomListPosition = randomGeneratorNumber.Next(0, list_OfStringEnglish.Count);
		string_OneTranslation = list_OfStringEnglish[int_randomListPosition];
		string_TwoTranslation = list_OfStringFrench[int_randomListPosition];
		
		// string_OneTranslation = "HelloBaby";
		// string_TwoTranslation = "BonjourBaby";
		
		int_LengthBothWords = string_OneTranslation.Length + string_TwoTranslation.Length;

		valuesOne_0.text = string_OneTranslation;
		valuesOne_1.text = string_TwoTranslation;

		string_OneTranslationOperational = string_OneTranslation;
		string_TwoTranslationOperational = string_TwoTranslation;

		list_OneTranslationOperational = new List<string>();
		list_TwoTranslationOperational = new List<string>(); 

		list_IntCharToColorOne = new List<int>(); 		
		list_IntCharToColorTwo = new List<int>();		


		for(int i = 0; i < string_OneTranslation.Length; i++)
		{
		
			list_OneTranslationOperational.Add(string_OneTranslation[i].ToString());
			list_IntCharToColorOne.Add(0);

		}

		for(int i = 0; i < string_TwoTranslation.Length; i++)
		{

			list_TwoTranslationOperational.Add(string_TwoTranslation[i].ToString());
			list_IntCharToColorTwo.Add(0);

		}


		
		// // string_TwoTranslation = list_OfStringFrench[int_randomListPosition];  


		// List<string> list_OfWordsCurrent = new List<string>();
		// list_PositionCheck = new List<int>();


		// // list_PositionCheck.Add(int_randomListPosition);
		// // string_OneTranslation = "OPERACIONESWOWMORE";//list_OfStringEnglish[int_randomListPosition];
		
		// list_OfWordsCurrent.Add(string_OneTranslation);
		// list_OfWordsCurrent.Add(string_TwoTranslation);


		// int_randomListPosition = randomGeneratorNumber.Next(0, list_OfStringEnglish.Count);
		// list_PositionCheck.Add(int_randomListPosition);
		
		// string_OneTranslation = list_OfStringEnglish[int_randomListPosition];
		// string_TwoTranslation = list_OfStringFrench[int_randomListPosition];
		// list_OfWordsCurrent.Add(string_OneTranslation);
		// list_OfWordsCurrent.Add(string_TwoTranslation);


		// int_randomListPosition = randomGeneratorNumber.Next(0, list_OfStringEnglish.Count);
		// list_PositionCheck.Add(int_randomListPosition);

		// string_OneTranslation = list_OfStringEnglish[int_randomListPosition];
		// string_TwoTranslation = list_OfStringFrench[int_randomListPosition];
		// list_OfWordsCurrent.Add(string_OneTranslation);
		// list_OfWordsCurrent.Add(string_TwoTranslation);


		// list_OfIntOrderPair = new List<int>();
		
		// list_OfIntOrderPair.Add(0);
		// list_OfIntOrderPair.Add(0);
		// list_OfIntOrderPair.Add(1);
		// list_OfIntOrderPair.Add(1);
		// list_OfIntOrderPair.Add(2);
		// list_OfIntOrderPair.Add(2);

		// list_OfIntOrderPair = GenerateRandomLoop(list_OfIntOrderPair);
		

		// list_OfWordsAfterSuffle = new List<string>();

		// list_OfWordsAfterSuffle.Add("");
		// list_OfWordsAfterSuffle.Add("");
		// list_OfWordsAfterSuffle.Add("");
		// list_OfWordsAfterSuffle.Add("");
		// list_OfWordsAfterSuffle.Add("");
		// list_OfWordsAfterSuffle.Add("");

		// int int_counterPair = 0;
		// int int_CounterDuality = 0;
		// int int_CounterFind = 0;


		// Debug.Log("CurrentWords");
		// Debug.Log("CurrentWords");
		// Debug.Log("CurrentWords");

		// foreach(string valueWord in list_OfWordsCurrent)
		// {
		// 	Debug.Log(valueWord);
		// }

		// Debug.Log("CurrentWords");
		// Debug.Log("CurrentWords");
		// Debug.Log("CurrentWords");
		
		// Debug.Log("CurrentIntOrder");
		// Debug.Log("CurrentIntOrder");
		// Debug.Log("CurrentIntOrder");

		// foreach(int valueInt in list_OfIntOrderPair)
		// {
		// 	Debug.Log(valueInt);
		// }
		// Debug.Log("CurrentIntOrder");
		// Debug.Log("CurrentIntOrder");
		// Debug.Log("CurrentIntOrder");
		



		// for(int i = 0; i < 3; i++)
		// {
			
		// 	for(int j = 0; j < list_OfIntOrderPair.Count; j++)
		// 	{
		// 		if(list_OfIntOrderPair[j] == i  && int_CounterFind == 0)
		// 		{
		// 			list_OfWordsAfterSuffle[j] = list_OfWordsCurrent[i * 2];  
		// 			int_CounterFind ++;
		// 			continue;
		// 		}

		// 		if(list_OfIntOrderPair[j] == i  && int_CounterFind == 1)
		// 		{
					
		// 			list_OfWordsAfterSuffle[j] = list_OfWordsCurrent[i * 2  + 1];  

		// 			int_CounterFind = 0;
		// 			break;
		// 		}

		// 	}

		// }


		// foreach(string valueWord in list_OfWordsAfterSuffle)
		// {

		// 	Debug.Log(valueWord);
		
		// }

		// // int_PositionList = randomGeneratorNumber.Next(0, list_PositionCheck.Count);


		// // int_PositionSelected = list_PositionCheck[int_PositionList];


		// Debug.Log("Int positionSelected");
		// Debug.Log(int_PositionSelected);
		// Debug.Log("Int positionSelected");



		// string_OneTranslation = list_OfStringEnglish[int_PositionSelected];		
		// string_TwoTranslation = list_OfStringFrench[int_PositionSelected];		

		// textMeshProFocus.text = string_TwoTranslation;

		// list_OfTextMeshPro.Add(valuesOne_0);
		// list_OfTextMeshPro.Add(valuesOne_1);
		// list_OfTextMeshPro.Add(valuesOne_2);
		// list_OfTextMeshPro.Add(valuesOne_3);
		// list_OfTextMeshPro.Add(valuesOne_4);
		// list_OfTextMeshPro.Add(valuesOne_5);
		
		// for (int i = 0; i < list_OfWordsAfterSuffle.Count; i++)
		// {
		// 	list_OfTextMeshPro[i].text = list_OfWordsAfterSuffle[i];
		// }


		float widthText_One   = valuesOne_0.preferredWidth;
		float heightText_One  = valuesOne_0.preferredHeight;


		backgroundShader_0.transform.localScale = GetScaleBackGroundShader(widthText_One, backgroundShader_0.transform.localScale); 	
		BoxOne_0.transform.localScale = GetScaleBackGround(widthText_One, BoxOne_0.transform.localScale);

		vector3_PositionStartBackground_0 = new Vector3(BoxOne_0.transform.position.x, BoxOne_0.transform.position.y, BoxOne_0.transform.position.z);

		backgroundShader_0.transform.position += GetPositionBackGround(widthText_One);
		BoxOne_0.transform.position += GetPositionBackGround(widthText_One);


		widthText_One   = valuesOne_1.preferredWidth;
		heightText_One  = valuesOne_1.preferredHeight;


		backgroundShader_1.transform.localScale = GetScaleBackGroundShader(widthText_One, backgroundShader_1.transform.localScale); 	
		BoxOne_1.transform.localScale = GetScaleBackGround(widthText_One, BoxOne_1.transform.localScale);

		vector3_PositionStartBackground_1 = new Vector3(BoxOne_1.transform.position.x, BoxOne_1.transform.position.y, BoxOne_1.transform.position.z);

		backgroundShader_1.transform.position += GetPositionBackGround(widthText_One);
		BoxOne_1.transform.position += GetPositionBackGround(widthText_One);


		int int_LengthOne = string_OneTranslation.Length;
		int int_LengthTwo = string_TwoTranslation.Length;


		// System.Random randomGeneratorNumber = new System.Random(hashRandom);


		// x = -8.65 min corners
		// x = 1.55  max corners
		// y = -2.74 min corners
		// y = 6.0  max corners


		// x = -8.15 min corners correctect / inner square;
		// x = 1.05  max corners correctect / inner square;
		// y = -2.54 min corners correctect  / inner square;
		// y = 5.5  max corners correctect / inner square;


		// x = 9.2;
		// y = 8.04;

		list_GameObjectInstanciated_0 = new List<GameObject>();
		list_GameObjectInstanciated_1 = new List<GameObject>();

		list_IntPositionMark_0 = new List<int>(); 
		list_IntPositionMark_1 = new List<int>(); 

		List<Vector3> list_Vector3Addition = new List<Vector3>();


		float float_randomPosition_x;
		float float_randomPosition_y;


		for(int i = 0; i < int_LengthOne; i++)
		{

			bool bool_Verifyaddition = true;
			
			Vector3 vector3_NewPositionInstance = new Vector3(0f, 0f, 0f);
	
			for(int j = 0; j < 100; j++)
			// while(bool_Verifyaddition)
			{

				float_randomPosition_x = 9.2f * (float)randomGeneratorNumber.NextDouble();
				float_randomPosition_y = 8.04f * (float)randomGeneratorNumber.NextDouble();
				
				vector3_NewPositionInstance = new Vector3(-6.15f + float_randomPosition_x, -2.54f + float_randomPosition_y,  10f);

				for(int n = 0; n < list_Vector3Addition.Count; n++)
				{

					Vector3 vector3_ValidatePosition = vector3_NewPositionInstance - list_Vector3Addition[n];

					if(vector3_ValidatePosition.magnitude < 1.0f)
					{
						break;

					}
			
					bool_Verifyaddition = false;

				}

				if(bool_Verifyaddition == false)
				{
					j = 100;
				}

			}
			

			list_Vector3Addition.Add(vector3_NewPositionInstance);



			GameObject gameobject_InstanceContainer = Instantiate(Container_0, Vector3.zero, Quaternion.identity);

			gameobject_InstanceContainer.name = "container_0_" + i.ToString();

			GameObject backgroundShaderObject = gameobject_InstanceContainer.transform.GetChild(0).gameObject;
			GameObject backgroundPlaneObject = gameobject_InstanceContainer.transform.GetChild(1).gameObject;
			GameObject textObject = gameobject_InstanceContainer.transform.GetChild(2).gameObject;


			backgroundShaderObject.GetComponent<Plane_Renderer_CharToWords_0>().bool_ActivePredefinedShader = true;

			backgroundPlaneObject.name = "containerPlane_0_" + i.ToString();
			backgroundPlaneObject.layer = 8;
			backgroundPlaneObject.AddComponent<Rigidbody>();
			backgroundPlaneObject.GetComponent<Rigidbody>().useGravity = false;
    		LayerMask elementLayer = LayerMask.NameToLayer("Arrow");
    		// Debug.Log(elementLayer.value);

			backgroundPlaneObject.GetComponent<BoxCollider>().excludeLayers = (int) Math.Pow(2, elementLayer.value);


			gameobject_InstanceContainer.transform.position = new Vector3(vector3_NewPositionInstance.x, vector3_NewPositionInstance.y, vector3_NewPositionInstance.z); 


			TextMeshPro textMeshObject = textObject.GetComponent<TextMeshPro>();


			textMeshObject.text = string_OneTranslation[i].ToString();

			widthText_One   = textMeshObject.preferredWidth;
			heightText_One  = textMeshObject.preferredHeight;


			backgroundShaderObject.transform.localScale =  GetScaleBackGroundShader(widthText_One * 1.5f, backgroundShaderObject.transform.localScale); 	
			backgroundPlaneObject.transform.localScale  =        GetScaleBackGround(widthText_One * 1.5f, backgroundPlaneObject.transform.localScale);

			// vector3_PositionStartBackground_0 //= new Vector3(backgroundPlaneObject.transform.position.x, backgroundPlaneObject.transform.position.y, backgroundPlaneObject.transform.position.z);

			backgroundShaderObject.transform.position -= GetPositionBackGround(valuesOne_0.preferredWidth);
			backgroundPlaneObject.transform.position  -= GetPositionBackGround(valuesOne_0.preferredWidth);

			backgroundShaderObject.transform.position += GetPositionBackGround(widthText_One);
			backgroundPlaneObject.transform.position  += GetPositionBackGround(widthText_One);

			backgroundPlaneObject.GetComponent<CollisionScriptCode>().enabled = true;



			list_GameObjectInstanciated_0.Add(gameobject_InstanceContainer);
			list_IntPositionMark_0.Add(0);

		}



		for(int i = 0; i < int_LengthTwo; i++)
		{

			bool bool_Verifyaddition = true;
			
			Vector3 vector3_NewPositionInstance = new Vector3(0f, 0f, 0f);
	
			// while(bool_Verifyaddition)
			for(int j = 0; j < 100; j++)
			{

				float_randomPosition_x = 9.2f * (float)randomGeneratorNumber.NextDouble();
				float_randomPosition_y = 8.04f * (float)randomGeneratorNumber.NextDouble();
				
				vector3_NewPositionInstance = new Vector3(-6.15f + float_randomPosition_x, -2.54f + float_randomPosition_y,  10f);


				// foreach(Vector3 vector3_PositionsAdded in list_Vector3Addition)
				// {

				// 	Vector3 vector3_ValidatePosition = vector3_NewPositionInstance - vector3_PositionsAdded;

				for(int n = 0; n < list_Vector3Addition.Count; n++)
				{

					Vector3 vector3_ValidatePosition = vector3_NewPositionInstance - list_Vector3Addition[n];

					if(vector3_ValidatePosition.magnitude < 1.0f)
					{
						break;

					}
			
					bool_Verifyaddition = false;

				}

				if(bool_Verifyaddition == false)
				{
					j = 100;
				}

			}

			
			list_Vector3Addition.Add(vector3_NewPositionInstance);



			GameObject gameobject_InstanceContainer = Instantiate(Container_1, Vector3.zero, Quaternion.identity);

			gameobject_InstanceContainer.name = "container_1_" + i.ToString();

			GameObject backgroundShaderObject = gameobject_InstanceContainer.transform.GetChild(0).gameObject;
			GameObject backgroundPlaneObject = gameobject_InstanceContainer.transform.GetChild(1).gameObject;
			GameObject textObject = gameobject_InstanceContainer.transform.GetChild(2).gameObject;

			backgroundShaderObject.GetComponent<Plane_Renderer_CharToWords_1>().bool_ActivePredefinedShader = true;

			backgroundPlaneObject.name = "containerPlane_0_" + i.ToString();
			backgroundPlaneObject.layer = 8;
			backgroundPlaneObject.AddComponent<Rigidbody>();
			backgroundPlaneObject.GetComponent<Rigidbody>().useGravity = false;
    		LayerMask elementLayer = LayerMask.NameToLayer("Arrow");
    		// Debug.Log(elementLayer.value);

			backgroundPlaneObject.GetComponent<BoxCollider>().excludeLayers = (int) Math.Pow(2, elementLayer.value);



			gameobject_InstanceContainer.transform.position = new Vector3(vector3_NewPositionInstance.x, vector3_NewPositionInstance.y, vector3_NewPositionInstance.z); 


			// GameObject gameobject_InstanceContainer = Instantiate(Container_1, vector3_NewPositionInstance, Quaternion.identity);

			// gameobject_InstanceContainer.name = "container_1_" + i.ToString();		

			// GameObject backgroundShaderObject = gameobject_InstanceContainer.transform.GetChild(0).gameObject;
			// GameObject backgroundPlaneObject = gameobject_InstanceContainer.transform.GetChild(1).gameObject;
			// GameObject textObject = gameobject_InstanceContainer.transform.GetChild(2).gameObject;

			TextMeshPro textMeshObject = textObject.GetComponent<TextMeshPro>();

			textMeshObject.text = string_TwoTranslation[i].ToString();

			widthText_One   = textMeshObject.preferredWidth;
			heightText_One  = textMeshObject.preferredHeight;


			backgroundShaderObject.transform.localScale =  GetScaleBackGroundShader(widthText_One * 1.5f, backgroundShaderObject.transform.localScale); 	
			backgroundPlaneObject.transform.localScale  =        GetScaleBackGround(widthText_One * 1.5f, backgroundPlaneObject.transform.localScale);

			// vector3_PositionStartBackground_0 //= new Vector3(backgroundPlaneObject.transform.position.x, backgroundPlaneObject.transform.position.y, backgroundPlaneObject.transform.position.z);


			backgroundShaderObject.transform.position -= GetPositionBackGround(valuesOne_1.preferredWidth);
			backgroundPlaneObject.transform.position  -= GetPositionBackGround(valuesOne_1.preferredWidth);

			backgroundShaderObject.transform.position += GetPositionBackGround(widthText_One);
			backgroundPlaneObject.transform.position  += GetPositionBackGround(widthText_One);

			backgroundPlaneObject.GetComponent<CollisionScriptCode>().enabled = true;

			// backgroundPlaneObject.GetComponent<Rigidbody>().useGravity = false;

			// Debug.Log(gameobject_InstanceContainer.transform.GetChild(1).gameObject);


			list_GameObjectInstanciated_1.Add(gameobject_InstanceContainer);
			list_IntPositionMark_1.Add(0);

		}



		// foreach(GameObject valueObject in list_OfGameObjectBackgroundShader)
		// {
		// 	valueObject.SetActive(false);
		// }


		// foreach(int valueList in list_OfIntOrderPair)
		// {
			
		// 	Debug.Log(valueList);

		// }


		// foreach(int valueList in list_OfIntOrderPair)
		// {
			
		// 	Debug.Log(valueList);

		// }

    }

	
	List<int> GenerateRandomLoop(List<int> listToShuffle)
	{


		var src = DateTime.Now;
		var hm = new DateTime(src.Year, src.Month, src.Day, src.Hour, src.Minute, src.Second);

		int hashRandom = (hm.Hour + hm.Year + hm.Month + hm.Day + hm.Minute + hm.Second);

		
		System.Random _rand = new System.Random(95397 + hashRandom);


	    for (int i = listToShuffle.Count - 1; i > 0; i--)
	    {
	        var k = _rand.Next(i + 1);
	        var valueList = listToShuffle[k];
	        listToShuffle[k] = listToShuffle[i];
	        listToShuffle[i] = valueList;
	    }
	    return listToShuffle;
	}


    Vector3 GetScaleBackGroundShader(float width, Vector3 Current)
    {
		float scale = (width * 0.047f)/1.15f ;
    	Vector3 valueOut = new Vector3(scale, Current.y, Current.z);
  
    	return valueOut;
    }


    Vector3 GetScaleBackGround(float width, Vector3 Current)
    {
		float scale = (width * 0.035f)/1.15f ;
    	Vector3 valueOut = new Vector3(scale, Current.y, Current.z);
  
    	return valueOut;
    }


    Vector3 GetPositionBackGround(float width)
    {


		float position = (width * 0.16f)/1.15f ; 
    	Vector3 valueOut = new Vector3(position, 0.0f, 0.0f);
  
    	return valueOut;
    	// return position;
    }





    void LoadStringList()
    {	


		TextAsset asset = (TextAsset)Resources.Load("WordListEnglish");
		string string_FileLines = asset.ToString();

		string[] lines = string_FileLines.Split(
	    // new string[] { "\r\n", "\r", "\n" },
	    new string[] { "\r\n" },
	    StringSplitOptions.None
		);

		for(int i = 0; i < lines.Length; i++)
		{
			// Debug.Log(lines[i] + "  " + lines[i].Length.ToString());
			list_OfStringEnglish.Add(lines[i]);

		}


		asset = (TextAsset)Resources.Load("WordListFrench");
		string_FileLines = asset.ToString();

		string[] lines2 = string_FileLines.Split(
	    // new string[] { "\r\n", "\r", "\n" },
	    new string[] { "\r\n" },
	    StringSplitOptions.None
		);

		for(int i = 0; i < lines2.Length; i++)
		{
			// Debug.Log(lines2[i] + "  " + (lines2[i].Length).ToString());
			list_OfStringFrench.Add(lines2[i]);
		
		}


    }





    void ColorCurrentTextWordOne(List<int> list_CharToColor)
    { 

		TMP_Text m_TextComponent = TextOne_0.GetComponent<TMP_Text>();


		m_TextComponent.ForceMeshUpdate();

        TMP_TextInfo textInfo = m_TextComponent.textInfo;


        for(int i = 0; i < list_CharToColor.Count; i++)
        {

			if(list_CharToColor[i] == 1)
			{

		        int currentCharacter = i;
		        
		        int characterCount = textInfo.characterCount;
		
		        Color32[] newVertexColors;
		        Color32 c0 = m_TextComponent.color;
		
		        int materialIndex = textInfo.characterInfo[currentCharacter].materialReferenceIndex;
		        newVertexColors = textInfo.meshInfo[materialIndex].colors32;
		        int vertexIndex = textInfo.characterInfo[currentCharacter].vertexIndex;
		
	
		
		        if (textInfo.characterInfo[currentCharacter].isVisible)
		        {
		            c0 = new Color32((byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), 255);
		            newVertexColors[vertexIndex + 0] = c0;
		            newVertexColors[vertexIndex + 1] = c0;
		            newVertexColors[vertexIndex + 2] = c0;
		            newVertexColors[vertexIndex + 3] = c0;
		            // New function which pushes (all) updated vertex data to the appropriate meshes when using either the Mesh Renderer or CanvasRenderer.
		            m_TextComponent.UpdateVertexData(TMP_VertexDataUpdateFlags.Colors32);
		            // This last process could be done to only update the vertex data that has changed as opposed to all of the vertex data but it would require extra steps and knowing what type of renderer is used.
		            // These extra steps would be a performance optimization but it is unlikely that such optimization will be necessary.
		        }

			}

			else
			{

		        int currentCharacter = i;
		        
		        int characterCount = textInfo.characterCount;
		
		        Color32[] newVertexColors;
		        Color32 c0 = m_TextComponent.color;
		
		        int materialIndex = textInfo.characterInfo[currentCharacter].materialReferenceIndex;
		        newVertexColors = textInfo.meshInfo[materialIndex].colors32;
		        int vertexIndex = textInfo.characterInfo[currentCharacter].vertexIndex;
		
	
		
		        if (textInfo.characterInfo[currentCharacter].isVisible)
		        {
		            c0 = new Color32(0, 0, 0, 0);
		            newVertexColors[vertexIndex + 0] = c0;
		            newVertexColors[vertexIndex + 1] = c0;
		            newVertexColors[vertexIndex + 2] = c0;
		            newVertexColors[vertexIndex + 3] = c0;
		            // New function which pushes (all) updated vertex data to the appropriate meshes when using either the Mesh Renderer or CanvasRenderer.
		            m_TextComponent.UpdateVertexData(TMP_VertexDataUpdateFlags.Colors32);
		            // This last process could be done to only update the vertex data that has changed as opposed to all of the vertex data but it would require extra steps and knowing what type of renderer is used.
		            // These extra steps would be a performance optimization but it is unlikely that such optimization will be necessary.
		        }

			}




	    }
		
	}

    void ColorCurrentTextWordTwo(List<int> list_CharToColor)
    { 

		TMP_Text m_TextComponent = TextOne_1.GetComponent<TMP_Text>();


		m_TextComponent.ForceMeshUpdate();

        TMP_TextInfo textInfo = m_TextComponent.textInfo;


        for(int i = 0; i < list_CharToColor.Count; i++)
        {

			if(list_CharToColor[i] == 1)
			{

		        int currentCharacter = i;
		        
		        int characterCount = textInfo.characterCount;
		
		        Color32[] newVertexColors;
		        Color32 c0 = m_TextComponent.color;
		
		        int materialIndex = textInfo.characterInfo[currentCharacter].materialReferenceIndex;
		        newVertexColors = textInfo.meshInfo[materialIndex].colors32;
		        int vertexIndex = textInfo.characterInfo[currentCharacter].vertexIndex;
		
	
		
		        if (textInfo.characterInfo[currentCharacter].isVisible)
		        {
		            c0 = new Color32((byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), 255);
		            newVertexColors[vertexIndex + 0] = c0;
		            newVertexColors[vertexIndex + 1] = c0;
		            newVertexColors[vertexIndex + 2] = c0;
		            newVertexColors[vertexIndex + 3] = c0;
		            // New function which pushes (all) updated vertex data to the appropriate meshes when using either the Mesh Renderer or CanvasRenderer.
		            m_TextComponent.UpdateVertexData(TMP_VertexDataUpdateFlags.Colors32);
		            // This last process could be done to only update the vertex data that has changed as opposed to all of the vertex data but it would require extra steps and knowing what type of renderer is used.
		            // These extra steps would be a performance optimization but it is unlikely that such optimization will be necessary.
		        }

			}

			else
			{

		        int currentCharacter = i;
		        
		        int characterCount = textInfo.characterCount;
		
		        Color32[] newVertexColors;
		        Color32 c0 = m_TextComponent.color;
		
		        int materialIndex = textInfo.characterInfo[currentCharacter].materialReferenceIndex;
		        newVertexColors = textInfo.meshInfo[materialIndex].colors32;
		        int vertexIndex = textInfo.characterInfo[currentCharacter].vertexIndex;
		
	
		
		        if (textInfo.characterInfo[currentCharacter].isVisible)
		        {
		            c0 = new Color32(0, 0, 0, 0);
		            newVertexColors[vertexIndex + 0] = c0;
		            newVertexColors[vertexIndex + 1] = c0;
		            newVertexColors[vertexIndex + 2] = c0;
		            newVertexColors[vertexIndex + 3] = c0;
		            // New function which pushes (all) updated vertex data to the appropriate meshes when using either the Mesh Renderer or CanvasRenderer.
		            m_TextComponent.UpdateVertexData(TMP_VertexDataUpdateFlags.Colors32);
		            // This last process could be done to only update the vertex data that has changed as opposed to all of the vertex data but it would require extra steps and knowing what type of renderer is used.
		            // These extra steps would be a performance optimization but it is unlikely that such optimization will be necessary.
		        }

			}




	    }
		
	}




  //   void ColorCurrentTextList(int currentList, int numberOfCharacters)
  //   { 



		// TMP_Text m_TextComponent = list_OfTextMeshPro[currentList].GetComponent<TMP_Text>();

		// m_TextComponent.ForceMeshUpdate();


  //       TMP_TextInfo textInfo = m_TextComponent.textInfo;

  //       if(numberOfCharacters > 0)
  //       {

	 //        for(int i = 0; i < numberOfCharacters; i++)
	 //        {
		
		//         int currentCharacter = i;
		        
		//         int characterCount = textInfo.characterCount;
		
		//         Color32[] newVertexColors;
		//         Color32 c0 = m_TextComponent.color;
		
		//         int materialIndex = textInfo.characterInfo[currentCharacter].materialReferenceIndex;
		//         newVertexColors = textInfo.meshInfo[materialIndex].colors32;
		//         int vertexIndex = textInfo.characterInfo[currentCharacter].vertexIndex;
		
		
		
		//         if (textInfo.characterInfo[currentCharacter].isVisible)
		//         {
		//             c0 = new Color32((byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), 255);
		//             newVertexColors[vertexIndex + 0] = c0;
		//             newVertexColors[vertexIndex + 1] = c0;
		//             newVertexColors[vertexIndex + 2] = c0;
		//             newVertexColors[vertexIndex + 3] = c0;
		//             // New function which pushes (all) updated vertex data to the appropriate meshes when using either the Mesh Renderer or CanvasRenderer.
		//             m_TextComponent.UpdateVertexData(TMP_VertexDataUpdateFlags.Colors32);
		//             // This last process could be done to only update the vertex data that has changed as opposed to all of the vertex data but it would require extra steps and knowing what type of renderer is used.
		//             // These extra steps would be a performance optimization but it is unlikely that such optimization will be necessary.
		//         }
	
		//     }

  //       }


  //       if(numberOfCharacters == 0)
  //       {

	 //        for(int i = 0; i < numberOfCharacters; i++)
	 //        {
		
		//         int currentCharacter = i;
		        
		//         int characterCount = textInfo.characterCount;
		
		//         Color32[] newVertexColors;
		//         Color32 c0 = m_TextComponent.color;
		
		//         int materialIndex = textInfo.characterInfo[currentCharacter].materialReferenceIndex;
		//         newVertexColors = textInfo.meshInfo[materialIndex].colors32;
		//         int vertexIndex = textInfo.characterInfo[currentCharacter].vertexIndex;
		
		
		//         if (textInfo.characterInfo[currentCharacter].isVisible)
		//         {
		//             c0 = new Color32((byte)255, (byte)255, (byte)255, 255);
		//             newVertexColors[vertexIndex + 0] = c0;
		//             newVertexColors[vertexIndex + 1] = c0;
		//             newVertexColors[vertexIndex + 2] = c0;
		//             newVertexColors[vertexIndex + 3] = c0;
		//             // New function which pushes (all) updated vertex data to the appropriate meshes when using either the Mesh Renderer or CanvasRenderer.
		//             m_TextComponent.UpdateVertexData(TMP_VertexDataUpdateFlags.Colors32);
		//             // This last process could be done to only update the vertex data that has changed as opposed to all of the vertex data but it would require extra steps and knowing what type of renderer is used.
		//             // These extra steps would be a performance optimization but it is unlikely that such optimization will be necessary.
		//         }
	
		//     }

		// }

  //   }


  //   string GetCurrentEqualityWord(int currentFindPosition)
  //   {
  //   	int currentNumber = list_OfIntOrderPair[currentFindPosition];

  //   	string valuePairWord = "";

  //   	for(int i = 0; i < list_OfIntOrderPair.Count;i++)
  //   	{
  //   		if(i == currentFindPosition)
  //   		{
  //   			continue;
  //   		}
  //   		if(list_OfIntOrderPair[i] == currentNumber)
  //   		{
  //   			valuePairWord = list_OfWordsAfterSuffle[i];
  //   			break;
  //   		}
  //   	}

  //   	return valuePairWord;
  //   }


  //   int GetCurrentPositionEqualityWord(int currentFindPosition)
  //   {
  //   	int currentNumber = list_OfIntOrderPair[currentFindPosition];

  //   	int valuePairWord = 0;

  //   	for(int i = 0; i < list_OfIntOrderPair.Count;i++)
  //   	{
  //   		if(i == currentFindPosition)
  //   		{
  //   			continue;
  //   		}
  //   		if(list_OfIntOrderPair[i] == currentNumber)
  //   		{
  //   			valuePairWord = i;
  //   			break;
  //   		}
  //   	}

  //   	return valuePairWord;
  //   }


    int int_CounterCorrectPairWords = 0;

    int int_CounterTranslation = 1;

    int int_CounterPositionListWords = 0;

    bool bool_FirstString = true;
	bool bool_SecondString = true;

    bool bool_CheckString = false;

    int int_PositionContainerFound_0 = -1; 

    int int_PositionContainerFound_1 = -1; 
    
    bool bool_AnswerFound = false;

    bool bool_ResetListOfWords = false;


    string string_FromInputField = "";

    int counterColoredCharacters = 0;

    string string_EvaluationColor = "";


    bool bool_ActiveCamaraShake = false;
    
    float float_evaluationTime = 0.0f;
	
	int int_CounterCollisionChar = 0;
	int int_LengthBothWords = 0;


    bool tab_press = false;

    int counter_tab = 0;



	int int_FirstCorrectWordLength = 0;

    List<int> list_IntColored = new List<int>{0, 0, 0, 0, 0, 0};




	public int GetMaxColored(List<int> list)
	{
	 
	    int maxAge = 0;
	    foreach (int valueList in list)
	    {
	        if (valueList > maxAge)
	        {
	            maxAge = valueList;
	        }
	    }
	    return maxAge;
	}



    void Update()
    {



    	if(Input.GetKeyDown(KeyCode.F1))
    	{
			SceneManager.LoadScene (sceneBuildIndex:0);

    	}


    	if(Input.GetKeyDown(KeyCode.F2))
    	{
			SceneManager.LoadScene (sceneBuildIndex:1);

    	}


    	if(Input.GetKeyDown(KeyCode.F3))
    	{
			SceneManager.LoadScene (sceneBuildIndex:2);

    	}

    	if(Input.GetKeyDown(KeyCode.F4))
    	{
			SceneManager.LoadScene (sceneBuildIndex:3);

    	}


    	if(Input.GetKeyDown(KeyCode.F5))
    	{
			SceneManager.LoadScene (sceneBuildIndex:4);

    	}






   //  	if(Input.GetKeyDown(KeyCode.Tab))
   //  	{

   //  		tab_press = true;
   //  		counter_tab ++;
   //  	}


   //  	if(counter_tab%2 == 0 && tab_press == true)
   //  	{

   //  		tab_press = false;

			// string_OneTranslation = list_OfStringEnglish[int_PositionSelected];		
			// string_TwoTranslation = list_OfStringFrench[int_PositionSelected];		
	
			// textMeshProFocus.text = string_TwoTranslation;
	


   //  		for(int i = 0; i < list_OfTextMeshPro.Count; i++)
   //  		{
   //  			list_OfTextMeshPro[i].text = list_OfStringEnglish[list_PositionCheck[i]];
   //  		}


	
			// float widthText_One = textMeshProFocus.preferredWidth;
			// float heightText_One  = textMeshProFocus.preferredHeight;
	
			// // Transform transform_BackOne = BackGroundOne_0.transform;
			// // TextFocus.transform.position = transformFocus.position;

			// transformFocus.position = basePositionBox;

			// transformFocus.localScale = GetScaleBackGround(widthText_One, transformFocus.localScale);
	
	
			// updatedPositionOne = GetPositionBackGround(widthText_One);
	
			// transformFocus.position +=  updatedPositionOne;
	
	
			// BoxFocus.transform.position = transformFocus.position;


   //  	}

   //  	if(counter_tab%2 == 1 && tab_press == true)
   //  	{

   //  		tab_press = false;

			// string_OneTranslation = list_OfStringFrench[int_PositionSelected];		
			// string_TwoTranslation = list_OfStringEnglish[int_PositionSelected];		
	
			// textMeshProFocus.text = string_TwoTranslation;
	

   //  		for(int i = 0; i < list_OfTextMeshPro.Count; i++)
   //  		{
   //  			list_OfTextMeshPro[i].text = list_OfStringFrench[list_PositionCheck[i]];
   //  		}


			// float widthText_One = textMeshProFocus.preferredWidth;
			// float heightText_One  = textMeshProFocus.preferredHeight;
	
			// // Transform transform_BackOne = BackGroundOne_0.transform;
			// // TextFocus.transform.position = transformFocus.position;

			// transformFocus.position = basePositionBox;

			// transformFocus.localScale = GetScaleBackGround(widthText_One, transformFocus.localScale);
	
	
			// updatedPositionOne = GetPositionBackGround(widthText_One);
	
			// transformFocus.position +=  updatedPositionOne;
	
	
			// BoxFocus.transform.position = transformFocus.position;

   //  	}




    	// print("DebugLogColor");
    	// print("DebugLogColor");
    	// Debug.Log(string_EvaluationColor);
    	// print("DebugLogColor");
    	// print("DebugLogColor");

    	
  //   	string_EvaluationColor = LinkCommunicationColoredClass.string_InputField;

  //   	counterColoredCharacters = 0;


  //   	// if(int_CounterTranslation  == 0)
  //   	// {
				
	 //    // 	string string_EvaluationEqualityColor = string_TwoTranslation;
	
			
	 //    // 	for(int i = 0; i < string_EvaluationColor.Length; i++)
	 //    // 	{
		
		//    //  	if(string_EvaluationColor.Length > string_EvaluationEqualityColor.Length)
		//    //  	{
		//    //  		break;
		//    //  	}
		
	 //    // 		char color = string_EvaluationColor[i]; 
	 //    // 		char currentString = string_EvaluationEqualityColor[i];
	
	 //    // 		// if(string_EvaluationColor[i] == string_OneTranslation[i])
		//    //  	if(color == currentString)
	 //    // 		{
	 //    // 			counterColoredCharacters++;
	 //    // 		}
	 //    // 		else
	 //    // 		{
	 //    // 			break;
	 //    // 		}
	
	 //    // 	}
    	
  //   	// 	ColorCurrentTextSingleWord(counterColoredCharacters);
    
  //   	// }




  //   	if(int_CounterTranslation == 1)
  // 		{


  // 			for(int iUp = 0; iUp < list_OfTextMeshPro.Count; iUp++)
  // 			{

  // 				counterColoredCharacters = 0;

		//     	string string_EvaluationEqualityColor = list_OfTextMeshPro[iUp].text;

				

		//     	for(int i = 0; i < string_EvaluationColor.Length; i++)
		//     	{

		// 	    	if(string_EvaluationColor.Length > string_EvaluationEqualityColor.Length)
		// 	    	{
		// 	    		break;
		// 	    	}
		    
		//     		char color = string_EvaluationColor[i]; 
		//     		char currentString = string_EvaluationEqualityColor[i];
		
		//     		// if(string_EvaluationColor[i] == string_OneTranslation[i])
		// 	    	if(color == currentString)
		//     		{
		//     			counterColoredCharacters++;
		//     			list_IntColored[iUp] = counterColoredCharacters;
		//     		}
		//     		else
		//     		{
		//     			break;
		//     		}
		
		//     	}
  	
  // 			}


  // 			List<int> valuesCharacters = new List<int>();
  // 			int MaxIntColored = GetMaxColored(list_IntColored);

  // 			counterColoredCharacters = 0;

  // 			for(int i = 0; i < list_IntColored.Count; i++)
  // 			{
  // 				if(MaxIntColored > list_IntColored[i])
  // 				{
  // 					counterColoredCharacters = 0;
  //   				ColorCurrentTextList(i, counterColoredCharacters);
  // 				}
  // 				else
  // 				{

  // 					counterColoredCharacters = list_IntColored[i];
  // 					ColorCurrentTextList(i, counterColoredCharacters);	
  // 				}

  // 			}

 	// 	}  	

		
		// list_IntColored = new List<int>{0, 0, 0, 0, 0, 0};



		// if(bool_ListWords)
		// {

		// 	ColorCurrentTextList(int_CounterPositionListWords, int_FirstCorrectWordLength);
		
		// }


  //   	if(bool_CheckString == true)
  //   	{

  //   		bool_CheckString = false;

  //   		bool_ActiveCamaraShake = true;


  //   		if(bool_ToCheckWord == true)
  //   		{


		// 		for(int i = 0; i < list_OfWordsAfterSuffle.Count; i++)
		// 		{

		// 			string string_EvaluationEquality = list_OfWordsAfterSuffle[i];


	 //    			if(string_FromInputField == string_EvaluationEquality && list_OfTextMeshPro[i].text != "")
	 //    			{


		// 				CommunicationCorrectAnswerClass.bool_ActiveCorrectAnswerShader = true;
						
		// 				int_FirstCorrectWordLength = string_EvaluationEquality.Length;


		// 				list_OfGameObjectBackgroundShader[i].SetActive(true);
	 //    				int_CounterPositionListWords = i;
		//     			bool_ToCheckWord = false;
						
		// 				bool_ListWords = true;
						
	 //    				bool_ActiveCamaraShake = false;
	
		// 				break;
	
	 //    			}
	
		// 		}

  //   		}


		// 	if(bool_ListWords == true)
		// 	{


		// 		string string_EvaluationEquality = GetCurrentEqualityWord(int_CounterPositionListWords);

  //   			if(string_FromInputField == string_EvaluationEquality)
  //   			{
	
  //   				// CommunicationMotionClass.SetSplineTrue(int_PositionList); 

		// 			CommunicationCorrectAnswerClass.bool_ActiveCorrectAnswerShader = true;
    				

  //   				list_OfTextMeshPro[GetCurrentPositionEqualityWord(int_CounterPositionListWords)].text = "";
		// 			list_OfTextMeshPro[int_CounterPositionListWords].text = "";

		// 			list_OfGameObjectBackgroundShader[GetCurrentPositionEqualityWord(int_CounterPositionListWords)].SetActive(true);
	    			
	 //    			int_CounterPositionListWords = 0;
	 //    			int_FirstCorrectWordLength = 0;

	 //    			bool_ToCheckWord = true;

	 //    			bool_ListWords = false;

	 //    			int_CounterCorrectPairWords++;
	 //    			// bool_ToCheckWord = true;
					
		// 			// bool_ListWords = false;
	 //    			// int_CounterTranslation ++;

  //   				bool_ActiveCamaraShake = false;

  //   			}


		// 	}

  //           LinkCommunicationColoredClass.string_InputField = "";

  //           CommunicationCamaraShakeClass.bool_ActiveCamaraShake = bool_ActiveCamaraShake;
  //           CommunicationCamaraShakeClass.bool_ActiveCamaraShakeShader = bool_ActiveCamaraShake;

  //   	}

  //   	if(int_CounterCorrectPairWords == 3)
  //   	{

		// 	bool_ResetListOfWords = true;
		// 	int_CounterCorrectPairWords = 0;
  //   	}

    	ColorCurrentTextWordOne(list_IntCharToColorOne);
    	ColorCurrentTextWordTwo(list_IntCharToColorTwo);


    	if(bool_CheckString)
    	{

    		bool_CheckString = false;

    		bool_ActiveCamaraShake = true;

    		bool_SecondString = true;

    		if(string_FromInputField.Length == 1)
    		{

    			int int_LastIndexCurrent = string_OneTranslationOperational.LastIndexOf(string_FromInputField); 


				if(int_LastIndexCurrent != -1)
				{

					for(int i = 0; i < list_OneTranslationOperational.Count; i++)
					{


						if(list_IntPositionMark_0[i] == -1)
						{
							continue;
						}

						// string string_comparation = list_GameObjectInstanciated_0[i].transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text;
						string string_comparation = list_OneTranslationOperational[i];



						if(string_comparation == string_FromInputField)
						{

							list_GameObjectInstanciated_0[i].transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = "";
							list_IntPositionMark_0[i] = -1;
							list_IntCharToColorOne[i] = 1;
							string_OneTranslationOperational = string_OneTranslationOperational.Remove(int_LastIndexCurrent, 1);

							bool_SecondString = false;

							bool_AnswerFound = true;
							int_PositionContainerFound_0 = i;

							break;

						}

					}
					
				}


    			int_LastIndexCurrent = string_TwoTranslationOperational.LastIndexOf(string_FromInputField); 



				if(bool_SecondString == true && int_LastIndexCurrent != -1)
				{

					for(int i = 0; i < list_TwoTranslationOperational.Count; i++)
					{

						if(list_IntPositionMark_1[i] == -1)
						{
							continue;
						}


						string string_comparation = list_TwoTranslationOperational[i];


						if(string_comparation == string_FromInputField)
						{

							list_GameObjectInstanciated_1[i].transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = "";
							list_IntPositionMark_1[i] = -1;
							list_IntCharToColorTwo[i] = 1;

							string_TwoTranslationOperational = string_TwoTranslationOperational.Remove(int_LastIndexCurrent, 1);
							
							bool_SecondString = false;

							bool_AnswerFound = true;
							int_PositionContainerFound_1 = i;

							break;

						}

					}

				}

    		}

    	}


    	if(bool_AnswerFound == true)
    	{
    		bool_AnswerFound = false;

    		if(int_PositionContainerFound_0 >= 0)
    		{


    			Vector3 vector3_operational_0 = new Vector3(list_GameObjectInstanciated_0[int_PositionContainerFound_0].transform.GetChild(0).gameObject.transform.position.x, list_GameObjectInstanciated_0[int_PositionContainerFound_0].transform.position.y, list_GameObjectInstanciated_0[int_PositionContainerFound_0].transform.position.z);
    			list_GameObjectInstanciated_0[int_PositionContainerFound_0].transform.position = vector3_operational_0;



				// Vector3 vector3_operational = list_GameObjectInstanciated_0[int_PositionContainerFound_0].transform.GetChild(0).gameObject.transform.position;

				list_GameObjectInstanciated_0[int_PositionContainerFound_0].transform.GetChild(0).gameObject.transform.position = vector3_operational_0;//new Vector3(0.0f, vector3_operational.y, vector3_operational.z);
				list_GameObjectInstanciated_0[int_PositionContainerFound_0].transform.GetChild(1).gameObject.transform.position = vector3_operational_0;//new Vector3( 	0.0f, vector3_operational.y, vector3_operational.z);


    			CommunicationBezierCharToWords.string_NameObjectMessage = list_GameObjectInstanciated_0[int_PositionContainerFound_0].name;
    			CommunicationBezierCharToWords.bool_ActiveMotionMessage = true;
				CommunicationBezierCharToWords.int_OneOrTwoMessage = 1;

    			int_PositionContainerFound_0 = -1;
    		
    		}

    		if(int_PositionContainerFound_1 >= 0)
    		{

    			Vector3 vector3_operational_1 = new Vector3(list_GameObjectInstanciated_1[int_PositionContainerFound_1].transform.GetChild(0).gameObject.transform.position.x, list_GameObjectInstanciated_1[int_PositionContainerFound_1].transform.position.y, list_GameObjectInstanciated_1[int_PositionContainerFound_1].transform.position.z);
    			list_GameObjectInstanciated_1[int_PositionContainerFound_1].transform.position = vector3_operational_1;



				// Vector3 vector3_operational = list_GameObjectInstanciated_0[int_PositionContainerFound_1].transform.GetChild(0).gameObject.transform.position;

				list_GameObjectInstanciated_1[int_PositionContainerFound_1].transform.GetChild(0).gameObject.transform.position = vector3_operational_1;//new Vector3(0.0f, vector3_operational.y, vector3_operational.z);
				list_GameObjectInstanciated_1[int_PositionContainerFound_1].transform.GetChild(1).gameObject.transform.position = vector3_operational_1;//new Vector3( 	0.0f, vector3_operational.y, vector3_operational.z);



    			CommunicationBezierCharToWords.string_NameObjectMessage = list_GameObjectInstanciated_1[int_PositionContainerFound_1].name;
    			CommunicationBezierCharToWords.bool_ActiveMotionMessage = true;
				CommunicationBezierCharToWords.int_OneOrTwoMessage = 2;


    			int_PositionContainerFound_1 = -1;

    		}
    		

    	}


    	// print(string_OneTranslationOperational);
    	// print(string_TwoTranslationOperational);



    	if(LinkCommunicationColoredClass.bool_ActiveStatus == true)
    	{	

    		LinkCommunicationColoredClass.bool_ActiveStatus = false;

    		Debug.Log("String In InputField After ENTER  == " + LinkCommunicationColoredClass.string_InputField);

    		string_FromInputField = LinkCommunicationColoredClass.string_InputField;

    		bool_CheckString = true;

    	}

		// if(Input.GetKeyDown(KeyCode.Tab))
		// {
		// 	CommunicationCorrectAnswerClass.bool_ActiveResetWords = true;

		// }

		if(CommunicationCollisionCharToWordsClass.bool_ActiveCollisionDetectionMessage)
		{

			CommunicationCollisionCharToWordsClass.bool_ActiveCollisionDetectionMessage = false;
			int_CounterCollisionChar ++;

		}

		if(int_CounterCollisionChar == int_LengthBothWords)
		{
			int_CounterCollisionChar = 0;

			bool_ResetListOfWords = true;
		
		}



		// if(CommunicationCollisionClass.bool_ResetListOfWords)
		if(bool_ResetListOfWords)
    	{
			// CommunicationCollisionClass.bool_ResetListOfWords = false;    		

    		for(int i = 0; i < list_GameObjectInstanciated_0.Count; i++)
    		{
    			Destroy(list_GameObjectInstanciated_0[i]);

    		}

    		for(int i = 0; i < list_GameObjectInstanciated_1.Count; i++)
    		{
    			Destroy(list_GameObjectInstanciated_1[i]);

    		}



    		bool_ResetListOfWords = false;
	        float_CurrentTime = Time.realtimeSinceStartup;



	
			TextMeshPro valuesOne_0 = TextOne_0.GetComponent<TextMeshPro>();
			TextMeshPro valuesOne_1 = TextOne_1.GetComponent<TextMeshPro>();
	
	
	 
			var src = DateTime.Now;
			var hm = new DateTime(src.Year, src.Month, src.Day, src.Hour, src.Minute, src.Second);
			int hashRandom = (hm.Hour + hm.Year + hm.Month + hm.Day + hm.Minute + hm.Second);
	
			System.Random randomGeneratorNumber = new System.Random(hashRandom);
			int int_randomListPosition = randomGeneratorNumber.Next(0, list_OfStringEnglish.Count);
			string_OneTranslation = list_OfStringEnglish[int_randomListPosition];
			string_TwoTranslation = list_OfStringFrench[int_randomListPosition];
			
			// string_OneTranslation = "HelloBaby";
			// string_TwoTranslation = "BonjourBaby";
			
			int_LengthBothWords = string_OneTranslation.Length + string_TwoTranslation.Length;
	
			valuesOne_0.text = string_OneTranslation;
			valuesOne_1.text = string_TwoTranslation;
	
			string_OneTranslationOperational = string_OneTranslation;
			string_TwoTranslationOperational = string_TwoTranslation;
	
			list_OneTranslationOperational = new List<string>();
			list_TwoTranslationOperational = new List<string>(); 

			list_IntCharToColorOne = new List<int>(); 		
			list_IntCharToColorTwo = new List<int>();		
	

			for(int i = 0; i < string_OneTranslation.Length; i++)
			{
			
				list_OneTranslationOperational.Add(string_OneTranslation[i].ToString());
				list_IntCharToColorOne.Add(0);
	
			}
	
			for(int i = 0; i < string_TwoTranslation.Length; i++)
			{
	
				list_TwoTranslationOperational.Add(string_TwoTranslation[i].ToString());
				list_IntCharToColorTwo.Add(0);
	
			}
	
	

			float widthText_One   = valuesOne_0.preferredWidth;
			float heightText_One  = valuesOne_0.preferredHeight;
	
	
			backgroundShader_0.transform.localScale = GetScaleBackGroundShader(widthText_One, backgroundShader_0.transform.localScale); 	
			BoxOne_0.transform.localScale = GetScaleBackGround(widthText_One, BoxOne_0.transform.localScale);
	
			backgroundShader_0.transform.position = new Vector3(vector3_PositionStartBackground_0.x, vector3_PositionStartBackground_0.y, vector3_PositionStartBackground_0.z); 
			BoxOne_0.transform.position = new Vector3(vector3_PositionStartBackground_0.x, vector3_PositionStartBackground_0.y, vector3_PositionStartBackground_0.z - 0.05f); 

			backgroundShader_0.transform.position += GetPositionBackGround(widthText_One);
			BoxOne_0.transform.position += GetPositionBackGround(widthText_One);
	
	
			widthText_One   = valuesOne_1.preferredWidth;
			heightText_One  = valuesOne_1.preferredHeight;
	
	
			backgroundShader_1.transform.localScale = GetScaleBackGroundShader(widthText_One, backgroundShader_1.transform.localScale); 	
			BoxOne_1.transform.localScale = GetScaleBackGround(widthText_One, BoxOne_1.transform.localScale);
	
			backgroundShader_1.transform.position = new Vector3(vector3_PositionStartBackground_1.x, vector3_PositionStartBackground_1.y, vector3_PositionStartBackground_1.z); 
			BoxOne_1.transform.position = new Vector3(vector3_PositionStartBackground_1.x, vector3_PositionStartBackground_1.y, vector3_PositionStartBackground_1.z - 0.05f); 

	
			backgroundShader_1.transform.position += GetPositionBackGround(widthText_One);
			BoxOne_1.transform.position += GetPositionBackGround(widthText_One);
	
	
	
			int int_LengthOne = string_OneTranslation.Length;
			int int_LengthTwo = string_TwoTranslation.Length;
	
	
			// System.Random randomGeneratorNumber = new System.Random(hashRandom);
	
	
			// x = -8.65 min corners
			// x = 1.55  max corners
			// y = -2.74 min corners
			// y = 6.0  max corners
	
	
			// x = -8.15 min corners correctect / inner square;
			// x = 1.05  max corners correctect / inner square;
			// y = -2.54 min corners correctect  / inner square;
			// y = 5.5  max corners correctect / inner square;
	
	
			// x = 9.2;
			// y = 8.04;
	
			list_GameObjectInstanciated_0 = new List<GameObject>();
			list_GameObjectInstanciated_1 = new List<GameObject>();
	
			list_IntPositionMark_0 = new List<int>(); 
			list_IntPositionMark_1 = new List<int>(); 
	
			List<Vector3> list_Vector3Addition = new List<Vector3>();
	
	
			float float_randomPosition_x;
			float float_randomPosition_y;
	
	
			for(int i = 0; i < int_LengthOne; i++)
			{
	
				bool bool_Verifyaddition = true;
				
				Vector3 vector3_NewPositionInstance = new Vector3(0f, 0f, 0f);
		
				for(int j = 0; j < 100; j++)
				// while(bool_Verifyaddition)
				{
	
					float_randomPosition_x = 9.2f * (float)randomGeneratorNumber.NextDouble();
					float_randomPosition_y = 8.04f * (float)randomGeneratorNumber.NextDouble();
					
					vector3_NewPositionInstance = new Vector3(-6.15f + float_randomPosition_x, -2.54f + float_randomPosition_y,  10f);
	
					for(int n = 0; n < list_Vector3Addition.Count; n++)
					{
	
						Vector3 vector3_ValidatePosition = vector3_NewPositionInstance - list_Vector3Addition[n];
	
						if(vector3_ValidatePosition.magnitude < 1.0f)
						{
							break;
	
						}
				
						bool_Verifyaddition = false;
	
					}
	
					if(bool_Verifyaddition == false)
					{
						j = 100;
					}
	
				}
				
	
				list_Vector3Addition.Add(vector3_NewPositionInstance);
	
	
	
				GameObject gameobject_InstanceContainer = Instantiate(Container_0, Vector3.zero, Quaternion.identity);
	
				gameobject_InstanceContainer.name = "container_0_" + i.ToString();
	
				GameObject backgroundShaderObject = gameobject_InstanceContainer.transform.GetChild(0).gameObject;
				GameObject backgroundPlaneObject = gameobject_InstanceContainer.transform.GetChild(1).gameObject;
				GameObject textObject = gameobject_InstanceContainer.transform.GetChild(2).gameObject;
	
	
				backgroundPlaneObject.name = "containerPlane_0_" + i.ToString();
				backgroundPlaneObject.layer = 8;
				backgroundPlaneObject.AddComponent<Rigidbody>();
				backgroundPlaneObject.GetComponent<Rigidbody>().useGravity = false;
	    		LayerMask elementLayer = LayerMask.NameToLayer("Arrow");
	    		// Debug.Log(elementLayer.value);
	
				backgroundPlaneObject.GetComponent<BoxCollider>().excludeLayers = (int) Math.Pow(2, elementLayer.value);
	
	
				gameobject_InstanceContainer.transform.position = new Vector3(vector3_NewPositionInstance.x, vector3_NewPositionInstance.y, vector3_NewPositionInstance.z); 
	
	
				TextMeshPro textMeshObject = textObject.GetComponent<TextMeshPro>();
	
	
				textMeshObject.text = string_OneTranslation[i].ToString();
	
				widthText_One   = textMeshObject.preferredWidth;
				heightText_One  = textMeshObject.preferredHeight;
	
	
				backgroundShaderObject.transform.localScale =  GetScaleBackGroundShader(widthText_One * 1.5f, backgroundShaderObject.transform.localScale); 	
				backgroundPlaneObject.transform.localScale  =        GetScaleBackGround(widthText_One * 1.5f, backgroundPlaneObject.transform.localScale);
	
				// vector3_PositionStartBackground_0 //= new Vector3(backgroundPlaneObject.transform.position.x, backgroundPlaneObject.transform.position.y, backgroundPlaneObject.transform.position.z);

				backgroundShaderObject.transform.position -= GetPositionBackGround(valuesOne_0.preferredWidth);
				backgroundPlaneObject.transform.position  -= GetPositionBackGround(valuesOne_0.preferredWidth);

				backgroundShaderObject.transform.position += GetPositionBackGround(widthText_One);
				backgroundPlaneObject.transform.position  += GetPositionBackGround(widthText_One) + new Vector3(0.0f, 0.0f, -0.1f);
				textObject.transform.position += new Vector3(0.0f, 0.0f, -0.11f);
	

				backgroundPlaneObject.GetComponent<CollisionScriptCode>().enabled = true;
	
	
	
				list_GameObjectInstanciated_0.Add(gameobject_InstanceContainer);
				list_IntPositionMark_0.Add(0);
	
			}
	
	
	
			for(int i = 0; i < int_LengthTwo; i++)
			{
	
				bool bool_Verifyaddition = true;
				
				Vector3 vector3_NewPositionInstance = new Vector3(0f, 0f, 0f);
		
				// while(bool_Verifyaddition)
				for(int j = 0; j < 100; j++)
				{
	
					float_randomPosition_x = 9.2f * (float)randomGeneratorNumber.NextDouble();
					float_randomPosition_y = 8.04f * (float)randomGeneratorNumber.NextDouble();
					
					vector3_NewPositionInstance = new Vector3(-6.15f + float_randomPosition_x, -2.54f + float_randomPosition_y,  10f);
	
	
					// foreach(Vector3 vector3_PositionsAdded in list_Vector3Addition)
					// {
	
					// 	Vector3 vector3_ValidatePosition = vector3_NewPositionInstance - vector3_PositionsAdded;
	
					for(int n = 0; n < list_Vector3Addition.Count; n++)
					{
	
						Vector3 vector3_ValidatePosition = vector3_NewPositionInstance - list_Vector3Addition[n];
	
						if(vector3_ValidatePosition.magnitude < 1.0f)
						{
							break;
	
						}
				
						bool_Verifyaddition = false;
	
					}
	
					if(bool_Verifyaddition == false)
					{
						j = 100;
					}
	
				}
	
				
				list_Vector3Addition.Add(vector3_NewPositionInstance);
	
	
	
				GameObject gameobject_InstanceContainer = Instantiate(Container_1, Vector3.zero, Quaternion.identity);
	
				gameobject_InstanceContainer.name = "container_1_" + i.ToString();
	
				GameObject backgroundShaderObject = gameobject_InstanceContainer.transform.GetChild(0).gameObject;
				GameObject backgroundPlaneObject = gameobject_InstanceContainer.transform.GetChild(1).gameObject;
				GameObject textObject = gameobject_InstanceContainer.transform.GetChild(2).gameObject;
	
				backgroundPlaneObject.name = "containerPlane_0_" + i.ToString();
				backgroundPlaneObject.layer = 8;
				backgroundPlaneObject.AddComponent<Rigidbody>();
				backgroundPlaneObject.GetComponent<Rigidbody>().useGravity = false;
	    		LayerMask elementLayer = LayerMask.NameToLayer("Arrow");
	    		// Debug.Log(elementLayer.value);
	
				backgroundPlaneObject.GetComponent<BoxCollider>().excludeLayers = (int) Math.Pow(2, elementLayer.value);
	
	
	
				gameobject_InstanceContainer.transform.position = new Vector3(vector3_NewPositionInstance.x, vector3_NewPositionInstance.y, vector3_NewPositionInstance.z); 
	
	
				// GameObject gameobject_InstanceContainer = Instantiate(Container_1, vector3_NewPositionInstance, Quaternion.identity);
	
				// gameobject_InstanceContainer.name = "container_1_" + i.ToString();		
	
				// GameObject backgroundShaderObject = gameobject_InstanceContainer.transform.GetChild(0).gameObject;
				// GameObject backgroundPlaneObject = gameobject_InstanceContainer.transform.GetChild(1).gameObject;
				// GameObject textObject = gameobject_InstanceContainer.transform.GetChild(2).gameObject;
	
				TextMeshPro textMeshObject = textObject.GetComponent<TextMeshPro>();
	
				textMeshObject.text = string_TwoTranslation[i].ToString();
	
				widthText_One   = textMeshObject.preferredWidth;
				heightText_One  = textMeshObject.preferredHeight;
	
	
				backgroundShaderObject.transform.localScale =  GetScaleBackGroundShader(widthText_One * 1.5f, backgroundShaderObject.transform.localScale); 	
				backgroundPlaneObject.transform.localScale  =        GetScaleBackGround(widthText_One * 1.5f, backgroundPlaneObject.transform.localScale);
	
				// vector3_PositionStartBackground_0 //= new Vector3(backgroundPlaneObject.transform.position.x, backgroundPlaneObject.transform.position.y, backgroundPlaneObject.transform.position.z);
	
	
				backgroundShaderObject.transform.position -= GetPositionBackGround(valuesOne_1.preferredWidth);
				backgroundPlaneObject.transform.position  -= GetPositionBackGround(valuesOne_1.preferredWidth);
				
				backgroundShaderObject.transform.position += GetPositionBackGround(widthText_One);
				backgroundPlaneObject.transform.position  += GetPositionBackGround(widthText_One) +  new Vector3(0.0f, 0.0f, -0.1f);
				textObject.transform.position += new Vector3(0.0f, 0.0f, -0.11f);
		
				backgroundPlaneObject.GetComponent<CollisionScriptCode>().enabled = true;
	
				// backgroundPlaneObject.GetComponent<Rigidbody>().useGravity = false;
	
				// Debug.Log(gameobject_InstanceContainer.transform.GetChild(1).gameObject);
	
	
				list_GameObjectInstanciated_1.Add(gameobject_InstanceContainer);
				list_IntPositionMark_1.Add(0);
	
			}
	






			list_IntColored = new List<int>{0, 0, 0, 0, 0, 0};


    		float_evaluationTime = float_CurrentTime;

			CommunicationCorrectAnswerClass.bool_ActiveResetWords = true;

    		// int_CounterTranslation = 1;
		
		 	// bool_ToCheckWord = true;

	
			// float widthText_One = textMeshProFocus.preferredWidth;
			// float heightText_One  = textMeshProFocus.preferredHeight;
	
			// // Transform transform_BackOne = BackGroundOne_0.transform;
			// // TextFocus.transform.position = transformFocus.position;

			// transformFocus.position = basePositionBox;

			// transformFocus.localScale = GetScaleBackGround(widthText_One, transformFocus.localScale);
	
	
			// updatedPositionOne = GetPositionBackGround(widthText_One);
	
			// transformFocus.position +=  updatedPositionOne;
	
	
			// BoxFocus.transform.position = transformFocus.position;
	


    	}
        
    }

}
