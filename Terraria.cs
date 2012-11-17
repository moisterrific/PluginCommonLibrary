﻿// This file is provided unter the terms of the 
// Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/.
// 
// Written by CoderCow

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using DPoint = System.Drawing.Point;

using TShockAPI;

namespace Terraria.Plugins.CoderCow {
  public static partial class Terraria {
    #region [Constants]
    public const int TileId_DirtBlock = 0;
    public const int TileId_StoneBlock = 1;
    public const int TileId_Grass = 2;
    public const int TileId_GrassPlants = 3;
    public const int TileId_Torch = 4;
    public const int TileId_Tree = 5;
    public const int TileId_IronOre = 6;
    public const int TileId_CopperOre = 7;
    public const int TileId_GoldOre = 8;
    public const int TileId_SilverOre = 9;
    public const int TileId_DoorClosed = 10;
    public const int TileId_DoorOpened = 11;
    public const int TileId_CrystalHeart = 12;
    public const int TileId_Bottle = 13;
    public const int TileId_WoodenTable = 14;
    public const int TileId_WoodenChair = 15;
    public const int TileId_IronAnvil = 16;
    public const int TileId_Furnace = 17;
    public const int TileId_WorkBench = 18;
    public const int TileId_WoodPlatform = 19;
    public const int TileId_Sapling = 20;
    public const int TileId_Chest = 21;
    public const int TileId_DemoniteOre = 22;
    public const int TileId_CorruptGrass = 23;
    public const int TileId_CorruptionPlants = 24;
    public const int TileId_EbonstoneBlock = 25;
    public const int TileId_DemonAltar = 26;
    public const int TileId_Sunflower = 27;
    public const int TileId_Pot = 28;
    public const int TileId_PiggyBank = 29;
    public const int TileId_Wood = 30;
    public const int TileId_ShadowOrb = 31;
    public const int TileId_CorruptionThornyBush = 32;
    public const int TileId_Candle = 33;
    public const int TileId_CopperChandelier = 34;
    public const int TileId_SilverChandelier = 35;
    public const int TileId_GoldChandelier = 36;
    public const int TileId_Meteorite = 37;
    public const int TileId_GrayBrick = 38;
    public const int TileId_RedBrick = 39;
    public const int TileId_Clay = 40;
    public const int TileId_BlueBrick = 41;
    public const int TileId_ChainLantern = 42;
    public const int TileId_GreenBrick = 43;
    public const int TileId_PinkBrick = 44;
    public const int TileId_GoldBrick = 45;
    public const int TileId_SilverBrick = 46;
    public const int TileId_CopperBrick = 47;
    public const int TileId_Spike = 48;
    public const int TileId_WaterCandle = 49;
    public const int TileId_Book = 50;
    public const int TileId_Cobweb = 51;
    public const int TileId_Vine = 52;
    public const int TileId_SandBlock = 53;
    public const int TileId_Glass = 54;
    public const int TileId_Sign = 55;
    public const int TileId_Obsidian = 56;
    public const int TileId_AshBlock = 57;
    public const int TileId_Hellstone = 58;
    public const int TileId_MudBlock = 59;
    public const int TileId_JungleGrass = 60;
    public const int TileId_JunglePlants = 61;
    public const int TileId_JungleVine = 62;
    public const int TileId_SapphireBlock = 63;
    public const int TileId_RubyBlock = 64;
    public const int TileId_EmeraldBlock = 65;
    public const int TileId_TopazBlock = 66;
    public const int TileId_AmethystBlock = 67;
    public const int TileId_DiamondBlock = 68;
    public const int TileId_JungleThornyBush = 69;
    public const int TileId_MushroomGrass = 70;
    public const int TileId_GlowingMushroom = 71;
    public const int TileId_GiantGlowingMushroom = 72;
    public const int TileId_TallGrassPlants = 73;
    public const int TileId_TallJunglePlants = 74;
    public const int TileId_ObsidianBrick = 75;
    public const int TileId_HellstoneBrick = 76;
    public const int TileId_Hellforge = 77;
    public const int TileId_ClayPot = 78;
    public const int TileId_Bed = 79;
    public const int TileId_Cactus = 80;
    public const int TileId_Coral = 81;
    public const int TileId_PlantablePlantsGrowing = 82;
    public const int TileId_PlantablePlantsMature = 83;
    public const int TileId_PlantablePlantsBlooming = 84;
    public const int TileId_Tombstone = 85;
    public const int TileId_Loom = 86;
    public const int TileId_Piano = 87;
    public const int TileId_Dresser = 88;
    public const int TileId_Bench = 89;
    public const int TileId_Bathtub = 90;
    public const int TileId_Banner = 91;
    public const int TileId_LampPost = 92;
    public const int TileId_TikiTorch = 93;
    public const int TileId_Keg = 94;
    public const int TileId_ChineseLantern = 95;
    public const int TileId_CookingPot = 96;
    public const int TileId_Safe = 97;
    public const int TileId_SkullLantern = 98;
    public const int TileId_TashCan_UNUSED = 99;
    public const int TileId_Candelabra = 100;
    public const int TileId_Bookcase = 101;
    public const int TileId_Throne = 102;
    public const int TileId_Bowl = 103;
    public const int TileId_GrandfatherClock = 104;
    public const int TileId_Statue = 105;
    public const int TileId_Sawmill = 106;
    public const int TileId_CobaltOre = 107;
    public const int TileId_MythrilOre = 108;
    public const int TileId_HallowedGrass = 109;
    public const int TileId_HallowedPlants = 110;
    public const int TileId_AdamantiteOre = 111;
    public const int TileId_EbonsandBlock = 112;
    public const int TileId_TallHallowedPlants = 113;
    public const int TileId_TinkerersWorkshop = 114;
    public const int TileId_HallowedVine = 115;
    public const int TileId_PearlsandBlock = 116;
    public const int TileId_PearlstoneBlock = 117;
    public const int TileId_PearlstoneBrick = 118;
    public const int TileId_IridescentBrick = 119;
    public const int TileId_MudstoneBlock = 120;
    public const int TileId_CobaltBrick = 121;
    public const int TileId_MythrilBrick = 122;
    public const int TileId_SiltBlock = 123;
    public const int TileId_WoodenBeam = 124;
    public const int TileId_CrystalBall = 125;
    public const int TileId_DiscoBall = 126;
    public const int TileId_IceBlock = 127;
    public const int TileId_Mannequin = 128;
    public const int TileId_CrystalShard = 129;
    public const int TileId_ActiveStone = 130;
    public const int TileId_InactiveStone = 131;
    public const int TileId_Lever = 132;
    public const int TileId_AdamantiteForge = 133;
    public const int TileId_MythrilAnvil = 134;
    public const int TileId_PressurePlate = 135;
    public const int TileId_Switch = 136;
    public const int TileId_DartTrap = 137;
    public const int TileId_Boulder = 138;
    public const int TileId_MusicBox = 139;
    public const int TileId_DemoniteBrick = 140;
    public const int TileId_Explosives = 141;
    public const int TileId_InletPump = 142;
    public const int TileId_OutletPump = 143;
    public const int TileId_XSecondTimer = 144;
    public const int TileId_RedCandyCaneBlock = 145;
    public const int TileId_GreenCandyCaneBlock = 146;
    public const int TileId_SnowBlock = 147;
    public const int TileId_SnowBrick = 148;
    public const int TileId_XMasLight = 149;

