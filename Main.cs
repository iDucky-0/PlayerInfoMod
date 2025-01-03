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
                        check(vrrig, Color.white, vrrig.OwningNetPlayer.NickName + " [Steam]", vrrig.OwningNetPlayer.NickName + " [Steam]");
                    }
                    else // Quest?
                    {
                        check(vrrig, Color.white, vrrig.OwningNetPlayer.NickName + " [Quest?]", vrrig.OwningNetPlayer.NickName + " [Quest?]");
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAK.")) // Moderator // Yellow
                    {
                        check(vrrig, Color.yellow, vrrig.OwningNetPlayer.NickName + " [Moderator]", vrrig.OwningNetPlayer.NickName + " [Moderator]");
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAD.")) // Lemming // Yellow
                    {
                        check(vrrig, Color.yellow, vrrig.OwningNetPlayer.NickName + " [Lemming]", vrrig.OwningNetPlayer.NickName + " [Lemming]");
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBADE.")) // Finger Painter // Green
                    {
                        check(vrrig, Color.green, vrrig.OwningNetPlayer.NickName + " [Finger Painter]", vrrig.OwningNetPlayer.NickName + " [Finger Painter]");
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAGS.")) // Illustrator // Green
                    {
                        check(vrrig, Color.green, vrrig.OwningNetPlayer.NickName + " [Illustrator]", vrrig.OwningNetPlayer.NickName + " [Illustrator]");
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAZ.")) // GT1 Badge // Blue
                    {
                        if (vrrig.OwningNetPlayer.UserId == player.UserId)
                        {
                            check(vrrig, Color.blue, vrrig.OwningNetPlayer.NickName + " [GT1]", vrrig.OwningNetPlayer.NickName + " [GT1]");
                        }
                    }
                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBACP.")) // Unreleased Sweater // Blue
                    {
                        if (vrrig.OwningNetPlayer.UserId == player.UserId)
                        {
                            check(vrrig, Color.blue, vrrig.OwningNetPlayer.NickName + " [OddSweater]", vrrig.OwningNetPlayer.NickName + " [OddSweater]");
                        }
                    }


                    if (player.CustomProperties.ContainsKey("genesis")) // ShibaGT Genesis [Illegal Mod Menu] // Red
                    {
                        if (vrrig.OwningNetPlayer.UserId == player.UserId)
                        {
                            check(vrrig, Color.red, vrrig.OwningNetPlayer.NickName + " [Genesis User]", vrrig.OwningNetPlayer.NickName + " [Genesis User]");
                        }
                    }
                    if (player.CustomProperties.ContainsKey("BlehUser")) // Bleh. [Illegal Mod Menu] // Red
                    {
                        if (vrrig.OwningNetPlayer.UserId == player.UserId)
                        {
                            check(vrrig, Color.red, vrrig.OwningNetPlayer.NickName + " [Bleh User]", vrrig.OwningNetPlayer.NickName + " [Bleh User]");
                        }
                    }
                }
            }

            void check(VRRig vrrig, Color col, string stri1, string stri2)
            {
                vrrig.playerText1.color = col;
                vrrig.playerText1.text = stri1;
                vrrig.playerText2.text = stri2;
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

// Made code better -NgbatzYT
