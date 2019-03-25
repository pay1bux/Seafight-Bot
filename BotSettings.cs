﻿using System.Collections.Generic;

namespace BoxyBot
{
    public static class BotSettings
    {
        public static Dictionary<double, int> attackOnSightShips = new Dictionary<double, int>();
        public static Dictionary<string, int> attackOnSightGuilds = new Dictionary<string, int>();
        public static int rebuyAmmoID = -1;
        public static int rebuyHarpoonsID = -1;
        public static int AmmoIDRaid = 5;
        public static int AmmoIDRaidBoss;
        public static int AmmoIDBM = 5;
        public static int AmmoIDBMChanged = 5;
        public static int AmmoIDShootBack;
        public static int RaidType;
        public static int ReBuyAmmoAmount;
        public static int ReBuyHarpoonsAmount;
        public static int ShootBackType;
        public static int botDesign;
        public static int repDesign;
        public static int collectorrange = 100;
        public static int repathp = 50;
        public static int repathpraid = 50;
        public static int repathpbm = 50;
        public static int maxRaidRejoins;
        public static int shootBackHPItemID;
        public static int shootBackVPItemID;
        public static double switchMapTime;
        public static int finishNPCHpLimit;
        public static int useActionItemID;
        public static int useActionItemType;
        public static int movementType = 0;
        public static int rebuyAmmoSmaller;
        public static int rebuyHarpoonsSmaller;
        public static int changeAmmoBMWave;
        public static bool shootNPCs;
        public static bool shootMonsters;
        public static bool collectGlitters;
        public static bool autoJoinRaid;
        public static bool collectMeat;
        public static bool shootRaidBoss;
        public static bool autoJoinBM;
        public static bool onlyFullHPRaidNpc;
        public static bool onlyFullHPNpc;
        public static bool onlyFullHPMonsters;
        public static bool rebuyAmmo;
        public static bool rebuyHarpoons;
        public static bool underAttack;
        public static bool escapingIsland;
        public static bool jumpMaps;
        public static bool usePowderRaid;
        public static bool useArmorRaid;
        public static bool usePowderRaidBoss;
        public static bool useArmorRaidBoss;
        public static bool usePowderBM;
        public static bool useArmorBM;
        public static bool usePowderPlayer;
        public static bool useArmorPlayer;
        public static bool useDesignChanger;
        public static bool collectchests;
        public static bool collecteventchests;
        public static bool repatcorner;
        public static bool repatborder;
        public static bool useFleeSpeedStone;
        public static bool useFleeSmokebomb;
        public static bool useShootbackHPItem;
        public static bool useShootbackVPItem;
        public static bool useRaidBossCandle;
        public static bool useRaidBossSnowman;
        public static bool useRaidBossSpeedstone;
        public static bool useRaidBossBloodlust;
        public static bool useSkyfire;
        public static bool useElmosfire;
        public static bool useHumanMovement;
        public static bool collectEventGlitter;
        public static bool needMapSwitch;
        public static bool finishNPCs;
        public static bool joinSameBM;
        public static bool attackOnSight;
        public static bool jumpMapRandom;
        public static bool jumpMapLeftRight;
        public static bool jumpMapIfAvailable;
        public static bool clearCache;
        public static bool rangeBMNpcs;
        public static bool repAtIsland;
        public static bool ignoreBoxesPlayerNearby;
        public static bool rebuyRaidMedallions;
        public static bool rebuyKeys;
        public static bool useActionItemUser;
        public static bool boardVCMA;
        public static bool prioNPCs;
        public static bool prioMonsters;
        public static bool betterGFX;
        public static bool avoidIslands;
        public static bool leaveBM;
        public static bool canLeaveBM;
        public static bool tasksDoneLogout;
        public static bool joinBeheLvl26;
        public static bool acceptLoginBonus;
        public static bool collectWhileAttack;
        public static bool avoidBeheNPCs;
        public static bool fleeIfEnemyNearby;
        public static bool useBMAmmoChanger;
        public static bool useQuestSystem;
        public static bool doDailyQuest;
        public static string lastBM = "";
    }
}