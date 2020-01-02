using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Familiaris.Models;

namespace Familiaris
{
    public class SearchLogic
    {
        public static string Help()
        {
            var botMsg = "I'm a Monster Hunter World discord bot! I help you find the things you need quickly.\n\n" +
                         "With one of the commands below you can search for: debuffs, armor, charms, locations, monsters, items, skills, weapons, and more!\n\n" +
                         "I accept partial matches as well, but be careful I'll only return the closest match to what you want. For example if you type:" +
                         " 'bleed' I will return 'Bleeding', 'luna' will return 'Lunastra' etc.\n\n" +
                         "Here are my commands:\n" +
                         "```bash\n" +
                         "(!ailment | !dbuff | !debuff | !sickness) + search => returns debuffs and ailments.\n\n" +
                         "(!armor | !ar | !gear) + search => returns armor.\n\n" +
                         "(!charm | !neck | !necklace | !jewel) + search => returns charms\n\n" +
                         "(!event | !quest | !optional | !assigned) + search => returns quests.\n\n" +
                         "(!item | !search | !material) => returns items.\n\n" +
                         "(!monster | !mon | !creature | !beast | !bug) + search => returns monsters.\n\n" +
                         "(!weapon | !weap | !wep | !elderseal) + search => returns weapons.\n\n" +
                         "```\n\n" +
                         "If you have any problems please contact Somethin!";
            return botMsg;
        }
        
        public static async Task<string> GetDebuffResults(string msgText)
        {
            var source = new CancellationTokenSource();
            var token = source.Token;
            var url = "https://mhw-db.com/ailments?q={\"name\":{ \"$like\": \""+msgText+"%\"}}";
            var mhwData = await QueryApi.MonsterHunterData(url, token);

            var refine = "";
            if (mhwData.Count > 1)
                refine = $"*Please refine your search you have: {mhwData.Count} results.*";
            var botMsg = $"{refine}\nName: **{mhwData[0].Name}**\n\n" +
                         $"Description: ***{mhwData[0].Description}***\n\n";
            if (mhwData[0].Recovery.Actions.Count > 0)
            {
                botMsg += $"Recovery Action: ";
                foreach (var recoveryAction in mhwData[0].Recovery.Actions)
                {
                    botMsg += $"**{recoveryAction}** ";
                }

                botMsg += "\n\n";
            }

            if (mhwData[0].Recovery.Items.Count > 0)
            {
                botMsg += "Recovery Items: \n";
                botMsg += "```css\n";
                foreach (var recoveryItem in mhwData[0].Recovery.Items)
                {
                    botMsg += $"Name: {recoveryItem.Name}\n";
                    botMsg += $"Description: {recoveryItem.Description}\n";
                    botMsg += $"Rarity: {recoveryItem.Rarity}\n";
                    botMsg += $"Carry Limit: {recoveryItem.CarryLimit}\n\n";
                }

                botMsg += "\n\n```\n\n";
            }

            if (mhwData[0].Protection.Items.Count > 0)
            {
                botMsg += "Protection Items: \n";
                botMsg += "```apache\n";
                foreach (var protItem in mhwData[0].Protection.Items)
                {
                    botMsg += $"Name: {protItem.Name}\n";
                    botMsg += $"Description: {protItem.Description}\n";
                    botMsg += $"Rarity: {protItem.Rarity}\n";
                    botMsg += $"Value: {protItem.Value}\n";
                    botMsg += $"Carry Limit: {protItem.CarryLimit}\n\n";
                }

                botMsg += "\n\n```\n\n";
            }

            if (mhwData[0].Protection.Skills.Count > 0)
            {
                botMsg += "Protection Skills: \n";
                botMsg += "```fix\n";
                foreach (var protSkill in mhwData[0].Protection.Skills)
                {
                    botMsg += $"Name: {protSkill.Name}\n";
                    botMsg += $"Description: {protSkill.Description}\n\n";
                }
                botMsg += "\n\n```\n\n";
            }

            return botMsg;
        }

