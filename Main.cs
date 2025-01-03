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
                    string name = vrrig.OwningNetPlayer.NickName;
                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("FIRST LOGIN")) // Steam
                    {
                        check(vrrig, Color.white, name + " [Steam]", name + " [Steam]");
                    }
                    else // Quest?
                    {
                        check(vrrig, Color.white, name + " [Quest?]", name + " [Quest?]");
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAK.")) // Moderator // Yellow
                    {
                        check(vrrig, Color.yellow, name + " [Moderator]", name + " [Moderator]");
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAD.")) // Lemming // Yellow
                    {
                        check(vrrig, Color.yellow, name + " [Lemming]", name + " [Lemming]");
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBADE.")) // Finger Painter // Green
                    {
                        check(vrrig, Color.green, name + " [Finger Painter]", name + " [Finger Painter]");
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAGS.")) // Illustrator // Green
                    {
                        check(vrrig, Color.green, name + " [Illustrator]", name + " [Illustrator]");
                    }


                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAZ.")) // GT1 Badge // Blue
                    {
                        if (vrrig.OwningNetPlayer.UserId == player.UserId)
                        {
                            check(vrrig, Color.blue, name + " [GT1]", name + " [GT1]");
                        }
                    }
                    if (vrrig.concatStringOfCosmeticsAllowed.Contains("LBACP.")) // Unreleased Sweater // Blue
                    {
                        if (vrrig.OwningNetPlayer.UserId == player.UserId)
                        {
                            check(vrrig, Color.blue, name + " [OddSweater]", name + " [OddSweater]");
                        }
                    }


                    if (player.CustomProperties.ContainsKey("genesis")) // ShibaGT Genesis [Illegal Mod Menu] // Red
                    {
                        if (vrrig.OwningNetPlayer.UserId == player.UserId)
                        {
                            check(vrrig, Color.red, name + " [Genesis User]", name + " [Genesis User]");
                        }
                    }
                    if (player.CustomProperties.ContainsKey("BlehUser")) // Bleh. [Illegal Mod Menu] // Red
                    {
                        if (vrrig.OwningNetPlayer.UserId == player.UserId)
                        {
                            check(vrrig, Color.red, name + " [Bleh User]", name + " [Bleh User]");
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

// Made code better - NgbatzYT