    public const int TileId_Min = 0;
    public const int TileId_Max = 149;

    public const int WallId_Sky = 0;
    public const int WallId_StoneWall = 1;
    public const int WallId_DirtWall = 2;
    public const int WallId_EbonstoneWall = 3;
    public const int WallId_WoodWall = 4;
    public const int WallId_GrayBrickWall = 5;
    public const int WallId_RedBrickWall = 6;
    public const int WallId_DungeonBlueBrickWall = 7;
    public const int WallId_DungeonGreenBrickWall = 8;
    public const int WallId_DungeonPinkBrickWall = 9;
    public const int WallId_GoldWall = 10;
    public const int WallId_SilverWall = 11;
    public const int WallId_CopperWall = 12;
    public const int WallId_HellstoneWall = 13;
    public const int WallId_ObsidianBrickWall = 14;
    public const int WallId_MudWall = 15;
    public const int WallId_PlayerDirtWall = 16;
    public const int WallId_BlueBrickWall = 17;
    public const int WallId_GreenBrickWall = 18;
    public const int WallId_PinkBrickWall = 19;
    public const int WallId_PlayerObsidianBrickWall = 20;
    public const int WallId_GlassWall = 21;
    public const int WallId_PearlstoneBrickWall = 22;
    public const int WallId_IridecentBrickWall = 23;
    public const int WallId_MudstoneBrickWall = 24;
    public const int WallId_CobaltBrickWall = 25;
    public const int WallId_MythrilBrickWall = 26;
    public const int WallId_PlankedWall = 27;
    public const int WallId_PearlstoneWall = 28;
    public const int WallId_CandyCaneWall = 29;
    public const int WallId_GreenCandyCaneWall = 30;
    public const int WallId_SnowBrickWall = 31;

    public const int WallId_Min = 0;
    public const int WallId_Max = 31;

    public const int ItemId_CobaltOre = 364;
    public const int ItemId_Wire = 530;
    public const int ItemId_DartTrap = 539;
    public const int ItemId_Boulder = 540;

    public const int ItemId_Min = 0;
    public const int ItemId_Max = 603;

    public const int DefaultTextureTileSize = 18;
    public const int TileSize = 16;
    #endregion

    #region [Property: Tiles]
    private static readonly TerrariaTiles tiles;

    public static TerrariaTiles Tiles {
      get { return Terraria.tiles; }
    }
    #endregion


    #region [Method: Constructor]
    static Terraria() {
      Terraria.tiles = new TerrariaTiles();
    }
    #endregion

