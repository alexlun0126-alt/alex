using System;
using System.IO;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class NewHouse : Mod
{
	private bool m_isLoaded;

	public static string assetPath;

	public static string configPath;

	public static string nnombre;

	public static string aauthor;

	public static string vversion;

	private static NewHouse m_instance;

	private CasaBehaviour casasave;

	private TelefonoBehaviour phonesave;

	private LucesBehaviour lightsave;

	private PuertaBehaviour doorsave;

	private ElectricidadBehaviour electricsave;

	private MandoBehaviour remotesave;

	private VendedorBistecBehaviour bagssave;

	private CosasGarageBehaviour garagesave;

	private BistecBehaviour bistecsave;

	private ModBehaviour mensagesave;

	private CompraObjetosBehaviour comprassave;

	public override string ID => "NewHouse";

	public override string Name => "NewHouse";

	public override string Author => "Kunedo";

	public override string Version => "5.1";

	public override void ModSetup()
	{
		SetupFunction(Setup.OnMenuLoad, OnMenuLoad);
		SetupFunction(Setup.OnSave, OnSave);
		SetupFunction(Setup.ModSettings, ModSettings);
		SetupFunction(Setup.Update, Update);
	}

	public static NewHouse Instance => m_instance;

	public static string SaveFilePathgeneral => Path.Combine(configPath, "NewHouse-general.save");

	public static string SaveFilePathphone => Path.Combine(configPath, "NewHouse-phone.save");

	public static string SaveFilePathdeco => Path.Combine(configPath, "NewHouse-decoration.save");

	public static string SaveFilePathluz => Path.Combine(configPath, "NewHouse-lights.save");

	public static string SaveFilePathpuerta => Path.Combine(configPath, "NewHouse-doors.save");

	public static string SaveFilePathelectric => Path.Combine(configPath, "NewHouse-electrics.save");

	public static string SaveFilePathremote => Path.Combine(configPath, "NewHouse-remote.save");

	public static string SaveFilePathbags => Path.Combine(configPath, "NewHouse-bags.save");

	public static string SaveFilePathgarage => Path.Combine(configPath, "NewHouse-garage.save");

	public static string SaveFilePathbarbecue => Path.Combine(configPath, "NewHouse-barbecue.save");

	public static string SaveFilePathsteaks => Path.Combine(configPath, "NewHouse-steaks.save");

	public static string SaveFilePathmesa => Path.Combine(configPath, "NewHouse-tables.save");

	public static string SaveFilePathmesa2 => Path.Combine(configPath, "NewHouse-tables2.save");

	public static string SaveFilePathsofa => Path.Combine(configPath, "NewHouse-couchs.save");

	public static string SaveFilePathalfombra => Path.Combine(configPath, "NewHouse-carpets.save");

	public static string SaveFilePathsilla => Path.Combine(configPath, "NewHouse-deskchairs.save");

	public static string SaveFilePathsilla2 => Path.Combine(configPath, "NewHouse-chairs.save");

	public static string SaveFilePathpouf => Path.Combine(configPath, "NewHouse-poufs.save");

	public static string SaveFilePathnightstand => Path.Combine(configPath, "NewHouse-nightstands.save");

	public static string SaveFilePathcajamesa => Path.Combine(configPath, "NewHouse-cardboard-table.save");

	public static string SaveFilePathcajamesa2 => Path.Combine(configPath, "NewHouse-cardboard-table2.save");

	public static string SaveFilePathcajasofa => Path.Combine(configPath, "NewHouse-cardboard-couch.save");

	public static string SaveFilePathcajaalfombra => Path.Combine(configPath, "NewHouse-cardboard-carpet.save");

	public static string SaveFilePathcajasilla => Path.Combine(configPath, "NewHouse-cardboard-deskchair.save");

	public static string SaveFilePathcajasilla2 => Path.Combine(configPath, "NewHouse-cardboard-chair.save");

	public static string SaveFilePathcajapouf => Path.Combine(configPath, "NewHouse-cardboard-pouf.save");

	public static string SaveFilePathcajanightstand => Path.Combine(configPath, "NewHouse-cardboard-nightstand.save");

	public static string SaveFilePathmessage => Path.Combine(configPath, "NewHouse-message.save");

	public static string SaveFilePathorder => Path.Combine(configPath, "NewHouse-order.save");

	private void OnSave()
	{
		if (casasave.vendido)
		{
			lightsave.Save();
			doorsave.Save();
			electricsave.Save();
			remotesave.Save();
			garagesave.Save();
			if (casasave.barbacoacomprada)
			{
				bistecsave.Save();
			}
			comprassave.Save();
		}
		casasave.Save();
		mensagesave.Save();
		bagssave.Save();
	}

	public static void Testing2()
	{
		if (File.Exists(SaveFilePathremote))
		{
			File.Delete(SaveFilePathremote);
		}
	}

	public static void Testing3()
	{
		if (File.Exists(SaveFilePathbags))
		{
			File.Delete(SaveFilePathbags);
		}
	}

	public static void Testing()
	{
		if (File.Exists(SaveFilePathmessage))
		{
			File.Delete(SaveFilePathmessage);
		}
		if (File.Exists(SaveFilePathnightstand))
		{
			File.Delete(SaveFilePathnightstand);
		}
		if (File.Exists(SaveFilePathcajanightstand))
		{
			File.Delete(SaveFilePathcajanightstand);
		}
		if (File.Exists(SaveFilePathgeneral))
		{
			File.Delete(SaveFilePathgeneral);
		}
		if (File.Exists(SaveFilePathphone))
		{
			File.Delete(SaveFilePathphone);
		}
		if (File.Exists(SaveFilePathdeco))
		{
			File.Delete(SaveFilePathdeco);
		}
		if (File.Exists(SaveFilePathsofa))
		{
			File.Delete(SaveFilePathsofa);
		}
		if (File.Exists(SaveFilePathcajasofa))
		{
			File.Delete(SaveFilePathcajasofa);
		}
		if (File.Exists(SaveFilePathpouf))
		{
			File.Delete(SaveFilePathpouf);
		}
		if (File.Exists(SaveFilePathcajapouf))
		{
			File.Delete(SaveFilePathcajapouf);
		}
		if (File.Exists(SaveFilePathmesa))
		{
			File.Delete(SaveFilePathmesa);
		}
		if (File.Exists(SaveFilePathcajamesa))
		{
			File.Delete(SaveFilePathcajamesa);
		}
		if (File.Exists(SaveFilePathmesa2))
		{
			File.Delete(SaveFilePathmesa2);
		}
		if (File.Exists(SaveFilePathcajamesa2))
		{
			File.Delete(SaveFilePathcajamesa2);
		}
		if (File.Exists(SaveFilePathsilla))
		{
			File.Delete(SaveFilePathsilla);
		}
		if (File.Exists(SaveFilePathcajasilla))
		{
			File.Delete(SaveFilePathcajasilla);
		}
		if (File.Exists(SaveFilePathsilla2))
		{
			File.Delete(SaveFilePathsilla2);
		}
		if (File.Exists(SaveFilePathcajasilla2))
		{
			File.Delete(SaveFilePathcajasilla2);
		}
		if (File.Exists(SaveFilePathalfombra))
		{
			File.Delete(SaveFilePathalfombra);
		}
		if (File.Exists(SaveFilePathcajaalfombra))
		{
			File.Delete(SaveFilePathcajaalfombra);
		}
		if (File.Exists(SaveFilePathluz))
		{
			File.Delete(SaveFilePathluz);
		}
		if (File.Exists(SaveFilePathpuerta))
		{
			File.Delete(SaveFilePathpuerta);
		}
		if (File.Exists(SaveFilePathelectric))
		{
			File.Delete(SaveFilePathelectric);
		}
		if (File.Exists(SaveFilePathremote))
		{
			File.Delete(SaveFilePathremote);
		}
		if (File.Exists(SaveFilePathbags))
		{
			File.Delete(SaveFilePathbags);
		}
		if (File.Exists(SaveFilePathgarage))
		{
			File.Delete(SaveFilePathgarage);
		}
		if (File.Exists(SaveFilePathbarbecue))
		{
			File.Delete(SaveFilePathbarbecue);
		}
		if (File.Exists(SaveFilePathsteaks))
		{
			File.Delete(SaveFilePathsteaks);
		}
		if (File.Exists(SaveFilePathorder))
		{
			File.Delete(SaveFilePathorder);
		}
	}

	private void ModSettings()
	{
		Settings.AddButton("Clean Saves Mod", Testing);
		Settings.AddButton("Reset Position Remote Control", Testing2);
	}

	private void OnMenuLoad()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		m_instance = this;
		assetPath = ModLoader.GetModAssetsFolder((Mod)(object)this);
		configPath = ModLoader.GetModSettingsFolder((Mod)(object)this);
		nnombre = ((Mod)this).Name;
		aauthor = ((Mod)this).Author;
		vversion = ((Mod)this).Version;
		if (!m_isLoaded)
		{
			new GameObject("NewHouse").AddComponent<ModBehaviour>();
			m_isLoaded = true;
		}
	}

	private void Update()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Application.loadedLevelName == "GAME")
			{
				if (!m_isLoaded)
				{
					new GameObject("NewHouse").AddComponent<ModBehaviour>();
					m_isLoaded = true;
				}
				else if ((Object)(object)casasave == (Object)null)
				{
					casasave = Object.FindObjectOfType<CasaBehaviour>();
					phonesave = Object.FindObjectOfType<TelefonoBehaviour>();
					lightsave = Object.FindObjectOfType<LucesBehaviour>();
					doorsave = Object.FindObjectOfType<PuertaBehaviour>();
					electricsave = Object.FindObjectOfType<ElectricidadBehaviour>();
					remotesave = Object.FindObjectOfType<MandoBehaviour>();
					bagssave = Object.FindObjectOfType<VendedorBistecBehaviour>();
					garagesave = Object.FindObjectOfType<CosasGarageBehaviour>();
					bistecsave = Object.FindObjectOfType<BistecBehaviour>();
					mensagesave = Object.FindObjectOfType<ModBehaviour>();
					comprassave = Object.FindObjectOfType<CompraObjetosBehaviour>();
				}
			}
			else if (Application.loadedLevelName != "GAME" && m_isLoaded)
			{
				m_isLoaded = false;
			}
		}
		catch (Exception ex)
		{
			ModConsole.Error(ex.ToString());
		}
	}

	public NewHouse()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
	}
}