        public static async Task<string> GetMonsterResults(string msgText)
        {
            var source = new CancellationTokenSource();
            var token = source.Token;
            var url = "https://mhw-db.com/monsters?q={\"name\":{ \"$like\": \"" + msgText + "%\"}}";
            var mhwData = await QueryApi.MonsterHunterData(url, token);
            var refine = "";
            if (mhwData.Count > 1)
                refine = $"*Please refine your search you have: {mhwData.Count} results.*";
            var botMsg = $"{refine}\nName: **{mhwData[0].Name}**\n\n" +
                         $"Description: ***{mhwData[0].Description}***\n\n" +
                         $"Species: **{mhwData[0].Species}**\n\n";
            if (mhwData[0].Elements.Count > 0)
            {
                botMsg += "Elements: \n";
                botMsg += "```diff\n";
                foreach (var element in mhwData[0].Elements)
                {
                    botMsg += $"{element} ";
                }

                botMsg += "```\n";
            }

            if (mhwData[0].Ailments.Count > 0)
            {
                botMsg += "Ailments: \n";
                botMsg += "```bash\n";
                foreach (var ail in mhwData[0].Ailments)
                {
                    botMsg += $"Name: {ail.Name}\n";
                    botMsg += $"Description: {ail.Description}\n\n";
                    if (ail.Recovery.Actions.Count > 0)
                    {
                        botMsg += $"Recovery Actions: ";
                        foreach (var rec in ail.Recovery.Actions)
                        {
                            botMsg += $"{rec} ";
                        }

                        botMsg += "\n\n";
                    }

                    if (ail.Recovery.Items.Count > 0)
                    {
                        botMsg += "Recovery Items: \n";
                        foreach (var rec in ail.Recovery.Items)
                        {
                            botMsg += $"Name: {rec.Name}\n";
                            botMsg += $"Description: {rec.Description}\n";
                            botMsg += $"Rarity: {rec.Rarity}\n";
                            botMsg += $"Value: {rec.Value}\n";
                            botMsg += $"Carry Limit: {rec.CarryLimit}\n\n";
                        }
                    }

                    if (ail.Protection.Skills.Count > 0)
                    {
                        botMsg += "Protection Skills: \n";
                        foreach (var prot in ail.Protection.Skills)
                        {
                            botMsg += $"Name: {prot.Name}\n";
                            botMsg += $"Description: {prot.Description}\n\n";
                        }
                        
                    }

                    if (ail.Protection.Items.Count > 0)
                    {
                        botMsg += "Protection Items: \n";
                        foreach (var prot in ail.Protection.Items)
                        {
                            botMsg += $"Name: {prot.Name}\n";
                            botMsg += $"Description: {prot.Description}\n";
                            botMsg += $"Rarity: {prot.Rarity}\n";
                            botMsg += $"Value: {prot.Value}\n";
                            botMsg += $"Carry Limit: {prot.CarryLimit}\n\n";
                        }
                        
                    }
                }
                botMsg += "```\n";
            }
            
            if (mhwData[0].Locations.Count > 0)
            {
                botMsg += "Locations: \n";
                botMsg += "```css\n";
                foreach (var location in mhwData[0].Locations)
                {
                    botMsg += $"Name: {location.Name}\n";
                    botMsg += $"Zone#: {location.ZoneCount}\n";
                }

                botMsg += "```\n";
            }


            botMsg += "Resistances: \n";
            botMsg += "```bash\n";
            var resistancesUnion = mhwData[0].Resistances;
            if (resistancesUnion != null) botMsg += $"Fire: {resistancesUnion.Value.ResistancesClass.Fire}";
            if (resistancesUnion != null) botMsg += $"Water: {resistancesUnion.Value.ResistancesClass.Water}";
            if (resistancesUnion != null) botMsg += $"Ice: {resistancesUnion.Value.ResistancesClass.Ice}";
            if (resistancesUnion != null) botMsg += $"Thunder: {resistancesUnion.Value.ResistancesClass.Thunder}";
            if (resistancesUnion != null) botMsg += $"Dragon: {resistancesUnion.Value.ResistancesClass.Dragon}";
            botMsg += "```\n";
            

            if (mhwData[0].Weaknesses.Count > 0)
            {
                botMsg += "Weaknesses: \n";
                botMsg += "```css\n";
                foreach (var weak in mhwData[0].Weaknesses)
                {
                    botMsg +=
                        $"Element: {weak.Element} | Rating: {string.Concat(Enumerable.Repeat("★",Convert.ToInt32(weak.Stars)))}\n";
                }

                botMsg += "```\n";
            }

            if (mhwData[0].Rewards.Count > 0)
            {
                botMsg += "Rewards: \n";
                botMsg += "```bash\n";
                foreach (var reward in mhwData[0].Rewards)
                {
                    botMsg += $"Name: {reward.Item.Name}\n";
                    botMsg += $"Description: {reward.Item.Description}\n";
                    botMsg += $"Rarity: {reward.Item.Rarity}\n";
                    botMsg += $"Carry Limit: {reward.Item.CarryLimit}\n";
                    botMsg += $"Value: {reward.Item.Value}\n\n";
                    
                    if (reward.Conditions.Count > 0)
                    {
                        botMsg += "Conditions: \n";
                        foreach (var condition in reward.Conditions)
                        {
                            botMsg += $"Type: {condition.Type}\n";
                            if (condition.Subtype.HasValue)
                                botMsg += $"Subtype: {condition.Subtype}\n";
                            botMsg += $"Rank: {condition.Rank}\n";
                            botMsg += $"Quantity: {condition.Quantity}\n";
                            botMsg += $"Chance: {condition.Chance}\n\n";
                        }
                    }
                }
                botMsg += "```\n";
            }
            return botMsg;
        }

