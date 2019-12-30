﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paths {
	//预制体路径
	private const string PREFAB_FOLDER = "Prefab/";
	private const string UI_FOLDER = PREFAB_FOLDER + "UI/";
	public const string PREFAB_START_VIEW = UI_FOLDER + "StartView";
	public const string PREFAB_SELECTED_HERO_VIEW = UI_FOLDER + "SelectedHeroView";
	public const string PREFAB_STRENGTHEN_VIEW = UI_FOLDER + "StrengthenView";
	public const string PREFAB_LEVELS_VIEW = UI_FOLDER + "LevelsView";
	public const string PREFAB_LEVEL_ITEM = UI_FOLDER + "LevelItem";
	public const string PREFAB_PROPERTY_ITEM = UI_FOLDER + "PropertyItem";
	public const string PREFAB_DIALOG = UI_FOLDER + "Dialog";
	public const string PREFAB_LOADING_VIEW = UI_FOLDER + "LoadingView";
	public const string PREFAB_GAME_UI_VIEW = UI_FOLDER + "GameUI";
	public const string PREFAB_LIFE_ITEM_VIEW = UI_FOLDER + "LifeItem";
	public const string PREFAB_PAUSE_VIEW = UI_FOLDER + "GamePauseView";
	public const string PREFAB_ITEM_EFFECT_VIEW = UI_FOLDER + "ItemEffect";
	//game预制
	private const string Game_FOLDER = PREFAB_FOLDER + "Game/";
	public const string PREFAB_GAME_ROOT = Game_FOLDER + "GameRoot";
	public const string PREFAB_MAP_MGR = Game_FOLDER + "MapMgr";
	public const string PREFAB_PLAYER = Game_FOLDER + "Player";
	public const string PREFAB_BULLET = Game_FOLDER + "Bullet";
	
	private const string EFFECT_FOLDER = Game_FOLDER + "Effect/";
	public const string EFFECT_SHIELD = EFFECT_FOLDER + "Shield";
	
	public const string ENEMY_FOLDER = PREFAB_FOLDER + "Enemy/";
	//图片路径
	private const string PICTURE_FOLDER = "Picture/";
	public const string PICTURE_PLAYER_PICTURE_FOLDER = PICTURE_FOLDER+"Player/";
	public const string PICTURE_MAP_FOLDER = PICTURE_FOLDER+"Map/";
	
	public const string PICTURE_BULLET_FOLDER = PICTURE_FOLDER+"Buttle/";
	public const string PICTURE_PLAYER_BULLET_FOLDER = PICTURE_BULLET_FOLDER+"Player/";
	public const string PICTURE_BULLET_EFFECT = PICTURE_BULLET_FOLDER+"Effect/";
	public const string PICTURE_POWER = PICTURE_BULLET_EFFECT+"Power";
	//配置路径
	public static readonly string CONFIG_FOLDER = Application.streamingAssetsPath + "/Config";
	public static readonly string CONFIG_INIT_PLANE_CONFIG = CONFIG_FOLDER + "/InitPlane.json";
	public static readonly string CONFIG_LEVEL_CONFIG = CONFIG_FOLDER + "/LevelConfig.json";
	public static readonly string CONFIG_AUDIO_VOLUME_CONFIG = CONFIG_FOLDER + "/AudioVolume.json";
	public static readonly string CONFIG_Game_CONFIG = CONFIG_FOLDER + "/GameConfig.json";
	public static readonly string CONFIG_BULLET_CONFIG = CONFIG_FOLDER + "/BulletConfig.json";
	//音频路径
	public static readonly string AUDIO_FOLDER = "Audio";
	public static readonly string AUDIO_UI_FOLDER = AUDIO_FOLDER+"/UI/";
	public static readonly string AUDIO_Player_FOLDER = AUDIO_FOLDER+"/Player/";
	public static readonly string AUDIO_GAME_BG = AUDIO_FOLDER+"/Game_BG";
	public static readonly string AUDIO_CLICK_BUTTON = AUDIO_Player_FOLDER+"/UI_ClickButton";
	public static readonly string AUDIO_LOADING = AUDIO_Player_FOLDER+"/UI_Loading";
	public static readonly string AUDIO_START_GAME = AUDIO_Player_FOLDER+"/UI_StartGame";
}