    #region [Methods: MeasureSprite, IsLeftTreeBranch, IsRightTreeBranch, IsLeftCactusBranch, IsRightCactusBranch]
    // Note: A sprite is considered any tile type the player is not blocked from passing through plus 
    // Active Stone, Boulders, Wood Platforms and Dart Traps.
    // This function is currently unable to calculate the height of dynamic sprites.
    public static Terraria.SpriteMeasureData MeasureSprite(DPoint anyTileLocation) {
      Tile tile = Terraria.Tiles[anyTileLocation];
      if (!tile.active) {
        throw new ArgumentException(string.Format(
          "The tile at location {0} can not be measured because its not active", anyTileLocation
        ));
      }

      DPoint spriteSize = Terraria.GetSpriteSize(tile.type);
      DPoint textureTileSize = new DPoint(Terraria.DefaultTextureTileSize, Terraria.DefaultTextureTileSize);
      int frameXOffsetAdd = 0;
      switch (tile.type) {
        // Dynamic sprites, special handling
        case Terraria.TileId_Tree:
          textureTileSize = new DPoint(22, 22);
          break;

        case Terraria.TileId_GrassPlants:
        case Terraria.TileId_CorruptionPlants:
        case Terraria.TileId_Candle:
        case Terraria.TileId_WaterCandle:
        case Terraria.TileId_JunglePlants:
        case Terraria.TileId_GlowingMushroom:
        case Terraria.TileId_PlantablePlantsGrowing:
        case Terraria.TileId_PlantablePlantsMature:
        case Terraria.TileId_PlantablePlantsBlooming:
        case Terraria.TileId_HallowedPlants:
          textureTileSize = new DPoint(18, 20);
          break;

        case Terraria.TileId_Coral:
          textureTileSize = new DPoint(26, 28);
          break;

        case Terraria.TileId_Torch:
          frameXOffsetAdd = Terraria.DefaultTextureTileSize * 3;
          textureTileSize = new DPoint(22, 22);
          break;

        case Terraria.TileId_PressurePlate:
          textureTileSize = new DPoint(16, 16);
          break;

        case Terraria.TileId_XMasLight:
          frameXOffsetAdd = Terraria.DefaultTextureTileSize * 2;
          break;

        case Terraria.TileId_TallGrassPlants:
        case Terraria.TileId_TallJunglePlants:
        case Terraria.TileId_TallHallowedPlants:
          textureTileSize = new DPoint(18, 16);
          break;
      }

      int originX, originY;
      switch (tile.type) {
        // Removed dynamic measuring support for Cactus due to Terraria bugs...
        case Terraria.TileId_Cactus:
          originX = anyTileLocation.X;
          originY = anyTileLocation.Y;

          break;
        case Terraria.TileId_Tree: 
        case Terraria.TileId_GiantGlowingMushroom: {
        //case Terraria.TileId_Cactus: {
          originX = anyTileLocation.X;
          originY = anyTileLocation.Y;

          if (tile.type == Terraria.TileId_Tree) {
            if (Terraria.IsLeftTreeBranch(tile))
              originX++;
            else if (Terraria.IsRightTreeBranch(tile))
              originX--;
          } else if (tile.type == Terraria.TileId_Cactus) {
            if (Terraria.IsLeftCactusBranch(tile))
              originX++;
            else if (Terraria.IsRightCactusBranch(tile))
              originX--;
          }

          while (true) {
            Tile tile2 = Terraria.Tiles[originX, originY + 1];

            if (tile2.type == tile.type)
              originY++;
            else 
              break;
          }

          spriteSize = new DPoint(3, 0);
          break;
        }
        case Terraria.TileId_Vine:
        case Terraria.TileId_JungleVine:
        case Terraria.TileId_HallowedVine: {
          originX = anyTileLocation.X;
          originY = anyTileLocation.Y;

          while (true) {
            Tile tile2 = Terraria.Tiles[originX, originY - 1];

            if (tile2.type == tile.type)
              originY--;
            else 
              break;
          }

          spriteSize = new DPoint(1, 0);
          break;
        }
        case Terraria.TileId_DoorOpened: {
          int tileIndexX = tile.frameX / textureTileSize.X;
          int frameIndexX = tileIndexX / spriteSize.X;

          // Is opened to the right side?
          if (frameIndexX == 0) {
            originX = anyTileLocation.X - tileIndexX;
            originY = anyTileLocation.Y - (tile.frameY / textureTileSize.Y);
          } else {
            originX = (anyTileLocation.X - (tileIndexX - (frameIndexX * spriteSize.X))) + 1;
            originY = anyTileLocation.Y - (tile.frameY / textureTileSize.Y);
          }

          break;
        }
        default: {
          if (spriteSize.X == 1 && spriteSize.Y == 1) {
            originX = anyTileLocation.X;
            originY = anyTileLocation.Y;
          } else {
            int tileIndexX = tile.frameX / textureTileSize.X;
            int frameIndexX = tileIndexX / spriteSize.X;

            originX = anyTileLocation.X - (tileIndexX - (frameIndexX * spriteSize.X));
            originY = anyTileLocation.Y - (tile.frameY / textureTileSize.Y);
          }

          break;
        }
      }

      return new Terraria.SpriteMeasureData(
        tile.type, new DPoint(originX, originY), spriteSize, textureTileSize, frameXOffsetAdd
      );
    }