        public static async Task<string> GetItemResults(string msgText)
        {
            var source = new CancellationTokenSource();
            var token = source.Token;
            var url = "https://mhw-db.com/items?q={\"name\":{ \"$like\": \"" + msgText + "%\"}}";
            var mhwData = await QueryApi.MonsterHunterData(url, token);
            
            var refine = "";
            if (mhwData.Count > 1)
                refine = $"*Please refine your search you have: {mhwData.Count} results.*";
            var botMsg = $"{refine}\nName: **{mhwData[0].Name}**\n\n" +
                         $"Description: ***{mhwData[0].Description}***\n\n" +
                         $"Rarity: **{mhwData[0].Rarity}**\n\n" +
                         $"Carry Limit: **{mhwData[0].CarryLimit}**\n\n" +
                         $"Value: **{mhwData[0].Value}**\n\n";
            return botMsg;
        }

        public static async Task<string> GetArmorResults(string msgText)
        {
            var source = new CancellationTokenSource();
            var token = source.Token;
            var url = "https://mhw-db.com/armor?q={\"name\":{ \"$like\": \"" + msgText + "%\"}}";
            var mhwData = await QueryApi.MonsterHunterData(url, token);
            
            var refine = "";
            if (mhwData.Count > 1)
                refine = $"*Please refine your search you have: {mhwData.Count} results.*";
            var botMsg = $"{refine}\nName: **{mhwData[0].Name}**\n" +
                         $"Type: **{mhwData[0].Type}**\n" +
                         $"Rank: **{mhwData[0].Rank}**\n" +
                         $"Rarity: **{mhwData[0].Rarity}**\n\n";
            botMsg += "Defense: \n";
            botMsg += "```bash\n";
            botMsg += $"Base: {mhwData[0].Defense.Base}\n";
            botMsg += $"Max: {mhwData[0].Defense.Max}\n";
            botMsg += $"Augmented: {mhwData[0].Defense.Augmented}\n";
            botMsg += "```\n";
            botMsg += "Resistances\n";
            botMsg += "```css\n";
            var resistancesUnion = mhwData[0].Resistances;
            if (resistancesUnion != null) botMsg += $"Fire: {resistancesUnion.Value.ResistancesClass.Fire}\n";
            if (resistancesUnion != null) botMsg += $"Water: {resistancesUnion.Value.ResistancesClass.Water}\n";
            if (resistancesUnion != null) botMsg += $"Ice: {resistancesUnion.Value.ResistancesClass.Ice}\n";
            if (resistancesUnion != null) botMsg += $"Thunder: {resistancesUnion.Value.ResistancesClass.Thunder}\n";
            if (resistancesUnion != null) botMsg += $"Dragon: {resistancesUnion.Value.ResistancesClass.Dragon}\n";
            botMsg += "```\n";

            botMsg += "Attributes: \n";
            botMsg += "```css\n";
            var attributesUnion = mhwData[0].Attributes;
            if (attributesUnion != null) botMsg += $"Required Gender: {attributesUnion.Value.PurpleAttributes.RequiredGender}\n";
            botMsg += "```\n";


            if (mhwData[0].Slots.Count > 0)
            {
                botMsg += "Slots: \n";
                botMsg += "```css\n";
                foreach (var slot in mhwData[0].Slots)
                {
                    botMsg += $"Rank: {slot.Rank}\n";
                }

                botMsg += "```\n";
            }

            if (mhwData[0].Skills.Count > 0)
            {
                botMsg += "Skills: \n";
                botMsg += "```bash\n";
                foreach (var skill in mhwData[0].Skills)
                {
                    botMsg += $"Name: {skill.SkillName}\n";
                    botMsg += $"Description: {skill.Description}\n";
                    botMsg += $"Level: {skill.Level}\n";
                    botMsg += $"Skill: {skill.Skill}\n";
                    if (skill.Modifiers.AnythingArray.Count > 0)
                    {
                        botMsg += $"Modifier: ";
                        foreach (var mod in skill.Modifiers.AnythingArray)
                        {
                            botMsg += $"{mod} ";
                        }
                    }

                    botMsg += "\n\n";
                }

                botMsg += "```\n";
            }

            botMsg += "Armorset: \n";
            botMsg += "```css\n";
            botMsg += $"Name: {mhwData[0].ArmorSet.Name}\n";
            botMsg += $"Rank: {mhwData[0].ArmorSet.Rank}\n";
            if (mhwData[0].ArmorSet.Bonus != null) botMsg += $"Bonus: {mhwData[0].ArmorSet.Bonus}\n";
            botMsg += "```\n";

            botMsg += "Images: \n";
            if (mhwData[0].Assets.ImageFemale != null) botMsg += $"Female: ({mhwData[0].Assets.ImageFemale})\n";
            if (mhwData[0].Assets.ImageMale != null) botMsg += $"Male: ({mhwData[0].Assets.ImageMale})\n";
            botMsg += "\n";

            if (mhwData[0].Crafting.Materials.Count > 0)
            {
                botMsg += "Crafting Materials: \n";
                botMsg += "```ini\n";
                foreach (var material in mhwData[0].Crafting.Materials)
                {
                    botMsg += $"Name: {material.Item.Name}\n";
                    botMsg += $"Description: {material.Item.Description}\n";
                    botMsg += $"Quantity Needed: {material.Quantity}\n";
                    botMsg += $"Rarity: {material.Item.Rarity}\n";
                    botMsg += $"Value: {material.Item.Value}\n";
                    botMsg += $"Carry Limit: {material.Item.CarryLimit}\n\n";
                }

                botMsg += "```\n";
            }



            return botMsg;
        }

