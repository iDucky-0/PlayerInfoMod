using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerInfoMod
{
    internal class System
    {
        public static string CosmeticIDs()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("FIRST LOGIN"); // Steam [Just unbanned / New account]
            stringBuilder.Append("LBAAK."); // Moderator
            stringBuilder.Append("LBAAD."); // Lemming
            stringBuilder.Append("LBADE."); // Finger Painter
            stringBuilder.Append("LBAGS."); // Illustrator
            stringBuilder.Append("LBACP."); // Unreleased sweater
            stringBuilder.Append("LBAAZ."); // GT1 Badge
            return stringBuilder.ToString();
        }

        public static string IllegalModMenuPropertys()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("genesis"); // ShibaGT Genesis
            stringBuilder.Append("BlehUser"); // Bleh.
            return stringBuilder.ToString();
        }
    }
}