    public static bool IsLeftTreeBranch(Tile tile) {
      if (tile.type != Terraria.TileId_Tree)
        return false;

      int frameX = tile.frameX;
      int frameY = tile.frameY;

      if (frameX == 44) {
        // Sub side or Green Branch
        return ((frameY >= 132 && frameY <= 176) || frameY >= 198);
      } else if (frameX == 66) {
        // Branch
        return (frameY >= 0 && frameY <= 44);
      } else {
        return false;
      }
    }

    public static bool IsRightTreeBranch(Tile tile) {
      if (tile.type != Terraria.TileId_Tree)
        return false;

      int frameX = tile.frameX;
      int frameY = tile.frameY;

      if (frameX == 22) {
        // Sub side
        return (frameY >= 132 && frameY <= 176);
      } else if (frameX == 66) {
        // Green Branch
        return (frameY >= 198);
      } else if (frameX == 88) {
        // Branch
        return (frameY >= 66 && frameY <= 110);
      } else {
        return false;
      }
    }

    public static bool IsLeftCactusBranch(Tile tile) {
      if (tile.type != Terraria.TileId_Cactus)
        return false;

      int frameX = tile.frameX;
      int frameY = tile.frameY;

      return (frameX == 54 || (frameX == 108 && frameY == 36));
    }

    public static bool IsRightCactusBranch(Tile tile) {
      if (tile.type != Terraria.TileId_Cactus)
        return false;

      int frameX = tile.frameX;
      int frameY = tile.frameY;

      return (frameX == 36 || (frameX == 108 && frameY == 16));
    }
    #endregion

    #region [Methods: IsSpriteToggleable, HasSpriteActiveFrame, SetSpriteActiveFrame, IsSpriteWired]
    // Does not include doors or active stone!
    public static bool IsSpriteToggleable(int blockId) {
      return (
        blockId == Terraria.TileId_Torch ||
        (blockId >= Terraria.TileId_Candle && blockId <= Terraria.TileId_GoldChandelier) ||
        blockId == Terraria.TileId_ChainLantern ||
        blockId == Terraria.TileId_LampPost ||
        blockId == Terraria.TileId_TikiTorch ||
        blockId == Terraria.TileId_ChineseLantern ||
        blockId == Terraria.TileId_Candelabra ||
        blockId == Terraria.TileId_DiscoBall ||
        blockId == Terraria.TileId_Lever ||
        blockId == Terraria.TileId_Switch ||
        blockId == Terraria.TileId_XSecondTimer ||
        blockId == Terraria.TileId_XMasLight
      );
    }

    public static bool HasSpriteActiveFrame(Terraria.SpriteMeasureData measureData) {
      Tile tile = Terraria.Tiles[measureData.OriginTileLocation];

      switch (measureData.SpriteType) {
        case Terraria.TileId_Switch:
          return (tile.frameY == 0);
        case Terraria.TileId_XSecondTimer:
          return (tile.frameY != 0);
        case Terraria.TileId_MusicBox:
          return (tile.frameX != 0);
        default:
          return (tile.frameX < measureData.FrameXOffsetAdd + 1);
      }
    }

    public static void SetSpriteActiveFrame(
      Terraria.SpriteMeasureData measureData, bool setActiveFrame, bool sendTileSquare = true
    ) {
      #if DEBUG
      if (Terraria.HasSpriteActiveFrame(measureData) == setActiveFrame) {
        throw new ArgumentException(string.Format(
          "The sprite \"{0}\" does already have the state \"{1}\".", Terraria.Tiles.GetBlockName(measureData.SpriteType), setActiveFrame
        ));
      }
      #endif

      int originX = measureData.OriginTileLocation.X;
      int originY = measureData.OriginTileLocation.Y;
      int spriteWidth = measureData.Size.X;
      int spriteHeight = measureData.Size.Y;
      short newFrameXOffset = 0;
      short newFrameYOffset = 0;

      if (measureData.SpriteType != Terraria.TileId_Switch && measureData.SpriteType != Terraria.TileId_XSecondTimer) {
        int frameXOffset = (spriteWidth * measureData.TextureTileSize.X) + measureData.FrameXOffsetAdd;
        if (measureData.SpriteType == Terraria.TileId_MusicBox)
          setActiveFrame = !setActiveFrame;

        if (setActiveFrame)
          newFrameXOffset = (short)-frameXOffset;
        else
          newFrameXOffset = (short)frameXOffset;
      } else {
        int frameYOffset = (spriteHeight * measureData.TextureTileSize.Y);
        if (measureData.SpriteType == Terraria.TileId_XSecondTimer)
          setActiveFrame = !setActiveFrame;

        if (setActiveFrame)
          newFrameYOffset = (short)-frameYOffset;
        else
          newFrameYOffset = (short)frameYOffset;
      }
        
      for (int tx = 0; tx < spriteWidth; tx++) {
        for (int ty = 0; ty < spriteHeight; ty++) {
          int absoluteX = originX + tx;
          int absoluteY = originY + ty;

          Terraria.Tiles[absoluteX, absoluteY].frameX += newFrameXOffset;
          Terraria.Tiles[absoluteX, absoluteY].frameY += newFrameYOffset;
        }
      }
            
      if (sendTileSquare)
        TSPlayer.All.SendTileSquareEx(originX, originY, Math.Max(spriteWidth, spriteHeight));
    }