        public static async Task<string> GetWeaponResults(string msgText)
        {
            var source = new CancellationTokenSource();
            var token = source.Token;
            var url = "https://mhw-db.com/weapons?q={\"name\":{ \"$like\": \"" + msgText + "%\"}}";
            var mhwData = await QueryApi.MonsterHunterData(url, token);
            
            var refine = "";
            if (mhwData.Count > 1)
                refine = $"*Please refine your search you have: {mhwData.Count} results.*";

            var botMsg = $"Name: **{refine}\n{mhwData[0].Name}**\n" +
                         $"Type: **{mhwData[0].Type}**\n" +
                         $"Rarity: **{mhwData[0].Rarity}**\n" +
                         $"Attack: **{mhwData[0].Attack.Display}**\n" +
                         $"Attack Raw: **{mhwData[0].Attack.Raw}**\n";
            if (mhwData[0].Elderseal != null) botMsg += $"Elderseal: {mhwData[0].Elderseal}";
            botMsg += "\nAttributes: \n";
            botMsg += "```css\n";
            var attributesUnion = mhwData[0].Attributes;
            if (attributesUnion != null && attributesUnion.Value.PurpleAttributes.Affinity > 0) 
                botMsg += $"Affinity: {attributesUnion.Value.PurpleAttributes.Affinity}\n";
            if (attributesUnion != null && attributesUnion.Value.PurpleAttributes.Defense > 0) 
                botMsg += $"Defense: {attributesUnion.Value.PurpleAttributes.Defense}\n";
            if (attributesUnion != null && attributesUnion.Value.PurpleAttributes.Elderseal > 0) 
                botMsg += $"Elderseal: {attributesUnion.Value.PurpleAttributes.Elderseal}\n";
            if (attributesUnion != null && attributesUnion.Value.PurpleAttributes.DamageType > 0) 
                botMsg += $"Damage Type: {attributesUnion.Value.PurpleAttributes.DamageType}\n";
            botMsg += "```\n";

            botMsg += $"Damage Type: **{mhwData[0].DamageType}**\n\n";

            /*
             Over the message limit on discord
            if (mhwData[0].Durability.Count > 0)
            {
                botMsg += $"Durability List: \n```ini\n";
                foreach (var dur in mhwData[0].Durability)
                {
                    botMsg += $"Red: {dur.Red}\n";
                    botMsg += $"Orange: {dur.Orange}\n";
                    botMsg += $"Yellow: {dur.Yellow}\n";
                    botMsg += $"Green: {dur.Green}\n";
                    botMsg += $"Blue: {dur.Blue}\n";
                    botMsg += $"White: {dur.White}\n\n";
                }

                botMsg += "```\n";
            }
            */
            
            if (mhwData[0].Slots.Count > 0)
            {
                botMsg += "Slots: \n";
                botMsg += "```css\n";
                foreach (var slot in mhwData[0].Slots)
                {
                    botMsg += $"Rank: {slot.Rank}\n";
                }

                botMsg += "```\n";
            }
            
            if (mhwData[0].Elements.Count > 0)
            {
                botMsg += "Elements: \n```bash\n";
                foreach (var element in mhwData[0].Elements)
                {
                    botMsg += $"Type: {element.ElementClass.Type}\n" +
                              $"Element: {element.ElementClass.Damage}\n" +
                              $"Hidden: {element.ElementClass.Hidden}\n\n";
                }

                botMsg += "```\n";
            }

            botMsg += "Crafting Details: \n```ini\n" +
                      $"Craftable: {mhwData[0].Crafting.Craftable}\n";

            if (mhwData[0].Crafting.CraftingMaterials.Count > 0)
            {
                botMsg += "\nCrafting Materials: \n";
                foreach (var material in mhwData[0].Crafting.CraftingMaterials)
                {
                    botMsg += $"Name: {material.Item.Name}\n" +
                              $"Description: {material.Item.Description}\n" +
                              $"Quantity: {material.Quantity}\n" +
                              $"Rarity: {material.Item.Rarity}\n" +
                              $"Value: {material.Item.Value}\n" +
                              $"Carry Limit: {material.Item.CarryLimit}\n\n";
                }
            }

            botMsg += "```\n";

            if (mhwData[0].Crafting.UpgradeMaterials.Count > 0)
            {
                botMsg += "Upgrade Details: \n```bash\n";
                foreach (var material in mhwData[0].Crafting.UpgradeMaterials)
                {
                    botMsg += $"Name: {material.Item.Name}\n" +
                              $"Description: {material.Item.Description}\n" +
                              $"Quantity: {material.Quantity}\n" +
                              $"Rarity: {material.Item.Rarity}\n" +
                              $"Value: {material.Item.Value}\n" +
                              $"Carry Limit: {material.Item.CarryLimit}\n\n";
                }

                botMsg += "```\n";
            }
            
            if (mhwData[0].Assets.Image != null) botMsg += $"\nImage: ({mhwData[0].Assets.Image})\n";
            botMsg += "\n";
            
            return botMsg;
        }

