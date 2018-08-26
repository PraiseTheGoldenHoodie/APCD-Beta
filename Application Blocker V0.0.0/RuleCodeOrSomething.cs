﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Blocker_V0._0._0
{
    public enum RuleType : byte
    {
        Time,
        AppBlocked,
        UsageTime
    }
    public abstract class GenericRule
    {
        private RuleType ruletype;
        //private (type) appsBlocked;
        private bool[] compartmentsBlocked;
        private string[] blockedAppNames;
        public string namedCompartsBlocked = "";
        public string namedAppsBlocked = "";

        public GenericRule(RuleType ruleType, bool[] blockTheseComparts, string[] blockTheseAppNames)
        {
            this.ruletype = ruleType;
            compartmentsBlocked = blockTheseComparts;
            blockedAppNames = blockTheseAppNames;

            for (byte i = 0; i < blockTheseComparts.Length; i++)
                if (blockTheseComparts[i]) namedCompartsBlocked += i + 1 + ", ";
            if (namedCompartsBlocked.Length > 0) namedCompartsBlocked = namedCompartsBlocked.Substring(0, namedCompartsBlocked.Length - 2);
            else namedCompartsBlocked = "none";

            foreach (string i in blockTheseAppNames)
                namedAppsBlocked += i + ", ";
            if (namedAppsBlocked.Length > 0) namedAppsBlocked = namedAppsBlocked.Substring(0, namedAppsBlocked.Length - 2);
            else namedAppsBlocked = "none";
        }
        public RuleType getRuleType()
        {
            return ruletype;
        }
        public override String ToString()
        {
            return ruletype.ToString();
        }
        public bool[] getCompartmentsBlocked() {return compartmentsBlocked;}
        public string[] getAppsBlocked() { return blockedAppNames;}
        public abstract String RuleDesc();
        public abstract bool isLocked();

        public abstract string[] Hire();

        //This thing will throw all sorts of exceptions, make sure to catch them...
        //It also returns null if basically anything goes wrong? Probably...
        public static GenericRule newFromIO(string[] lines)
        {
            GenericRule schRule = null;
            if (Int32.Parse(lines[1]) == 0) //5 lines for TimeRule
            {
                byte type = Byte.Parse(lines[0]);

                string[] blockTheseApps = lines[1].Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

                string[] stringBool = lines[2].Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

                bool[] blockTheseComparts = new bool[stringBool.Length];
                for (byte i = 0; i < blockTheseComparts.Length; i++)
                    blockTheseComparts[i] = Convert.ToBoolean(stringBool[i]);
                switch (type)
                {
                    case 0:
                    default:
                        DateTime startTime = DateTime.Parse(lines[3]);
                        DateTime endTime = DateTime.Parse(lines[4]);
                        schRule = new TimeRule(startTime, endTime, blockTheseComparts, blockTheseApps);
                        break;
                }
            }
            return schRule;
        }
    }
    class TimeRule : GenericRule
    {
        DateTime startDate;
        DateTime endDate;
        public TimeRule(DateTime start, DateTime end, bool[] blockTheseComparts, string[] blockTheseAppNames) 
            : base(RuleType.Time, blockTheseComparts, blockTheseAppNames)
        {
            this.startDate = start;
            this.endDate = end;
        }

        public override String RuleDesc()
        {
            return startDate.ToUniversalTime() + " thru " + endDate.ToUniversalTime() + " for compartments " + namedCompartsBlocked + " and " + namedAppsBlocked;
        }
        public override bool isLocked()
        {
            return startDate.CompareTo(DateTime.Today) < 0 && endDate.CompareTo(DateTime.Today) > 0;
        }
        public override string[] Hire()
        {
            string[] hireList = new string[5];
            hireList[0] = ""+(int)(getRuleType());
            hireList[1] = namedAppsBlocked;
            foreach (bool c in getCompartmentsBlocked())
                hireList[2] += c +",";
            hireList[3] = startDate.ToString();
            hireList[4] = endDate.ToString();
            return hireList;
        }
//        public 
    }
}