    public static bool IsSpriteWired(DPoint originTileLocation, DPoint size, out DPoint firstWirePosition) {
      for (int tx = 0; tx < size.X; tx++) {
        for (int ty = 0; ty < size.Y; ty++) {
          int ax = originTileLocation.X + tx;
          int ay = originTileLocation.Y + ty;

          if (Terraria.Tiles[ax, ay].wire) {
            firstWirePosition = new DPoint(ax, ay);
            return true;
          }
        }
      }

      firstWirePosition = DPoint.Empty;
      return false;
    }

    public static bool IsSpriteWired(DPoint originTileLocation, DPoint size) {
      DPoint dummy;
      return Terraria.IsSpriteWired(originTileLocation, size, out dummy);
    }

    public static bool IsSpriteWired(Terraria.SpriteMeasureData measureData) {
      DPoint dummy;
      return Terraria.IsSpriteWired(measureData.OriginTileLocation, measureData.Size, out dummy);
    }

    public static bool IsSpriteWired(Terraria.SpriteMeasureData measureData, out DPoint firstWirePosition) {
      return Terraria.IsSpriteWired(measureData.OriginTileLocation, measureData.Size, out firstWirePosition);
    }
    #endregion

    #region [Methods: GetStatueType, GetItemTypeFromStatueType]
    public static StatueType GetStatueType(DPoint anyStatueTileLocation) {
      Tile tile = Terraria.Tiles[anyStatueTileLocation];
      if (tile.type != Terraria.TileId_Statue)
        throw new ArgumentException("The tile at the given location is not of type Statue.", "anyStatueTileLocation");

      return (StatueType)(tile.frameX / (Terraria.DefaultTextureTileSize * 2));
    }

    public static int GetItemTypeFromStatueType(StatueType statueType) {
      switch (statueType) {
        case StatueType.Armor:
          return 360;
        case StatueType.Angel:
          return 52;
        case StatueType.Star:
          return 438;
        case StatueType.Sword:
          return 439;
        case StatueType.Slime:
          return 440;
        case StatueType.Goblin:
          return 441;
        case StatueType.Shield:
          return 442;
        case StatueType.Bat:
          return 443;
        case StatueType.Fish:
          return 444;
        case StatueType.Bunny:
          return 445;
        case StatueType.Skeleton:
          return 446;
        case StatueType.Reaper:
          return 447;
        case StatueType.Woman:
          return 448;
        case StatueType.Imp:
          return 449;
        case StatueType.Gargoyle:
          return 450;
        case StatueType.Gloom:
          return 451;
        case StatueType.Hornet:
          return 452;
        case StatueType.Bomb:
          return 453;
        case StatueType.Crab:
          return 454;
        case StatueType.Hammer:
          return 455;
        case StatueType.Potion:
          return 456;
        case StatueType.Spear:
          return 457;
        case StatueType.Cross:
          return 458;
        case StatueType.Jellyfish:
          return 459;
        case StatueType.Bow:
          return 460;
        case StatueType.Boomerang:
          return 461;
        case StatueType.Boot:
          return 462;
        case StatueType.Chest:
          return 463;
        case StatueType.Bird:
          return 464;
        case StatueType.Axe:
          return 465;
        case StatueType.Corrupt:
          return 466;
        case StatueType.Tree:
          return 467;
        case StatueType.Anvil:
          return 468;
        case StatueType.Pickaxe:
          return 469;
        case StatueType.Mushroom:
          return 470;
        case StatueType.Eyeball:
          return 471;
        case StatueType.Pillar:
          return 472;
        case StatueType.Heart:
          return 473;
        case StatueType.Pot:
          return 474;
        case StatueType.Sunflower:
          return 475;
        case StatueType.King:
          return 476;
        case StatueType.Queen:
          return 477;
        case StatueType.Piranha:
          return 478;
        default:
          throw new ArgumentOutOfRangeException("statueType");
      }
    }
    #endregion

    #region [Methods: GetChestType, GetChestKind]
    public static ChestType GetChestType(DPoint anyChestTileLocation, out bool isLocked) {
      Tile tile = Terraria.Tiles[anyChestTileLocation];
      if (tile.type != Terraria.TileId_Statue)
        throw new ArgumentException("The tile at the given location is not of type Chest.", "anyChestTileLocation");

      isLocked = false;
      if (tile.frameX <= 18) {
        return ChestType.WoodenChest;
      } else if (tile.frameX <= 54) {
        return ChestType.GoldChest;
      } else if (tile.frameX <= 90) {
        isLocked = true;
        return ChestType.GoldChest;
      } else if (tile.frameX <= 126) {
        return ChestType.ShadowChest;
      } else if (tile.frameX <= 162) {
        isLocked = true;
        return ChestType.ShadowChest;
      } else if (tile.frameX <= 198) {
        return ChestType.Barrel;
      }

      return ChestType.TrashCan;
    }

