using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Familiaris.Models
{
    public partial class ApiModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public WeaponTypeEnum? Type { get; set; }

        [JsonProperty("species", NullValueHandling = NullValueHandling.Ignore)]
        public string Species { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("elements", NullValueHandling = NullValueHandling.Ignore)]
        public List<ElementUnion> Elements { get; set; }

        [JsonProperty("ailments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Ailment> Ailments { get; set; }

        [JsonProperty("locations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Location> Locations { get; set; }

        [JsonProperty("resistances", NullValueHandling = NullValueHandling.Ignore)]
        public ResistancesUnion? Resistances { get; set; }

        [JsonProperty("weaknesses", NullValueHandling = NullValueHandling.Ignore)]
        public List<Weakness> Weaknesses { get; set; }

        [JsonProperty("rewards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Reward> Rewards { get; set; }

        [JsonProperty("recovery", NullValueHandling = NullValueHandling.Ignore)]
        public Recovery Recovery { get; set; }

        [JsonProperty("protection", NullValueHandling = NullValueHandling.Ignore)]
        public Protection Protection { get; set; }

        [JsonProperty("rarity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rarity { get; set; }

        [JsonProperty("carryLimit", NullValueHandling = NullValueHandling.Ignore)]
        public long? CarryLimit { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public RankEnum? Rank { get; set; }

        [JsonProperty("defense", NullValueHandling = NullValueHandling.Ignore)]
        public Defense Defense { get; set; }

        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public ApiModelAttributes? Attributes { get; set; }

        [JsonProperty("slots", NullValueHandling = NullValueHandling.Ignore)]
        public List<Slot> Slots { get; set; }

        [JsonProperty("skills", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApiModelSkill> Skills { get; set; }

        [JsonProperty("armorSet")]
        public ArmorSet ArmorSet { get; set; }

        [JsonProperty("assets")]
        public ApiModelAssets Assets { get; set; }

        [JsonProperty("crafting", NullValueHandling = NullValueHandling.Ignore)]
        public ApiModelCrafting Crafting { get; set; }

        [JsonProperty("pieces", NullValueHandling = NullValueHandling.Ignore)]
        public List<Piece> Pieces { get; set; }

        [JsonProperty("bonus")]
        public Bonus Bonus { get; set; }

        [JsonProperty("ranks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApiModelRankClass> Ranks { get; set; }

        [JsonProperty("slot", NullValueHandling = NullValueHandling.Ignore)]
        public long? Slot { get; set; }

        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public Platform? Platform { get; set; }

        [JsonProperty("exclusive")]
        public string Exclusive { get; set; }

        [JsonProperty("expansion", NullValueHandling = NullValueHandling.Ignore)]
        public Expansion? Expansion { get; set; }

        [JsonProperty("requirements")]
        public string Requirements { get; set; }

        [JsonProperty("questRank", NullValueHandling = NullValueHandling.Ignore)]
        public long? QuestRank { get; set; }

        [JsonProperty("masterRank", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MasterRank { get; set; }

        [JsonProperty("successConditions", NullValueHandling = NullValueHandling.Ignore)]
        public string SuccessConditions { get; set; }

        [JsonProperty("startTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public StartTimestamp? StartTimestamp { get; set; }

        [JsonProperty("endTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public EndTimestamp? EndTimestamp { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }

        [JsonProperty("zoneCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? ZoneCount { get; set; }

        [JsonProperty("camps", NullValueHandling = NullValueHandling.Ignore)]
        public List<Camp> Camps { get; set; }

        [JsonProperty("weaponType", NullValueHandling = NullValueHandling.Ignore)]
        public WeaponTypeEnum? WeaponType { get; set; }

        [JsonProperty("damageType")]
        public DamageType? DamageType { get; set; }

        [JsonProperty("stun")]
        public long? Stun { get; set; }

        [JsonProperty("exhaust")]
        public long? Exhaust { get; set; }

        [JsonProperty("hits", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Hits { get; set; }

        [JsonProperty("attack", NullValueHandling = NullValueHandling.Ignore)]
        public Attack Attack { get; set; }

        [JsonProperty("elderseal")]
        public Deviation? Elderseal { get; set; }

        [JsonProperty("durability", NullValueHandling = NullValueHandling.Ignore)]
        public List<Durability> Durability { get; set; }

        [JsonProperty("shelling", NullValueHandling = NullValueHandling.Ignore)]
        public Shelling Shelling { get; set; }

        [JsonProperty("phial", NullValueHandling = NullValueHandling.Ignore)]
        public Phial Phial { get; set; }

        [JsonProperty("boostType", NullValueHandling = NullValueHandling.Ignore)]
        public BoostTypeEnum? BoostType { get; set; }

        [JsonProperty("specialAmmo")]
        public SpecialAmmo? SpecialAmmo { get; set; }

        [JsonProperty("deviation", NullValueHandling = NullValueHandling.Ignore)]
        public Deviation? Deviation { get; set; }

        [JsonProperty("ammo", NullValueHandling = NullValueHandling.Ignore)]
        public List<Ammo> Ammo { get; set; }

        [JsonProperty("coatings", NullValueHandling = NullValueHandling.Ignore)]
        public List<Coating> Coatings { get; set; }
    }

    public partial class Ailment
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("recovery")]
        public Recovery Recovery { get; set; }

        [JsonProperty("protection")]
        public Protection Protection { get; set; }
    }

    public partial class Protection
    {
        [JsonProperty("skills")]
        public List<ProtectionSkill> Skills { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rarity")]
        public long Rarity { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("carryLimit")]
        public long CarryLimit { get; set; }
    }

    public partial class ProtectionSkill
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class Recovery
    {
        [JsonProperty("actions")]
        public List<Action> Actions { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }

    public partial class Ammo
    {
        [JsonProperty("type")]
        public AmmoType Type { get; set; }

        [JsonProperty("capacities")]
        public List<long> Capacities { get; set; }
    }

    public partial class ArmorSet
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public RankEnum Rank { get; set; }

        [JsonProperty("pieces")]
        public List<long> Pieces { get; set; }

        [JsonProperty("bonus")]
        public long? Bonus { get; set; }
    }

    public partial class ApiModelAssets
    {
        [JsonProperty("imageMale")]
        public Uri ImageMale { get; set; }

        [JsonProperty("imageFemale")]
        public Uri ImageFemale { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Image { get; set; }
    }

    public partial class Attack
    {
        [JsonProperty("display")]
        public long Display { get; set; }

        [JsonProperty("raw")]
        public long Raw { get; set; }
    }

    public partial class PurpleAttributes
    {
        [JsonProperty("requiredGender", NullValueHandling = NullValueHandling.Ignore)]
        public RequiredGender? RequiredGender { get; set; }

        [JsonProperty("affinity", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodingChoiceConverter))]
        public long? Affinity { get; set; }

        [JsonProperty("defense", NullValueHandling = NullValueHandling.Ignore)]
        public long? Defense { get; set; }

        [JsonProperty("damageType", NullValueHandling = NullValueHandling.Ignore)]
        public BoostTypeEnum? DamageType { get; set; }

        [JsonProperty("elderseal", NullValueHandling = NullValueHandling.Ignore)]
        public Deviation? Elderseal { get; set; }
    }

    public partial class Bonus
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ranks")]
        public List<BonusRank> Ranks { get; set; }
    }

    public partial class BonusRank
    {
        [JsonProperty("pieces")]
        public long Pieces { get; set; }

        [JsonProperty("skill")]
        public PurpleSkill Skill { get; set; }
    }

    public partial class PurpleSkill
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modifiers")]
        public TentacledModifiers Modifiers { get; set; }

        [JsonProperty("skill")]
        public long Skill { get; set; }

        [JsonProperty("skillName")]
        public string SkillName { get; set; }
    }

    public partial class PurpleModifiers
    {
        [JsonProperty("affinity")]
        public long Affinity { get; set; }
    }

    public partial class Camp
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public CampName Name { get; set; }

        [JsonProperty("zone")]
        public long Zone { get; set; }
    }

    public partial class ApiModelCrafting
    {
        [JsonProperty("materials", NullValueHandling = NullValueHandling.Ignore)]
        public List<Material> Materials { get; set; }

        [JsonProperty("craftable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Craftable { get; set; }

        [JsonProperty("previous")]
        public long? Previous { get; set; }

        [JsonProperty("branches", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Branches { get; set; }

        [JsonProperty("craftingMaterials", NullValueHandling = NullValueHandling.Ignore)]
        public List<Material> CraftingMaterials { get; set; }

        [JsonProperty("upgradeMaterials", NullValueHandling = NullValueHandling.Ignore)]
        public List<Material> UpgradeMaterials { get; set; }
    }

    public partial class Material
    {
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }
    }

    public partial class Defense
    {
        [JsonProperty("base")]
        public long Base { get; set; }

        [JsonProperty("max")]
        public long Max { get; set; }

        [JsonProperty("augmented")]
        public long Augmented { get; set; }
    }

    public partial class Durability
    {
        [JsonProperty("red")]
        public long Red { get; set; }

        [JsonProperty("orange")]
        public long Orange { get; set; }

        [JsonProperty("yellow")]
        public long Yellow { get; set; }

        [JsonProperty("green")]
        public long Green { get; set; }

        [JsonProperty("blue")]
        public long Blue { get; set; }

        [JsonProperty("white")]
        public long White { get; set; }
    }

    public partial class ElementClass
    {
        [JsonProperty("type")]
        public ElementEnum Type { get; set; }

        [JsonProperty("damage")]
        public long Damage { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public LocationName Name { get; set; }

        [JsonProperty("zoneCount")]
        public long ZoneCount { get; set; }

        [JsonProperty("camps", NullValueHandling = NullValueHandling.Ignore)]
        public List<Camp> Camps { get; set; }
    }

    public partial class Phial
    {
        [JsonProperty("type")]
        public PhialType Type { get; set; }

        [JsonProperty("damage")]
        public long? Damage { get; set; }
    }

    public partial class Piece
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public WeaponTypeEnum Type { get; set; }

        [JsonProperty("rank")]
        public RankEnum Rank { get; set; }

        [JsonProperty("rarity")]
        public long Rarity { get; set; }

        [JsonProperty("attributes")]
        public PieceAttributes Attributes { get; set; }

        [JsonProperty("defense")]
        public Defense Defense { get; set; }

        [JsonProperty("resistances")]
        public ResistancesClass Resistances { get; set; }

        [JsonProperty("slots")]
        public List<Slot> Slots { get; set; }

        [JsonProperty("skills")]
        public List<PieceSkill> Skills { get; set; }

        [JsonProperty("armorSet")]
        public long ArmorSet { get; set; }

        [JsonProperty("assets")]
        public PieceAssets Assets { get; set; }

        [JsonProperty("crafting")]
        public PieceCrafting Crafting { get; set; }
    }

    public partial class PieceAssets
    {
        [JsonProperty("imageMale")]
        public Uri ImageMale { get; set; }

        [JsonProperty("imageFemale")]
        public Uri ImageFemale { get; set; }
    }

    public partial class FluffyAttributes
    {
        [JsonProperty("requiredGender")]
        public RequiredGender RequiredGender { get; set; }
    }

    public partial class PieceCrafting
    {
        [JsonProperty("materials")]
        public List<Material> Materials { get; set; }
    }

    public partial class ResistancesClass
    {
        [JsonProperty("fire")]
        public long Fire { get; set; }

        [JsonProperty("water")]
        public long Water { get; set; }

        [JsonProperty("ice")]
        public long Ice { get; set; }

        [JsonProperty("thunder")]
        public long Thunder { get; set; }

        [JsonProperty("dragon")]
        public long Dragon { get; set; }
    }

    public partial class PieceSkill
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modifiers")]
        public StickyModifiers Modifiers { get; set; }

        [JsonProperty("skill")]
        public string Skill { get; set; }

        [JsonProperty("skillName")]
        public string SkillName { get; set; }
    }

    public partial class Slot
    {
        [JsonProperty("rank")]
        public long Rank { get; set; }
    }

    public partial class ApiModelRankClass
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("rarity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rarity { get; set; }

        [JsonProperty("skills", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApiModelSkill> Skills { get; set; }

        [JsonProperty("crafting", NullValueHandling = NullValueHandling.Ignore)]
        public RankCrafting Crafting { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("skill", NullValueHandling = NullValueHandling.Ignore)]
        public long? Skill { get; set; }

        [JsonProperty("skillName", NullValueHandling = NullValueHandling.Ignore)]
        public string SkillName { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("modifiers", NullValueHandling = NullValueHandling.Ignore)]
        public RankModifiers? Modifiers { get; set; }
    }

    public partial class RankCrafting
    {
        [JsonProperty("craftable")]
        public bool Craftable { get; set; }

        [JsonProperty("materials")]
        public List<Material> Materials { get; set; }
    }

    public partial class FluffyModifiers
    {
        [JsonProperty("attack", NullValueHandling = NullValueHandling.Ignore)]
        public long? Attack { get; set; }

        [JsonProperty("affinity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Affinity { get; set; }

        [JsonProperty("defense", NullValueHandling = NullValueHandling.Ignore)]
        public long? Defense { get; set; }

        [JsonProperty("resistAll", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResistAll { get; set; }

        [JsonProperty("health", NullValueHandling = NullValueHandling.Ignore)]
        public long? Health { get; set; }

        [JsonProperty("resistFire", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResistFire { get; set; }

        [JsonProperty("resistWater", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResistWater { get; set; }

        [JsonProperty("resistIce", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResistIce { get; set; }

        [JsonProperty("resistThunder", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResistThunder { get; set; }

        [JsonProperty("resistDragon", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResistDragon { get; set; }

        [JsonProperty("damageFire", NullValueHandling = NullValueHandling.Ignore)]
        public Damage? DamageFire { get; set; }

        [JsonProperty("damageWater", NullValueHandling = NullValueHandling.Ignore)]
        public Damage? DamageWater { get; set; }

        [JsonProperty("damageIce", NullValueHandling = NullValueHandling.Ignore)]
        public Damage? DamageIce { get; set; }

        [JsonProperty("damageThunder", NullValueHandling = NullValueHandling.Ignore)]
        public Damage? DamageThunder { get; set; }

        [JsonProperty("damageDragon", NullValueHandling = NullValueHandling.Ignore)]
        public Damage? DamageDragon { get; set; }

        [JsonProperty("sharpnessBonus", NullValueHandling = NullValueHandling.Ignore)]
        public long? SharpnessBonus { get; set; }
    }

    public partial class ApiModelSkill
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modifiers")]
        public StickyModifiers Modifiers { get; set; }

        [JsonProperty("skill")]
        public long Skill { get; set; }

        [JsonProperty("skillName")]
        public string SkillName { get; set; }
    }

    public partial class Resistance
    {
        [JsonProperty("element")]
        public ElementEnum Element { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }
    }

    public partial class Reward
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("conditions")]
        public List<Condition> Conditions { get; set; }
    }

    public partial class Condition
    {
        [JsonProperty("type")]
        public ConditionType Type { get; set; }

        [JsonProperty("subtype")]
        public Subtype? Subtype { get; set; }

        [JsonProperty("rank")]
        public RankEnum Rank { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("chance")]
        public long Chance { get; set; }
    }

    public partial class Shelling
    {
        [JsonProperty("type")]
        public ShellingType Type { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }
    }

    public partial class Weakness
    {
        [JsonProperty("element")]
        public ElementEnum Element { get; set; }

        [JsonProperty("stars")]
        public long Stars { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }
    }

    public enum Action { Dodge };

    public enum AmmoType { Armor, Cluster, Demon, Dragon, Exhaust, Flaming, Freeze, Normal, Paralysis, Piercing, Poison, Recover, Sleep, Slicing, Spread, Sticky, Thunder, Tranq, Water, Wyvern };

    public enum RankEnum { High, Low, Master };

    public enum BoostTypeEnum { Blunt, BluntBoost, Element, Health, Sever, Speed, Stamina };

    public enum Deviation { Average, High, Low, None };

    public enum RequiredGender { Female, Male };

    public enum CampName { AncientForestCamp, Camp, CentralCamp, EasternCamp, NortheastCamp, NorthwestCamp, ShipwreckCamp, SoutheastCamp, SouthernCamp, SouthwestCamp, WesternCamp };

    public enum Coating { Blast, CloseRange, CoatingBlast, CoatingCloseRange, CoatingParalysis, CoatingSleep, Paralysis, Poison, Power, Sleep };

    public enum DamageType { Blunt, Projectile, Sever, SeverBlunt };

    public enum ElementEnum { Blast, Dragon, Fire, Ice, Paralysis, Poison, Sleep, Stun, Thunder, Water };

    public enum EndTimestamp { The20190109T2359000000, The20200102T2359000000, The20200105T2359000000, The20200109T2359000000, The20200123T2359000000 };

    public enum Expansion { Base, Iceborne };

    public enum LocationName { AncientForest, Arena, CavernsOfElDorado, ConfluenceOfFates, CoralHighlands, ElderSRecess, Everstream, GreatRavine, GuidingLands, HoarfrostReach, RottenVale, SecludedValley, SpecialArena, WildspireWaste };

    public enum PhialType { Dragon, Exhaust, Impact, Para, Poison, Power, PowerElement };

    public enum WeaponTypeEnum { Bow, ChallengeQuest, ChargeBlade, Chest, DualBlades, EventQuest, Gloves, GreatSword, Gunlance, Hammer, Head, HeavyBowgun, HuntingHorn, InsectGlaive, KulveTarothSiege, Lance, Large, Legs, LightBowgun, LongSword, SafiJiivaSiege, Small, SwitchAxe, SwordAndShield, Waist };

    public enum Platform { Console, Pc };

    public enum Subtype { Back, Body, Forearms, Gold, Head, HeadShell, Hindlegs, Horn, Horns, Silver, Tail, Wings };

    public enum ConditionType { Carve, Investigation, Palico, Plunderblade, Reward, Shiny, Track, Wound };

    public enum ShellingType { Long, Normal, Wide };

    public enum SpecialAmmo { Wyvernblast, Wyvernheart, Wyvernsnipe };

    public enum StartTimestamp { The20190103T0000000000, The20191122T0000000000, The20191129T0000000000, The20191213T0000000000, The20191220T0000000000, The20191227T0000000000 };

    public partial struct ApiModelAttributes
    {
        public List<object> AnythingArray;
        public PurpleAttributes PurpleAttributes;

        public static implicit operator ApiModelAttributes(List<object> AnythingArray) => new ApiModelAttributes { AnythingArray = AnythingArray };
        public static implicit operator ApiModelAttributes(PurpleAttributes PurpleAttributes) => new ApiModelAttributes { PurpleAttributes = PurpleAttributes };
    }

    public partial struct TentacledModifiers
    {
        public List<object> AnythingArray;
        public PurpleModifiers PurpleModifiers;

        public static implicit operator TentacledModifiers(List<object> AnythingArray) => new TentacledModifiers { AnythingArray = AnythingArray };
        public static implicit operator TentacledModifiers(PurpleModifiers PurpleModifiers) => new TentacledModifiers { PurpleModifiers = PurpleModifiers };
    }

    public partial struct ElementUnion
    {
        public ElementClass ElementClass;
        public ElementEnum? Enum;

        public static implicit operator ElementUnion(ElementClass ElementClass) => new ElementUnion { ElementClass = ElementClass };
        public static implicit operator ElementUnion(ElementEnum Enum) => new ElementUnion { Enum = Enum };
    }

    public partial struct PieceAttributes
    {
        public List<object> AnythingArray;
        public FluffyAttributes FluffyAttributes;

        public static implicit operator PieceAttributes(List<object> AnythingArray) => new PieceAttributes { AnythingArray = AnythingArray };
        public static implicit operator PieceAttributes(FluffyAttributes FluffyAttributes) => new PieceAttributes { FluffyAttributes = FluffyAttributes };
    }

    public partial struct StickyModifiers
    {
        public List<object> AnythingArray;
        public Dictionary<string, long> IntegerMap;

        public static implicit operator StickyModifiers(List<object> AnythingArray) => new StickyModifiers { AnythingArray = AnythingArray };
        public static implicit operator StickyModifiers(Dictionary<string, long> IntegerMap) => new StickyModifiers { IntegerMap = IntegerMap };
    }

    public partial struct Damage
    {
        public long? Integer;
        public string String;

        public static implicit operator Damage(long Integer) => new Damage { Integer = Integer };
        public static implicit operator Damage(string String) => new Damage { String = String };
    }

    public partial struct RankModifiers
    {
        public List<object> AnythingArray;
        public FluffyModifiers FluffyModifiers;

        public static implicit operator RankModifiers(List<object> AnythingArray) => new RankModifiers { AnythingArray = AnythingArray };
        public static implicit operator RankModifiers(FluffyModifiers FluffyModifiers) => new RankModifiers { FluffyModifiers = FluffyModifiers };
    }

    public partial struct ResistancesUnion
    {
        public List<Resistance> ResistanceArray;
        public ResistancesClass ResistancesClass;

        public static implicit operator ResistancesUnion(List<Resistance> ResistanceArray) => new ResistancesUnion { ResistanceArray = ResistanceArray };
        public static implicit operator ResistancesUnion(ResistancesClass ResistancesClass) => new ResistancesUnion { ResistancesClass = ResistancesClass };
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ActionConverter.Singleton,
                AmmoTypeConverter.Singleton,
                RankEnumConverter.Singleton,
                ApiModelAttributesConverter.Singleton,
                BoostTypeEnumConverter.Singleton,
                DeviationConverter.Singleton,
                RequiredGenderConverter.Singleton,
                TentacledModifiersConverter.Singleton,
                CampNameConverter.Singleton,
                CoatingConverter.Singleton,
                DamageTypeConverter.Singleton,
                ElementUnionConverter.Singleton,
                ElementEnumConverter.Singleton,
                EndTimestampConverter.Singleton,
                ExpansionConverter.Singleton,
                LocationNameConverter.Singleton,
                PhialTypeConverter.Singleton,
                PieceAttributesConverter.Singleton,
                StickyModifiersConverter.Singleton,
                WeaponTypeEnumConverter.Singleton,
                PlatformConverter.Singleton,
                RankModifiersConverter.Singleton,
                DamageConverter.Singleton,
                ResistancesUnionConverter.Singleton,
                SubtypeConverter.Singleton,
                ConditionTypeConverter.Singleton,
                ShellingTypeConverter.Singleton,
                SpecialAmmoConverter.Singleton,
                StartTimestampConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ActionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Action) || t == typeof(Action?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "dodge")
            {
                return Action.Dodge;
            }
            throw new Exception("Cannot unmarshal type Action");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Action)untypedValue;
            if (value == Action.Dodge)
            {
                serializer.Serialize(writer, "dodge");
                return;
            }
            throw new Exception("Cannot marshal type Action");
        }

        public static readonly ActionConverter Singleton = new ActionConverter();
    }

    internal class AmmoTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AmmoType) || t == typeof(AmmoType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "armor":
                    return AmmoType.Armor;
                case "cluster":
                    return AmmoType.Cluster;
                case "demon":
                    return AmmoType.Demon;
                case "dragon":
                    return AmmoType.Dragon;
                case "exhaust":
                    return AmmoType.Exhaust;
                case "flaming":
                    return AmmoType.Flaming;
                case "freeze":
                    return AmmoType.Freeze;
                case "normal":
                    return AmmoType.Normal;
                case "paralysis":
                    return AmmoType.Paralysis;
                case "piercing":
                    return AmmoType.Piercing;
                case "poison":
                    return AmmoType.Poison;
                case "recover":
                    return AmmoType.Recover;
                case "sleep":
                    return AmmoType.Sleep;
                case "slicing":
                    return AmmoType.Slicing;
                case "spread":
                    return AmmoType.Spread;
                case "sticky":
                    return AmmoType.Sticky;
                case "thunder":
                    return AmmoType.Thunder;
                case "tranq":
                    return AmmoType.Tranq;
                case "water":
                    return AmmoType.Water;
                case "wyvern":
                    return AmmoType.Wyvern;
            }
            throw new Exception("Cannot unmarshal type AmmoType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AmmoType)untypedValue;
            switch (value)
            {
                case AmmoType.Armor:
                    serializer.Serialize(writer, "armor");
                    return;
                case AmmoType.Cluster:
                    serializer.Serialize(writer, "cluster");
                    return;
                case AmmoType.Demon:
                    serializer.Serialize(writer, "demon");
                    return;
                case AmmoType.Dragon:
                    serializer.Serialize(writer, "dragon");
                    return;
                case AmmoType.Exhaust:
                    serializer.Serialize(writer, "exhaust");
                    return;
                case AmmoType.Flaming:
                    serializer.Serialize(writer, "flaming");
                    return;
                case AmmoType.Freeze:
                    serializer.Serialize(writer, "freeze");
                    return;
                case AmmoType.Normal:
                    serializer.Serialize(writer, "normal");
                    return;
                case AmmoType.Paralysis:
                    serializer.Serialize(writer, "paralysis");
                    return;
                case AmmoType.Piercing:
                    serializer.Serialize(writer, "piercing");
                    return;
                case AmmoType.Poison:
                    serializer.Serialize(writer, "poison");
                    return;
                case AmmoType.Recover:
                    serializer.Serialize(writer, "recover");
                    return;
                case AmmoType.Sleep:
                    serializer.Serialize(writer, "sleep");
                    return;
                case AmmoType.Slicing:
                    serializer.Serialize(writer, "slicing");
                    return;
                case AmmoType.Spread:
                    serializer.Serialize(writer, "spread");
                    return;
                case AmmoType.Sticky:
                    serializer.Serialize(writer, "sticky");
                    return;
                case AmmoType.Thunder:
                    serializer.Serialize(writer, "thunder");
                    return;
                case AmmoType.Tranq:
                    serializer.Serialize(writer, "tranq");
                    return;
                case AmmoType.Water:
                    serializer.Serialize(writer, "water");
                    return;
                case AmmoType.Wyvern:
                    serializer.Serialize(writer, "wyvern");
                    return;
            }
            throw new Exception("Cannot marshal type AmmoType");
        }

        public static readonly AmmoTypeConverter Singleton = new AmmoTypeConverter();
    }

    internal class RankEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RankEnum) || t == typeof(RankEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "high":
                    return RankEnum.High;
                case "low":
                    return RankEnum.Low;
                case "master":
                    return RankEnum.Master;
            }
            throw new Exception("Cannot unmarshal type RankEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RankEnum)untypedValue;
            switch (value)
            {
                case RankEnum.High:
                    serializer.Serialize(writer, "high");
                    return;
                case RankEnum.Low:
                    serializer.Serialize(writer, "low");
                    return;
                case RankEnum.Master:
                    serializer.Serialize(writer, "master");
                    return;
            }
            throw new Exception("Cannot marshal type RankEnum");
        }

        public static readonly RankEnumConverter Singleton = new RankEnumConverter();
    }

    internal class ApiModelAttributesConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ApiModelAttributes) || t == typeof(ApiModelAttributes?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleAttributes>(reader);
                    return new ApiModelAttributes { PurpleAttributes = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new ApiModelAttributes { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ApiModelAttributes");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ApiModelAttributes)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.PurpleAttributes != null)
            {
                serializer.Serialize(writer, value.PurpleAttributes);
                return;
            }
            throw new Exception("Cannot marshal type ApiModelAttributes");
        }

        public static readonly ApiModelAttributesConverter Singleton = new ApiModelAttributesConverter();
    }

    internal class DecodingChoiceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return integerValue;
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    long l;
                    if (Int64.TryParse(stringValue, out l))
                    {
                        return l;
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value);
            return;
        }

        public static readonly DecodingChoiceConverter Singleton = new DecodingChoiceConverter();
    }

    internal class BoostTypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BoostTypeEnum) || t == typeof(BoostTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Blunt Boost":
                    return BoostTypeEnum.BluntBoost;
                case "blunt":
                    return BoostTypeEnum.Blunt;
                case "element":
                    return BoostTypeEnum.Element;
                case "health":
                    return BoostTypeEnum.Health;
                case "sever":
                    return BoostTypeEnum.Sever;
                case "speed":
                    return BoostTypeEnum.Speed;
                case "stamina":
                    return BoostTypeEnum.Stamina;
            }
            throw new Exception("Cannot unmarshal type BoostTypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BoostTypeEnum)untypedValue;
            switch (value)
            {
                case BoostTypeEnum.BluntBoost:
                    serializer.Serialize(writer, "Blunt Boost");
                    return;
                case BoostTypeEnum.Blunt:
                    serializer.Serialize(writer, "blunt");
                    return;
                case BoostTypeEnum.Element:
                    serializer.Serialize(writer, "element");
                    return;
                case BoostTypeEnum.Health:
                    serializer.Serialize(writer, "health");
                    return;
                case BoostTypeEnum.Sever:
                    serializer.Serialize(writer, "sever");
                    return;
                case BoostTypeEnum.Speed:
                    serializer.Serialize(writer, "speed");
                    return;
                case BoostTypeEnum.Stamina:
                    serializer.Serialize(writer, "stamina");
                    return;
            }
            throw new Exception("Cannot marshal type BoostTypeEnum");
        }

        public static readonly BoostTypeEnumConverter Singleton = new BoostTypeEnumConverter();
    }

    internal class DeviationConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Deviation) || t == typeof(Deviation?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "average":
                    return Deviation.Average;
                case "high":
                    return Deviation.High;
                case "low":
                    return Deviation.Low;
                case "none":
                    return Deviation.None;
            }
            throw new Exception("Cannot unmarshal type Deviation");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Deviation)untypedValue;
            switch (value)
            {
                case Deviation.Average:
                    serializer.Serialize(writer, "average");
                    return;
                case Deviation.High:
                    serializer.Serialize(writer, "high");
                    return;
                case Deviation.Low:
                    serializer.Serialize(writer, "low");
                    return;
                case Deviation.None:
                    serializer.Serialize(writer, "none");
                    return;
            }
            throw new Exception("Cannot marshal type Deviation");
        }

        public static readonly DeviationConverter Singleton = new DeviationConverter();
    }

    internal class RequiredGenderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RequiredGender) || t == typeof(RequiredGender?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "female":
                    return RequiredGender.Female;
                case "male":
                    return RequiredGender.Male;
            }
            throw new Exception("Cannot unmarshal type RequiredGender");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RequiredGender)untypedValue;
            switch (value)
            {
                case RequiredGender.Female:
                    serializer.Serialize(writer, "female");
                    return;
                case RequiredGender.Male:
                    serializer.Serialize(writer, "male");
                    return;
            }
            throw new Exception("Cannot marshal type RequiredGender");
        }

        public static readonly RequiredGenderConverter Singleton = new RequiredGenderConverter();
    }

    internal class TentacledModifiersConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TentacledModifiers) || t == typeof(TentacledModifiers?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleModifiers>(reader);
                    return new TentacledModifiers { PurpleModifiers = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new TentacledModifiers { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TentacledModifiers");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TentacledModifiers)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.PurpleModifiers != null)
            {
                serializer.Serialize(writer, value.PurpleModifiers);
                return;
            }
            throw new Exception("Cannot marshal type TentacledModifiers");
        }

        public static readonly TentacledModifiersConverter Singleton = new TentacledModifiersConverter();
    }

    internal class CampNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CampName) || t == typeof(CampName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Ancient Forest Camp":
                    return CampName.AncientForestCamp;
                case "Camp":
                    return CampName.Camp;
                case "Central Camp":
                    return CampName.CentralCamp;
                case "Eastern Camp":
                    return CampName.EasternCamp;
                case "Northeast Camp":
                    return CampName.NortheastCamp;
                case "Northwest Camp":
                    return CampName.NorthwestCamp;
                case "Shipwreck Camp":
                    return CampName.ShipwreckCamp;
                case "Southeast Camp":
                    return CampName.SoutheastCamp;
                case "Southern Camp":
                    return CampName.SouthernCamp;
                case "Southwest Camp":
                    return CampName.SouthwestCamp;
                case "Western Camp":
                    return CampName.WesternCamp;
            }
            throw new Exception("Cannot unmarshal type CampName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CampName)untypedValue;
            switch (value)
            {
                case CampName.AncientForestCamp:
                    serializer.Serialize(writer, "Ancient Forest Camp");
                    return;
                case CampName.Camp:
                    serializer.Serialize(writer, "Camp");
                    return;
                case CampName.CentralCamp:
                    serializer.Serialize(writer, "Central Camp");
                    return;
                case CampName.EasternCamp:
                    serializer.Serialize(writer, "Eastern Camp");
                    return;
                case CampName.NortheastCamp:
                    serializer.Serialize(writer, "Northeast Camp");
                    return;
                case CampName.NorthwestCamp:
                    serializer.Serialize(writer, "Northwest Camp");
                    return;
                case CampName.ShipwreckCamp:
                    serializer.Serialize(writer, "Shipwreck Camp");
                    return;
                case CampName.SoutheastCamp:
                    serializer.Serialize(writer, "Southeast Camp");
                    return;
                case CampName.SouthernCamp:
                    serializer.Serialize(writer, "Southern Camp");
                    return;
                case CampName.SouthwestCamp:
                    serializer.Serialize(writer, "Southwest Camp");
                    return;
                case CampName.WesternCamp:
                    serializer.Serialize(writer, "Western Camp");
                    return;
            }
            throw new Exception("Cannot marshal type CampName");
        }

        public static readonly CampNameConverter Singleton = new CampNameConverter();
    }

    internal class CoatingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Coating) || t == typeof(Coating?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Blast":
                    return Coating.CoatingBlast;
                case "Close Range":
                    return Coating.CoatingCloseRange;
                case "Paralysis":
                    return Coating.CoatingParalysis;
                case "Sleep":
                    return Coating.CoatingSleep;
                case "blast":
                    return Coating.Blast;
                case "close range":
                    return Coating.CloseRange;
                case "paralysis":
                    return Coating.Paralysis;
                case "poison":
                    return Coating.Poison;
                case "power":
                    return Coating.Power;
                case "sleep":
                    return Coating.Sleep;
            }
            throw new Exception("Cannot unmarshal type Coating");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Coating)untypedValue;
            switch (value)
            {
                case Coating.CoatingBlast:
                    serializer.Serialize(writer, "Blast");
                    return;
                case Coating.CoatingCloseRange:
                    serializer.Serialize(writer, "Close Range");
                    return;
                case Coating.CoatingParalysis:
                    serializer.Serialize(writer, "Paralysis");
                    return;
                case Coating.CoatingSleep:
                    serializer.Serialize(writer, "Sleep");
                    return;
                case Coating.Blast:
                    serializer.Serialize(writer, "blast");
                    return;
                case Coating.CloseRange:
                    serializer.Serialize(writer, "close range");
                    return;
                case Coating.Paralysis:
                    serializer.Serialize(writer, "paralysis");
                    return;
                case Coating.Poison:
                    serializer.Serialize(writer, "poison");
                    return;
                case Coating.Power:
                    serializer.Serialize(writer, "power");
                    return;
                case Coating.Sleep:
                    serializer.Serialize(writer, "sleep");
                    return;
            }
            throw new Exception("Cannot marshal type Coating");
        }

        public static readonly CoatingConverter Singleton = new CoatingConverter();
    }

    internal class DamageTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DamageType) || t == typeof(DamageType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "blunt":
                    return DamageType.Blunt;
                case "projectile":
                    return DamageType.Projectile;
                case "sever":
                    return DamageType.Sever;
                case "sever + blunt":
                    return DamageType.SeverBlunt;
            }
            throw new Exception("Cannot unmarshal type DamageType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DamageType)untypedValue;
            switch (value)
            {
                case DamageType.Blunt:
                    serializer.Serialize(writer, "blunt");
                    return;
                case DamageType.Projectile:
                    serializer.Serialize(writer, "projectile");
                    return;
                case DamageType.Sever:
                    serializer.Serialize(writer, "sever");
                    return;
                case DamageType.SeverBlunt:
                    serializer.Serialize(writer, "sever + blunt");
                    return;
            }
            throw new Exception("Cannot marshal type DamageType");
        }

        public static readonly DamageTypeConverter Singleton = new DamageTypeConverter();
    }

    internal class ElementUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ElementUnion) || t == typeof(ElementUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "blast":
                            return new ElementUnion { Enum = ElementEnum.Blast };
                        case "dragon":
                            return new ElementUnion { Enum = ElementEnum.Dragon };
                        case "fire":
                            return new ElementUnion { Enum = ElementEnum.Fire };
                        case "ice":
                            return new ElementUnion { Enum = ElementEnum.Ice };
                        case "paralysis":
                            return new ElementUnion { Enum = ElementEnum.Paralysis };
                        case "poison":
                            return new ElementUnion { Enum = ElementEnum.Poison };
                        case "sleep":
                            return new ElementUnion { Enum = ElementEnum.Sleep };
                        case "stun":
                            return new ElementUnion { Enum = ElementEnum.Stun };
                        case "thunder":
                            return new ElementUnion { Enum = ElementEnum.Thunder };
                        case "water":
                            return new ElementUnion { Enum = ElementEnum.Water };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ElementClass>(reader);
                    return new ElementUnion { ElementClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type ElementUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ElementUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case ElementEnum.Blast:
                        serializer.Serialize(writer, "blast");
                        return;
                    case ElementEnum.Dragon:
                        serializer.Serialize(writer, "dragon");
                        return;
                    case ElementEnum.Fire:
                        serializer.Serialize(writer, "fire");
                        return;
                    case ElementEnum.Ice:
                        serializer.Serialize(writer, "ice");
                        return;
                    case ElementEnum.Paralysis:
                        serializer.Serialize(writer, "paralysis");
                        return;
                    case ElementEnum.Poison:
                        serializer.Serialize(writer, "poison");
                        return;
                    case ElementEnum.Sleep:
                        serializer.Serialize(writer, "sleep");
                        return;
                    case ElementEnum.Stun:
                        serializer.Serialize(writer, "stun");
                        return;
                    case ElementEnum.Thunder:
                        serializer.Serialize(writer, "thunder");
                        return;
                    case ElementEnum.Water:
                        serializer.Serialize(writer, "water");
                        return;
                }
            }
            if (value.ElementClass != null)
            {
                serializer.Serialize(writer, value.ElementClass);
                return;
            }
            throw new Exception("Cannot marshal type ElementUnion");
        }

        public static readonly ElementUnionConverter Singleton = new ElementUnionConverter();
    }

    internal class ElementEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ElementEnum) || t == typeof(ElementEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "blast":
                    return ElementEnum.Blast;
                case "dragon":
                    return ElementEnum.Dragon;
                case "fire":
                    return ElementEnum.Fire;
                case "ice":
                    return ElementEnum.Ice;
                case "paralysis":
                    return ElementEnum.Paralysis;
                case "poison":
                    return ElementEnum.Poison;
                case "sleep":
                    return ElementEnum.Sleep;
                case "stun":
                    return ElementEnum.Stun;
                case "thunder":
                    return ElementEnum.Thunder;
                case "water":
                    return ElementEnum.Water;
            }
            throw new Exception("Cannot unmarshal type ElementEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ElementEnum)untypedValue;
            switch (value)
            {
                case ElementEnum.Blast:
                    serializer.Serialize(writer, "blast");
                    return;
                case ElementEnum.Dragon:
                    serializer.Serialize(writer, "dragon");
                    return;
                case ElementEnum.Fire:
                    serializer.Serialize(writer, "fire");
                    return;
                case ElementEnum.Ice:
                    serializer.Serialize(writer, "ice");
                    return;
                case ElementEnum.Paralysis:
                    serializer.Serialize(writer, "paralysis");
                    return;
                case ElementEnum.Poison:
                    serializer.Serialize(writer, "poison");
                    return;
                case ElementEnum.Sleep:
                    serializer.Serialize(writer, "sleep");
                    return;
                case ElementEnum.Stun:
                    serializer.Serialize(writer, "stun");
                    return;
                case ElementEnum.Thunder:
                    serializer.Serialize(writer, "thunder");
                    return;
                case ElementEnum.Water:
                    serializer.Serialize(writer, "water");
                    return;
            }
            throw new Exception("Cannot marshal type ElementEnum");
        }

        public static readonly ElementEnumConverter Singleton = new ElementEnumConverter();
    }

    internal class EndTimestampConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EndTimestamp) || t == typeof(EndTimestamp?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "2019-01-09T23:59:00+0000":
                    return EndTimestamp.The20190109T2359000000;
                case "2020-01-02T23:59:00+0000":
                    return EndTimestamp.The20200102T2359000000;
                case "2020-01-05T23:59:00+0000":
                    return EndTimestamp.The20200105T2359000000;
                case "2020-01-09T23:59:00+0000":
                    return EndTimestamp.The20200109T2359000000;
                case "2020-01-23T23:59:00+0000":
                    return EndTimestamp.The20200123T2359000000;
            }
            throw new Exception("Cannot unmarshal type EndTimestamp");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EndTimestamp)untypedValue;
            switch (value)
            {
                case EndTimestamp.The20190109T2359000000:
                    serializer.Serialize(writer, "2019-01-09T23:59:00+0000");
                    return;
                case EndTimestamp.The20200102T2359000000:
                    serializer.Serialize(writer, "2020-01-02T23:59:00+0000");
                    return;
                case EndTimestamp.The20200105T2359000000:
                    serializer.Serialize(writer, "2020-01-05T23:59:00+0000");
                    return;
                case EndTimestamp.The20200109T2359000000:
                    serializer.Serialize(writer, "2020-01-09T23:59:00+0000");
                    return;
                case EndTimestamp.The20200123T2359000000:
                    serializer.Serialize(writer, "2020-01-23T23:59:00+0000");
                    return;
            }
            throw new Exception("Cannot marshal type EndTimestamp");
        }

        public static readonly EndTimestampConverter Singleton = new EndTimestampConverter();
    }

    internal class ExpansionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Expansion) || t == typeof(Expansion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "base":
                    return Expansion.Base;
                case "iceborne":
                    return Expansion.Iceborne;
            }
            throw new Exception("Cannot unmarshal type Expansion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Expansion)untypedValue;
            switch (value)
            {
                case Expansion.Base:
                    serializer.Serialize(writer, "base");
                    return;
                case Expansion.Iceborne:
                    serializer.Serialize(writer, "iceborne");
                    return;
            }
            throw new Exception("Cannot marshal type Expansion");
        }

        public static readonly ExpansionConverter Singleton = new ExpansionConverter();
    }

    internal class LocationNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LocationName) || t == typeof(LocationName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Ancient Forest":
                    return LocationName.AncientForest;
                case "Arena":
                    return LocationName.Arena;
                case "Caverns of El Dorado":
                    return LocationName.CavernsOfElDorado;
                case "Confluence of Fates":
                    return LocationName.ConfluenceOfFates;
                case "Coral Highlands":
                    return LocationName.CoralHighlands;
                case "Elder's Recess":
                    return LocationName.ElderSRecess;
                case "Everstream":
                    return LocationName.Everstream;
                case "Great Ravine":
                    return LocationName.GreatRavine;
                case "Guiding Lands":
                    return LocationName.GuidingLands;
                case "Hoarfrost Reach":
                    return LocationName.HoarfrostReach;
                case "Rotten Vale":
                    return LocationName.RottenVale;
                case "Secluded Valley":
                    return LocationName.SecludedValley;
                case "Special Arena":
                    return LocationName.SpecialArena;
                case "Wildspire Waste":
                    return LocationName.WildspireWaste;
            }
            throw new Exception("Cannot unmarshal type LocationName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LocationName)untypedValue;
            switch (value)
            {
                case LocationName.AncientForest:
                    serializer.Serialize(writer, "Ancient Forest");
                    return;
                case LocationName.Arena:
                    serializer.Serialize(writer, "Arena");
                    return;
                case LocationName.CavernsOfElDorado:
                    serializer.Serialize(writer, "Caverns of El Dorado");
                    return;
                case LocationName.ConfluenceOfFates:
                    serializer.Serialize(writer, "Confluence of Fates");
                    return;
                case LocationName.CoralHighlands:
                    serializer.Serialize(writer, "Coral Highlands");
                    return;
                case LocationName.ElderSRecess:
                    serializer.Serialize(writer, "Elder's Recess");
                    return;
                case LocationName.Everstream:
                    serializer.Serialize(writer, "Everstream");
                    return;
                case LocationName.GreatRavine:
                    serializer.Serialize(writer, "Great Ravine");
                    return;
                case LocationName.GuidingLands:
                    serializer.Serialize(writer, "Guiding Lands");
                    return;
                case LocationName.HoarfrostReach:
                    serializer.Serialize(writer, "Hoarfrost Reach");
                    return;
                case LocationName.RottenVale:
                    serializer.Serialize(writer, "Rotten Vale");
                    return;
                case LocationName.SecludedValley:
                    serializer.Serialize(writer, "Secluded Valley");
                    return;
                case LocationName.SpecialArena:
                    serializer.Serialize(writer, "Special Arena");
                    return;
                case LocationName.WildspireWaste:
                    serializer.Serialize(writer, "Wildspire Waste");
                    return;
            }
            throw new Exception("Cannot marshal type LocationName");
        }

        public static readonly LocationNameConverter Singleton = new LocationNameConverter();
    }

    internal class PhialTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PhialType) || t == typeof(PhialType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "dragon":
                    return PhialType.Dragon;
                case "exhaust":
                    return PhialType.Exhaust;
                case "impact":
                    return PhialType.Impact;
                case "para":
                    return PhialType.Para;
                case "poison":
                    return PhialType.Poison;
                case "power":
                    return PhialType.Power;
                case "power element":
                    return PhialType.PowerElement;
            }
            throw new Exception("Cannot unmarshal type PhialType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PhialType)untypedValue;
            switch (value)
            {
                case PhialType.Dragon:
                    serializer.Serialize(writer, "dragon");
                    return;
                case PhialType.Exhaust:
                    serializer.Serialize(writer, "exhaust");
                    return;
                case PhialType.Impact:
                    serializer.Serialize(writer, "impact");
                    return;
                case PhialType.Para:
                    serializer.Serialize(writer, "para");
                    return;
                case PhialType.Poison:
                    serializer.Serialize(writer, "poison");
                    return;
                case PhialType.Power:
                    serializer.Serialize(writer, "power");
                    return;
                case PhialType.PowerElement:
                    serializer.Serialize(writer, "power element");
                    return;
            }
            throw new Exception("Cannot marshal type PhialType");
        }

        public static readonly PhialTypeConverter Singleton = new PhialTypeConverter();
    }

    internal class PieceAttributesConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PieceAttributes) || t == typeof(PieceAttributes?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FluffyAttributes>(reader);
                    return new PieceAttributes { FluffyAttributes = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new PieceAttributes { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PieceAttributes");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PieceAttributes)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.FluffyAttributes != null)
            {
                serializer.Serialize(writer, value.FluffyAttributes);
                return;
            }
            throw new Exception("Cannot marshal type PieceAttributes");
        }

        public static readonly PieceAttributesConverter Singleton = new PieceAttributesConverter();
    }

    internal class StickyModifiersConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StickyModifiers) || t == typeof(StickyModifiers?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Dictionary<string, long>>(reader);
                    return new StickyModifiers { IntegerMap = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new StickyModifiers { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type StickyModifiers");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (StickyModifiers)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.IntegerMap != null)
            {
                serializer.Serialize(writer, value.IntegerMap);
                return;
            }
            throw new Exception("Cannot marshal type StickyModifiers");
        }

        public static readonly StickyModifiersConverter Singleton = new StickyModifiersConverter();
    }

    internal class WeaponTypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(WeaponTypeEnum) || t == typeof(WeaponTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bow":
                    return WeaponTypeEnum.Bow;
                case "challenge quest":
                    return WeaponTypeEnum.ChallengeQuest;
                case "charge-blade":
                    return WeaponTypeEnum.ChargeBlade;
                case "chest":
                    return WeaponTypeEnum.Chest;
                case "dual-blades":
                    return WeaponTypeEnum.DualBlades;
                case "event quest":
                    return WeaponTypeEnum.EventQuest;
                case "gloves":
                    return WeaponTypeEnum.Gloves;
                case "great-sword":
                    return WeaponTypeEnum.GreatSword;
                case "gunlance":
                    return WeaponTypeEnum.Gunlance;
                case "hammer":
                    return WeaponTypeEnum.Hammer;
                case "head":
                    return WeaponTypeEnum.Head;
                case "heavy-bowgun":
                    return WeaponTypeEnum.HeavyBowgun;
                case "hunting-horn":
                    return WeaponTypeEnum.HuntingHorn;
                case "insect-glaive":
                    return WeaponTypeEnum.InsectGlaive;
                case "kulve taroth siege":
                    return WeaponTypeEnum.KulveTarothSiege;
                case "lance":
                    return WeaponTypeEnum.Lance;
                case "large":
                    return WeaponTypeEnum.Large;
                case "legs":
                    return WeaponTypeEnum.Legs;
                case "light-bowgun":
                    return WeaponTypeEnum.LightBowgun;
                case "long-sword":
                    return WeaponTypeEnum.LongSword;
                case "safi'jiiva siege":
                    return WeaponTypeEnum.SafiJiivaSiege;
                case "small":
                    return WeaponTypeEnum.Small;
                case "switch-axe":
                    return WeaponTypeEnum.SwitchAxe;
                case "sword-and-shield":
                    return WeaponTypeEnum.SwordAndShield;
                case "waist":
                    return WeaponTypeEnum.Waist;
            }
            throw new Exception("Cannot unmarshal type WeaponTypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (WeaponTypeEnum)untypedValue;
            switch (value)
            {
                case WeaponTypeEnum.Bow:
                    serializer.Serialize(writer, "bow");
                    return;
                case WeaponTypeEnum.ChallengeQuest:
                    serializer.Serialize(writer, "challenge quest");
                    return;
                case WeaponTypeEnum.ChargeBlade:
                    serializer.Serialize(writer, "charge-blade");
                    return;
                case WeaponTypeEnum.Chest:
                    serializer.Serialize(writer, "chest");
                    return;
                case WeaponTypeEnum.DualBlades:
                    serializer.Serialize(writer, "dual-blades");
                    return;
                case WeaponTypeEnum.EventQuest:
                    serializer.Serialize(writer, "event quest");
                    return;
                case WeaponTypeEnum.Gloves:
                    serializer.Serialize(writer, "gloves");
                    return;
                case WeaponTypeEnum.GreatSword:
                    serializer.Serialize(writer, "great-sword");
                    return;
                case WeaponTypeEnum.Gunlance:
                    serializer.Serialize(writer, "gunlance");
                    return;
                case WeaponTypeEnum.Hammer:
                    serializer.Serialize(writer, "hammer");
                    return;
                case WeaponTypeEnum.Head:
                    serializer.Serialize(writer, "head");
                    return;
                case WeaponTypeEnum.HeavyBowgun:
                    serializer.Serialize(writer, "heavy-bowgun");
                    return;
                case WeaponTypeEnum.HuntingHorn:
                    serializer.Serialize(writer, "hunting-horn");
                    return;
                case WeaponTypeEnum.InsectGlaive:
                    serializer.Serialize(writer, "insect-glaive");
                    return;
                case WeaponTypeEnum.KulveTarothSiege:
                    serializer.Serialize(writer, "kulve taroth siege");
                    return;
                case WeaponTypeEnum.Lance:
                    serializer.Serialize(writer, "lance");
                    return;
                case WeaponTypeEnum.Large:
                    serializer.Serialize(writer, "large");
                    return;
                case WeaponTypeEnum.Legs:
                    serializer.Serialize(writer, "legs");
                    return;
                case WeaponTypeEnum.LightBowgun:
                    serializer.Serialize(writer, "light-bowgun");
                    return;
                case WeaponTypeEnum.LongSword:
                    serializer.Serialize(writer, "long-sword");
                    return;
                case WeaponTypeEnum.SafiJiivaSiege:
                    serializer.Serialize(writer, "safi'jiiva siege");
                    return;
                case WeaponTypeEnum.Small:
                    serializer.Serialize(writer, "small");
                    return;
                case WeaponTypeEnum.SwitchAxe:
                    serializer.Serialize(writer, "switch-axe");
                    return;
                case WeaponTypeEnum.SwordAndShield:
                    serializer.Serialize(writer, "sword-and-shield");
                    return;
                case WeaponTypeEnum.Waist:
                    serializer.Serialize(writer, "waist");
                    return;
            }
            throw new Exception("Cannot marshal type WeaponTypeEnum");
        }

        public static readonly WeaponTypeEnumConverter Singleton = new WeaponTypeEnumConverter();
    }

    internal class PlatformConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Platform) || t == typeof(Platform?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "console":
                    return Platform.Console;
                case "pc":
                    return Platform.Pc;
            }
            throw new Exception("Cannot unmarshal type Platform");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Platform)untypedValue;
            switch (value)
            {
                case Platform.Console:
                    serializer.Serialize(writer, "console");
                    return;
                case Platform.Pc:
                    serializer.Serialize(writer, "pc");
                    return;
            }
            throw new Exception("Cannot marshal type Platform");
        }

        public static readonly PlatformConverter Singleton = new PlatformConverter();
    }

    internal class RankModifiersConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RankModifiers) || t == typeof(RankModifiers?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FluffyModifiers>(reader);
                    return new RankModifiers { FluffyModifiers = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new RankModifiers { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type RankModifiers");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RankModifiers)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.FluffyModifiers != null)
            {
                serializer.Serialize(writer, value.FluffyModifiers);
                return;
            }
            throw new Exception("Cannot marshal type RankModifiers");
        }

        public static readonly RankModifiersConverter Singleton = new RankModifiersConverter();
    }

    internal class DamageConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Damage) || t == typeof(Damage?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Damage { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Damage { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type Damage");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Damage)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type Damage");
        }

        public static readonly DamageConverter Singleton = new DamageConverter();
    }

    internal class ResistancesUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ResistancesUnion) || t == typeof(ResistancesUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ResistancesClass>(reader);
                    return new ResistancesUnion { ResistancesClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<Resistance>>(reader);
                    return new ResistancesUnion { ResistanceArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ResistancesUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ResistancesUnion)untypedValue;
            if (value.ResistanceArray != null)
            {
                serializer.Serialize(writer, value.ResistanceArray);
                return;
            }
            if (value.ResistancesClass != null)
            {
                serializer.Serialize(writer, value.ResistancesClass);
                return;
            }
            throw new Exception("Cannot marshal type ResistancesUnion");
        }

        public static readonly ResistancesUnionConverter Singleton = new ResistancesUnionConverter();
    }

    internal class SubtypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Subtype) || t == typeof(Subtype?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Back":
                    return Subtype.Back;
                case "Body":
                    return Subtype.Body;
                case "Forearms":
                    return Subtype.Forearms;
                case "Gold":
                    return Subtype.Gold;
                case "Head":
                    return Subtype.Head;
                case "Head Shell":
                    return Subtype.HeadShell;
                case "Hindlegs":
                    return Subtype.Hindlegs;
                case "Horn":
                    return Subtype.Horn;
                case "Horns":
                    return Subtype.Horns;
                case "Silver":
                    return Subtype.Silver;
                case "Tail":
                    return Subtype.Tail;
                case "Wings":
                    return Subtype.Wings;
            }
            throw new Exception("Cannot unmarshal type Subtype");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Subtype)untypedValue;
            switch (value)
            {
                case Subtype.Back:
                    serializer.Serialize(writer, "Back");
                    return;
                case Subtype.Body:
                    serializer.Serialize(writer, "Body");
                    return;
                case Subtype.Forearms:
                    serializer.Serialize(writer, "Forearms");
                    return;
                case Subtype.Gold:
                    serializer.Serialize(writer, "Gold");
                    return;
                case Subtype.Head:
                    serializer.Serialize(writer, "Head");
                    return;
                case Subtype.HeadShell:
                    serializer.Serialize(writer, "Head Shell");
                    return;
                case Subtype.Hindlegs:
                    serializer.Serialize(writer, "Hindlegs");
                    return;
                case Subtype.Horn:
                    serializer.Serialize(writer, "Horn");
                    return;
                case Subtype.Horns:
                    serializer.Serialize(writer, "Horns");
                    return;
                case Subtype.Silver:
                    serializer.Serialize(writer, "Silver");
                    return;
                case Subtype.Tail:
                    serializer.Serialize(writer, "Tail");
                    return;
                case Subtype.Wings:
                    serializer.Serialize(writer, "Wings");
                    return;
            }
            throw new Exception("Cannot marshal type Subtype");
        }

        public static readonly SubtypeConverter Singleton = new SubtypeConverter();
    }

    internal class ConditionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionType) || t == typeof(ConditionType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "carve":
                    return ConditionType.Carve;
                case "investigation":
                    return ConditionType.Investigation;
                case "palico":
                    return ConditionType.Palico;
                case "plunderblade":
                    return ConditionType.Plunderblade;
                case "reward":
                    return ConditionType.Reward;
                case "shiny":
                    return ConditionType.Shiny;
                case "track":
                    return ConditionType.Track;
                case "wound":
                    return ConditionType.Wound;
            }
            throw new Exception("Cannot unmarshal type ConditionType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ConditionType)untypedValue;
            switch (value)
            {
                case ConditionType.Carve:
                    serializer.Serialize(writer, "carve");
                    return;
                case ConditionType.Investigation:
                    serializer.Serialize(writer, "investigation");
                    return;
                case ConditionType.Palico:
                    serializer.Serialize(writer, "palico");
                    return;
                case ConditionType.Plunderblade:
                    serializer.Serialize(writer, "plunderblade");
                    return;
                case ConditionType.Reward:
                    serializer.Serialize(writer, "reward");
                    return;
                case ConditionType.Shiny:
                    serializer.Serialize(writer, "shiny");
                    return;
                case ConditionType.Track:
                    serializer.Serialize(writer, "track");
                    return;
                case ConditionType.Wound:
                    serializer.Serialize(writer, "wound");
                    return;
            }
            throw new Exception("Cannot marshal type ConditionType");
        }

        public static readonly ConditionTypeConverter Singleton = new ConditionTypeConverter();
    }

    internal class ShellingTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ShellingType) || t == typeof(ShellingType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "long":
                    return ShellingType.Long;
                case "normal":
                    return ShellingType.Normal;
                case "wide":
                    return ShellingType.Wide;
            }
            throw new Exception("Cannot unmarshal type ShellingType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ShellingType)untypedValue;
            switch (value)
            {
                case ShellingType.Long:
                    serializer.Serialize(writer, "long");
                    return;
                case ShellingType.Normal:
                    serializer.Serialize(writer, "normal");
                    return;
                case ShellingType.Wide:
                    serializer.Serialize(writer, "wide");
                    return;
            }
            throw new Exception("Cannot marshal type ShellingType");
        }

        public static readonly ShellingTypeConverter Singleton = new ShellingTypeConverter();
    }

    internal class SpecialAmmoConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SpecialAmmo) || t == typeof(SpecialAmmo?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "wyvernblast":
                    return SpecialAmmo.Wyvernblast;
                case "wyvernheart":
                    return SpecialAmmo.Wyvernheart;
                case "wyvernsnipe":
                    return SpecialAmmo.Wyvernsnipe;
            }
            throw new Exception("Cannot unmarshal type SpecialAmmo");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SpecialAmmo)untypedValue;
            switch (value)
            {
                case SpecialAmmo.Wyvernblast:
                    serializer.Serialize(writer, "wyvernblast");
                    return;
                case SpecialAmmo.Wyvernheart:
                    serializer.Serialize(writer, "wyvernheart");
                    return;
                case SpecialAmmo.Wyvernsnipe:
                    serializer.Serialize(writer, "wyvernsnipe");
                    return;
            }
            throw new Exception("Cannot marshal type SpecialAmmo");
        }

        public static readonly SpecialAmmoConverter Singleton = new SpecialAmmoConverter();
    }

    internal class StartTimestampConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StartTimestamp) || t == typeof(StartTimestamp?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "2019-01-03T00:00:00+0000":
                    return StartTimestamp.The20190103T0000000000;
                case "2019-11-22T00:00:00+0000":
                    return StartTimestamp.The20191122T0000000000;
                case "2019-11-29T00:00:00+0000":
                    return StartTimestamp.The20191129T0000000000;
                case "2019-12-13T00:00:00+0000":
                    return StartTimestamp.The20191213T0000000000;
                case "2019-12-20T00:00:00+0000":
                    return StartTimestamp.The20191220T0000000000;
                case "2019-12-27T00:00:00+0000":
                    return StartTimestamp.The20191227T0000000000;
            }
            throw new Exception("Cannot unmarshal type StartTimestamp");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StartTimestamp)untypedValue;
            switch (value)
            {
                case StartTimestamp.The20190103T0000000000:
                    serializer.Serialize(writer, "2019-01-03T00:00:00+0000");
                    return;
                case StartTimestamp.The20191122T0000000000:
                    serializer.Serialize(writer, "2019-11-22T00:00:00+0000");
                    return;
                case StartTimestamp.The20191129T0000000000:
                    serializer.Serialize(writer, "2019-11-29T00:00:00+0000");
                    return;
                case StartTimestamp.The20191213T0000000000:
                    serializer.Serialize(writer, "2019-12-13T00:00:00+0000");
                    return;
                case StartTimestamp.The20191220T0000000000:
                    serializer.Serialize(writer, "2019-12-20T00:00:00+0000");
                    return;
                case StartTimestamp.The20191227T0000000000:
                    serializer.Serialize(writer, "2019-12-27T00:00:00+0000");
                    return;
            }
            throw new Exception("Cannot marshal type StartTimestamp");
        }

        public static readonly StartTimestampConverter Singleton = new StartTimestampConverter();
    }
}