        public static async Task<string> GetEventResults(string msgText)
        {
            var source = new CancellationTokenSource();
            var token = source.Token;
            var url = "https://mhw-db.com/events?q={\"name\":{ \"$like\": \"" + msgText + "%\"}}";
            var mhwData = await QueryApi.MonsterHunterData(url, token);
            var refine = "";
            if (mhwData.Count > 1)
                refine = $"*Please refine your search you have: {mhwData.Count} results.*";
            var botMsg = $"{refine}\nEvent Name: **{mhwData[0].Name}**\n\n" +
                         $"Descritpion: ***{mhwData[0].Description}***\n\n" +
                         $"Platform: **{mhwData[0].Platform}**\n";
            if (mhwData[0].Exclusive != null) botMsg += $"Exclusive: **{mhwData[0].Exclusive}**\n";
            botMsg += $"Type: **{mhwData[0].Type}**\n" +
                      $"Expansion: **{mhwData[0].Expansion}**\n" +
                      $"Requirements: **{mhwData[0].Requirements}**\n" +
                      $"Quest Rank: **{mhwData[0].QuestRank}**\n" +
                      $"Master Rank: **{mhwData[0].MasterRank}**\n" +
                      $"Success: **{mhwData[0].SuccessConditions}**\n" +
                      $"Start: **{mhwData[0].StartTimestamp}**\n" +
                      $"End: **{mhwData[0].EndTimestamp}**\n" +
                      $"Location Info: \n```ini\n" +
                      $"Name: {mhwData[0].Location.Name}\n" +
                      $"Zone Count: {mhwData[0].Location.ZoneCount}";
            foreach (var camp in mhwData[0].Location.Camps)
            {
                botMsg += $"Camp Name: {camp.Name} | Zone: {camp.Zone}\n";
            }

            botMsg += "```\n";
            return botMsg;
        }

        public static async Task<string> GetCharmResults(string msgText)
        {
            var source = new CancellationTokenSource();
            var token = source.Token;
            var url = "https://mhw-db.com/charms?q={\"name\":{ \"$like\": \"" + msgText + "%\"}}";
            var mhwData = await QueryApi.MonsterHunterData(url, token);
            var refine = "";
            if (mhwData.Count > 1)
                refine = $"*Please refine your search you have: {mhwData.Count} results.*";
            var botMsg = $"{refine}\nName: **{mhwData[0].Name}**\n" +
                         $"";

            return botMsg;
        }
    }
}