    public static ChestKind GetChestKind(DPoint anyChestTileLocation) {
      bool isLocked;
      ChestType chestType = Terraria.GetChestType(anyChestTileLocation, out isLocked);

      switch (chestType) {
        case ChestType.GoldChest:
          Tile chestTile = Terraria.Tiles[anyChestTileLocation];

          if (isLocked) {
            if (chestTile.wall < Terraria.WallId_DungeonBlueBrickWall || chestTile.wall > Terraria.WallId_DungeonPinkBrickWall)
              return ChestKind.SkyIslandChest;

            return ChestKind.DungeonChest;
          }

          if (chestTile.liquid < 255 || chestTile.lava)
            return ChestKind.Unknown;
          if (anyChestTileLocation.X > 250 && anyChestTileLocation.X > Main.maxTilesX - 250)
            return ChestKind.Unknown;
          if (anyChestTileLocation.Y < Main.worldSurface - 450 || anyChestTileLocation.Y > Main.worldSurface)
            return ChestKind.Unknown;

          return ChestKind.OceanChest;
        case ChestType.ShadowChest:
          return ChestKind.ShadowChest;
        default:
          return ChestKind.Unknown;
      }
    }
    #endregion

    #region [Methods: EnumerateSpriteTileLocations, EnumerateSpriteTiles]
    public static IEnumerable<DPoint> EnumerateSpriteTileLocations(Terraria.SpriteMeasureData measureData) {
      for (int x = measureData.OriginTileLocation.X; x < measureData.OriginTileLocation.X + measureData.Size.X; x++) {
        for (int y = measureData.OriginTileLocation.Y; y < measureData.OriginTileLocation.Y + measureData.Size.Y; y++) {
          yield return new DPoint(x, y);
        }
      }
    }

    public static IEnumerable<Tile> EnumerateSpriteTiles(Terraria.SpriteMeasureData measureData) {
      for (int x = measureData.OriginTileLocation.X; x < measureData.OriginTileLocation.X + measureData.Size.X; x++) {
        for (int y = measureData.OriginTileLocation.Y; y < measureData.OriginTileLocation.Y + measureData.Size.Y; y++) {
          yield return Terraria.Tiles[x, y];
        }
      }
    }
    #endregion

