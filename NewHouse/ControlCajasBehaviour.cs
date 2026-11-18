using System.Collections.Generic;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class ControlCajasBehaviour : MonoBehaviour
{
	public class SaveData
	{
		public List<SaveDataList> save = new List<SaveDataList>();
	}

	public class SaveDataList
	{
		public float[] posX;

		public float[] posY;

		public float[] posZ;

		public float[] rotX;

		public float[] rotY;

		public float[] rotZ;
	}

	private void Start()
	{
		Loads();
	}

	public void Save()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Unknown result type (might be due to invalid IL or missing references)
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		CajaMesaBehaviour[] array = Object.FindObjectsOfType<CajaMesaBehaviour>();
		Quaternion rotation;
		if (array != null)
		{
			SaveData saveData = new SaveData();
			SaveDataList saveDataList = new SaveDataList
			{
				posX = new float[array.Length],
				posY = new float[array.Length],
				posZ = new float[array.Length],
				rotX = new float[array.Length],
				rotY = new float[array.Length],
				rotZ = new float[array.Length]
			};
			for (int i = 0; i < saveDataList.posY.Length; i++)
			{
				saveDataList.posY[i] = ((Component)array[i]).transform.position.y;
				saveDataList.posZ[i] = ((Component)array[i]).transform.position.z;
				float[] rotX = saveDataList.rotX;
				int num = i;
				rotation = ((Component)array[i]).transform.rotation;
				rotX[num] = rotation.eulerAngles.x;
				float[] rotY = saveDataList.rotY;
				int num2 = i;
				rotation = ((Component)array[i]).transform.rotation;
				rotY[num2] = rotation.eulerAngles.y;
				float[] rotZ = saveDataList.rotZ;
				int num3 = i;
				rotation = ((Component)array[i]).transform.rotation;
				rotZ[num3] = rotation.eulerAngles.z;
				saveDataList.posX[i] = ((Component)array[i]).transform.position.x;
			}
			saveData.save.Add(saveDataList);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData, "NewHouse-cardboard-table.save");
		}
		CajaMesa2Behaviour[] array2 = Object.FindObjectsOfType<CajaMesa2Behaviour>();
		if (array2 != null)
		{
			SaveData saveData2 = new SaveData();
			SaveDataList saveDataList2 = new SaveDataList
			{
				posX = new float[array2.Length],
				posY = new float[array2.Length],
				posZ = new float[array2.Length],
				rotX = new float[array2.Length],
				rotY = new float[array2.Length],
				rotZ = new float[array2.Length]
			};
			for (int j = 0; j < saveDataList2.posY.Length; j++)
			{
				saveDataList2.posY[j] = ((Component)array2[j]).transform.position.y;
				saveDataList2.posZ[j] = ((Component)array2[j]).transform.position.z;
				float[] rotX2 = saveDataList2.rotX;
				int num4 = j;
				rotation = ((Component)array2[j]).transform.rotation;
				rotX2[num4] = rotation.eulerAngles.x;
				float[] rotY2 = saveDataList2.rotY;
				int num5 = j;
				rotation = ((Component)array2[j]).transform.rotation;
				rotY2[num5] = rotation.eulerAngles.y;
				float[] rotZ2 = saveDataList2.rotZ;
				int num6 = j;
				rotation = ((Component)array2[j]).transform.rotation;
				rotZ2[num6] = rotation.eulerAngles.z;
				saveDataList2.posX[j] = ((Component)array2[j]).transform.position.x;
			}
			saveData2.save.Add(saveDataList2);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData2, "NewHouse-cardboard-table2.save");
		}
		CajaSillaBehaviour[] array3 = Object.FindObjectsOfType<CajaSillaBehaviour>();
		if (array3 != null)
		{
			SaveData saveData3 = new SaveData();
			SaveDataList saveDataList3 = new SaveDataList
			{
				posX = new float[array3.Length],
				posY = new float[array3.Length],
				posZ = new float[array3.Length],
				rotX = new float[array3.Length],
				rotY = new float[array3.Length],
				rotZ = new float[array3.Length]
			};
			for (int k = 0; k < array3.Length; k++)
			{
				saveDataList3.posY[k] = ((Component)array3[k]).transform.position.y;
				saveDataList3.posZ[k] = ((Component)array3[k]).transform.position.z;
				float[] rotX3 = saveDataList3.rotX;
				int num7 = k;
				rotation = ((Component)array3[k]).transform.rotation;
				rotX3[num7] = rotation.eulerAngles.x;
				float[] rotY3 = saveDataList3.rotY;
				int num8 = k;
				rotation = ((Component)array3[k]).transform.rotation;
				rotY3[num8] = rotation.eulerAngles.y;
				float[] rotZ3 = saveDataList3.rotZ;
				int num9 = k;
				rotation = ((Component)array3[k]).transform.rotation;
				rotZ3[num9] = rotation.eulerAngles.z;
				saveDataList3.posX[k] = ((Component)array3[k]).transform.position.x;
			}
			saveData3.save.Add(saveDataList3);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData3, "NewHouse-cardboard-deskchair.save");
		}
		CajaSilla2Behaviour[] array4 = Object.FindObjectsOfType<CajaSilla2Behaviour>();
		if (array4 != null)
		{
			SaveData saveData4 = new SaveData();
			SaveDataList saveDataList4 = new SaveDataList
			{
				posX = new float[array4.Length],
				posY = new float[array4.Length],
				posZ = new float[array4.Length],
				rotX = new float[array4.Length],
				rotY = new float[array4.Length],
				rotZ = new float[array4.Length]
			};
			for (int l = 0; l < saveDataList4.posY.Length; l++)
			{
				saveDataList4.posY[l] = ((Component)array4[l]).transform.position.y;
				saveDataList4.posZ[l] = ((Component)array4[l]).transform.position.z;
				float[] rotX4 = saveDataList4.rotX;
				int num10 = l;
				rotation = ((Component)array4[l]).transform.rotation;
				rotX4[num10] = rotation.eulerAngles.x;
				float[] rotY4 = saveDataList4.rotY;
				int num11 = l;
				rotation = ((Component)array4[l]).transform.rotation;
				rotY4[num11] = rotation.eulerAngles.y;
				float[] rotZ4 = saveDataList4.rotZ;
				int num12 = l;
				rotation = ((Component)array4[l]).transform.rotation;
				rotZ4[num12] = rotation.eulerAngles.z;
				saveDataList4.posX[l] = ((Component)array4[l]).transform.position.x;
			}
			saveData4.save.Add(saveDataList4);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData4, "NewHouse-cardboard-chair.save");
		}
		CajaAlfombraBehaviour[] array5 = Object.FindObjectsOfType<CajaAlfombraBehaviour>();
		if (array5 != null)
		{
			SaveData saveData5 = new SaveData();
			SaveDataList saveDataList5 = new SaveDataList
			{
				posX = new float[array5.Length],
				posY = new float[array5.Length],
				posZ = new float[array5.Length],
				rotX = new float[array5.Length],
				rotY = new float[array5.Length],
				rotZ = new float[array5.Length]
			};
			for (int m = 0; m < saveDataList5.posY.Length; m++)
			{
				saveDataList5.posY[m] = ((Component)array5[m]).transform.position.y;
				saveDataList5.posZ[m] = ((Component)array5[m]).transform.position.z;
				float[] rotX5 = saveDataList5.rotX;
				int num13 = m;
				rotation = ((Component)array5[m]).transform.rotation;
				rotX5[num13] = rotation.eulerAngles.x;
				float[] rotY5 = saveDataList5.rotY;
				int num14 = m;
				rotation = ((Component)array5[m]).transform.rotation;
				rotY5[num14] = rotation.eulerAngles.y;
				float[] rotZ5 = saveDataList5.rotZ;
				int num15 = m;
				rotation = ((Component)array5[m]).transform.rotation;
				rotZ5[num15] = rotation.eulerAngles.z;
				saveDataList5.posX[m] = ((Component)array5[m]).transform.position.x;
			}
			saveData5.save.Add(saveDataList5);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData5, "NewHouse-cardboard-carpet.save");
		}
		CajaNightStandBehaviour[] array6 = Object.FindObjectsOfType<CajaNightStandBehaviour>();
		if (array6 != null)
		{
			SaveData saveData6 = new SaveData();
			SaveDataList saveDataList6 = new SaveDataList
			{
				posX = new float[array6.Length],
				posY = new float[array6.Length],
				posZ = new float[array6.Length],
				rotX = new float[array6.Length],
				rotY = new float[array6.Length],
				rotZ = new float[array6.Length]
			};
			for (int n = 0; n < saveDataList6.posY.Length; n++)
			{
				saveDataList6.posY[n] = ((Component)array6[n]).transform.position.y;
				saveDataList6.posZ[n] = ((Component)array6[n]).transform.position.z;
				float[] rotX6 = saveDataList6.rotX;
				int num16 = n;
				rotation = ((Component)array6[n]).transform.rotation;
				rotX6[num16] = rotation.eulerAngles.x;
				float[] rotY6 = saveDataList6.rotY;
				int num17 = n;
				rotation = ((Component)array6[n]).transform.rotation;
				rotY6[num17] = rotation.eulerAngles.y;
				float[] rotZ6 = saveDataList6.rotZ;
				int num18 = n;
				rotation = ((Component)array6[n]).transform.rotation;
				rotZ6[num18] = rotation.eulerAngles.z;
				saveDataList6.posX[n] = ((Component)array6[n]).transform.position.x;
			}
			saveData6.save.Add(saveDataList6);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData6, "NewHouse-cardboard-nightstand.save");
		}
		CajaSofaBehaviour[] array7 = Object.FindObjectsOfType<CajaSofaBehaviour>();
		if (array7 != null)
		{
			SaveData saveData7 = new SaveData();
			SaveDataList saveDataList7 = new SaveDataList
			{
				posX = new float[array7.Length],
				posY = new float[array7.Length],
				posZ = new float[array7.Length],
				rotX = new float[array7.Length],
				rotY = new float[array7.Length],
				rotZ = new float[array7.Length]
			};
			for (int num19 = 0; num19 < saveDataList7.posY.Length; num19++)
			{
				saveDataList7.posY[num19] = ((Component)array7[num19]).transform.position.y;
				saveDataList7.posZ[num19] = ((Component)array7[num19]).transform.position.z;
				float[] rotX7 = saveDataList7.rotX;
				int num20 = num19;
				rotation = ((Component)array7[num19]).transform.rotation;
				rotX7[num20] = rotation.eulerAngles.x;
				float[] rotY7 = saveDataList7.rotY;
				int num21 = num19;
				rotation = ((Component)array7[num19]).transform.rotation;
				rotY7[num21] = rotation.eulerAngles.y;
				float[] rotZ7 = saveDataList7.rotZ;
				int num22 = num19;
				rotation = ((Component)array7[num19]).transform.rotation;
				rotZ7[num22] = rotation.eulerAngles.z;
				saveDataList7.posX[num19] = ((Component)array7[num19]).transform.position.x;
			}
			saveData7.save.Add(saveDataList7);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData7, "NewHouse-cardboard-couch.save");
		}
		CajaPoufBehaviour[] array8 = Object.FindObjectsOfType<CajaPoufBehaviour>();
		if (array8 != null)
		{
			SaveData saveData8 = new SaveData();
			SaveDataList saveDataList8 = new SaveDataList
			{
				posX = new float[array8.Length],
				posY = new float[array8.Length],
				posZ = new float[array8.Length],
				rotX = new float[array8.Length],
				rotY = new float[array8.Length],
				rotZ = new float[array8.Length]
			};
			for (int num23 = 0; num23 < array8.Length; num23++)
			{
				saveDataList8.posY[num23] = ((Component)array8[num23]).transform.position.y;
				saveDataList8.posZ[num23] = ((Component)array8[num23]).transform.position.z;
				float[] rotX8 = saveDataList8.rotX;
				int num24 = num23;
				rotation = ((Component)array8[num23]).transform.rotation;
				rotX8[num24] = rotation.eulerAngles.x;
				float[] rotY8 = saveDataList8.rotY;
				int num25 = num23;
				rotation = ((Component)array8[num23]).transform.rotation;
				rotY8[num25] = rotation.eulerAngles.y;
				float[] rotZ8 = saveDataList8.rotZ;
				int num26 = num23;
				rotation = ((Component)array8[num23]).transform.rotation;
				rotZ8[num26] = rotation.eulerAngles.z;
				saveDataList8.posX[num23] = ((Component)array8[num23]).transform.position.x;
			}
			saveData8.save.Add(saveDataList8);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData8, "NewHouse-cardboard-pouf.save");
		}
	}

	private void Loads()
	{
		Load();
		Load2();
		Load3();
		Load4();
		Load5();
		Load6();
		Load7();
		Load8();
	}

	private void Load()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-cardboard-table.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posX.Length];
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				CajaMesaBehaviour cajaMesaBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaMesaPrefab")).AddComponent<CajaMesaBehaviour>();
				array[i] = ((Component)cajaMesaBehaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posX[i], saveData.save[0].posY[i], saveData.save[0].posZ[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotX[i], saveData.save[0].rotY[i], saveData.save[0].rotZ[i]);
			}
		}
	}

	private void Load2()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-cardboard-table2.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posX.Length];
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				CajaMesa2Behaviour cajaMesa2Behaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaMesa2Prefab")).AddComponent<CajaMesa2Behaviour>();
				array[i] = ((Component)cajaMesa2Behaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posX[i], saveData.save[0].posY[i], saveData.save[0].posZ[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotX[i], saveData.save[0].rotY[i], saveData.save[0].rotZ[i]);
			}
		}
	}

	private void Load3()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-cardboard-deskchair.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posX.Length];
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				CajaSillaBehaviour cajaSillaBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaSillaPrefab")).AddComponent<CajaSillaBehaviour>();
				array[i] = ((Component)cajaSillaBehaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posX[i], saveData.save[0].posY[i], saveData.save[0].posZ[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotX[i], saveData.save[0].rotY[i], saveData.save[0].rotZ[i]);
			}
		}
	}

	private void Load4()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-cardboard-chair.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posX.Length];
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				CajaSilla2Behaviour cajaSilla2Behaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaSilla2Prefab")).AddComponent<CajaSilla2Behaviour>();
				array[i] = ((Component)cajaSilla2Behaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posX[i], saveData.save[0].posY[i], saveData.save[0].posZ[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotX[i], saveData.save[0].rotY[i], saveData.save[0].rotZ[i]);
			}
		}
	}

	private void Load5()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-cardboard-carpet.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posX.Length];
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				CajaAlfombraBehaviour cajaAlfombraBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaAlfombraPrefab")).AddComponent<CajaAlfombraBehaviour>();
				array[i] = ((Component)cajaAlfombraBehaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posX[i], saveData.save[0].posY[i], saveData.save[0].posZ[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotX[i], saveData.save[0].rotY[i], saveData.save[0].rotZ[i]);
			}
		}
	}

	private void Load6()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-cardboard-nightstand.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posX.Length];
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				CajaNightStandBehaviour cajaNightStandBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaNightStandPrefab")).AddComponent<CajaNightStandBehaviour>();
				array[i] = ((Component)cajaNightStandBehaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posX[i], saveData.save[0].posY[i], saveData.save[0].posZ[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotX[i], saveData.save[0].rotY[i], saveData.save[0].rotZ[i]);
			}
		}
	}

	private void Load7()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-cardboard-couch.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posX.Length];
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				CajaSofaBehaviour cajaSofaBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaSofaPrefab")).AddComponent<CajaSofaBehaviour>();
				array[i] = ((Component)cajaSofaBehaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posX[i], saveData.save[0].posY[i], saveData.save[0].posZ[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotX[i], saveData.save[0].rotY[i], saveData.save[0].rotZ[i]);
			}
		}
	}

	private void Load8()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-cardboard-pouf.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posX.Length];
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				CajaPoufBehaviour cajaPoufBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaPoufPrefab")).AddComponent<CajaPoufBehaviour>();
				array[i] = ((Component)cajaPoufBehaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posX[i], saveData.save[0].posY[i], saveData.save[0].posZ[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotX[i], saveData.save[0].rotY[i], saveData.save[0].rotZ[i]);
			}
		}
	}

	private void Update()
	{
	}
}
