using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class ModBehaviour : MonoBehaviour
{
	public class SaveData
	{
		public List<SaveDataList> save = new List<SaveDataList>();
	}

	public class SaveDataList
	{
		public bool primeravez;
	}

	public static AssetBundle m_bundle;

	private static ModBehaviour m_instance;

	public bool primeravez;

	public static ModBehaviour Instance => m_instance;

	private void Start()
	{
		m_instance = this;
		Load();
		((MonoBehaviour)this).StartCoroutine(SetupMod());
	}

	public void Save()
	{
		SaveData saveData = new SaveData();
		SaveDataList item = new SaveDataList
		{
			primeravez = primeravez
		};
		saveData.save.Add(item);
		SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData, "NewHouse-message.save");
	}

	private void Load()
	{
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-message.save");
		if (saveData != null)
		{
			primeravez = saveData.save[0].primeravez;
		}
	}

	private IEnumerator SetupMod()
	{
		while ((Object)(object)GameObject.Find("YARD") == (Object)null)
		{
			yield return null;
		}
		try
		{
			string assetPath = NewHouse.assetPath;
			assetPath = Path.Combine(assetPath, "newhouse.unity3d");
			if (!File.Exists(assetPath))
			{
				ModConsole.Error("Couldn't find asset bundle from path " + assetPath);
			}
			if (File.Exists(assetPath))
			{
				m_bundle = AssetBundle.CreateFromMemoryImmediate(File.ReadAllBytes(assetPath));
				ModConsole.Print(NewHouse.nnombre + " loaded successfully. / Autor = " + NewHouse.aauthor + " / Version = " + NewHouse.vversion);
				LoadAssets();
			}
		}
		catch (Exception ex)
		{
			ModConsole.Error(ex.ToString());
		}
	}

	private void LoadAssets()
	{
		Object.Instantiate<GameObject>(m_bundle.LoadAsset<GameObject>("caseron")).AddComponent<CasaBehaviour>();
	}

	private void OnDestroy()
	{
		m_bundle.Unload(true);
	}

	private void Update()
	{
		try
		{
			if (Application.loadedLevelName != "GAME" && !primeravez)
			{
				ModUI.ShowMessage("New House is in development, may contain errors and may cause permanent damage to the save (save back up).", "ATTENTION");
				primeravez = true;
				Save();
			}
		}
		catch (Exception ex)
		{
			ModConsole.Error(ex.ToString());
		}
	}
}