    #region [Methods: GetSpriteSize, GetSpriteOrientation]
    private static DPoint[] spriteSizes;
    public static DPoint GetSpriteSize(int blockId) {
      if (Terraria.spriteSizes == null) {
        Terraria.spriteSizes = new[] {
          new DPoint(1, 1), // Dirt
          new DPoint(1, 1), // Stone
          new DPoint(1, 1), // Grass
          new DPoint(1, 1), // Grass Plant
          new DPoint(1, 1), // Torch
          new DPoint(1, 1), // Tree (dynamic!)
          new DPoint(1, 1), // Iron Ore
          new DPoint(1, 1), // Copper Ore
          new DPoint(1, 1), // Gold Ore
          new DPoint(1, 1), // Silver Ore
          new DPoint(1, 3), // Door (Closed)
          new DPoint(2, 3), // Door (Opened)
          new DPoint(2, 2), // Crystal Heart
          new DPoint(1, 1), // Bottle
          new DPoint(3, 2), // Wooden Table
          new DPoint(1, 2), // Wooden Chair
          new DPoint(2, 1), // Iron Anvil
          new DPoint(3, 2), // Furnace
          new DPoint(2, 1), // Work Bench
          new DPoint(1, 1), // Wood Platform
          new DPoint(1, 2), // Sapling
          new DPoint(2, 2), // Chest
          new DPoint(1, 1), // Demonite Ore
          new DPoint(1, 1), // Corrupt Grass
          new DPoint(1, 1), // Corruption Plant
          new DPoint(1, 1), // Ebonstone Block
          new DPoint(3, 2), // Demon Altar
          new DPoint(2, 4), // Sunflower
          new DPoint(2, 2), // Pot
          new DPoint(2, 1), // Piggy Bank
          new DPoint(1, 1), // Wood
          new DPoint(2, 2), // Shadow Orb
          new DPoint(1, 1), // Corruption Thorny Bush
          new DPoint(1, 1), // Candle
          new DPoint(3, 3), // Copper Chandelier
          new DPoint(3, 3), // Silver Chandelier
          new DPoint(3, 3), // Gold Chandelier
          new DPoint(1, 1), // Meteorite
          new DPoint(1, 1), // Gray Brick
          new DPoint(1, 1), // Red Brick
          new DPoint(1, 1), // Clay
          new DPoint(1, 1), // Blue Brick
          new DPoint(1, 2), // Chain Lantern
          new DPoint(1, 1), // Green Brick
          new DPoint(1, 1), // Pink Brick
          new DPoint(1, 1), // Gold Brick
          new DPoint(1, 1), // Silver Brick
          new DPoint(1, 1), // Copper Brick
          new DPoint(1, 1), // Spike
          new DPoint(1, 1), // Water Candle
          new DPoint(1, 1), // Book
          new DPoint(1, 1), // Cobweb
          new DPoint(1, 1), // Vines (dynamic!)
          new DPoint(1, 1), // Sand
          new DPoint(1, 1), // Glass
          new DPoint(2, 2), // Sign
          new DPoint(1, 1), // Obsidian
          new DPoint(1, 1), // Ash
          new DPoint(1, 1), // Hellstone
          new DPoint(1, 1), // Mud
          new DPoint(1, 1), // Jungle Grass
          new DPoint(1, 1), // Jungle Plant
          new DPoint(1, 1), // Jungle Vine (dynamic!)
          new DPoint(1, 1), // Sapphire
          new DPoint(1, 1), // Ruby
          new DPoint(1, 1), // Emerald
          new DPoint(1, 1), // Topaz
          new DPoint(1, 1), // Amethyst
          new DPoint(1, 1), // Diamond
          new DPoint(1, 1), // Jungle Thorny Bush
          new DPoint(1, 1), // Mushroom Grass
          new DPoint(1, 1), // Glowing Mushroom
          new DPoint(1, 1), // Giant Glowing Mushroom (dynamic!)
          new DPoint(1, 2), // Tall Grass Plant
          new DPoint(1, 2), // Tall Jungle Plant
          new DPoint(1, 1), // Obsidian Brick
          new DPoint(1, 1), // Hellstone Brick
          new DPoint(3, 2), // Hellforge
          new DPoint(1, 1), // ClayPot
          new DPoint(4, 2), // Bed
          new DPoint(1, 1), // Cactus (dynamic!)
          new DPoint(1, 1), // Coral
          new DPoint(1, 1), // Plantable Plant (Growing)
          new DPoint(1, 1), // Plantable Plant (Mature)
          new DPoint(1, 1), // Plantable Plant (Blooming)
          new DPoint(2, 2), // Tombstone
          new DPoint(3, 2), // Loom
          new DPoint(3, 2), // Piano
          new DPoint(3, 2), // Dresser
          new DPoint(3, 2), // Bench
          new DPoint(4, 2), // Bathtub
          new DPoint(1, 3), // Banner
          new DPoint(1, 6), // LampPost
          new DPoint(1, 3), // Tiki Torch
          new DPoint(2, 2), // Keg
          new DPoint(2, 2), // Chinese Lantern
          new DPoint(2, 2), // Cooking Pot
          new DPoint(2, 2), // Safe
          new DPoint(2, 2), // Skull Lantern
          new DPoint(2, 2), // TashCan
          new DPoint(2, 2), // Candelabra
          new DPoint(3, 4), // Bookcase
          new DPoint(3, 4), // Throne
          new DPoint(2, 1), // Bowl
          new DPoint(2, 5), // Grandfather Clock
          new DPoint(2, 3), // Statue
          new DPoint(3, 3), // Sawmill
          new DPoint(1, 1), // Cobalt Ore
          new DPoint(1, 1), // Mythril Ore
          new DPoint(1, 1), // Hallowed Grass
          new DPoint(1, 1), // Hallowed Plant
          new DPoint(1, 1), // Adamantite Ore
          new DPoint(1, 1), // Ebonsand
          new DPoint(1, 2), // Tall Hallowed Plant
          new DPoint(3, 2), // Tinkerer's Workshop
          new DPoint(1, 1), // Hallowed Vine (dynamic!)
          new DPoint(1, 1), // Pearlsand
          new DPoint(1, 1), // Pearlstone
          new DPoint(1, 1), // Pearlstone Brick
          new DPoint(1, 1), // Iridescent Brick
          new DPoint(1, 1), // Mudstone
          new DPoint(1, 1), // Cobalt Brick
          new DPoint(1, 1), // Mythril Brick
          new DPoint(1, 1), // Silt
          new DPoint(1, 1), // Wooden Beam
          new DPoint(2, 2), // Crystal Ball
          new DPoint(2, 2), // Disco Ball
          new DPoint(1, 1), // Ice
          new DPoint(2, 3), // Mannequin
          new DPoint(1, 1), // Crystal Shard
          new DPoint(1, 1), // Active Stone
          new DPoint(1, 1), // Inactive Stone
          new DPoint(2, 2), // Lever
          new DPoint(3, 2), // Adamantite Forge
          new DPoint(2, 1), // Mythril Anvil
          new DPoint(1, 1), // Pressure Plate
          new DPoint(1, 1), // Switch
          new DPoint(1, 1), // Dart Trap
          new DPoint(2, 2), // Boulder
          new DPoint(2, 2), // Music Box
          new DPoint(1, 1), // Demonite Brick
          new DPoint(1, 1), // Explosives
          new DPoint(2, 2), // Inlet Pump
          new DPoint(2, 2), // Outlet Pump
          new DPoint(1, 1), // XSecond Timer
          new DPoint(1, 1), // Red Candy Cane
          new DPoint(1, 1), // Green Candy Cane
          new DPoint(1, 1), // Snow
          new DPoint(1, 1), // Snow Brick
          new DPoint(1, 1), // X-Mas Light
        };
      }

      if (blockId < 0 || blockId >= Terraria.spriteSizes.Length)
        throw new ArgumentException(string.Format("The tild id \"{0}\" is invalid.", blockId), "blockId");

      return Terraria.spriteSizes[blockId];
    }

