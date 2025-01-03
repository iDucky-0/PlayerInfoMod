using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace PlayerInfoMod
{
    public class Main
    {
        public static void Prefix()
        {
            // Find Players Type
            foreach (Player player in PhotonNetwork.PlayerList)
            {
                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("FIRST LOGIN")) // Steam
                    {
                        vrrig.playerText1.color = Color.white;
                        vrrig.playerText1.text = vrrig.OwningNetPlayer.NickName + " [Steam]";
                        vrrig.playerText2.text = vrrig.OwningNetPlayer.NickName + " [Steam]";
                    }
                    else // Quest?
                    {
                        vrrig.playerText1.color = Color.white;
                        vrrig.playerText1.text = vrrig.OwningNetPlayer.NickName + " [Quest?]";
                        vrrig.playerText2.text = vrrig.OwningNetPlayer.NickName + " [Quest?]";
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAK.")) // Moderator // Yellow
                    {
                        vrrig.playerText1.color = Color.yellow;
                        vrrig.playerText1.text = vrrig.OwningNetPlayer.NickName + " [Moderator]";
                        vrrig.playerText2.text = vrrig.OwningNetPlayer.NickName + " [Moderator]";
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAD.")) // Lemming // Yellow
                    {
                        vrrig.playerText1.color = Color.yellow;
                        vrrig.playerText1.text = vrrig.OwningNetPlayer.NickName + " [Lemming]";
                        vrrig.playerText2.text = vrrig.OwningNetPlayer.NickName + " [Lemming]";
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBADE.")) // Finger Painter // Green
                    {
                        vrrig.playerText1.color = Color.green;
                        vrrig.playerText1.text = vrrig.OwningNetPlayer.NickName + " [Finger Painter]";
                        vrrig.playerText2.text = vrrig.OwningNetPlayer.NickName + " [Finger Painter]";
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAGS.")) // Illustrator // Green
                    {
                        vrrig.playerText1.color = Color.green;
                        vrrig.playerText1.text = vrrig.OwningNetPlayer.NickName + " [Illustrator]";
                        vrrig.playerText2.text = vrrig.OwningNetPlayer.NickName + " [Illustrator]";
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAZ.")) // GT1 Badge // Blue
                    {
                        if (vrrig.OwningNetPlayer.UserId == player.UserId)
                        {
                            vrrig.playerText1.color = Color.red;
                            vrrig.playerText1.text = vrrig.OwningNetPlayer.NickName + " [GT1]";
                            vrrig.playerText2.text = vrrig.OwningNetPlayer.NickName + " [GT1]";
                        }
                    }
                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBACP.")) // Unreleased Sweater // Blue
                    {
                        if (vrrig.OwningNetPlayer.UserId == player.UserId)
                        {
                            vrrig.playerText1.color = Color.red;
                            vrrig.playerText1.text = vrrig.OwningNetPlayer.NickName + " [OddSweater]";
                            vrrig.playerText2.text = vrrig.OwningNetPlayer.NickName + " [OddSweater]";
                        }
                    }


                    if (player.CustomProperties.ContainsKey("genesis")) // ShibaGT Genesis [Illegal Mod Menu] // Red
                    {
                        if (vrrig.OwningNetPlayer.UserId == player.UserId)
                        {
                            vrrig.playerText1.color = Color.red;
                            vrrig.playerText1.text = vrrig.OwningNetPlayer.NickName + " [Genesis User]";
                            vrrig.playerText2.text = vrrig.OwningNetPlayer.NickName + " [Genesis User]";
                        }
                    }
                    if (player.CustomProperties.ContainsKey("BlehUser")) // Bleh. [Illegal Mod Menu] // Red
                    {
                        if (vrrig.OwningNetPlayer.UserId == player.UserId)
                        {
                            vrrig.playerText1.color = Color.red;
                            vrrig.playerText1.text = vrrig.OwningNetPlayer.NickName + " [Bleh User]";
                            vrrig.playerText2.text = vrrig.OwningNetPlayer.NickName + " [Bleh User]";
                        }
                    }
                }
            }
        }
    }
}

// Notes:
// Red names are Illegal Mod Menu users.
// Yellow names are Lemming and Moderators.
// Green names are Finger Painters and Illustrators.
// White names are Steam and Quest users.
// Blue names have rare cosmetics.

// Colors:
// Black, Blue, Clear, Cyan, Gray, Green, Grey, Magenta, Red, White, Yellow