    public static Direction GetSpriteOrientation(Tile anyTile) {
      if (!anyTile.active)
        return Direction.Unknown;

      switch (anyTile.type) {
        case Terraria.TileId_Torch:
          if (anyTile.frameX == 44 || anyTile.frameX == 110)
            return Direction.Left;

          if (anyTile.frameX == 22 || anyTile.frameX == 88)
            return Direction.Right;

          return Direction.Up;

        case Terraria.TileId_Sign:
          if (anyTile.frameX < 36)
            return Direction.Up;

          if (anyTile.frameX == 36 || anyTile.frameX == 54)
            return Direction.Down;

          if (anyTile.frameX == 72 || anyTile.frameX == 90)
            return Direction.Right;

          return Direction.Left;

        case Terraria.TileId_CrystalShard:
          if (anyTile.frameY == 0)
            return Direction.Up;

          if (anyTile.frameY == 18)
            return Direction.Down;

          if (anyTile.frameY == 36)
            return Direction.Left;

          return Direction.Right;

        case Terraria.TileId_Switch:
          if (anyTile.frameX == 0)
            return Direction.Up;

          if (anyTile.frameX == 18)
            return Direction.Right;

          return Direction.Left;

        default:
          return Direction.Unknown;
      }
    }
    #endregion

    #region [Method: IsValidItemId]
    public static bool IsValidItemId(int itemId) {
      return (itemId >= Terraria.ItemId_Min && itemId <= Terraria.ItemId_Max);
    }
    #endregion

    #region [Methods: CountNPCsInTileRange, CountItemsInTileRange]
    public static int CountNPCsInTileRange(int x, int y, int npcType, int rangeInTiles) {
      int halfAreaWidth = (rangeInTiles * Terraria.TileSize) / 2;
      int areaL = x - halfAreaWidth;
      int areaT = y - halfAreaWidth;
      int areaR = x + halfAreaWidth;
      int areaB = y + halfAreaWidth;
      int count = 0;

      for (int i = 0; i < 200; i++) {
        NPC npc = Main.npc[i];

        if (
          npc.active && npc.type == npcType && 
          npc.position.X > areaL && npc.position.X < areaR &&
          npc.position.Y > areaT && npc.position.Y < areaB
        ) {
          count++;
        }
      }

      return count;
    }

    public static int CountItemsInTileRange(int x, int y, int itemType, int rangeInTiles) {
      int halfAreaWidth = (rangeInTiles * 16) / 2;
      int areaL = x - halfAreaWidth;
      int areaT = y - halfAreaWidth;
      int areaR = x + halfAreaWidth;
      int areaB = y + halfAreaWidth;
      int count = 0;

      for (int i = 0; i < 200; i++) {
        Item item = Main.item[i];

        if (
          item.active && item.type == itemType && 
          item.position.X > areaL && item.position.X < areaR &&
          item.position.Y > areaT && item.position.Y < areaB
        ) {
          count++;
        }
      }

      return count;
    }
    #endregion

    #region [Methods: GetSpecificNPCIndexes, GetFriendlyNPCIndexes, GetFriendlyFemaleNPCIndexes, GetFriendlyMaleNPCIndexes]
    public static List<int> GetSpecificNPCIndexes(IList<int> npcTypes) {
      List<int> npcIndexes = new List<int>();
      for (int i = 0; i < 200; i++) {
        NPC npc = Main.npc[i];

        if (!npc.active || !npc.friendly)
          continue;

        if (npcTypes.Contains(npc.type)) {
          npcIndexes.Add(i);

          if (npcIndexes.Count == 10 || npcTypes.Count == 1)
            break;
        }
      }

      return npcIndexes;
    }

    public static List<int> GetFriendlyNPCIndexes() {
      return Terraria.GetSpecificNPCIndexes(new List<int> { 17, 18, 19, 20, 22, 38, 54, 107, 108, 124 });
    }

    public static List<int> GetFriendlyFemaleNPCIndexes() {
      return Terraria.GetSpecificNPCIndexes(new List<int> { 18, 20, 124 });
    }

    public static List<int> GetFriendlyMaleNPCIndexes() {
      return Terraria.GetSpecificNPCIndexes(new List<int> { 17, 19, 22, 38, 54, 107, 108 });
    }
    #endregion
  }
}
